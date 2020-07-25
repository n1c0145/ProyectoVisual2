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


End Class
