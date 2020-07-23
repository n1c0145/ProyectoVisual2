

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
        Dim consulta2 = From b In tabla.UsuarioLogin Where b.contrasenia = contrasenia


        If consulta.Count() > 0 Then
            If consulta2.Count() > 0 Then
                Return True
            End If
            Return False
        End If
        Return False


    End Function

    Public Function listarLogins()

        Dim lista As List(Of Login) = New List(Of Login)
        Dim consulta = From a In tabla.UsuarioLogin Where a.usuario = usuario
        Dim listaregistro = consulta.ToList()
        For Each registro In listaregistro
            lista.Add(New Login With {
            .idLogin = registro.IdLogin,
            .usuario = registro.usuario,
            .contrasenia = registro.contrasenia,
            .tipousuario = registro.tipousuario
            })
        Next
        Return lista


    End Function

End Class