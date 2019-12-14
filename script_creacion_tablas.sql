USE GD2C2019
GO
CREATE  PROCEDURE CRISPI.proc_create_tables
AS
BEGIN TRY	
	begin transaction;

	PRINT '----- Empezando a crear tablas -----'
	CREATE TABLE CRISPI.Usuario( 
		usuario_id int IDENTITY(1,1) PRIMARY KEY,
		usuario_username nvarchar(50) NOT NULL,
		usuario_password nvarchar(50) NOT NULL,
		usuario_proveedor_id int NULL,
		usuario_cliente_id int NULL,
		usuario_habilitado bit NOT NULL,
		usuario_estado bit DEFAULT 0,
		usuario_cantidad_errores int NOT NULL default 0,
	)

	CREATE TABLE CRISPI.Ciudad( 
		ciudad_id int IDENTITY(1,1) PRIMARY KEY,
		ciudad_nombre nvarchar(255) NOT NULL	
	)

	CREATE TABLE CRISPI.Cliente(
		cliente_id int IDENTITY(1,1) PRIMARY KEY,
		cliente_nombre nvarchar(255) NOT NULL,
		cliente_apellido nvarchar(255) NOT NULL,
		cliente_dni numeric(18,0)  NOT NULL,
		cliente_mail nvarchar(255) NOT NULL,
		cliente_telefono numeric(18,0) NOT NULL,
		cliente_direccion nvarchar(255) NOT NULL,
		cliente_fechanac datetime NOT NULL,	
		cliente_ciudad_id int NULL,
		cliente_codigo_postal int NULL,
		cliente_credito numeric(18,2) NULL,
	)

	CREATE TABLE CRISPI.Funcionalidad( 
		funcionalidad_id int IDENTITY(1,1) PRIMARY KEY,
		funcionalidad_descripcion nvarchar(50) NOT NULL
	)

	CREATE TABLE CRISPI.Rol( 
		rol_id int IDENTITY(1,1) PRIMARY KEY,
		rol_nombre nvarchar(50) NOT NULL,
		rol_estado bit DEFAULT 0
	)

	CREATE TABLE CRISPI.Proveedor( 
		proveedor_id int IDENTITY(1,1) PRIMARY KEY,
		proveedor_cuit nvarchar(20) NOT NULL,
		proveedor_rs nvarchar(100) NOT NULL,
		proveedor_dom nvarchar(100) NOT NULL,
		proveedor_mail nvarchar(255) NULL,
		proveedor_ciudad_id int NOT NULL,
		proveedor_telefono numeric(18,0) NOT NULL,
		proveedor_estado bit DEFAULT 0
	)

	CREATE TABLE CRISPI.Rol_Por_Usuario( 
		rol_usuario_id int IDENTITY(1,1) PRIMARY KEY,
		usuario_id int NOT NULL,
		rol_id int NOT NULL
	)

	CREATE TABLE CRISPI.Rol_Por_Funcionalidad( 
		rol_id int NOT NULL,
		funcionalidad_id int NOT NULL
	)

	CREATE TABLE CRISPI.Rubro( 
		rubro_id int IDENTITY(1,1) PRIMARY KEY,
		rubro_nombre nvarchar(100) NOT NULL,
	
	)

	CREATE TABLE CRISPI.Rubro_Proveedor( 
		rubro_proveedor_id int IDENTITY(1,1) PRIMARY KEY,
		rubro_proveedor int NOT NULL,
		rubro_id int NOT NULL,
	)

	CREATE TABLE CRISPI.Tipo_pago( 
		tipo_pago_id int IDENTITY(1,1) PRIMARY KEY,
		tipo_pago_nombre nvarchar(100) NOT NULL,
	)

	CREATE TABLE CRISPI.Credito( 
		credito_id int IDENTITY(1,1) PRIMARY KEY,
		credito_fecha datetime NOT NULL,
		credito_monto numeric(18,2) NOT NULL,
		credito_cliente_id int NOT NULL, 
		credito_tipo_pago_id int NULL,
		credito_tarjeta decimal(18,0) NULL,
		credito_datos nvarchar(255) NULL,
	)

	CREATE TABLE CRISPI.Oferta( 
		oferta_id int IDENTITY(1,1) PRIMARY KEY,
		oferta_codigo nvarchar(50) NOT NULL,
		oferta_descripcion nvarchar(255) NOT NULL,
		oferta_precio numeric(18,2) NOT NULL,
		oferta_lista numeric(18,2) NOT NULL,
		oferta_cantidad numeric(18,0) NOT NULL,
		oferta_maxima int NOT NULL,
		oferta_fecha_inicio datetime,
		oferta_fecha_fin datetime,
		--oferta_proveedor_id int NOT NULL, 
		oferta_usuario_creador_id int NULL,
		oferta_eliminado bit DEFAULT 0,
		oferta_rubro_proveedor_id int 
	)

	CREATE TABLE CRISPI.Facturacion(
		facturacion_id int IDENTITY(1,1) PRIMARY KEY,
		facturacion_nro numeric(18,0) NOT NULL,
		facturacion_tipo nvarchar(1) NOT NULL,
		facturacion_proveedor_id int NOT NULL,
		facturacion_fecha datetime NOT NULL,
		facturacion_monto numeric(18,2),	
	)

	CREATE TABLE CRISPI.Item_factura(
		item_factura_id int IDENTITY(1,1) PRIMARY KEY,
		facturacion_id int NOT NULL,
		cliente_id int NOT NULL,
		oferta_id int NOT NULL,
		item_factura_cantidad int	
	)

	CREATE TABLE CRISPI.Estado(
		estado_id int IDENTITY(1,1) PRIMARY KEY,
		estado_descripcion nvarchar(50)	
	)

	CREATE TABLE CRISPI.Cupones(
		cupones_id int IDENTITY(1,1) PRIMARY KEY,
		cupones_oferta_id int NOT NULL,
		cupones_precio_oferta numeric(18,2) NOT NULL,
		cupones_precio_lista numeric(18,2) NOT NULL,
		cupones_cliente_id int NOT NULL,
		cupones_estado_id int NOT NULL,		
	)

	CREATE TABLE CRISPI.Historial_cupones(
		historial_id int IDENTITY(1,1) PRIMARY KEY,
		historial_cupon_id int NOT NULL,
		historial_estado_id int NOT NULL,
		historial_detalle nvarchar(255) NOT NULL,
		historial_fecha datetime
	)

	CREATE TABLE CRISPI.Venta(
		venta_id int IDENTITY(1,1) PRIMARY KEY,
		venta_oferta_id int NOT NULL,
		venta_cliente_id int NOT NULL,
		venta_fecha datetime,
		venta_cliente_destino_id int NOT NULL
	)

	ALTER TABLE CRISPI.Usuario ADD CONSTRAINT fk_usuario_cliente_id FOREIGN KEY (usuario_cliente_id) REFERENCES CRISPI.Cliente(cliente_id);

	ALTER TABLE CRISPI.Usuario ADD CONSTRAINT fk_usuario_proveedor_id FOREIGN KEY (usuario_proveedor_id) REFERENCES CRISPI.PROVEEDOR(proveedor_id);

	ALTER TABLE CRISPI.Ciudad ADD CONSTRAINT uq_ciudad_nombre UNIQUE (ciudad_nombre);

	ALTER TABLE CRISPI.Cliente ADD CONSTRAINT fk_cliente_ciudad_id FOREIGN KEY (cliente_ciudad_id) REFERENCES CRISPI.Ciudad(ciudad_id);

	ALTER TABLE CRISPI.Funcionalidad ADD CONSTRAINT uq_funcionalidad_descripcion UNIQUE (funcionalidad_descripcion);

	ALTER TABLE CRISPI.Rol ADD CONSTRAINT uq_rol_nombre UNIQUE (rol_nombre);

	ALTER TABLE CRISPI.Proveedor ADD CONSTRAINT uq_cuit_rs UNIQUE (proveedor_cuit,proveedor_rs);

	ALTER TABLE CRISPI.Proveedor ADD CONSTRAINT fk_proveedor_ciudad_id FOREIGN KEY (proveedor_ciudad_id) REFERENCES CRISPI.Ciudad(ciudad_id);

	ALTER TABLE CRISPI.Rol_Por_Usuario ADD CONSTRAINT fk_rolusuario_usuario FOREIGN KEY (usuario_id) REFERENCES CRISPI.Usuario(usuario_id);

	ALTER TABLE CRISPI.Rol_Por_Usuario ADD CONSTRAINT fk_rolusuario_rol FOREIGN KEY (rol_id) REFERENCES CRISPI.Rol(rol_id);

	ALTER TABLE CRISPI.Rol_Por_Funcionalidad ADD CONSTRAINT fk_rolfuncionalidad_rol FOREIGN KEY (rol_id) REFERENCES CRISPI.Rol(rol_id);

	ALTER TABLE CRISPI.Rol_Por_Funcionalidad ADD CONSTRAINT fk_rolfuncionalidad_funcionalidad FOREIGN KEY (funcionalidad_id) REFERENCES CRISPI.Funcionalidad(funcionalidad_id);

	ALTER TABLE CRISPI.Rubro ADD CONSTRAINT uq_rubro_nombre UNIQUE (rubro_nombre);

	ALTER TABLE CRISPI.Rubro_Proveedor ADD CONSTRAINT fk_rubro_proveedor FOREIGN KEY (rubro_proveedor) REFERENCES CRISPI.Proveedor(proveedor_id);

	ALTER TABLE CRISPI.Rubro_Proveedor ADD CONSTRAINT fk_rubro_id FOREIGN KEY (rubro_id) REFERENCES CRISPI.Rubro(rubro_id);

	ALTER TABLE CRISPI.Tipo_pago ADD CONSTRAINT uq_tipo_pago_nombre UNIQUE (tipo_pago_nombre);

	ALTER TABLE CRISPI.Credito ADD CONSTRAINT fk_credito_cliente_id FOREIGN KEY (credito_cliente_id) REFERENCES CRISPI.Cliente(cliente_id);

	ALTER TABLE CRISPI.Credito ADD CONSTRAINT fk_credito_tipo_pago_id FOREIGN KEY (credito_tipo_pago_id) REFERENCES CRISPI.Tipo_pago(tipo_pago_id);

	ALTER TABLE CRISPI.Oferta ADD CONSTRAINT fk_oferta_rubro_proveedor_id FOREIGN KEY (Oferta_rubro_proveedor_id) REFERENCES CRISPI.Rubro_Proveedor(rubro_proveedor_id);

	ALTER TABLE CRISPI.Oferta ADD CONSTRAINT fk_oferta_usuario_creador_id FOREIGN KEY (oferta_usuario_creador_id) REFERENCES CRISPI.Usuario(usuario_id);

	ALTER TABLE CRISPI.Facturacion ADD CONSTRAINT fk_facturacion_proveedor_id FOREIGN KEY (facturacion_proveedor_id) REFERENCES CRISPI.Proveedor(proveedor_id);

	ALTER TABLE CRISPI.Item_factura ADD  CONSTRAINT fk_item_factura_facturacion_id FOREIGN KEY (facturacion_id) REFERENCES CRISPI.Facturacion(facturacion_id);

	ALTER TABLE CRISPI.Item_factura ADD  CONSTRAINT fk_item_factura_cliente_id FOREIGN KEY (cliente_id) REFERENCES CRISPI.Cliente(cliente_id);

	ALTER TABLE CRISPI.Item_factura ADD  CONSTRAINT fk_item_factura_oferta_id FOREIGN KEY (oferta_id) REFERENCES CRISPI.Oferta(oferta_id);

	ALTER TABLE CRISPI.Estado ADD CONSTRAINT uq_estado_descripcion UNIQUE (estado_descripcion);

	ALTER TABLE CRISPI.Cupones ADD  CONSTRAINT fk_cupones_estado_id FOREIGN KEY (cupones_estado_id) REFERENCES CRISPI.Estado(estado_id);

	ALTER TABLE CRISPI.Cupones ADD  CONSTRAINT fk_cupones_cliente_id FOREIGN KEY (cupones_cliente_id) REFERENCES CRISPI.Cliente(cliente_id);

	ALTER TABLE CRISPI.Cupones ADD  CONSTRAINT fk_cupones_oferta_id FOREIGN KEY (cupones_oferta_id) REFERENCES CRISPI.Oferta(oferta_id);

	ALTER TABLE CRISPI.Historial_cupones ADD  CONSTRAINT fk_historial_cupon_id FOREIGN KEY (historial_cupon_id) REFERENCES CRISPI.Cupones(cupones_id);

	ALTER TABLE CRISPI.Historial_cupones ADD  CONSTRAINT fk_historial_estado_id FOREIGN KEY (historial_estado_id) REFERENCES CRISPI.Estado(estado_id);

	ALTER TABLE CRISPI.Venta ADD  CONSTRAINT fk_venta_oferta_id FOREIGN KEY (venta_oferta_id) REFERENCES CRISPI.Oferta(oferta_id);

	ALTER TABLE CRISPI.Venta ADD  CONSTRAINT fk_venta_cliente_id FOREIGN KEY (venta_cliente_id) REFERENCES CRISPI.Cliente(cliente_id);

	ALTER TABLE CRISPI.Venta ADD  CONSTRAINT fk_venta_cliente_destino_id FOREIGN KEY (venta_cliente_destino_id) REFERENCES CRISPI.Cliente(cliente_id);

	PRINT '----- Creación de tablas exitosa -----'
	
	
	INSERT INTO CRISPI.Usuario(usuario_username,usuario_password,usuario_proveedor_id,usuario_cliente_id,usuario_habilitado,usuario_estado,usuario_cantidad_errores)
	VALUES ('admin', HASHBYTES('SHA2_256', CONVERT(nvarchar(50), 'w23e')),NULL,NULL,1,1,0);

	PRINT 'Creando roles'
	INSERT INTO CRISPI.Rol (rol_nombre, rol_estado)
	VALUES('Administrador', 1),
		('Usuario', 1),
		('Proveedor',1);
	PRINT 'Roles creados correctamente'
	
	PRINT 'Creando rol por usuario'
	INSERT INTO CRISPI.Rol_Por_Usuario (usuario_id, rol_id)
	VALUES(1, 1);
	PRINT 'rol por usuario creado correctamente'


	PRINT 'Creando funcionalidades'
	INSERT INTO CRISPI.Funcionalidad (funcionalidad_descripcion)
	VALUES('ALTA_ROL'),
		('BAJA_ROL'),
		('EDITAR_ROL'),
		('VISUALIZAR_ROL')
		('ALTA_OFERTA'),
		('BAJA_OFERTA'),
		('EDITAR_OFERTA'),
		('VISUALIZAR_OFERTA'),
		('VISUALIZAR_CLIENTE'),
		('ALTA_CLIENTE'),
		('EDITAR_CLIENTE'),
		('ELIMINAR_CLIENTE'),
		('VISUALIZAR_PROVEEDOR'),
		('ALTA_PROVEEDOR'),
		('EDITAR_PROVEEDOR'),
		('ELIMINAR_PROVEEDOR')
		('VISUALIZAR_LISTADO_ESTADISTICO');
	PRINT 'Funcionalidades creadas correctamente'


	PRINT 'Asignando funcionalidad a los roles'
	INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
	(SELECT 1, funcionalidad_id FROM CRISPI.Funcionalidad);
	PRINT 'Funcionalidades asignadas a los roles correctamente'


	PRINT 'Migracion de ciudades'
	INSERT INTO CRISPI.Ciudad(ciudad_nombre)
	(SELECT Cli_Ciudad
	FROM gd_esquema.Maestra
	WHERE Cli_Ciudad IS NOT NULL
	group by Cli_Ciudad);
	PRINT 'Ciudades migrados correctamente'


	PRINT 'Migracion de rubro'
	INSERT INTO CRISPI.Rubro(rubro_nombre)
	(SELECT Provee_Rubro
	FROM gd_esquema.Maestra
	WHERE Provee_Rubro IS NOT NULL
	group by Provee_Rubro);
	PRINT 'Rubro migrados correctamente'


	PRINT 'Migracion de tipo_pago'
	INSERT INTO CRISPI.Tipo_pago(tipo_pago_nombre)
	(SELECT Tipo_Pago_Desc
	FROM gd_esquema.Maestra
	WHERE Tipo_Pago_Desc IS NOT NULL
	group by Tipo_Pago_Desc);
	PRINT 'Tipos de pago migrados correctamente'


	PRINT 'Migracion de clientes'
	INSERT INTO CRISPI.Cliente(cliente_apellido,cliente_nombre,cliente_dni,cliente_fechanac,cliente_direccion,cliente_mail,cliente_telefono,cliente_ciudad_id,cliente_credito)
	(SELECT Cli_Apellido,Cli_Nombre, Cli_Dni,Cli_Fecha_Nac,Cli_Direccion,Cli_Mail,Cli_Telefono,a.ciudad_id,SUM(ISNULL(Carga_Credito,0))
	FROM gd_esquema.Maestra m,CRISPI.Ciudad a
	WHERE m.Cli_Dni IS NOT NULL AND m.Cli_Ciudad = a.ciudad_nombre
	GROUP BY Cli_Apellido,Cli_Nombre, Cli_Dni,Cli_Fecha_Nac,Cli_Direccion,Cli_Mail,Cli_Telefono,a.ciudad_id);
	PRINT 'Clientes migrados correctamente'


	PRINT 'Migracion de  Proveedores'
	INSERT INTO CRISPI.Proveedor(proveedor_cuit,proveedor_dom,proveedor_rs,proveedor_telefono,proveedor_ciudad_id,proveedor_estado)
	SELECT DISTINCT Provee_CUIT,Provee_Dom,Provee_RS,Provee_Telefono,a.ciudad_id,1
	FROM gd_esquema.Maestra m ,CRISPI.Ciudad a
	WHERE m.Provee_CUIT IS NOT NULL AND m.Provee_Ciudad=a.ciudad_nombre
	PRINT 'Proveedores migrados correctamente'


	PRINT 'Migracion Rubro Proveedor'
	INSERT INTO CRISPI.Rubro_Proveedor(rubro_proveedor,rubro_id)
	SELECT DISTINCT a.proveedor_id,r.rubro_id
	FROM gd_esquema.Maestra m,CRISPI.Proveedor a,CRISPI.Rubro r
	WHERE m.Provee_CUIT IS NOT NULL AND m.Provee_CUIT=a.proveedor_cuit AND m.Provee_Rubro=r.rubro_nombre
	PRINT 'Rubro Proveedor migrados correctamente'


	PRINT 'Migracion Credito'
	INSERT INTO CRISPI.Credito(credito_fecha,credito_monto,credito_cliente_id,credito_tipo_pago_id)
	SELECT DISTINCT Carga_Fecha,Carga_Credito,r.cliente_id,a.tipo_pago_id
	FROM gd_esquema.Maestra m,CRISPI.Tipo_pago a,CRISPI.Cliente r
	WHERE m.Carga_Credito IS NOT NULL AND m.Tipo_Pago_Desc=a.tipo_pago_nombre AND m.Cli_Dni=r.cliente_dni
	PRINT 'Credito migrados correctamente'

	
	PRINT 'Migracion oferta'
	INSERT INTO CRISPI.Oferta(oferta_codigo,oferta_descripcion,oferta_precio,oferta_lista,oferta_cantidad,oferta_maxima,oferta_fecha_inicio,oferta_fecha_fin,oferta_proveedor_id)
	SELECT Oferta_Codigo,Oferta_Descripcion,Oferta_Precio,Oferta_Precio_Ficticio,Oferta_Cantidad,1,Oferta_Fecha,Oferta_Fecha_Venc,p.proveedor_id
	FROM gd_esquema.Maestra m
	join CRISPI.Proveedor p on p.proveedor_cuit = m.Provee_CUIT
	where m.Oferta_Codigo is not null
	group by Oferta_Codigo,Oferta_Descripcion,Oferta_Precio,Oferta_Precio_Ficticio,Oferta_Cantidad,Oferta_Fecha,Oferta_Fecha_Venc,p.proveedor_id
	PRINT 'oferta migrados correctamente'


	PRINT 'Migracion facturacion'
	INSERT INTO CRISPI.Facturacion(facturacion_nro,facturacion_tipo,facturacion_fecha,facturacion_monto,facturacion_proveedor_id)
	SELECT m.Factura_Nro,'A',m.Factura_Fecha,sum(Oferta_Precio),a.proveedor_id
	FROM gd_esquema.Maestra m,CRISPI.Proveedor a
	where m.Factura_Nro is not null and m.Provee_CUIT=a.proveedor_cuit
	group by m.Factura_Nro,m.Factura_Fecha,a.proveedor_id
	PRINT 'Rubro Proveedor migrados correctamente'


	PRINT 'Migracion item facturacion'
	INSERT INTO CRISPI.Item_factura(facturacion_id,cliente_id,oferta_id)
	select a.facturacion_id,c.cliente_id,o.oferta_id
	from gd_esquema.Maestra m,CRISPI.Facturacion a,CRISPI.Cliente c,CRISPI.Oferta o
	where m.Factura_Nro is not null and m.Factura_Nro=a.facturacion_nro and m.Cli_Dni=c.cliente_dni and m.Oferta_Codigo=o.oferta_codigo
	PRINT ' migrados correctamente'
	
	PRINT 'Estados Cupones'
	INSERT INTO CRISPI.Estado(estado_descripcion)
	VALUES('Disponible'),
		  ('Vencido'),
		  ('Cancelado')
	PRINT 'migrados correctamente'


	PRINT 'Migracion cupones'
	INSERT INTO CRISPI.Cupones(cupones_oferta_id,cupones_precio_oferta,cupones_precio_lista,cupones_cliente_id,cupones_estado_id)
	select distinct o.oferta_id,m.Oferta_Precio,m.Oferta_Precio_Ficticio,c.cliente_id,1
	from gd_esquema.Maestra m,CRISPI.Oferta o,CRISPI.Cliente c
	where m.Factura_Nro is not null and m.Oferta_Codigo=o.oferta_codigo and m.Cli_Dni=c.cliente_dni
	PRINT 'migrados correctamente'	

	commit
END TRY
BEGIN CATCH	
	SELECT  
        ERROR_NUMBER() AS ErrorNumber  
        ,ERROR_SEVERITY() AS ErrorSeverity  
        ,ERROR_STATE() AS ErrorState  
        ,ERROR_PROCEDURE() AS ErrorProcedure  
        ,ERROR_LINE() AS ErrorLine  
        ,ERROR_MESSAGE() AS ErrorMessage; 
	rollback    
END CATCH

exec CRISPI.proc_create_tables