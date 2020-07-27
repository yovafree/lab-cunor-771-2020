--- SQL

--- DDL
--- Data Definition Language

CREATE TABLE usuario
(
    cod_usuario serial not null,
    usuario character varying(15) not null,
    correo_electronico character varying(75) not null,
    contrasenia character varying(150) not null,
    PRIMARY KEY(cod_usuario)
);

DROP TABLE usuario;


------------------------
--- DML
--- Data Manipulation Language
------------------------
INSERT: Insertar datos en la Base de Datos.

Sintáxis:

INSERT INTO public.proveedor(nit, nombre, direccion, telefono) 
VALUES('6542231', 'TIENDA DIEGO', 'BARRIO EL GALLITO', '54652121');

INSERT INTO public.proveedor(nit, nombre, direccion, telefono) 
VALUES('885546', 'TIENDA CARLOS', 'BARRIO EL PERICO', '54652121');

INSERT INTO public.proveedor(nit, nombre, direccion, telefono) 
VALUES('354433', 'TIENDA ANGEL', 'BARRIO LA GALLINA', '54652121');

INSERT INTO public.proveedor(nit, nombre, direccion, telefono) 
VALUES('54665', 'TIENDA CELESTE', 'BARRIO EL SALMON', '54652121');

---------------------
-- UPDATE: Actualizar registros

-- Sintáxis

-- Actualización general de registros
UPDATE public.proveedor SET telefono='12345678'; 

-- Actualización sobre un registro específico
UPDATE public.proveedor SET telefono='87654321' WHERE cod_proveedor = 2;

-- Actualización sobre un registro específico
UPDATE public.proveedor SET telefono='87654321', direccion='Barrio Santiago' WHERE cod_proveedor = 2;

---------------------
-- DELETE: Eliminar registros
---------------------

-- Sintáxis

-- Eliminar todos los registros
DELETE FROM public.proveedor;

-- Eliminar un registro en específico
DELETE FROM public.proveedor WHERE cod_proveedor = 9;


---------------------
-- CONSULTA: Consultar registros y manipular registros entre tablas.
---------------------

-- Sintáxis

-- Todos los campos y registros
SELECT * FROM public.producto;

-- Ciertos campos y todos los registros.
SELECT nombre, fec_vencimiento FROM public.producto;

-- Ciertos campos y todos los registros.
SELECT * FROM public.producto WHERE cod_producto < 4;

-- Ciertos campos y todos los registros.
SELECT * FROM public.producto WHERE (fec_vencimiento - DATE '2020-07-24') <= 7;

-- Agregar una columna virtual calculada a nuestra consulta.

SELECT cod_producto, nombre, fec_vencimiento, (fec_vencimiento - DATE '2020-07-24') AS cant_dias
FROM public.producto WHERE (fec_vencimiento - DATE '2020-07-24') <= 7;