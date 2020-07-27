@ModelType ProyectoVisual2.ProveedorInventario
@Code
    ViewData("Title") = "EditarProveedor"
End Code

    <body style="background-color:black">
        <div class="jumbotron jumbotron-fluid">
            <div class="container">
                <center><picture style="font: oblique bold 120% cursive"><h1 class="display-4"></picture>Editar Proveedor</h1></center>
            </div>
        </div>

        @Using (Html.BeginForm("ActualizarProveedor", "Administrador", FormMethod.Post))
            @Html.AntiForgeryToken()

            @<div class="form-horizontal" readonly class="form-control-plaintext" style="color:navajowhite">
                <h4>Proveedor Inventario</h4>
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                <div class="form-group visible-md" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.idProveedor, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.idProveedor, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.idProveedor, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite" >
                    @Html.LabelFor(Function(model) model.nombre, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.nombre, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.nombre, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.correo, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.correo, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.correo, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.telefono, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.telefono, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.telefono, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.direccion, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.direccion, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.direccion, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" value="Guardar" class="btn btn-danger" />
                    </div>
                </div>
            </div>
        End Using


