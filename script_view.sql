IF OBJECT_ID('CRISPI.view_clientes', 'V') IS NOT NULL
    DROP VIEW CRISPI.view_clientes
GO

CREATE VIEW CRISPI.view_clientes AS
SELECT cliente_id,cliente_nombre,cliente_apellido,cliente_dni,cliente_mail,cliente_telefono,cliente_direccion,cliente_fechanac as fecha_nacimiento,ciudad_nombre as ciudad,cliente_codigo_postal as codigo_postal,cliente_credito
FROM CRISPI.Cliente c
join CRISPI.Ciudad ci on ci.ciudad_id = c.cliente_ciudad_id
GO



IF OBJECT_ID('CRISPI.view_proveedores', 'V') IS NOT NULL
    DROP VIEW CRISPI.view_proveedores
GO

CREATE VIEW CRISPI.view_proveedores AS
SELECT p.proveedor_id,p.proveedor_cuit as cuit,p.proveedor_rs as razon_social,p.proveedor_dom as domicilio,
	p.proveedor_mail as mail,p.proveedor_telefono as telefono,c.ciudad_nombre as ciudad,r.rubro_nombre as rubro
FROM CRISPI.Proveedor p
join CRISPI.Ciudad c on c.ciudad_id = p.proveedor_ciudad_id
join CRISPI.Rubro_Proveedor rp on rp.rubro_proveedor = p.proveedor_id
join CRISPI.Rubro r on r.rubro_id = rp.rubro_id
GO


IF OBJECT_ID('CRISPI.view_user', 'V') IS NOT NULL
    DROP VIEW CRISPI.view_user
GO

CREATE VIEW CRISPI.view_user AS
select u.usuario_id as id, u.usuario_username as username, r.rol_id as rol_id,u.usuario_proveedor_id as proveedor_id,
	u.usuario_cliente_id as cliente_id 
from CRISPI.Usuario u
join CRISPI.Rol_Por_Usuario r on r.usuario_id = u.usuario_id
GO


IF OBJECT_ID('CRISPI.ofertas_facturas', 'V') IS NOT NULL
    DROP VIEW CRISPI.ofertas_facturas
GO

CREATE VIEW CRISPI.ofertas_facturas AS
select o.oferta_codigo as codigo,o.oferta_descripcion as oferta_descripcion,c.cliente_nombre as cliente_nombre,
	v.venta_fecha as fecha_compra, v.venta_cantidad as cantidad,o.oferta_precio as precio,rp.rubro_proveedor as proveedor_id 
from CRISPI.Venta v
join CRISPI.Oferta o on o.oferta_id = v.venta_oferta_id
join CRISPI.Cliente c on c.cliente_id = v.venta_cliente_id
join CRISPI.Rubro_Proveedor rp on rp.rubro_proveedor_id = o.oferta_rubro_proveedor_id
GO
