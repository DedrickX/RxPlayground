
Public Class MainWindow

    Public Property ViewModel As AppViewModel


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ViewModel = New AppViewModel()

    End Sub

End Class