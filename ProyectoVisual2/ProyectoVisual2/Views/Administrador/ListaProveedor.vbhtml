@ModelType ProyectoVisual2.ProveedorInventario
@Code
    ViewData("Title") = "ListaProveedor"
End Code

    <div class="accordion" id="accordionExample">
        <div class="card">
            <div class="card-header" id="headingOne">
                <h2 class="mb-0">
                    <button class="btn btn-link btn-block text-left" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                        Datos del Nuevo Producto
                    </button>
                </h2>
            </div>

            <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#accordionExample">
                <div class="card-body">
                    <div>
                        @Using Html.BeginForm("Proveedor", "Administrador", FormMethod.Post)
                            @<div class="form-group">
                                @Html.LabelFor(Function(model) model.nombre)
                                @Html.TextBoxFor(Function(model) model.nombre, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(model) model.nombre)
                            </div>
                            @<div class="form-group">
                                @Html.LabelFor(Function(model) model.correo)
                                @Html.TextBoxFor(Function(model) model.correo, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(model) model.correo)
                            </div>
                            @<div class="form-group">
                                @Html.LabelFor(Function(model) model.telefono)
                                @Html.TextBoxFor(Function(model) model.telefono, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(model) model.telefono)
                            </div>
                            @<div class="form-group">
                                @Html.LabelFor(Function(model) model.direccion)
                                @Html.TextBoxFor(Function(model) model.direccion, New With {.class = "form-control"})
                                @Html.ValidationMessageFor(Function(model) model.direccion)
                            </div>
                            @<input type="submit" value="Ingreso" class="btn btn-block btn-danger" />
                        End Using

                        @Code
                            If ViewBag.message <> "" Then
                                @<small>@ViewBag.Message</small>
                            End If
                        End Code

                    </div>
                </div>
            </div>
        </div>
        <div class="card">
            <div class="card-header" id="headingTwo">
                <h2 class="mb-0">
                    <button class="btn btn-link btn-block text-left collapsed" type="button" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                        Collapsible Group Item #2
                    </button>
                </h2>
            </div>
            <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#accordionExample">
                <div class="card-body">
                    Codigo Lista
                </div>
            </div>
        </div>
    </div>
