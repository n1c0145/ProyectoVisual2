@Code
    ViewData("Title") = "InicioAdministrador"
End Code



    <ul class="nav nav-tabs">
        <li class="nav-item">
            <a class="nav-link active" href="/Administrador/ListaUsuarios">Lista de Usuarios</a>
        </li>

        <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Gestión Productos</a>
            <div class="dropdown-menu">
                <a class="dropdown-item" href="/Administrador/InsertarProducto">Insertar Producto</a>
                <a class="dropdown-item" href="/Administrador/ListaProducto">Lista Producto</a>

            </div>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="/Administrador/Inventario">Inventario</a>
        </li>
        <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Gestión Proveedor</a>
            <div class="dropdown-menu">
                <a class="dropdown-item" href="/Administrador/InsertarProveedor">Insertar Proveedor</a>
                <a class="dropdown-item" href="/Administrador/ListaProveedor">Lista Proveedor</a>

            </div>
        </li>
        <li class="nav-item">
            <a class="nav-link " href="/Inicio/Index">Cerrar Sesion</a>
        </li>
    </ul>