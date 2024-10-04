-- DDL
CREATE DATABASE LabPizzeria;
GO
USE [master]
GO
CREATE LOGIN [usrpizzeria] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [LabPizzeria],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [LabPizzeria]
GO
CREATE USER [usrpizzeria] FOR LOGIN [usrpizzeria]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrpizzeria]
GO

DROP TABLE IF EXISTS CompraDetalle;
DROP TABLE IF EXISTS Compra;
DROP TABLE IF EXISTS Usuario;
DROP TABLE IF EXISTS Empleado;
DROP TABLE IF EXISTS Proveedor;
DROP TABLE IF EXISTS Producto;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS Venta;
DROP TABLE IF EXISTS VentaDetalle;

CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  codigo VARCHAR(20) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  unidadMedida VARCHAR(20) NOT NULL,
  saldo DECIMAL NOT NULL DEFAULT 0,
  precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0)
);

CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nit BIGINT NOT NULL,
  razonSocial VARCHAR(100) NOT NULL,
  direccion VARCHAR(250) NULL,
  telefono VARCHAR(30) NOT NULL,
  representante VARCHAR(100) NOT NULL
);

CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);

CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL,
  clave VARCHAR(250) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
);

CREATE TABLE Cliente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(100) NOT NULL,
  telefono VARCHAR(30) NOT NULL,
  direccion VARCHAR(250) NULL
);

CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProveedor INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
);

CREATE TABLE CompraDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  CONSTRAINT fk_CompreDetalle FOREIGN KEY (idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

CREATE TABLE Venta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  id_cliente INT NOT NULL,
  usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
  CONSTRAINT fk_Venta_Cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id)
);

CREATE TABLE VentaDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  id_venta INT NOT NULL,
  id_producto INT NOT NULL,
  CONSTRAINT fk_VentaDetalle_Venta FOREIGN KEY (id_venta) REFERENCES Venta(id),
  CONSTRAINT fk_VentaDetalle_Producto FOREIGN KEY (id_producto) REFERENCES Producto(id)
);

ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE VentaDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

GO

-- DML
INSERT INTO Producto (codigo, descripcion, unidadMedida, saldo, precioVenta)
VALUES 
('PIZ001', 'Pizza Margherita', 'Unidad', 10, 50.00),
('PIZ002', 'Pizza Pepperoni', 'Unidad', 15, 55.00),
('PIZ003', 'Pizza Hawaiana', 'Unidad', 12, 60.00),
('PIZ004', 'Pizza Veggie', 'Unidad', 14, 52.00),
('PIZ005', 'Pizza Cuatro Quesos', 'Unidad', 18, 65.00);

INSERT INTO Proveedor (nit, razonSocial, direccion, telefono, representante)
VALUES 
(123456789, 'Distribuciones Pizzeria S.A.', 'Av. La Paz #123', '123456789', 'Juan Perez'),
(987654321, 'Alimentos Frescos S.R.L.', 'Calle Sucre #456', '987654321', 'Maria Lopez'),
(456789123, 'Comercial de Ingredientes Ltda.', 'Calle Oruro #789', '456789123', 'Carlos Rodriguez'),
(321654987, 'Distribuidora Gourmet', 'Av. Santa Cruz #321', '321654987', 'Ana Martinez'),
(789123456, 'Pizzas y Más S.A.C.', 'Calle Cochabamba #654', '789123456', 'Luis Torres');

INSERT INTO Empleado (cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES 
('123456789', 'Carlos', 'Mendoza', 'Gutiérrez', 'Calle Falsa #123', 123456789, 'Cocinero'),
('987654321', 'Luisa', 'Fernandez', 'Gonzalez', 'Calle Real #456', 987654321, 'Mesera'),
('456789123', 'Jose', 'Martinez', 'Salas', 'Calle Principal #789', 456789123, 'Gerente'),
('321654987', 'Maria', 'Sánchez', 'Alvarez', 'Av. Libertador #321', 321654987, 'Repartidor'),
('789123456', 'Ana', 'Lopez', 'Diaz', 'Calle Nueva #654', 789123456, 'Asistente');

INSERT INTO Cliente (nombre, telefono, direccion)
VALUES 
('Pedro Ramirez', '123456789', 'Av. Bolivar #101'),
('Julia Castro', '987654321', 'Calle España #202'),
('Ramon Ortiz', '456789123', 'Calle Los Andes #303'),
('Maria Jimenez', '321654987', 'Calle Las Flores #404'),
('Luis Alvarado', '789123456', 'Av. La Paz #505');

INSERT INTO Compra (idProveedor, transaccion, fecha)
VALUES 
(1, 1001, GETDATE()),
(2, 1002, GETDATE()),
(3, 1003, GETDATE()),
(4, 1004, GETDATE()),
(5, 1005, GETDATE());

INSERT INTO CompraDetalle (idCompra, idProducto, cantidad, precioUnitario, total)
VALUES 
(1, 1, 10, 50.00, 500.00),
(1, 2, 5, 55.00, 275.00),
(2, 3, 3, 60.00, 180.00),
(3, 4, 2, 52.00, 104.00),
(4, 5, 1, 65.00, 65.00);

INSERT INTO Venta (transaccion, id_cliente)
VALUES 
(2001, 1),
(2002, 2),
(2003, 3),
(2004, 4),
(2005, 5);

INSERT INTO VentaDetalle (cantidad, precioUnitario, total, id_venta, id_producto)
VALUES 
(2, 50.00, 100.00, 1, 1),
(1, 55.00, 55.00, 2, 2),
(3, 60.00, 180.00, 3, 3),
(1, 52.00, 52.00, 4, 4),
(2, 65.00, 130.00, 5, 5);
GO
