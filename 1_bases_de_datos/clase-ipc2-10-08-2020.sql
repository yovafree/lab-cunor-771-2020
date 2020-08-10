-- Contar registros
SELECT COUNT(c.cod_cliente)
FROM facturacion.cliente c

-- Obtener el valor mínimo de un campo
SELECT MIN(dv.cantidad)
FROM facturacion.det_venta dv

SELECT MIN(c.cod_cliente)
FROM facturacion.cliente c

-- Obtener el valor máximo de un campo
SELECT MAX(c.cod_cliente)
FROM facturacion.cliente c

-- Obtener la suma de registros
SELECT SUM(dv.cantidad)
FROM facturacion.det_venta dv

SELECT dv.cod_venta, SUM(dv.cantidad*dv.precio_unitario) subtotal
FROM facturacion.det_venta dv
GROUP BY dv.cod_venta

-- Obtener el promedio de un campo
SELECT AVG(dv.cantidad)
FROM facturacion.det_venta dv

SELECT dv.cod_producto, AVG(dv.cantidad)
FROM facturacion.det_venta dv
GROUP BY dv.cod_producto

-- Operador de rango BETWEEN
SELECT * 
FROM facturacion.venta v
WHERE v.fec_venta BETWEEN '2020-04-01' AND '2020-07-31'

SELECT * 
FROM facturacion.venta v
WHERE v.fec_venta NOT BETWEEN '2020-04-01' AND '2020-07-31'

-- Operador LIKE 
SELECT LOWER(c.nombre) 
FROM facturacion.cliente c
WHERE LOWER(c.nombre) LIKE '%se%'


-- Operadores Matemáticos
-- https://www.postgresql.org/docs/9.1/functions-math.html

SELECT pi()

SELECT trunc(42.8)

-- Funciones sobre caracteres
SELECT 'Angel' || ' ' || 'Ponce'

SELECT e.nombres || ' ' || e.apellidos nombre_completo
FROM facturacion.empleado e

SELECT upper('miguel')

-- Funciones de fecha
-- https://www.postgresql.org/docs/9.0/functions-datetime.html

SELECT date '2001-09-28' - integer '365'

SELECT age(timestamp '2001-04-10', timestamp '1957-06-13')

SELECT age(timestamp '1957-06-13')

SELECT current_date

SELECT current_time

SELECT current_timestamp