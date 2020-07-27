@ModelType ProyectoVisual2.ProductoInventario
@Code
    ViewData("Title") = "EditarInventario"
End Code

    <body style="background-color:black">
        <div class="jumbotron jumbotron-fluid">
            <div class="container">

                <center><picture style="font: oblique bold 120% cursive"><h1 class="display-4"></picture>Editar Inventario</h1></center>
            </div>
        </div>

        @Using (Html.BeginForm("ActualizarInventario", "Administrador", FormMethod.Post))
            @Html.AntiForgeryToken()

            @<div class="form-horizontal" readonly class="form-control-plaintext" style="color:navajowhite">
                <h4>Producto Inventario</h4>
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                <div class="form-group visible-md" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.idProducto, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.idProducto, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.idProducto, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group  visible-md" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.nombre, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.nombre, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.nombre, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group  visible-md" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.descripcion, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.descripcion, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.descripcion, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group  visible-md" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.precio, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.precio, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.precio, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group  visible-md" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.categoria, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.categoria, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.categoria, "", New With {.class = "text-danger"})
                    </div>
                </div>



                <div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                    @Html.LabelFor(Function(model) model.stock, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.stock, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.stock, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" value="Guardar" class="btn btn-danger" />
                    </div>
                </div>
            </div>  End Using

