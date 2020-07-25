@ModelType ProyectoVisual2.ProductoInventario
@Code
    ViewData("Title") = "InsertarProducto"
End Code

<h2>InsertarProducto</h2>

@Using Html.BeginForm("Producto", "Administrador", FormMethod.Post)
    @<div class="form-group">
        @Html.LabelFor(Function(model) model.nombre)
        @Html.TextBoxFor(Function(model) model.nombre, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(model) model.nombre)
    </div>
    @<div class="form-group">
        @Html.LabelFor(Function(model) model.descripcion)
        @Html.TextBoxFor(Function(model) model.descripcion, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(model) model.descripcion)
    </div>
    @<div class="form-group">
        @Html.LabelFor(Function(model) model.precio)
        @Html.TextBoxFor(Function(model) model.precio, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(model) model.precio)
    </div>
    @<div class="form-group">
        @Html.LabelFor(Function(model) model.categoria)
        @Html.TextBoxFor(Function(model) model.categoria, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(model) model.categoria)
    </div>
    @<div class="form-group">
        @Html.LabelFor(Function(model) model.stock)
        @Html.TextBoxFor(Function(model) model.stock, New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(model) model.stock)
    </div>
    @<input type="submit" value="Ingreso" class="btn btn-block btn-danger" />
End Using

@Code
    If ViewBag.message <> "" Then
        @<small>@ViewBag.Message</small>
    End If
End Code