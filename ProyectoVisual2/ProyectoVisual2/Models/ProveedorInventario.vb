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
End Class
