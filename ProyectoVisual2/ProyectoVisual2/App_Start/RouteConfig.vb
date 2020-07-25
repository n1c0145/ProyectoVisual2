Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
        routes.MapRoute(
            name:="Editar-Inventario",
            url:="Administrador/EditarInventario/{idProducto}",
            defaults:=New With {.controller = "Administrador", .action = "EditarInventario", .idProducto = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Eliminar-Proveedor",
            url:="Administrador/EliminarProveedor/{idProveedor}",
            defaults:=New With {.controller = "Administrador", .action = "EliminarProveedor", .idProveedor = UrlParameter.Optional}
        )

        routes.MapRoute(
            name:="Editar-Proveedor",
            url:="Administrador/EditarProveedor/{idProveedor}",
            defaults:=New With {.controller = "Administrador", .action = "EditarProveedor", .idProveedor = UrlParameter.Optional}
        )
        routes.MapRoute(
            name:="Eliminar-Usuario",
            url:="Administrador/EliminarUsuario/{idPersona}",
            defaults:=New With {.controller = "Administrador", .action = "EliminarUsuario", .idPersona = UrlParameter.Optional}
        )

        routes.MapRoute(
            name:="Editar-Usuario",
            url:="Administrador/EditarUsuario/{idPersona}",
            defaults:=New With {.controller = "Administrador", .action = "EditarUsuario", .idPersona = UrlParameter.Optional}
        )

        routes.MapRoute(
            name:="Inicio-Usuario",
            url:="Usuario/InicioUsuario/{id}",
            defaults:=New With {.controller = "Usuario", .action = "InicioUsuario", .id = UrlParameter.Optional}
        )

        routes.MapRoute(
            name:="Inicio-Administrador",
            url:="Administrador/InicioAdministrador/{id}",
            defaults:=New With {.controller = "Administrador", .action = "InicioAdministrador", .id = UrlParameter.Optional}
        )

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Inicio", .action = "Index", .id = UrlParameter.Optional}
        )
    End Sub
End Module