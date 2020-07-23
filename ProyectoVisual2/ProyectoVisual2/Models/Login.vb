

Imports System.ComponentModel.DataAnnotations
Public Class Login

    Public Property idLogin As String
    <Required(ErrorMessage:="Este campo es requerido")>
    <Display(Name:="Usuario")>
    Public Property usuario As String
    <Required(ErrorMessage:="Este campo es requerido")>
    <Display(Name:="Usuario")>
    Public Property contrasenia As String
    <Required(ErrorMessage:="Este campo es requerido")>
    <Display(Name:="Contraseña")>
    Public Property tipousuario As String
    <Display(Name:="Tipo de Usuario")>
    Dim tabla1 As New DataClasses1DataContext
    Dim log_1 As New UsuarioLogin
    Public Function crearRegistroLog()

        log_1.IdLogin = idLogin
        log_1.usuario = usuario
        log_1.contrasenia = contrasenia
        log_1.tipousuario = tipousuario

        tabla1.UsuarioLogin.InsertOnSubmit(log_1)
        tabla1.SubmitChanges()
        Return True
    End Function

End Class