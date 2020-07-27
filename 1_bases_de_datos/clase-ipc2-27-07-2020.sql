-- Mostrar todos los productos
SELECT * FROM public.producto

-- Mostrar todas las categorías
SELECT * FROM public.cat_producto

-- Mostrar todos los productos de cierta categoría
SELECT * 
FROM public.producto 
WHERE cod_categoria = 5

-- JOINS o relaciones entre tablas
-- INNER JOIN, LEFT JOIN, RIGHT JOIN

SELECT p.nombre producto, cp.nombre categoria, (p.fec_vencimiento - DATE '2020-07-24') AS cant_dias
FROM public.producto p
INNER JOIN public.cat_producto cp ON p.cod_categoria = cp.cod_categoria

SELECT p.*, cp.*
FROM public.producto p
INNER JOIN public.cat_producto cp ON p.cod_categoria = cp.cod_categoria