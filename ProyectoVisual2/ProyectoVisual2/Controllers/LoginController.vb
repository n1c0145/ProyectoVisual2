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
            Dim formularioValido = ModelState.IsValid
            If formularioValido Then
                If datos.crearRegistro() Then
                    Return RedirectToAction("Login", "Login", New With {.id = 1})
                Else
                    ViewBag.Message = "Login existe"
                    Return View("Registro")
                End If
            Else
                Return View("Registro")

            End If
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Function Login(datos As Login) As ActionResult

            Dim formularioValido = ModelState.IsValid
            If formularioValido Then


                If datos.entradaLogin() Then
                Return RedirectToAction("InicioAdministrador", "Administrador", New With {.id = 1})


                Else
                    Return View("Login")
                    ViewBag.Message = "Usuario o Contraseña Incorrectos"
                End If
            Else
                Return View("Login")
                ViewBag.Message = "Usuario o Contraseña Incorrectos"
            End If
        End Function


        Function Info() As ViewResult
            Return View()
        End Function

    End Class
End Namespace