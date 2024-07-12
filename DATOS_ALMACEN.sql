USE Almacen_hamburgueseria;
GO

-- Insertar datos en la tabla Usuario
INSERT INTO Usuario (id_usuario, nombre, rol, contraseña, correo)
VALUES 
(1, 'Juan Perez', 'Administrador', 'password1', 'juan.perez@example.com'),
(2, 'Maria Gomez', 'Vendedor', 'password2', 'maria.gomez@example.com'),
(3, 'Luis Rodriguez', 'Cajero', 'password3', 'luis.rodriguez@example.com');
GO

-- Insertar datos en la tabla Proveedor
INSERT INTO Proveedor (id_proveedor, nombre, contacto, historial_compras)
VALUES 
(1, 'Proveedor A', 'contactoA@example.com', 'Historial A'),
(2, 'Proveedor B', 'contactoB@example.com', 'Historial B'),
(3, 'Proveedor C', 'contactoC@example.com', 'Historial C');
GO

-- Insertar datos en la tabla Producto
INSERT INTO Producto (id_producto, nombre, fecha_vencimiento, precio, cantidad, nivelMinimo, id_proveedor)
VALUES 
(1, 'Producto 1', '2024-12-31', 10.00, 100, 10, 1),
(2, 'Producto 2', '2025-01-15', 20.00, 200, 20, 2),
(3, 'Producto 3', '2024-11-30', 15.50, 150, 15, 3);
GO

-- Insertar datos en la tabla Compra
INSERT INTO Compra (id_compra, id_producto, id_usuario, fecha_compra, cantidad)
VALUES 
(1, 1, 1, '2024-06-01', 50),
(2, 2, 2, '2024-06-02', 100),
(3, 3, 3, '2024-06-03', 75);
GO

-- Insertar datos en la tabla Alerta
INSERT INTO Alerta (id_alerta, id_producto, mensaje)
VALUES 
(1, 1, 'Producto 1 cerca de su nivel mínimo'),
(2, 2, 'Producto 2 cerca de su fecha de vencimiento'),
(3, 3, 'Producto 3 cerca de su nivel mínimo');
GO


SELECT * FROM Producto;
SELECT * FROM Proveedor;
SELECT * FROM Compra;
SELECT * FROM Usuario;
SELECT * FROM Alerta;
