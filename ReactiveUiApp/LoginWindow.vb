
Imports System.Reactive.Concurrency
Imports ReactiveUI
Imports ReactiveUiApp

Public Class LoginWindow
    Implements IViewFor(Of LoginViewModel)


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Public Property ViewModel As LoginViewModel Implements IViewFor(Of LoginViewModel).ViewModel
        Get
            ' Add any initialization after the InitializeComponent() call.
            If _ViewModel Is Nothing Then
                _ViewModel = New LoginViewModel()
            End If
            Return _ViewModel
        End Get
        Set(value As LoginViewModel)
            _ViewModel = value
        End Set
    End Property
    Private _ViewModel As LoginViewModel

    Private Property IViewFor_ViewModel As Object Implements IViewFor.ViewModel
        Get
            Return Me.ViewModel
        End Get
        Set(value As Object)
            Me.ViewModel = DirectCast(value, LoginViewModel)
        End Set
    End Property

    Private Sub LoginWindow_Load(sender As Object, e As EventArgs) Handles Me.Load

        TxtUserName.DataBindings.Add("Text", Me.ViewModel, "UserName")
        TxtPassword.DataBindings.Add("Text", Me.ViewModel, "Password")

    End Sub


End Class