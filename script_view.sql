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