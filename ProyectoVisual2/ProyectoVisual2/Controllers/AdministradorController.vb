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


        Function InsertarProducto() As ActionResult
            Return View()
        End Function
        Function ListaProducto() As ActionResult
            Dim instantaciaProducto = New ProductoInventario()

            Return View(instantaciaProducto.listarProductos)
        End Function

        Function EditarProducto(idProducto As String) As ActionResult
            Dim instantaciaProveedor = New ProductoInventario()

            Return View(instantaciaProveedor.editarProducto(idProducto))
        End Function

        Function EditarInventario(idProducto As String) As ActionResult
            Dim instantaciaProveedor = New ProductoInventario()

            Return View(instantaciaProveedor.editarProducto(idProducto))
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function ActualizarInventario(datosLogin As ProductoInventario) As Task(Of ActionResult)


            If datosLogin.actualizarProducto(datosLogin) Then

                Return RedirectToAction("Inventario", "Administrador")


            Else
                Return RedirectToAction("Inventario", "Administrador")

            End If
        End Function
        <HttpPost>
        <AllowAnonymous>
        Public Async Function ActualizarProducto(datosLogin As ProductoInventario) As Task(Of ActionResult)


            If datosLogin.actualizarProducto(datosLogin) Then

                Return RedirectToAction("ListaProducto", "Administrador")


            Else
                Return RedirectToAction("ListaProducto", "Administrador")

            End If
        End Function

        Public Async Function EliminarProducto(datosformulario As ProductoInventario) As Task(Of ActionResult)
            Dim instantaciaProveedor = New ProductoInventario()

            If instantaciaProveedor.EliminarProducto(datosformulario) = True Then
                Return RedirectToAction("ListaProducto", "Administrador")
                ViewBag.Message = "Eliminado"
            Else
                Return View(datosformulario)
            End If

        End Function


        Function Inventario() As ActionResult
            Dim instantaciaProducto = New ProductoInventario()

            Return View(instantaciaProducto.listarProductos)
        End Function
        Function ListaProveedor() As ActionResult
            Return View()
        End Function
        Function InsertarProveedor() As ActionResult
            Dim instantaciaProveedor = New ProveedorInventario()

            Return View(instantaciaProveedor.listarProveedores)


        End Function
        Function EditarProveedor(idProveedor As String) As ActionResult
            Dim instantaciaProveedor = New ProveedorInventario()

            Return View(instantaciaProveedor.editarProveedor(idProveedor))
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function ActualizarProveedor(datosLogin As ProveedorInventario) As Task(Of ActionResult)


            If datosLogin.actualizarProveedor(datosLogin) Then

                Return RedirectToAction("InsertarProveedor", "Administrador")


            Else
                Return RedirectToAction("InsertarProveedor", "Administrador")

            End If
        End Function

        Public Async Function EliminarProveedor(datosformulario As ProveedorInventario) As Task(Of ActionResult)
            Dim instantaciaProveedor = New ProveedorInventario()

            If instantaciaProveedor.EliminarProveedor(datosformulario) = True Then
                Return RedirectToAction("InsertarProveedor", "Administrador")
                ViewBag.Message = "Eliminado"
            Else
                Return View(datosformulario)
            End If

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