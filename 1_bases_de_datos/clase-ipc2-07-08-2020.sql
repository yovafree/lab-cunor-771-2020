-- Productos, cantidad vendida y el subtotal.
SELECT pr.nombre producto, dt.cantidad cantidad, (dt.cantidad*dt.precio_unitario) subtotal
FROM facturacion.det_venta dt
INNER JOIN facturacion.producto pr ON dt.cod_producto = pr.cod_producto


-- Agrupación de productos, cantidad vendida y el subtotal.
SELECT pr.nombre producto, SUM(dt.cantidad) cantidad, SUM(dt.cantidad*dt.precio_unitario) subtotal
FROM facturacion.det_venta dt
INNER JOIN facturacion.producto pr ON dt.cod_producto = pr.cod_producto
GROUP BY pr.nombre
ORDER BY subtotal DESC

-- TOP 5 de Productos más vendidos en terminos monetarios

SELECT pr.nombre producto, SUM(dt.cantidad) cantidad, SUM(dt.cantidad*dt.precio_unitario) subtotal
FROM facturacion.det_venta dt
INNER JOIN facturacion.producto pr ON dt.cod_producto = pr.cod_producto
GROUP BY pr.nombre
ORDER BY subtotal DESC
LIMIT 5

-- Ventas realizadas a clientes por cantidad y total

SELECT c.nombre cliente, COUNT(v.cod_venta) cantidad_venta, SUM(v.total) total
FROM facturacion.cliente c 
INNER JOIN facturacion.venta v ON c.cod_cliente = v.cod_cliente
GROUP BY c.nombre
ORDER BY total desc

-- Ventas realizadas a clientes por total, se calcula por medio de los detalles de la venta

SELECT c.nombre cliente, SUM(dv.cantidad*dv.precio_unitario) total
FROM facturacion.cliente c 
INNER JOIN facturacion.venta v ON c.cod_cliente = v.cod_cliente
INNER JOIN facturacion.det_venta dv ON v.cod_venta = dv.cod_venta
GROUP BY c.nombre
ORDER BY total desc

-- Ventas individuales realizadas por clientes

SELECT c.nombre cliente, v.cod_venta, SUM(dv.cantidad*dv.precio_unitario) total
FROM facturacion.cliente c 
INNER JOIN facturacion.venta v ON c.cod_cliente = v.cod_cliente
INNER JOIN facturacion.det_venta dv ON v.cod_venta = dv.cod_venta
GROUP BY c.nombre, v.cod_venta
ORDER BY total desc

-- Agrupación de ventas por fecha

SELECT v.fec_venta, c.nombre cliente, SUM(dv.cantidad*dv.precio_unitario) total
FROM facturacion.cliente c 
INNER JOIN facturacion.venta v ON c.cod_cliente = v.cod_cliente
INNER JOIN facturacion.det_venta dv ON v.cod_venta = dv.cod_venta
GROUP BY v.fec_venta, c.nombre
ORDER BY fec_venta desc