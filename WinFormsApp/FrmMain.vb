
Imports System.Reactive
Imports System.Reactive.Linq


Public Class FrmMain

    Private _delayedClickSubscription As IDisposable
    Private _randomClickErrorSubscription As IDisposable
    Private _textInputSubscription As IDisposable


#Region "Inicializácia"


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DelayedClickInit()
        RandomClickErrorInit()
        TextWritingInit()

    End Sub


#End Region


#Region "Oneskorený klik"


    Private Sub DelayedClickInit()

        ' vytvoríme stream z eventu Klik na tlačidlo, bude to stream časových pečiatok času kliku
        Dim delayedClickStream = Observable.FromEventPattern(Of EventArgs)(Me.BtnClick, "Click").
            Select(Of DateTime)(Function(args) DateTime.Now).  ' do streamu posielam presný čas kliku
            Delay(TimeSpan.FromSeconds(1)).                    ' v rámci streamu je event oneskorený o 1 sekundu
            ObserveOn(Me)                                      ' oznámenia sú posielané v event-loope prezentačnej vrstvy - teda tam kde bol vytvorený tento form

        _delayedClickSubscription = delayedClickStream.
            Subscribe(Sub(x) OutputText($"Button Click at {x.ToString("HH:mm:ss.FFF")}", Color.Blue))

    End Sub


#End Region


#Region "Náhodný exception"


    Private Sub RandomClickErrorInit()

        Dim randomClickErrorStream = Observable.FromEventPattern(Of EventArgs)(Me.BtnRandomExceptions, "Click").
            Do(Sub(x)
                   Dim rng = New Random()
                   If rng.Next(5) >= 4 Then
                       Throw New Exception("Boom!")
                   End If
               End Sub)

        _randomClickErrorSubscription = randomClickErrorStream.
            Subscribe(onNext:=Sub(x) OutputText($"Click - No Error", Color.Black),
                      onCompleted:=Sub() OutputText("Completed", Color.DarkGreen),
                      onError:=Sub(ex) OutputText($"Click - Exception {ex.Message}", Color.Red))

    End Sub


#End Region


#Region "Písanie textu"


    Private Sub TextWritingInit()

        Dim textInputStream = Observable.FromEventPattern(Of EventArgs)(Me.TxtInput, "TextChanged").
            Select(Of String)(Function(x) DirectCast(x.Sender, TextBox).Text).
            Throttle(TimeSpan.FromSeconds(1)).
            ObserveOn(Me)

        _textInputSubscription = textInputStream.
            Subscribe(onNext:=Sub(x) OutputText($"Zadaný text: {x}", Color.DarkBlue))

    End Sub



#End Region


#Region "Unsubscribe"


    Private Sub BtnUsnubscribe_Click(sender As Object, e As EventArgs) Handles BtnUsnubscribe.Click

        ' odhlásim sa z odberov eventov
        _delayedClickSubscription.Dispose()
        _randomClickErrorSubscription.Dispose()

    End Sub


#End Region


#Region "Ostatné"


    ''' <summary>
    ''' Zapísanie textu do jedného riadku
    ''' </summary>
    ''' <param name="text"></param>
    Private Sub OutputText(text As String, color As Color)
        TxtOutput.SelectionColor = color
        TxtOutput.AppendText(text & System.Environment.NewLine)
    End Sub


#End Region


End Class
