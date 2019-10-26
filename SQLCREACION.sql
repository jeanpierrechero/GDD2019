USE GD2C2019
GO
-------------------------------------/* CREACION ESQUEMA */-------------------------------------

CREATE SCHEMA CRISPI
GO

-------------------------------------/* CREACION TABLAS */-------------------------------------


PRINT '----- Empezando a crear tablas -----'
CREATE TABLE CRISPI.Usuario( 
	usuario_id int IDENTITY(1,1) PRIMARY KEY,
	usuario_username nvarchar(50) NOT NULL,
	usuario_password nvarchar(50) NOT NULL,
	usuario_habilitado bit NOT NULL,
	usuario_estado bit NOT NULL,
	usuario_cantidaderrores int NOT NULL,
)

CREATE TABLE CRISPI.Ciudad( 
	ciudad_id int IDENTITY(1,1) PRIMARY KEY,
	ciudad_nombre nvarchar(255) UNIQUE NOT NULL,
	
)

CREATE TABLE CRISPI.Cliente(
    cliente_id int IDENTITY(1,1) PRIMARY KEY,
    cliente_ciudad_id int CONSTRAINT FK_CLIENTE_CIUDAD REFERENCES CRISPI.Ciudad(ciudad_id),
	cliente_nombre nvarchar(255) NOT NULL,
	cliente_apellido nvarchar(255) NOT NULL,
	cliente_dni numeric(18,0)  NOT NULL,
	cliente_direccion nvarchar(255) NOT NULL,
	cliente_telefono numeric(18,0) NOT NULL,
	cliente_mail nvarchar(255) NOT NULL,
	cliente_credito numeric(18,2) NOT NULL,
	cliente_fechanac datetime2(3) NOT NULL,
	cliente_codigo_postal int NULL,
)

CREATE TABLE CRISPI.Funcionalidad( 
    funcionalidad_id int IDENTITY(1,1) PRIMARY KEY,
	funcionalidad_descripcion nvarchar(50) NOT NULL
)

CREATE TABLE CRISPI.Rol( 
	rol_id int IDENTITY(1,1) PRIMARY KEY,
	rol_nombre nvarchar(50) UNIQUE NOT NULL,
	rol_estado bit NOT NULL
)

CREATE TABLE CRISPI.Proveedor( 
	proveedor_id int IDENTITY(1,1) PRIMARY KEY,
	proveedor_cuit nvarchar(20),
	proveedor_rubro nvarchar(100),
	proveedor_rs nvarchar(100),
	proveedor_dom nvarchar(100),
	proveedro_mail nvarchar(100),
	proveedor_ciudad_id int CONSTRAINT FK_PROVEEDOR_CIUDAD REFERENCES CRISPI.Ciudad(ciudad_id),
	proveedor_telefono numeric(18,0),
	)

CREATE TABLE CRISPI.Rol_Por_Usuario( 
	rol_usuario_id int IDENTITY(1,1) PRIMARY KEY,
	usuario_id int CONSTRAINT FK_ROLUSUARIO_USUARIO REFERENCES CRISPI.Usuario(usuario_id),
	rol_proveedor int CONSTRAINT FK_ROLUSUARIO_PROVEEDOR REFERENCES CRISPI.Proveedor(proveedor_id),
	rol_cliente int CONSTRAINT FK_ROLUSUARIO_CLIENTE REFERENCES CRISPI.Cliente(cliente_id),
	rol_usuario_estado bit,
	rol_id int CONSTRAINT FK_ROLUSUARIO_ROL REFERENCES CRISPI.Rol(rol_id)
)

CREATE TABLE CRISPI.Rol_Por_Funcionalidad( 
	rol_id int CONSTRAINT FK_ROLFUNCIONALIDAD_ROL REFERENCES CRISPI.Rol(rol_id) ,
	funcionalidad_id int CONSTRAINT FK_ROLFUNCIONALIDAD_FUNCIONALIDAD REFERENCES CRISPI.Funcionalidad(funcionalidad_id)
)

