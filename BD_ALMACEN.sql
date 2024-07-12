DROP DATABASE Almacen_hamburgueseria
go

CREATE DATABASE Almacen_hamburgueseria
go

USE Almacen_hamburgueseria;
GO

CREATE TABLE Usuario (
    id_usuario INT PRIMARY KEY,
    nombre NVARCHAR(50),
    rol NVARCHAR(45),
    contraseña NVARCHAR(100),
    correo NVARCHAR(50),
    CONSTRAINT u_usuario_correo UNIQUE (correo)
);
GO

CREATE TABLE Producto (
    id_producto INT PRIMARY KEY,
    nombre NVARCHAR(50),
    fecha_vencimiento DATE,
    precio DECIMAL(9,2),
    cantidad DECIMAL(10,2),
	id_proveedor INT,
    nivelMinimo INT,
);
GO

CREATE TABLE Proveedor (
    id_proveedor INT PRIMARY KEY,
    nombre NVARCHAR(50),
    contacto NVARCHAR(50),
    historial_compras NVARCHAR(300),
    CONSTRAINT u_proveedor_contacto UNIQUE (contacto)
);
GO

CREATE TABLE Compra (
    id_compra INT PRIMARY KEY,
    id_producto INT,
	id_usuario INT,
    fecha_compra DATE,
    cantidad DECIMAL(10,2),
    CONSTRAINT fk_compra_id_producto FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),
);
GO

CREATE TABLE Alerta (
    id_alerta INT PRIMARY KEY,
    id_producto INT,
    mensaje NVARCHAR(200),
    CONSTRAINT fk_alerta_id_producto FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);
GO

ALTER TABLE Compra ADD CONSTRAINT fk_compra_id_usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario);
ALTER TABLE Producto ADD CONSTRAINT fk_producto_id_proveedor FOREIGN KEY (id_proveedor) REFERENCES Proveedor(id_proveedor)
