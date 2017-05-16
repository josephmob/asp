Imports System.Web.UI.WebControls

Public Class boto
    Inherits LinkButton

    Private _IdArticulo As String
    Public Property IdArticulo() As String
        Get
            Return _IdArticulo
        End Get
        Set(ByVal value As String)
            _IdArticulo = value
        End Set
    End Property


End Class