CREATE TABLE CRISPI.Rubro( 
	rubro_id int IDENTITY(1,1) PRIMARY KEY,
	rubro_nombre nvarchar(100) UNIQUE NOT NULL,
	
)

CREATE TABLE CRISPI.Rubro_Proveedor( 
	rubro_proveedor_id int IDENTITY(1,1) PRIMARY KEY,
	rubro_proveedor int CONSTRAINT FK_RUBRO_PROVEEDOR REFERENCES CRISPI.Proveedor(proveedor_id),
	rubro int CONSTRAINT FK_RUBRO REFERENCES CRISPI.Rubro(rubro_id),
)

CREATE TABLE CRISPI.TIPO( 
	tipo_id int IDENTITY(1,1) PRIMARY KEY,
	tipo_nombre nvarchar(100) UNIQUE NOT NULL,
	)

CREATE TABLE CRISPI.Credito( 
	credito_id int IDENTITY(1,1) PRIMARY KEY,
	credito_fecha datetime2(3),
	credito_monto numeric(18,2),
	credito_cliente int CONSTRAINT FK_CREDITO_CLIENTE REFERENCES CRISPI.Cliente(cliente_id), 
	credito_tipo int CONSTRAINT FK_CREDITO_TIPO REFERENCES CRISPI.TIPO(tipo_id),
	credito_tarjeta decimal(18,0),
	credito_datos nvarchar(255),
)

CREATE TABLE CRISPI.Oferta( 
	oferta_id int IDENTITY(1,1) PRIMARY KEY,
	oferta_codigo decimal(18,0) ,
	oferta_descripcion nvarchar(255),
	oferta_precio numeric(18,2),
	oferta_lista numeric(18,2),
	oferta_cantidad numeric(18,2),
	oferta_maxima int,
	oferta_fechap datetime2(3),
	oferta_fechaf datetime2(3),
	oferta_proveedor int CONSTRAINT FK_OFERTA_PROVEEDOR REFERENCES CRISPI.Proveedor(proveedor_id), 
)

CREATE TABLE CRISPI.Facturacion(
	facturacion_id int IDENTITY(1,1) PRIMARY KEY,
	facturacion_nro numeric(18,0),
	facturacion_tipo nvarchar(1),
	facturacion_proveedor int CONSTRAINT FK_FACTURACION_PROVEEDOR REFERENCES CRISPI.Proveedor(proveedor_id),
	facturacion_fecha datetime2(3),
	facturacion_monto int,
	
)

CREATE TABLE CRISPI.Item_factura(
	item_factura_id int IDENTITY(1,1) PRIMARY KEY,
	facturacion_id int CONSTRAINT FK_ITEM_FACTURACION REFERENCES CRISPI.Facturacion(facturacion_id),
	cliente_id int CONSTRAINT FK_ITEM_CLIENTE REFERENCES CRISPI.Cliente(cliente_id),
	oferta_id int CONSTRAINT FK_ITEM_OFERTA REFERENCES CRISPI.OFERTA(oferta_id),
	item_factura_cantidad int ,
	
)

CREATE TABLE CRISPI.Estado(
	estado_id int IDENTITY(1,1) PRIMARY KEY,
	estado nvarchar(50),
	
)

CREATE TABLE CRISPI.Cupones(
	cupones_id int IDENTITY(1,1) PRIMARY KEY,
	cupones_estado_id int CONSTRAINT FK_ITEM_FACTURACION REFERENCES CRISPI.Facturacion(facturacion_id),
	cupones_cliente_id int CONSTRAINT FK_ITEM_CLIENTE REFERENCES CRISPI.Cliente(cliente_id),
	cupones_oferta_id int CONSTRAINT FK_ITEM_OFERTA REFERENCES CRISPI.OFERTA(oferta_id),
	
)
    PRINT '----- COMIENZA LA CREACION DE DATOS -----'

