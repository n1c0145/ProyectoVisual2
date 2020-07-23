

Imports System.ComponentModel.DataAnnotations
Public Class RegistroPersona
    Public Property idPersona As String
    <Required(ErrorMessage:="El correo es requerido")>
    <Display(Name:="Correo Usuario")>
    Public Property nombre As String
    <Required(ErrorMessage:="El correo es requerido")>
    <Display(Name:="Correo Usuario")>
    Public Property apellido As String
    <Required(ErrorMessage:="El correo es requerido")>
    <Display(Name:="Correo Usuario")>
    Public Property correo As String
    <Required(ErrorMessage:="El correo es requerido")>
    <Display(Name:="Correo Usuario")>
    Public Property direccion As String
    <Required(ErrorMessage:="El correo es requerido")>
    <Display(Name:="Correo Usuario")>
    Public Property telefono As String
    Public Property usuario As String
    Public Property contrasenia As String
    Public Property tipousuario As String
    Dim tabla As New DataClasses1DataContext
    Dim reg As New Registro
    Dim log As New UsuarioLogin
    Public Function crearRegistro()

        reg.nombre = nombre
        reg.apellido = apellido
        reg.correo = correo
        reg.direccion = direccion
        reg.telefono = telefono
        log.usuario = usuario
        log.contrasenia = contrasenia
        log.tipousuario = tipousuario

        tabla.Registro.InsertOnSubmit(reg)
        tabla.UsuarioLogin.InsertOnSubmit(log)

        tabla.SubmitChanges()
        Return True
    End Function


End Class