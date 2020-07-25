
@ModelType IEnumerable(Of ProyectoVisual2.ProductoInventario)
@Code
    ViewData("Title") = "ListaProducto"
End Code

<h2>ListaProducto</h2>

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
                    <th scope="col">Descripcion</th>
                    <th scope="col">Precio</th>
                    <th scope="col">Categoria</th>
                    <th scope="col">Stock</th>
                    <th scope="col">Acciones</th>
                </tr>
            </thead>
            <tbody>
                @For Each item In Model
                    @<tr>

                        <td>@Html.DisplayFor(Function(modelItem) item.idProducto)</td>

                        <td>@Html.DisplayFor(Function(modelItem) item.nombre)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.descripcion)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.precio)</td>
                        <td>@Html.DisplayFor(Function(modelItem) item.categoria)</td>
      
                        <td>@Html.ActionLink("Editar", "EditarProducto", New With {.idProducto = item.idProducto}, htmlAttributes:=New With {.class = "btn btn-block btn-primary"}) </td>
                        <td>@Html.ActionLink("Eliminar", "EliminarProducto", New With {.idProducto = item.idProducto}, htmlAttributes:=New With {.class = "btn btn-block btn-success"}) </td>
                    </tr>
                Next


            </tbody>
        </table>
    </div>
    <div class="col-sm-1"></div>
</div>