-- Crear Base de Datos
CREATE DATABASE FinalPizzeria;
GO

-- Seleccionar la base de datos
USE FinalPizzeria;
GO

CREATE LOGIN usrpizzeria WITH PASSWORD = N'123456',
     DEFAULT_DATABASE = FinalPizzeria,
     CHECK_EXPIRATION = OFF,
     CHECK_POLICY = ON;
GO 

USE FinalPizzeria;
GO 

CREATE USER usrpizzeria FOR LOGIN usrpizzeria;
GO 

ALTER ROLE db_owner ADD MEMBER usrpizzeria;
GO

-- Eliminar tablas si existen
DROP TABLE IF EXISTS VentaDetalle;
DROP TABLE IF EXISTS Producto;
DROP TABLE IF EXISTS Categoria;
DROP TABLE IF EXISTS Venta;
DROP TABLE IF EXISTS Usuario;
DROP TABLE IF EXISTS Empleado;
DROP TABLE IF EXISTS Cliente;

-- Crear tablas
CREATE TABLE Empleado (
  idEmpleado INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(20) NOT NULL,
  apellidos VARCHAR(50) NOT NULL,
  telefono VARCHAR(20) NOT NULL,
  cargo VARCHAR(20) NOT NULL,
  salario FLOAT NOT NULL
);

CREATE TABLE Usuario (
  idUsuario INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(30) NOT NULL,
  clave VARCHAR(30) NOT NULL,
  FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado)
);

CREATE TABLE Categoria (
  idCategoria INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(30) NOT NULL
);

CREATE TABLE Producto (
  idProducto INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCategoria INT NOT NULL,
  codigo VARCHAR(20) NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  descripcion VARCHAR(500) NOT NULL,
  precio DECIMAL(5,2) NOT NULL,
  stock INT NOT NULL DEFAULT 0, -- Campo agregado
  FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
);

CREATE TABLE Cliente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  razonSocial VARCHAR(50) NOT NULL,
  cedulaIdentidad VARCHAR(15) NOT NULL,
  celular VARCHAR(8) NOT NULL DEFAULT '0'
);

CREATE TABLE Venta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idUsuario INT NOT NULL,
  idCliente INT NOT NULL,
  totalVenta DECIMAL NOT NULL,
  fechaVenta DATE NOT NULL DEFAULT GETDATE(),
  FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario),
  FOREIGN KEY (idCliente) REFERENCES Cliente(id)
);

CREATE TABLE VentaDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idVenta INT NOT NULL,
  idProducto INT NOT NULL,
  cantidad INT NOT NULL CHECK(cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  FOREIGN KEY (idVenta) REFERENCES Venta(id),
  FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);


ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Categoria ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Categoria ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Categoria ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Venta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Venta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Venta ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE VentaDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE VentaDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE VentaDetalle ADD estado SMALLINT NOT NULL DEFAULT 1;

GO

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
    SELECT p.idProducto, p.codigo, p.nombre, p.descripcion, p.precio, p.stock, c.nombre AS categoria
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

INSERT INTO Empleado (nombre, apellidos, telefono, cargo, salario) 
VALUES 


--usuario encriptado
INSERT INTO Empleado (nombre, apellidos, telefono, cargo, salario) 
VALUES 

('Elena', 'zanches', '555-9876', 'Chef', 3500.00);

INSERT INTO Usuario (idEmpleado, usuario, clave) 
VALUES 
(1, 'Elena', 'i0hcoO/nssY6WOs9pOp5Xw==');

SELECT * FROM Usuario;

INSERT INTO Categoria (nombre) 
VALUES 
('Pizza1'),
('Pizza2'),
('Pizza3');

INSERT INTO Producto (idCategoria, codigo, nombre, descripcion, precio) 
VALUES 
(1, 'p001', 'pizza1 ', 'unica con cebolla', 25),
(2, 'p002', 'pizza2', 'pizza con chocolate', 50),
(3, 'P003', 'Helado', 'Helado de vainilla con chocolate', 25);

INSERT INTO Cliente (razonSocial, cedulaIdentidad, celular) 
VALUES 
('Elena', '85324620', '123456'),
('jperez', '063531', '7654322'),
('tifani', '35725633', '7545260');

INSERT INTO Venta (idUsuario, idCliente, totalVenta) 
VALUES 
(1, 1, 100.00),
(2, 2, 50.00),
(3, 3, 75.00);

INSERT INTO VentaDetalle (idVenta, idProducto, cantidad, precioUnitario, total) 
VALUES 
(1, 1, 2, 25, 70),
(1, 2, 1, 50, 50),
(2, 2, 2, 25, 100),
(3, 3, 3, 25, 75);
