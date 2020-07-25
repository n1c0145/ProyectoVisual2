@ModelType ProyectoVisual2.RegistroPersona
@Code
    ViewData("Title") = "Registro"
End Code

<h2>Registro</h2>

<div>
    @Using Html.BeginForm("Registro", "Login", FormMethod.Post)
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.nombre)
            @Html.TextBoxFor(Function(model) model.nombre, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.nombre)
        </div>
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.apellido)
            @Html.TextBoxFor(Function(model) model.apellido, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.apellido)
        </div>
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.correo)
            @Html.TextBoxFor(Function(model) model.correo, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.correo)
        </div>
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.direccion)
            @Html.TextBoxFor(Function(model) model.direccion, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.direccion)
        </div>
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.telefono)
            @Html.TextBoxFor(Function(model) model.telefono, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.telefono)
        </div>
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.usuario)
            @Html.TextBoxFor(Function(model) model.usuario, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.usuario)
        </div>
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.contrasenia)
            @Html.TextBoxFor(Function(model) model.contrasenia, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.contrasenia)
        </div>

        @<input type="submit" value="Ingreso" class="btn btn-block btn-danger" />
    End Using

    @Code
        If ViewBag.message <> "" Then
            @<small>@ViewBag.Message</small>
        End If
    End Code

</div>