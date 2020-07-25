Imports System.Web.Mvc
Imports System.Threading.Tasks
Namespace Controllers
    Public Class AdministradorController
        Inherits Controller
        Dim instantaciaUsuario = New RegistroPersona()

        Dim listaLogin As New List(Of Login)
        ' GET: Administrador
        Function InicioAdministrador() As ActionResult
            Return View()
        End Function

        Function ListaUsuarios() As ActionResult
            Dim instantaciaUsuario = New RegistroPersona()

            Return View(instantaciaUsuario.listarRegistros)
        End Function
        Function EditarUsuario(idPersona As String) As ActionResult

            Return View(instantaciaUsuario.editarRegistros(idPersona))
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function ActualizarRegistro(datosLogin As RegistroPersona) As Task(Of ActionResult)


            If datosLogin.actualizarRegistro(datosLogin) Then

                Return RedirectToAction("ListaUsuarios", "Administrador")


            Else

                Return RedirectToAction("ListaUsuarios", "Administrador")

            End If
        End Function

        Public Async Function EliminarUsuario(datosformulario As RegistroPersona) As Task(Of ActionResult)
            If instantaciaUsuario.EliminarRegistro(datosformulario) = True Then
                Return RedirectToAction("ListaUsuarios", "Administrador")
                ViewBag.Message = "Eliminado"
            Else
                Return View(datosformulario)
            End If

        End Function




        <HttpPost>
        <AllowAnonymous>
        Public Async Function Producto(datos As ProductoInventario) As Task(Of ActionResult)
            Dim formularioValido = ModelState.IsValid
            If formularioValido Then
                If datos.crearProducto() Then
                    Return RedirectToAction("ListaProducto", "Administrador", New With {.id = 1})
                Else
                    ViewBag.Message = "Producto ya existe"
                    Return View("ListaProducto")
                End If
            Else
                ViewBag.Message = "Producto ya existe"
                Return View("ListaProducto")

            End If
        End Function
        Function Inventario() As ActionResult
            Return View()
        End Function
        Function ListaProveedor() As ActionResult
            Return View()
        End Function
        Function InsertarProveedor() As ActionResult


            Return View()
        End Function
        <HttpPost>
        <AllowAnonymous>
        Public Async Function Proveedor(datos As ProveedorInventario) As Task(Of ActionResult)
            Dim formularioValido = ModelState.IsValid
            If formularioValido Then
                If datos.crearProveedor() Then
                    Return RedirectToAction("InsertarProveedor", "Administrador", New With {.id = 1})
                Else
                    ViewBag.Message = "Proveedor ya existe"
                    Return View("ListaProveedor")
                End If
            Else
                Return View("ListaProveedor")

            End If
        End Function
    End Class
End Namespace