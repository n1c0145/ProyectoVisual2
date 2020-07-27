@ModelType ProyectoVisual2.RegistroPersona
@Code
    ViewData("Title") = "Registro"
End Code

    <body style="background-color:black">
        <div class="jumbotron jumbotron-fluid">
            <div class="container">
                <center><picture style="font: oblique bold 120% cursive"><h1 class="display-4"></picture>Registro</h1></center>
            </div>
        </div>

        <center><img src="https://image.flaticon.com/icons/png/512/327/327527.png" width="200" height="200"></center>

        <div>
            <center>
                @Using Html.BeginForm("Registro", "Login", FormMethod.Post)
                    @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.nombre)
                        @Html.TextBoxFor(Function(model) model.nombre, New With {.class = "form-control", .placeholder = "nombre"})
                        @Html.ValidationMessageFor(Function(model) model.nombre)
                    </div>
                    @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.apellido)
                        @Html.TextBoxFor(Function(model) model.apellido, New With {.class = "form-control", .placeholder = "apellido"})
                        @Html.ValidationMessageFor(Function(model) model.apellido)
                    </div>
                    @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.correo)
                        @Html.TextBoxFor(Function(model) model.correo, New With {.class = "form-control", .placeholder = "example@gmail.com"})
                        @Html.ValidationMessageFor(Function(model) model.correo)
                    </div>
                    @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.direccion)
                        @Html.TextBoxFor(Function(model) model.direccion, New With {.class = "form-control", .placeholder = "direccion"})
                        @Html.ValidationMessageFor(Function(model) model.direccion)
                    </div>
                    @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.telefono)
                        @Html.TextBoxFor(Function(model) model.telefono, New With {.class = "form-control", .placeholder = "0980000000"})
                        @Html.ValidationMessageFor(Function(model) model.telefono)
                    </div>
                    @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.usuario)
                        @Html.TextBoxFor(Function(model) model.usuario, New With {.class = "form-control", .placeholder = "usuario"})
                        @Html.ValidationMessageFor(Function(model) model.usuario)
                    </div>
                    @<div class="form-group" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.contrasenia)
                        @Html.TextBoxFor(Function(model) model.contrasenia, New With {.class = "form-control", .placeholder = "*********"})
                        @Html.ValidationMessageFor(Function(model) model.contrasenia)
                    </div>

                    @<input type="submit" value="Ingreso" class="btn btn-success"/>
                End Using

                @Code
                    If ViewBag.message <> "" Then
                        @<small>@ViewBag.Message</small>
                    End If
                End Code

        </div></center>
