﻿@ModelType ProyectoVisual2.ProductoInventario
@Code
    ViewData("Title") = "InsertarProducto"
End Code

<body style="background-color:black">
    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <ul class="nav nav-tabs" picture style="font: oblique bold 120% cursive">
                <li class="nav-item">
                    <a class="nav-link active" href="/Administrador/ListaUsuarios">Lista de Usuarios</a>
                </li>

                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Gestión Productos</a>
                    <div class="dropdown-menu" class="btn-group" role="group" aria-label="Basic example">
                        <a class="dropdown-item" href="/Administrador/InsertarProducto">Insertar Producto</a>
                        <a class="dropdown-item" href="/Administrador/ListaProducto">Lista Producto</a>

                    </div>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Administrador/Inventario">Inventario</a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Gestión Proveedor</a>
                    <div class="dropdown-menu" class="btn-group" role="group" aria-label="Basic example">
                        <a class="dropdown-item" href="/Administrador/InsertarProveedor">Lista Proveedor</a><b>
                            <a class="dropdown-item" href="/Administrador/ListaProveedor">Insertar Proveedor</a>

                    </div>
                </li>
                <li class="nav-item">
                    <a class="nav-link " href="/Inicio/Index" style="color:red">
                        Cerrar Sesion
                        <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-power" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                            <path fill-rule="evenodd" d="M5.578 4.437a5 5 0 1 0 4.922.044l.5-.866a6 6 0 1 1-5.908-.053l.486.875z" />
                            <path fill-rule="evenodd" d="M7.5 8V1h1v7h-1z" />
                    </a>
                    </svg>
                </li>
            </ul>
            <center><picture style="font: oblique bold 120% cursive"><h1 class="display-4"></picture>Insertar Producto</h1></center>
        </div>
    </div>
    <div>
        <center>
            @Using Html.BeginForm("Producto", "Administrador", FormMethod.Post)
                @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.nombre)
                    @Html.TextBoxFor(Function(model) model.nombre, New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.nombre)
                </div>
                @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.descripcion)
                    @Html.TextBoxFor(Function(model) model.descripcion, New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.descripcion)
                </div>
                @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.precio)
                    @Html.TextBoxFor(Function(model) model.precio, New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.precio)
                </div>
                @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.categoria)
                    @Html.TextBoxFor(Function(model) model.categoria, New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.categoria)
                </div>
                @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.stock)
                    @Html.TextBoxFor(Function(model) model.stock, New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.stock)
                </div>
                @<input type="submit" value="Ingreso" class="btn btn-block btn-success" />
            End Using

            @Code
                If ViewBag.message <> "" Then
                    @<small>@ViewBag.Message</small>
                End If
            End Code
    </div></center>
