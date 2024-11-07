
CREATE DATABASE LabPizzeriaHouse;
GO
USE LabPizzeriaHouse;
GO

USE master;
GO
CREATE LOGIN usrpizza WITH PASSWORD=N'123456',
    DEFAULT_DATABASE=LabPizzeriaHouse,
    CHECK_EXPIRATION=OFF,
    CHECK_POLICY=ON;
GO
USE LabPizzeriaHouse;
GO
CREATE USER usrpizza FOR LOGIN usrpizza;
GO
ALTER ROLE db_owner ADD MEMBER usrpizza;
GO

-- Eliminar tablas si existen
DROP TABLE IF EXISTS VentaDetalle;
GO
DROP TABLE IF EXISTS Producto;
GO
DROP TABLE IF EXISTS Categoria;
GO
DROP TABLE IF EXISTS Venta;
GO
DROP TABLE IF EXISTS Usuario;
GO
DROP TABLE IF EXISTS Empleado;
GO
DROP TABLE IF EXISTS Cliente;
GO


-- Crear tablas
CREATE TABLE Empleado(
    idEmpleado INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(20) NOT NULL,
    apellidos VARCHAR(50) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    cargo VARCHAR(20) NOT NULL,
    salario FLOAT NOT NULL
);
GO

CREATE TABLE Usuario(
    idUsuario INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    idEmpleado INT NOT NULL,
    usuario VARCHAR(30) NOT NULL,
    clave VARCHAR(30) NOT NULL,
    FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado)
);
GO

CREATE TABLE Categoria(
    idCategoria INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(30) NOT NULL
);
GO

CREATE TABLE Producto(
    idProducto INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    idCategoria INT NOT NULL,
    codigo VARCHAR(20) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(500) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
);
GO

CREATE TABLE Cliente(
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    razonSocial VARCHAR(50) NOT NULL,
    nit VARCHAR(15) NOT NULL,
    celular VARCHAR(8) NOT NULL DEFAULT '0'
);
GO

CREATE TABLE Venta(
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    idUsuario INT NOT NULL,
    idCliente INT NOT NULL,
    totalVenta DECIMAL(10,2) NOT NULL,
    fechaVenta DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fk_Venta_Usuario FOREIGN KEY(idUsuario) REFERENCES Usuario(idUsuario),
    CONSTRAINT fk_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id)
);
GO

CREATE TABLE VentaDetalle(
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    idVenta INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL CHECK(cantidad > 0),
    precioUnitario DECIMAL(10,2) NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    CONSTRAINT fk_VentaDetalle_Venta FOREIGN KEY(idVenta) REFERENCES Venta(id),
    CONSTRAINT fk_VentaDetalle_Producto FOREIGN KEY(idProducto) REFERENCES Producto(idProducto)
);
GO

-- Alter tables to add additional columns
ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
GO
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1;
GO

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
GO
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1;
GO

ALTER TABLE Categoria ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
GO
ALTER TABLE Categoria ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO
ALTER TABLE Categoria ADD estado SMALLINT NOT NULL DEFAULT 1;
GO

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
GO
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1;
GO

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
GO
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1;
GO

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
GO
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1;
GO

ALTER TABLE VentaDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
GO
ALTER TABLE VentaDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO
ALTER TABLE VentaDetalle ADD estado SMALLINT NOT NULL DEFAULT 1;
GO

-- Procedimientos almacenados
CREATE PROCEDURE paEmpleadoListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT idEmpleado, nombre, apellidos, telefono, cargo, salario
    FROM Empleado
    WHERE estado <> -1 AND nombre LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END;
GO

CREATE PROCEDURE paProductosListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT p.*, c.nombre AS categoria
    FROM Producto AS p
    INNER JOIN Categoria AS c ON p.idCategoria = c.idCategoria
    WHERE p.estado <> -1 AND p.nombre LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END;
GO

CREATE PROCEDURE paClienteListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Cliente
    WHERE estado <> -1 AND razonSocial LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END;
GO

CREATE PROCEDURE paVentaListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT v.*, u.usuario, c.razonSocial
    FROM Venta v
    INNER JOIN Usuario u ON u.idUsuario = v.idUsuario
    INNER JOIN Cliente c ON c.id = v.idCliente
    WHERE v.estado <> -1 AND c.razonSocial LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END;
GO

CREATE PROCEDURE paVentaDetalleListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT vd.*, p.nombre, c.razonSocial
    FROM VentaDetalle vd
    INNER JOIN Producto p ON p.idProducto = vd.idProducto
    INNER JOIN Venta v ON v.id = vd.idVenta
    INNER JOIN Cliente c ON c.id = v.idCliente
    WHERE vd.estado <> -1 AND c.razonSocial LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END;
GO

-- Insertar datos iniciales
INSERT INTO Empleado (nombre, apellidos, telefono, cargo, salario)
VALUES 
('Alan', 'Bejarano', '73353875', 'Cajero', 2000),
('Elena', 'Vallejos', '75452724', 'Administrativa', 5000);
GO 

INSERT INTO Usuario (idEmpleado, usuario, clave)
VALUES 
(1, 'EleV', 'hola1234');
GO

INSERT INTO Categoria (nombre)
VALUES 
('Pizzas Clasicas'),
('Pizzas Estaciones '),
('Pizzas Hawaiana'),
('Pizzas Mexicana'),
('Pizzas Tosino')
GO

INSERT INTO Producto (idCategoria, codigo, nombre, descripcion, precio)
VALUES 
(1, 'Clasica', 'Pizza Clasica 1', 'pizza con dos quesos', 50),
(2, 'Estaciones', 'Pizza Primavera', 'Pizza con frutos rojos', 60),
(3, 'Hawaiana', 'Pizza Taco', 'Pizza con salsa verde', 30);
GO

INSERT INTO Cliente (razonSocial, nit, celular)
VALUES 
('Esnor Vaca', '20191040', '7654321'),
('Lucia Flores', '10402521', '75457323');
GO

INSERT INTO Venta (idUsuario, idCliente, totalVenta)
VALUES 
(1, 1, 50),
(2, 2, 60);
GO

INSERT INTO VentaDetalle (idVenta, idProducto, cantidad, precioUnitario, total)
VALUES 
(1, 1, 2, 50, 50.00),
(1, 2, 5, 30.00, 60.00),
(1, 3, 1, 20.00, 20.00),
(2, 2, 10, 10.00, 100.00),
(2, 3, 1, 50.00, 150.00);
GO