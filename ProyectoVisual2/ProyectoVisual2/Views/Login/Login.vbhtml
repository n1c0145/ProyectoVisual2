@ModelType ProyectoVisual2.Login
@Code
    ViewData("Title") = "Login"
End Code

    <body style="background-color:black">
        <div class="jumbotron jumbotron-fluid">
            <div class="container">
                <center><picture style="font: oblique bold 120% cursive"><h1 class="display-4"></picture>Ingrese sus Datos</h1></center>
            </div>
        </div>


        <center><img src="https://en.ccqqfar.usac.edu.gt/wp-content/uploads/2018/03/Contact-icon.png" width="100" height="100"></center>

        <div>
            @Using Html.BeginForm("Login", "Login", FormMethod.Post)
                @<center>
                    <div class="form-group" input type="text" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.usuario)
                        @Html.TextBoxFor(Function(model) model.usuario, New With {.class = "form-control", .placeholder = "example@gmail.com"})
                        @Html.ValidationMessageFor(Function(model) model.usuario)
                    </div>
                </center>
                @<center>
                    <div class="form-group" input type="text" readonly class="form-control-plaintext" style="color:navajowhite">
                        @Html.LabelFor(Function(model) model.contrasenia)
                        @Html.PasswordFor(Function(model) model.contrasenia, New With {.class = "form-control", .placeholder = "**********"})
                        @Html.ValidationMessageFor(Function(model) model.contrasenia)
                    </div>
                </center>
                @Code
                    If ViewBag.message <> "" Then
                        @<small>@ViewBag.Message</small>
                    End If
                End Code
                @<center><input type="submit" value="Ingreso" class="btn btn-success" /></center>
            End Using

        </div>