PRINT 'Creando roles'

INSERT INTO CRISPI.Rol (rol_nombre, rol_estado)
         values('Administrador', 1),
		 ('Usuario', 1),
		 ('Proveedor',1)

PRINT 'Roles creados correctamente'
GO

PRINT 'Creando estados'

INSERT INTO CRISPI.Estado(estado,estado_id)
         values('', 1),
		 ('', 2)
		 

PRINT 'estados creados correctamente'
GO

PRINT 'Creando funcionalidades'
INSERT INTO CRISPI.Funcionalidad (funcionalidad_descripcion)
         values('ALTA_ROL'),
		 ('BAJA_ROL'),
		 ('MODIFICACION_ROL'),
		 ('ALTA_OFERTA'),
		 ('BAJA_OFERTA'),
		 ('MODIFICACION_OFERTA'),
		 ('VISUALIZACION_CLIENTES'),
		 ('VISUALIZACION_PROVEEDORES'),
		 ('VISUALIZACION_LISTADO_ESTADISTICO');

PRINT 'Funcionalidades creadas correctamente'
GO


PRINT 'Asignando funcionalidad a los roles'
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,1),
         (1,2),
		 (1,3),
		 (1,4),
		 (1,5),
		 (1,6),
		 (1,7),
		 (1,8),
		 (1,9);
--falta la asignacion de cliente y proveedores
PRINT 'Funcionalidades asignadas a los roles correctamente'
GO


-------------------------------------/* MIGRACION DE DATOS */-------------------------------------

PRINT '----- COMIENZA LA MIGRACION -----'

PRINT 'Migracion de ciudades'

INSERT INTO CRISPI.Ciudad(ciudad_nombre)
	SELECT DISTINCT Cli_Ciudad
    FROM gd_esquema.Maestra m
    where m.Cli_Ciudad is not null
	ORDER BY 1
PRINT 'Ciudades migrados correctamente'
GO

PRINT 'Migracion de rubro'
INSERT INTO CRISPI.Rubro(rubro_nombre)
	SELECT DISTINCT Provee_Rubro
		FROM gd_esquema.Maestra m
		where m.Provee_Rubro is not null
		ORDER BY 1
PRINT 'Rubro migrados correctamente'
GO

PRINT 'Migracion de tipos'
INSERT INTO CRISPI.TIPO(tipo_nombre)
	SELECT DISTINCT Tipo_Pago_Desc
		FROM gd_esquema.Maestra m
		where m.Tipo_Pago_Desc is not null
		ORDER BY 1
PRINT 'Tipos migrados correctamente'
GO

PRINT 'Migracion de clientes'
INSERT INTO CRISPI.Cliente(cliente_apellido,cliente_nombre,cliente_dni,cliente_fechanac,cliente_direccion,cliente_mail,cliente_telefono,cliente_ciudad_id,cliente_credito)
	SELECT Cli_Apellido,Cli_Nombre, Cli_Dni,Cli_Fecha_Nac,Cli_Direccion,Cli_Mail,Cli_Telefono,a.ciudad_id,SUM(ISNULL(Carga_Credito,0))
		FROM gd_esquema.Maestra m,CRISPI.Ciudad a
		where m.Cli_Dni is not null and m.Cli_Ciudad = a.ciudad_nombre
		group by Cli_Apellido,Cli_Nombre, Cli_Dni,Cli_Fecha_Nac,Cli_Direccion,Cli_Mail,Cli_Telefono,a.ciudad_id
		ORDER BY m.Cli_Dni
PRINT 'Clientes migrados correctamente'
GO

PRINT 'Migracion de  Proveedores'
INSERT INTO CRISPI.Proveedor(proveedor_cuit,proveedor_dom,proveedor_rs,proveedor_rubro,proveedor_telefono,proveedor_ciudad_id)
	SELECT DISTINCT Provee_CUIT,Provee_Dom,Provee_RS,Provee_Rubro,Provee_Telefono,a.ciudad_id
    FROM gd_esquema.Maestra m ,CRISPI.Ciudad a
    where m.Provee_CUIT is not null and m.Provee_Ciudad=a.ciudad_nombre 
	ORDER BY Provee_CUIT
