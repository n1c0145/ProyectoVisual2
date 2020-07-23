Imports System.Web.Mvc

Namespace Controllers
    Public Class AdministradorController
        Inherits Controller

        ' GET: Administrador
        Function InicioAdministrador() As ActionResult
            Return View()
        End Function
    End Class
End Namespace