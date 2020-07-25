Imports System.ComponentModel.DataAnnotations
Public Class ProductoInventario
    Public Property idProducto As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Nombre ")>
    Public Property nombre As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Descripcion")>
    Public Property descripcion As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Precio")>
    Public Property precio As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Categoria")>
    Public Property categoria As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Stock")>
    Public Property stock As String


    Dim tabla As New DataClasses2DataContext
    Dim pro As New Producto
    Public Function crearProducto()
        Dim consulta = From produc In tabla.Producto Where produc.nombre = nombre
        If consulta.Count() > 0 Then
            Return False
        Else
            pro.nombre = nombre
            pro.descripcion = descripcion
            pro.precio = precio
            pro.categoria = categoria
            pro.stock = stock
            tabla.Producto.InsertOnSubmit(pro)
            tabla.SubmitChanges()

            Return True
        End If
    End Function

    Public Function listarProductos()
        Dim listap As List(Of ProductoInventario) = New List(Of ProductoInventario)
        Dim consulta = From variable In tabla.Producto
        Dim listaProductos = consulta.ToList()

        For Each registro In listaProductos
            listap.Add(New ProductoInventario() With {
             .idProducto = registro.IdProducto,
            .nombre = registro.nombre,
             .descripcion = registro.descripcion,
             .precio = registro.precio,
             .categoria = registro.categoria,
             .stock = registro.stock})

        Next
        Return listap
    End Function

    Public Function editarProducto(idProducto As String)
        Dim loginEncontrado As ProductoInventario
        loginEncontrado = tabla.Producto.Where(Function(registro) registro.IdProducto = idProducto).[Select](Function(registro) New ProductoInventario() With {
        .idProducto = registro.IdProducto,
        .nombre = registro.nombre,
        .descripcion = registro.descripcion,
              .precio = registro.precio,
        .categoria = registro.categoria,
        .stock = registro.stock}).SingleOrDefault()
        Return loginEncontrado
    End Function

    Public Function actualizarProducto(model As ProductoInventario)
        Dim variable As Producto
        variable = tabla.Producto.Where(Function(loginUser) loginUser.IdProducto = model.idProducto).Single()
        variable.IdProducto = model.idProducto
        variable.nombre = model.nombre
        variable.descripcion = model.descripcion
        variable.precio = model.precio
        variable.categoria = model.categoria
        variable.stock = model.stock
        tabla.SubmitChanges()
        Return True
    End Function
    Public Function EliminarProducto(datosFormulario As ProductoInventario) As Boolean
        Dim registroEncontrado As Producto
        registroEncontrado = tabla.Producto.Where(Function(registro) registro.IdProducto = datosFormulario.idProducto).Single()
        tabla.Producto.DeleteOnSubmit(registroEncontrado)
        tabla.SubmitChanges()
        Return True
    End Function

End Class
