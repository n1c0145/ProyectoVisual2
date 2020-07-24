Imports System.Web.Mvc

Namespace Controllers
    Public Class AdministradorController
        Inherits Controller
        Dim listaLogin As New List(Of Login)
        ' GET: Administrador
        Function InicioAdministrador() As ActionResult
            Return View()
        End Function

        Function ListaUsuarios() As ActionResult
            Return View()
        End Function

        Function Producto() As ActionResult
            Return View()
        End Function

        Function Inventario() As ActionResult
            Return View()
        End Function
        Function Proveedor() As ActionResult
            Return View()
        End Function

    End Class
End Namespace