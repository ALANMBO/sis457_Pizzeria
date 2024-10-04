<p>
    La Pizzería LabPizzeria es un establecimiento que se especializa en la venta de pizzas, ofreciendo una variedad de sabores y opciones a sus clientes. 
    El negocio se encarga de la compra de ingredientes a proveedores, la preparación de pizzas por parte de cocineros y la venta de estos productos a los 
    clientes, tanto en el local como para entrega a domicilio. Además, gestiona la información de sus empleados y clientes para brindar un servicio eficiente 
    y personalizado.
</p>

<h2>Tablas y Atributos</h2>

<h3>Tabla: Producto</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>codigo: VARCHAR(20), código único del producto.</li>
    <li>descripcion: VARCHAR(250), descripción del producto (tipo de pizza).</li>
    <li>unidadMedida: VARCHAR(20), unidad de medida del producto.</li>
    <li>saldo: DECIMAL, cantidad disponible del producto.</li>
    <li>precioVenta: DECIMAL, precio de venta del producto.</li>
    <li>estado: SMALLINT, estado del producto (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: Proveedor</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>nit: BIGINT, número de identificación tributaria del proveedor.</li>
    <li>razonSocial: VARCHAR(100), razón social del proveedor.</li>
    <li>direccion: VARCHAR(250), dirección del proveedor.</li>
    <li>telefono: VARCHAR(30), número de teléfono del proveedor.</li>
    <li>representante: VARCHAR(100), nombre del representante del proveedor.</li>
    <li>estado: SMALLINT, estado del proveedor (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: Empleado</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>cedulaIdentidad: VARCHAR(12), número de cédula de identidad del empleado.</li>
    <li>nombres: VARCHAR(30), nombres del empleado.</li>
    <li>primerApellido: VARCHAR(30), primer apellido del empleado.</li>
    <li>segundoApellido: VARCHAR(30), segundo apellido del empleado.</li>
    <li>direccion: VARCHAR(250), dirección del empleado.</li>
    <li>celular: BIGINT, número de celular del empleado.</li>
    <li>cargo: VARCHAR(50), cargo o puesto del empleado.</li>
    <li>estado: SMALLINT, estado del empleado (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: Usuario</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>idEmpleado: INT, clave foránea que hace referencia a la tabla Empleado.</li>
    <li>usuario: VARCHAR(15), nombre de usuario para el sistema.</li>
    <li>clave: VARCHAR(250), contraseña del usuario.</li>
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

<h3>Tabla: Compra</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>idProveedor: INT, clave foránea que hace referencia a la tabla Proveedor.</li>
    <li>transaccion: INT, número de transacción de la compra.</li>
    <li>fecha: DATE, fecha en que se realizó la compra.</li>
    <li>estado: SMALLINT, estado de la compra (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: CompraDetalle</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>idCompra: INT, clave foránea que hace referencia a la tabla Compra.</li>
    <li>idProducto: INT, clave foránea que hace referencia a la tabla Producto.</li>
    <li>cantidad: DECIMAL, cantidad de producto comprada.</li>
    <li>precioUnitario: DECIMAL, precio unitario del producto.</li>
    <li>total: DECIMAL, total de la compra (cantidad * precio unitario).</li>
    <li>estado: SMALLINT, estado del detalle de la compra (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: Venta</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>transaccion: INT, número de transacción de la venta.</li>
    <li>fecha: DATE, fecha en que se realizó la venta.</li>
    <li>id_cliente: INT, clave foránea que hace referencia a la tabla Cliente.</li>
    <li>usuarioRegistro: VARCHAR(50), nombre de usuario que registró la venta.</li>
    <li>estado: SMALLINT, estado de la venta (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>

<h3>Tabla: VentaDetalle</h3>
<ul>
    <li>id: INT, clave primaria, autoincremental.</li>
    <li>cantidad: DECIMAL, cantidad de producto vendido.</li>
    <li>precioUnitario: DECIMAL, precio unitario del producto vendido.</li>
    <li>total: DECIMAL, total de la venta (cantidad * precio unitario).</li>
    <li>id_venta: INT, clave foránea que hace referencia a la tabla Venta.</li>
    <li>id_producto: INT, clave foránea que hace referencia a la tabla Producto.</li>
    <li>estado: SMALLINT, estado del detalle de la venta (1: Activo, 0: Inactivo, -1: Eliminado).</li>
</ul>
