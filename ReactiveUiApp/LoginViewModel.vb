Imports System.Reactive
Imports System.Reactive.Linq
Imports System.Web
Imports ReactiveUI


Public Class LoginViewModel
    Inherits ReactiveUI.ReactiveObject


    Public Function LoginCommand() As ReactiveCommand(Of Unit, Unit)
        Return Me._loginCommand
    End Function
    Private ReadOnly _loginCommand As ReactiveCommand(Of Unit, Unit)


    Public Function ResetCommand() As ReactiveCommand
        Return Me._resetCommand
    End Function
    Private ReadOnly _resetCommand As ReactiveCommand(Of Unit, Unit)


    Public Property UserName As String
        Get
            Return Me._userName
        End Get
        Set(value As String)
            Me.RaiseAndSetIfChanged(Me._userName, value)
        End Set
    End Property
    Private _userName As String


    Public Property Password As String
        Get
            Return Me._password
        End Get
        Set(value As String)
            Me.RaiseAndSetIfChanged(Me._password, value)
        End Set
    End Property
    Private _password As String


    Public Sub New()

        Dim canLogin = Me.WhenAnyValue(Function(x) x._userName,
                                       Function(x) x._password,
                                       Function(userName, password) Not String.IsNullOrEmpty(userName) AndAlso Not String.IsNullOrEmpty(password))

        Me._loginCommand = ReactiveCommand.CreateFromObservable(AddressOf Me.LoginAsync, canLogin)

        Me._resetCommand = ReactiveCommand.Create(Sub()
                                                      Me._userName = Nothing
                                                      Me._password = Nothing
                                                  End Sub)
    End Sub


    Private Function LoginAsync() As IObservable(Of Unit)
        Return Observable.
            Return(New Random().Next(0, 2) = 1).
            Delay(TimeSpan.FromSeconds(1)).
            Do(Sub(success)
                   If Not success Then
                       Throw New InvalidOperationException("Failed to login.")
                   End If
               End Sub).
            Select(Function(x) Unit.Default)
    End Function


End Class
