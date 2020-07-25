@ModelType IEnumerable(Of ProyectoVisual2.ProveedorInventario)
@Code
    ViewData("Title") = "InsertarProveedor"
End Code

<h2>InsertarProveedor</h2>


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
                    <th scope="col">correo</th>
                    <th scope="col">telefono</th>
                    <th scope="col">direccion</th>
           
                    <th scope="col">Acciones</th>
                </tr>
            </thead>
            <tbody>
                @For Each item In Model
                    @<tr>

                        <td>@Html.DisplayFor(Function(modelItem) item.idProveedor)</td>

                        <td>@Html.DisplayFor(Function(modelItem) item.nombre)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.correo)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.telefono)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.direccion)</td>

                        <td>@Html.ActionLink("Editar", "EditarProveedor", New With {.idProveedor = item.idProveedor}, htmlAttributes:=New With {.class = "btn btn-block btn-primary"}) </td>
                        <td>@Html.ActionLink("Eliminar", "EliminarProveedor", New With {.idProveedor = item.idProveedor}, htmlAttributes:=New With {.class = "btn btn-block btn-success"}) </td>
                    </tr>
                Next


            </tbody>
        </table>
    </div>
    <div class="col-sm-1"></div>
</div>
