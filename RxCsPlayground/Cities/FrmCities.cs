using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;


namespace RxCsPlayground.Cities
{

    public partial class FrmCities : Form
    {

        private ICitiesRepository _repository;

        /// <summary>
        /// Kontrakt odberu hľadaného výrazu
        /// </summary>
        private IDisposable _searchTermSubscription;

        /// <summary>
        /// Kontrakt odberu výsledkov
        /// </summary>
        private IDisposable _resultsSubscription;

        /// <summary>
        /// Scheduler prezentačnej vrstvy - tu môžem pracovať s prvkami formulára
        /// </summary>
        private IScheduler _uiScheduler;

        /// <summary>
        /// Scheduler iného vlákna - sem presmerúvam dlho trvajúce operácie
        /// </summary>
        private IScheduler _nextThreadScheduler;
        

        #region Konštruktor


        public FrmCities(ICitiesRepository repository)
        {
            InitializeComponent();

            _repository = repository;

            // inicializujem inštancie schedulerov
            _nextThreadScheduler = new NewThreadScheduler();
            _uiScheduler = new ControlScheduler(this);
        }


        #endregion


        #region Hlavné eventy


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // inicializácia streamov
            InitStreams();
        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // ukončenie streamov
            DisposeStreams();
        }


        #endregion


        #region Vyhľadávanie


        /// <summary>
        /// Inicializácia streamov pri Load evente formulára
        /// </summary>
        private void InitStreams()
        {
            Debug.Print($"Štart UI, ThreadId: {Thread.CurrentThread.ManagedThreadId}");

            // stream emitujúci hodnoty po stlačení tlačidla Enter - emituje vyhľadávaný reťazec
            var enterPressedStream = Observable
                .FromEventPattern<KeyEventArgs>(TxtSearch, nameof(TxtSearch.KeyDown))
                .Where(args => args.EventArgs.KeyCode == Keys.Enter)
                .Select(args => TxtSearch.Text);

            // stream emitujúci hodnoty po kliku na tlačidlo Hľadaj - emituje vyhľadávaný reťazec
            var buttonClickedStream = Observable
                .FromEventPattern<EventArgs>(BtnSearch, nameof(BtnSearch.Click))
                .Select(args => TxtSearch.Text);

            // spojenie streamov mi dá stream požiadaviek pre hľadanie - emituje vyhľadávaný reťazec
            var searchTermStream = enterPressedStream
                .Merge(buttonClickedStream);

            // stream udalostí o zatváraní okna - emitne prázdny reťazec ak sa okno zatvára
            var formClosingStream = Observable
                .FromEventPattern(this, nameof(this.FormClosing))
                .Select(args => string.Empty);

            // stream udalostí o tom, že je potrebné ukončiť aktuálne vyhľadávanie
            var stopSearchingStream = searchTermStream
                .Merge(formClosingStream);
                        
            // prihlásim sa na odber požiadaviek na vyhľadávanie
            _searchTermSubscription = searchTermStream
                // zabezpečím, aby bola prvá emitovaná hodnota ako prázdny reťazec - čiže sa spustí vyhľadávanie 
                // pri zobrazení formulára
                .StartWith(string.Empty) 
                // emitované hodnoty budem spracúvať v druhom vlákne
                .ObserveOn(_nextThreadScheduler)
                // samotný odber hodnôt
                .Subscribe(searchTerm => OnNextSearchTerm(searchTerm, stopSearchingStream), ShowErrorInfo);
        }


        /// <summary>
        /// Hľadaný výraz sa zmenil - vyvolám hľadanie a prihlásim sa na odber výsledkov hľadania
        /// </summary>        
        private void OnNextSearchTerm(string searchTerm, IObservable<string> stopSearchingStream)
        {
            Console.WriteLine($"Vyhľadávam \"{searchTerm}\", ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                        
            // prihlasujem sa na odber stránkovaných výsledkov vyhľadávania
            _resultsSubscription = _repository.GetCities(searchTerm)
                // výsledky odoberám až pokiaľ nevznikne dôvod na ukončenie - buď sa zmenil vyhľadávaný výraz alebo sa okno zatvára
                .TakeUntil(stopSearchingStream)
                // výsledky už chcem spracúvať v UI vlákne
                .ObserveOn(_uiScheduler)
                // samotný odber hodnôt
                .Subscribe(result => FillCities(result), ShowErrorInfo,
                    () =>
                    {
                        Debug.Print($"Vyhľadávanie dokončené, ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                        ShowInfoText("Vyhľadávanie dokončené.");
                    });
        }


        /// <summary>
        /// Zobrazenie info o prebiehajúcej operácii
        /// </summary>        
        private void ShowInfoText(string text) =>
            LblProgressInfo.Text = text;


        /// <summary>
        /// Zobrazenie výnimky v info o prebiehajúcej operácii
        /// </summary>        
        private void ShowErrorInfo(Exception ex) =>
            ShowInfoText($"Pri vyhľadávaní vznikla chyba {ex.Message}!");
        

        /// <summary>
        /// Naplnenie výsledkov do ListBoxu
        /// </summary>        
        private void FillCities(CitiesStreamItem searchResult)
        {
            Debug.Print($"Napĺňam výsledky - stránka {searchResult.Page}, ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            ShowInfoText($"Napĺňam stránku {searchResult.Page + 1}");

            if (searchResult.Page == 0)
                ListResults.Items.Clear();

            ListResults.Items.AddRange(searchResult.Cities.ToArray());
        }


        /// <summary>
        /// Dispose odberov zo streamov
        /// </summary>
        private void DisposeStreams()
        {
            // ukončenie sledovania streamov         
            _searchTermSubscription?.Dispose();            
            _resultsSubscription?.Dispose();
        }


        #endregion

    }

}
