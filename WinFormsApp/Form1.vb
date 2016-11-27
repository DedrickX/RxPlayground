
Imports System.Reactive
Imports System.Reactive.Linq


Public Class FrmMain

    ''' <summary>
    ''' Subscription na oneskorené kliky
    ''' </summary>
    Private _delayedClickSubscription As IDisposable


    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' vytvoríme stream z eventu Klik na tlačidlo, bude to stream časových pečiatok času kliku
        Dim delayedClickStream = Observable.FromEventPattern(Of EventArgs)(Me.BtnClick, "Click").
            Select(Of DateTime)(Function(args) DateTime.Now).  ' do streamu posielam presný čas kliku
            Delay(TimeSpan.FromSeconds(2)).                    ' v rámci streamu je event oneskorený o 2 sekundy
            ObserveOn(Me)                                      ' oznámenia sú posielané v event-loope prezentačnej vrstvy - teda tam kde bol vytvorený tento form

        _delayedClickSubscription = delayedClickStream.
            Subscribe(Sub(x) TxtOutput.AppendText($"Button Click at {x.ToString("HH:mm:ss.FFF")}{Environment.NewLine}"))

    End Sub

    Private Sub BtnUsnubscribe_Click(sender As Object, e As EventArgs) Handles BtnUsnubscribe.Click

        ' odhlásim sa z odberu eventov oneskoreného kliku na tlačidlo
        _delayedClickSubscription.Dispose()

    End Sub


End Class
