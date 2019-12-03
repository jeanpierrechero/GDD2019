IF OBJECT_ID('CRISPI.view_clientes', 'V') IS NOT NULL
    DROP VIEW CRISPI.view_clientes
GO

CREATE VIEW CRISPI.view_clientes AS
SELECT cliente_nombre,cliente_apellido,cliente_dni,cliente_mail,cliente_telefono,cliente_direccion,cliente_fechanac
FROM CRISPI.Cliente
GO


IF OBJECT_ID('CRISPI.view_proveedores', 'V') IS NOT NULL
    DROP VIEW CRISPI.view_proveedores
GO

CREATE VIEW CRISPI.view_proveedores AS
SELECT p.proveedor_cuit as cuit,p.proveedor_rs as razon_social,p.proveedor_dom as domicilio,
	p.proveedor_mail as mail,p.proveedor_telefono as telefono,c.ciudad_nombre as ciudad,r.rubro_nombre as rubro
FROM CRISPI.Proveedor p
join CRISPI.Ciudad c on c.ciudad_id = p.proveedor_ciudad_id
join CRISPI.Rubro_Proveedor rp on rp.rubro_proveedor_id = p.proveedor_id
join CRISPI.Rubro r on r.rubro_id = rp.rubro_id
GO