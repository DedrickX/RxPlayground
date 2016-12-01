Imports System.Web
Imports ReactiveUI
Imports ReactiveUI.Legacy

Public Class AppViewModel
    Inherits ReactiveUI.ReactiveObject

    Public Property SearchTerm As String
        Get
            Return _SearchTerm
        End Get
        Set(value As String)
            Me.RaiseAndSetIfChanged(_SearchTerm, value)
        End Set
    End Property
    Private _SearchTerm As String


    Public Property ExecuteSearch As ReactiveCommand(Of List(Of FlickrPhoto))


    Private _SearchResults As ObservableAsPropertyHelper(Of List(Of FlickrPhoto))
    Public Function SearchResults() As List(Of FlickrPhoto)
        Return _SearchResults.Value
    End Function



End Class
