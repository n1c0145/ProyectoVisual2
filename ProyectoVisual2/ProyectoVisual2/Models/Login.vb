

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
    Dim tabla As New DataClasses1DataContext
    Dim log As New UsuarioLogin
    Public Function entradaLogin()

        Dim consulta = From a In tabla.UsuarioLogin Where a.usuario = usuario

        Dim consulta2 = From a In tabla.UsuarioLogin Where a.contrasenia = contrasenia

        '   Dim tipoUsuario = From a In tabla.UsuarioLogin Where a.usuario = usuario Select tipoUsuario



        If consulta.Count() > 0 Then
            If consulta2.Count() > 0 Then
                Return True
            End If
        End If



    End Function



End Class