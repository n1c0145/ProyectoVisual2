Imports System.Web.Mvc

Namespace Controllers
    Public Class AdministradorController
        Inherits Controller
        Dim listaLogin As New List(Of Login)
        ' GET: Administrador
        Function InicioAdministrador() As ActionResult
            Return View()
        End Function

        Function InformacionUsuario(id As Integer) As ViewResult

            Dim instantaciaLogin = New Login()
            Dim loginEncotrado = listaLogin(id)
            Return View(instantaciaLogin.listarLogins)
        End Function

        Function ListaUsuarios() As ActionResult
            Return View()
        End Function

    End Class
End Namespace