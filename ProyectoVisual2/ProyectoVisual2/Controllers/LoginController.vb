Imports System.Web.Mvc
Imports System.Threading.Tasks
Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult
            Return View()
        End Function

        Function Login() As ActionResult
            Return View()
        End Function

        Function Registro() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function Registro(datos As RegistroPersona) As Task(Of ActionResult)


            datos.crearRegistro()
            Return RedirectToAction("Login", "Login", New With {.id = 1})
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function Login(datos As Login) As Task(Of ActionResult)
            If datos.entradaLogin() Then
                Return RedirectToAction("InicioAdministrador", "Administrador", New With {.id = 1})

            End If
        End Function

        Function Info() As ViewResult
        End Function

    End Class
End Namespace