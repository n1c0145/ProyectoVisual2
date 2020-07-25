
Imports System.ComponentModel.DataAnnotations


Public Class RegistroPersona
    Public Property idPersona As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Nombre Usuario")>
    Public Property nombre As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Apellido Usuario")>
    Public Property apellido As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Correo Usuario")>
    Public Property correo As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="direccion Usuario")>
    Public Property direccion As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Telefono Usuario")>
    Public Property telefono As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Usuario")>
    Public Property usuario As String
    <Required(ErrorMessage:="Es requerido")>
    <Display(Name:="Contraseña")>
    Public Property contrasenia As String

    Public Property idLogin As String
    Dim tabla As New DataClasses1DataContext
    Dim reg As New Registro
    Dim log As New UsuarioLogin
    Public Function crearRegistro()
        Dim consulta = From user In tabla.UsuarioLogin Where user.usuario = usuario
        If consulta.Count() > 0 Then
            Return False
        Else
            log.usuario = usuario
            log.contrasenia = contrasenia
            '  log.tipousuario = tipousuario
            tabla.UsuarioLogin.InsertOnSubmit(log)
            tabla.SubmitChanges()
            'Dim consulta = From a In tabla.UsuarioLogin Where a.usuario = usuario Select tipousuario


            reg.nombre = nombre
            reg.apellido = apellido
            reg.correo = correo
            reg.direccion = direccion
            reg.telefono = telefono
            ' reg.IdLogin = 1
            tabla.Registro.InsertOnSubmit(reg)
            tabla.SubmitChanges()
            Return True
        End If
    End Function

    Public Function listarRegistros()
        Dim lista As List(Of RegistroPersona) = New List(Of RegistroPersona)
        Dim consulta = From variable In tabla.Registro
        Dim listaRegistros = consulta.ToList()

        For Each registro In listaRegistros
            lista.Add(New RegistroPersona() With {
             .idPersona = registro.IdPersona,
            .nombre = registro.nombre,
             .apellido = registro.apellido,
             .correo = registro.correo,
             .direccion = registro.direccion,
             .telefono = registro.telefono})
            ' .usuario = log.usuario,
            ' .contrasenia = log.contrasenia,

        Next
        Return lista
    End Function


    Public Function editarRegistros(idPersona As String)
        Dim loginEncontrado As RegistroPersona
        loginEncontrado = tabla.Registro.Where(Function(registro) registro.IdPersona = idPersona).[Select](Function(registro) New RegistroPersona() With {
                      .idPersona = registro.IdPersona,
                      .nombre = registro.nombre,
                      .apellido = registro.apellido,
                      .correo = registro.correo,
                      .direccion = registro.direccion,
                      .telefono = registro.telefono
                      }).SingleOrDefault()
        Return loginEncontrado
    End Function

    Public Function actualizarRegistro(model As RegistroPersona)
        Dim variable As Registro
        variable = tabla.Registro.Where(Function(loginUser) loginUser.IdPersona = model.idPersona).Single()
        variable.IdPersona = model.idPersona
        variable.nombre = model.nombre
        variable.apellido = model.apellido
        variable.correo = model.correo
        variable.direccion = model.direccion
        variable.telefono = model.telefono
        tabla.SubmitChanges()
        Return True
    End Function
    Public Function EliminarRegistro(datosFormulario As RegistroPersona) As Boolean
        Dim registroEncontrado As Registro
        registroEncontrado = tabla.Registro.Where(Function(registro) registro.IdPersona = datosFormulario.idPersona).Single()
        tabla.Registro.DeleteOnSubmit(registroEncontrado)
        tabla.SubmitChanges()
        Return True
    End Function
End Class