PRINT 'Proveedores migrados correctamente'
GO

PRINT 'Migracion Rubro Proveedor'
INSERT INTO CRISPI.Rubro_Proveedor(rubro_proveedor,rubro)
	SELECT DISTINCT a.proveedor_id,r.rubro_id
		FROM gd_esquema.Maestra m,CRISPI.Proveedor a,CRISPI.Rubro r
		where m.Provee_CUIT is not null and m.Provee_CUIT=a.proveedor_cuit and m.Provee_Rubro=r.rubro_nombre
		ORDER BY a.proveedor_id
PRINT 'Rubro Proveedor migrados correctamente'
GO

PRINT 'Migracion Credito'
INSERT INTO CRISPI.Credito(credito_fecha,credito_monto,credito_tipo,credito_cliente)
	SELECT DISTINCT Carga_Fecha,Carga_Credito,a.tipo_id,r.cliente_id
		FROM gd_esquema.Maestra m,CRISPI.TIPO a,CRISPI.Cliente r
		where m.Carga_Credito is not null and m.Tipo_Pago_Desc=a.tipo_nombre and m.Cli_Dni=r.cliente_dni
		ORDER BY r.cliente_id
PRINT 'Credito migrados correctamente'
GO

PRINT 'Migracion oferta'
INSERT INTO CRISPI.Oferta(oferta_codigo,oferta_descripcion,oferta_fechaf,oferta_lista,oferta_precio,oferta_fechap,oferta_proveedor,oferta_cantidad)
	SELECT DISTINCT Oferta_Codigo,Oferta_Descripcion,Oferta_Fecha_Venc,Oferta_Precio_Ficticio,Oferta_Precio,Oferta_Fecha,r.proveedor_id,Oferta_Cantidad
		FROM gd_esquema.Maestra m,CRISPI.TIPO a,CRISPI.Proveedor r
		where m.Oferta_Codigo is not null and m.Provee_CUIT=r.proveedor_cuit 
		ORDER BY m.Oferta_Codigo
PRINT 'oferta migrados correctamente'
GO

PRINT 'Migracion facturacion'
INSERT INTO CRISPI.Facturacion(facturacion_nro,facturacion_tipo,facturacion_monto,facturacion_proveedor)
	
SELECT m.Factura_Nro,'A',m.Factura_Fecha,count(m.Factura_Nro)*m.Oferta_Precio,a.proveedor_id
FROM gd_esquema.Maestra m,CRISPI.Proveedor a
where m.Factura_Nro is not null and m.Provee_CUIT=a.proveedor_cuit
group by m.Factura_Nro,m.Factura_Fecha
PRINT 'Rubro Proveedor migrados correctamente'
GO


PRINT 'Migracion item facturacion'
INSERT INTO CRISPI.Item_factura(facturacion_id,cliente_id,item_factura_cantidad,oferta_id)

select a.facturacion_id,c.cliente_id,m.Oferta_Cantidad,o.oferta_id
from gd_esquema.Maestra m,CRISPI.Facturacion a,CRISPI.Cliente c,CRISPI.Oferta o
where m.Factura_Nro is not null and m.Factura_Nro=a.facturacion_nro and m.Cli_Dni=c.cliente_dni and m.Oferta_Codigo=o.oferta_codigo
PRINT ' migrados correctamente'
GO

select a.facturacion_id,c.cliente_id
from gd_esquema.Maestra m,CRISPI.Facturacion a,CRISPI.Cliente c
where Factura_Fecha is not null and m.Factura_Nro=a.facturacion_nro and m.Cli_Dni=c.cliente_dni

		
SELECT *
FROM gd_esquema.Maestra m
where m.Factura_Nro is not null



