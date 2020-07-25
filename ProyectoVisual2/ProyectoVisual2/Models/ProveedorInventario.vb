Imports System.ComponentModel.DataAnnotations
Public Class ProveedorInventario
    Public Property idProveedor As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Nombre")>
    Public Property nombre As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Correo")>
    Public Property correo As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Telefono")>
    Public Property telefono As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Direccion")>
    Public Property direccion As String

    Dim tabla As New DataClasses2DataContext
    Dim prov As New Proveedor
    Public Function crearProveedor()
        Dim consulta = From user In tabla.Proveedor Where user.nombre = nombre
        If consulta.Count() > 0 Then
            Return False
        Else
            prov.nombre = nombre
            prov.correo = correo
            prov.telefono = telefono
            prov.direccion = direccion

            tabla.Proveedor.InsertOnSubmit(prov)
            tabla.SubmitChanges()
            Return True
        End If
    End Function
    Public Function listarProveedores()
        Dim lista As List(Of ProveedorInventario) = New List(Of ProveedorInventario)
        Dim consulta = From variable In tabla.Proveedor
        Dim listaRegistros = consulta.ToList()

        For Each registro In listaRegistros
            lista.Add(New ProveedorInventario() With {
             .idProveedor = registro.IdProveedor,
            .nombre = registro.nombre,
              .correo = registro.correo,
                         .telefono = registro.telefono,
                          .direccion = registro.direccion})



        Next
        Return lista
    End Function


    Public Function editarProveedor(idProveedor As String)
        Dim loginEncontrado As ProveedorInventario
        loginEncontrado = tabla.Proveedor.Where(Function(registro) registro.IdProveedor = idProveedor).[Select](Function(registro) New ProveedorInventario() With {
        .idProveedor = registro.IdProveedor,
        .nombre = registro.nombre,
        .correo = registro.correo,
        .telefono = registro.telefono,
        .direccion = registro.direccion}).SingleOrDefault()
        Return loginEncontrado
    End Function

    Public Function actualizarProveedor(model As ProveedorInventario)
        Dim variable As Proveedor
        variable = tabla.Proveedor.Where(Function(loginUser) loginUser.IdProveedor = model.idProveedor).Single()
        variable.IdProveedor = model.idProveedor
        variable.nombre = model.nombre
        variable.correo = model.correo
        variable.telefono = model.telefono
        variable.direccion = model.direccion
        tabla.SubmitChanges()
        Return True
    End Function
    Public Function EliminarProveedor(datosFormulario As ProveedorInventario) As Boolean
        Dim registroEncontrado As Proveedor
        registroEncontrado = tabla.Proveedor.Where(Function(registro) registro.IdProveedor = datosFormulario.idProveedor).Single()
        tabla.Proveedor.DeleteOnSubmit(registroEncontrado)
        tabla.SubmitChanges()
        Return True
    End Function

End Class
