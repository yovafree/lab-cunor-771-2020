-- Consulta utilizando relaciones (INNER JOIN)
SELECT cp.nombre categoria, pr.nombre producto
FROM facturacion.producto pr
INNER JOIN facturacion.cat_producto cp ON pr.cod_cat_producto = cp.cod_cat_producto

-- Consulta utilizando producto cartesiano
SELECT cp.nombre categoria, pr.nombre producto
FROM facturacion.producto pr,
facturacion.cat_producto cp 
WHERE pr.cod_cat_producto = cp.cod_cat_producto

-- Productos vendidos por cliente.
SELECT pr.nombre producto, c.nombre cliente
FROM facturacion.cliente c
INNER JOIN facturacion.venta v ON c.cod_cliente = v.cod_cliente
INNER JOIN facturacion.det_venta dt ON v.cod_venta = dt.cod_venta
INNER JOIN facturacion.producto pr ON pr.cod_producto = dt.cod_producto

-- Productos vendidos por cliente - Ultimos 7 dias.
SELECT pr.nombre producto, c.nombre cliente
FROM facturacion.cliente c
INNER JOIN facturacion.venta v ON c.cod_cliente = v.cod_cliente
INNER JOIN facturacion.det_venta dt ON v.cod_venta = dt.cod_venta
INNER JOIN facturacion.producto pr ON pr.cod_producto = dt.cod_producto
WHERE (CURRENT_DATE - v.fec_venta) <= 7

-- Consultas con ordenamiento.
SELECT c.nombre cliente, cp.nombre categoria, pr.nombre producto
FROM facturacion.cliente c
INNER JOIN facturacion.venta v ON c.cod_cliente = v.cod_cliente
INNER JOIN facturacion.det_venta dt ON v.cod_venta = dt.cod_venta
INNER JOIN facturacion.producto pr ON pr.cod_producto = dt.cod_producto
INNER JOIN facturacion.cat_producto cp ON cp.cod_cat_producto = pr.cod_cat_producto
WHERE (CURRENT_DATE - v.fec_venta) <= 7
ORDER BY cliente, categoria DESC, producto ASC

-- Group by
SELECT pr.nombre producto, SUM(dt.cantidad) cantidad
FROM facturacion.det_venta dt
INNER JOIN facturacion.producto pr ON dt.cod_producto = pr.cod_producto
GROUP BY pr.nombre