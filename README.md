<p>
    La Pizzería LabPizzeria es un establecimiento que se especializa en la venta de pizzas, ofreciendo una variedad de sabores y opciones a sus clientes. 
    El negocio se encarga de la compra de ingredientes a proveedores, la preparación de pizzas por parte de cocineros y la venta de estos productos a los 
    clientes, tanto en el local como para entrega a domicilio. Además, gestiona la información de sus empleados y clientes para brindar un servicio eficiente 
    y personalizado.
</p>

<h2>Tablas y Atributos</h2>

 <h3>Tabla: Categoria</h3>
<ul>
    <li>idCategoria: INT, clave primaria, autoincremental.</li>
    <li>nombre: VARCHAR(250), nombre de la categoria (tipo de pizza).</li>
    <li>UsuarioRegistro: VARCHAR(30), usuario Registro de la categoria.</li>
    <li>FechaRegistro: VARCHAR(250), Fecha registro de la categoria.</li>
    <li>estado: SMALLINT, estado del producto (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: Producto</h3>
<ul>
    <li>idPorducto: INT, clave primaria, autoincremental.</li>
    <li>idCategoria: INT, clave primaria, autoincremental.</li>
    <li>codigo: VARCHAR(20), código único del producto.</li>
    <li>nombre: VARCHAR(250), nombre del producto (tipo de pizza).</li>
    <li>descripcion: VARCHAR(250), descripción del producto (tipo de pizza).</li>
    <li>precio: DECIMAL, precio de venta del producto.</li>
    <li>stock: DECIMAL, cantidad disponible del producto.</li>
    <li>UsuarioRegistro: VARCHAR(30), usuario Registro del producto.</li>
    <li>FechaRegistro: VARCHAR(250), Fecha registro del producto.</li>
    <li>estado: SMALLINT, estado del producto (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: Empleado</h3>
<ul>
    <li>idEmpleado: INT, clave primaria, autoincremental.</li>
    <li>nombres: VARCHAR(30), nombres del empleado.</li>
    <li>Apellidos: VARCHAR(30), apellidos del empleado.</li>
    <li>telefono: BIGINT, número de telefono del empleado.</li>
    <li>cargo: VARCHAR(50), cargo o puesto del empleado.</li>
    <li>Salario: VARCHAR(12), número de Salario del empleado.</li>
    <li>UsuarioRegistro: VARCHAR(30), usuario Registro del empleado.</li>
    <li>FechaRegistro: VARCHAR(250), Fecha registro del empleado.</li>
    
</ul>

<h3>Tabla: Usuario</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>idEmpleado: INT, clave foránea que hace referencia a la tabla Empleado.</li>
    <li>idUsuario: VARCHAR(15), nombre de usuario para el sistema.</li>
    <li>Usuario1: VARCHAR(15), nombre de usuario para el sistema.</li>
    <li>clave: VARCHAR(250), contraseña del usuario.</li>
    <li>UsuarioRegistro: VARCHAR(15), nombre de usuario para el sistema.</li>
    <li>estado: SMALLINT, estado del usuario (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: Cliente</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>nombre: VARCHAR(100), nombre del cliente.</li>
    <li>telefono: VARCHAR(30), número de teléfono del cliente.</li>
    <li>direccion: VARCHAR(250), dirección del cliente.</li>
    <li>estado: SMALLINT, estado del cliente (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: Venta</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>idUsuario: VARCHAR(15), nombre de usuario para el sistema.</li>
    <li>idCliente: INT, clave foránea que hace referencia a la tabla Cliente.</li>
    <li>totalVenta: INT, número de transacción de la venta.</li>
    <li>fechaVenta: DATE, fecha en que se realizó la venta.</li>
    <li>estado: SMALLINT, estado de la venta (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: VentaDetalle</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>idVenta: INT, clave foránea que hace referencia a la tabla Venta.</li>
    <li>idProducto: INT, clave foránea que hace referencia a la tabla Producto.</li>
    <li>cantidad: DECIMAL, cantidad de producto vendido.</li>
    <li>precioUnitario: DECIMAL, precio unitario del producto vendido.</li>
    <li>total: DECIMAL, total de la venta (cantidad * precio unitario).</li>
    <li>UsuarioRegistro: VARCHAR(15), nombre de usuario para el sistema.</li>
    <li>FechaRegistro: VARCHAR(250), Fecha registro del empleado.</li>
    <li>estado: SMALLINT, estado del detalle de la venta (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>
