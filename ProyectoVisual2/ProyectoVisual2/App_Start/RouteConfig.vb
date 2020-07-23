﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

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