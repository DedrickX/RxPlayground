
Imports System.Reactive.Concurrency
Imports ReactiveUI
Imports ReactiveUiApp

Public Class LoginWindow
    Implements IViewFor(Of LoginViewModel)


#Region "IViewFor"

    Public Property ViewModel As LoginViewModel = New LoginViewModel() Implements IViewFor(Of LoginViewModel).ViewModel


    Private Property IViewFor_ViewModel As Object Implements IViewFor.ViewModel
        Get
            Return Me.ViewModel
        End Get
        Set(value As Object)
            Me.ViewModel = DirectCast(value, LoginViewModel)
        End Set
    End Property

#End Region


    Private Sub LoginWindow_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Bind(ViewModel,
                Function(x As LoginViewModel) x.UserName,
                Function(x) x.TxtUserName.Text)

        Me.Bind(ViewModel,
                Function(x As LoginViewModel) x.Password,
                Function(x) x.TxtPassword.Text)

        'ReactiveUI.CommandBinder.BindCommand(Me,
        '    ViewModel,
        '    Function(x As LoginViewModel) x.LoginCommand,
        '    Function(x) x.BtnLogin)

        'ReactiveUI.CommandBinder.BindCommand(Me,
        '    ViewModel,
        '    Function(x As LoginViewModel) x.ResetCommand,
        '    Function(x) x.BtnReset)

    End Sub


End Class