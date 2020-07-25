@ModelType IEnumerable(Of ProyectoVisual2.RegistroPersona)
@Code
    ViewData("Title") = "ListaUsuarios"
End Code

<h2>ListaUsuarios</h2>

<div class="row">
    <div class="col-sm-4"></div>
    <div class="col-sm-4">

    </div>
    <div class="col-sm-4"></div>
</div>
<div class="row">
    <div class="col-sm-1"></div>
    <div class="col-sm-10">
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">id</th>
                    <th scope="col">Nombre</th>
                    <th scope="col">Apellido</th>
                    <th scope="col">Correo</th>
                    <th scope="col">Direccion</th>
                    <th scope="col">Telefono</th>
                    <th scope="col">Acciones</th>
                </tr>
            </thead>
            <tbody>
                @For Each item In Model
                    @<tr>

                        <td>@Html.DisplayFor(Function(modelItem) item.idPersona)</td>

                        <td>@Html.DisplayFor(Function(modelItem) item.nombre)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.apellido)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.correo)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.direccion)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.telefono)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.usuario)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.contrasenia)</td>
                        <td>@Html.ActionLink("Editar", "EditarUsuario", New With {.idPersona = item.idPersona}, htmlAttributes:=New With {.class = "btn btn-block btn-primary"}) </td>
                        <td>@Html.ActionLink("Eliminar", "EliminarUsuario", New With {.idPersona = item.idPersona}, htmlAttributes:=New With {.class = "btn btn-block btn-success"}) </td>
                    </tr>
                Next
   

            </tbody>
        </table>
    </div>
    <div class="col-sm-1"></div>
</div>