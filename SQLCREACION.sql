-------------------------------------/* CREACION ESQUEMA */-------------------------------------

CREATE SCHEMA CRISPI
GO

-------------------------------------/* CREACION TABLAS */-------------------------------------


PRINT '----- Empezando a crear tablas -----'
CREATE TABLE CRISPI.Usuario( 
	usuario_id int IDENTITY(1,1) PRIMARY KEY,
	usuario_nombre nvarchar(50) NOT NULL,
	usuario_username nvarchar(50) NOT NULL,
	usuario_password nvarchar(50) NOT NULL,
	usuario_apellido nvarchar(50) NOT NULL,
	usuario_dni decimal(18,0)  NOT NULL,
	usuario_direccion nvarchar(50) NOT NULL,
	usuario_telefono int NOT NULL,
	usuario_mail nvarchar(255) NOT NULL,
	usuario_cantidaderrores int NOT NULL,
	usuario_credito int NOT NULL,
	usuario_habilitado bit NOT NULL,
	usuario_fechanac datetime2(3) NOT NULL
)

/*CREATE TABLE EL_TITANIC.Usuario_administrador(
    usuarioAdmin_username nvarchar(50) PRIMARY KEY,
    usuarioAdmin_id int CONSTRAINT FK_USUARIOADMIN_USUARIO REFERENCES EL_TITANIC.Usuario(usuario_id),
	usuarioAdmin_passwordHash nvarchar(50),
	usuarioAdmin_intentosFallidos int
	)*/

CREATE TABLE CRISPI.Funcionalidad( 
    funcionalidad_id int IDENTITY(1,1) PRIMARY KEY,
	funcionalidad_descripcion nvarchar(50) NOT NULL
)

CREATE TABLE CRISPI.Rol( 
	rol_id int IDENTITY(1,1) PRIMARY KEY,
	rol_nombre nvarchar(50) UNIQUE NOT NULL,
	rol_estado bit NOT NULL
)

CREATE TABLE CRISPI.Rol_Por_Usuario( 
	usuario_id int CONSTRAINT FK_ROLUSUARIO_USUARIO REFERENCES CRISPI.Usuario(usuario_id),
	rol_id int CONSTRAINT FK_ROLUSUARIO_ROL REFERENCES CRISPI.Rol(rol_id)
)

CREATE TABLE CRISPI.Rol_Por_Funcionalidad( 
	rol_id int CONSTRAINT FK_ROLFUNCIONALIDAD_ROL REFERENCES CRISPI.Rol(rol_id) ,
	funcionalidad_id int CONSTRAINT FK_ROLFUNCIONALIDAD_FUNCIONALIDAD REFERENCES CRISPI.Funcionalidad(funcionalidad_id)
)

CREATE TABLE EL_TITANIC.Fabricante( 
	fabricante_id int IDENTITY(1,1) PRIMARY KEY,
	fabricante_nombre nvarchar(255),
	fabricante_cancelarPasajes bit
)
CREATE TABLE CRISPI.Producto( 
	producto_id int IDENTITY(1,1) PRIMARY KEY,
	producto_nombre nvarchar(50) UNIQUE NOT NULL,
	
)

CREATE TABLE CRISPI.TIPO( 
	tipo_id int IDENTITY(1,1) PRIMARY KEY,
	tipo_nombre nvarchar(50) UNIQUE NOT NULL,
	)
CREATE TABLE CRISPI.Provedor( 
	provedor_id int IDENTITY(1,1) PRIMARY KEY,
	provedor_nombre nvarchar(50) UNIQUE NOT NULL,
	provedor_cuit nvarchar(20),
	provedor_rubro nvarchar(100),
	provedor_rs nvarchar(100),
	provedor_dom nvarchar(100),
	provedor_ciudad nvarchar(255),
	provedor_telefono numeric(18,0),

	)
CREATE TABLE CRISPI.Credito( 
	credito_id int IDENTITY(1,1) PRIMARY KEY,
	credito_fecha datetime2(3),
	credito_monto int,
	credito_usuario int CONSTRAINT FK_CREDITO_USUARIO REFERENCES CRISPI.Usuario(usuario_id), 
	credito_tipo int CONSTRAINT FK_CREDITO_TIPO REFERENCES CRISPI.TIPO(tipo_id), 
	credito_datos nvarchar(255),
)

CREATE TABLE EL_TITANIC.Recorrido( 
	recorrido_id decimal(18,0) PRIMARY KEY,
	recorrido_estado bit 
)

CREATE TABLE EL_TITANIC.Crucero_por_Recorrido( 
    cxr_id int IDENTITY(1,1) PRIMARY KEY, 
    cxr_crucero nvarchar(50) CONSTRAINT FK_CXR_CRUCERO REFERENCES EL_TITANIC.Crucero(crucero_id),
    cxr_recorrido decimal(18,0) CONSTRAINT FK_CXR_RECORRIDO REFERENCES EL_TITANIC.Recorrido(recorrido_id)
)

CREATE TABLE EL_TITANIC.Viaje(
	viaje_id int IDENTITY(1,1) PRIMARY KEY,
	viaje_cxr int CONSTRAINT FK_VIAJE_CXR REFERENCES EL_TITANIC.Crucero_por_Recorrido(cxr_id),
	viaje_fechasalida datetime2(3),
	viaje_fechallegada datetime2(3),
	viaje_fechaestimada datetime2(3)
)

CREATE TABLE EL_TITANIC.Medio_de_Pago( 
	mediopago_id int IDENTITY(1,1) PRIMARY KEY,
	mediopago_descripcion nvarchar(255)
)

CREATE TABLE EL_TITANIC.Compra( 
	compra_id decimal(18,0) PRIMARY KEY,
	compra_usuario int CONSTRAINT FK_COMPRA_USUARIO REFERENCES EL_TITANIC.Usuario(usuario_id),
	compra_viaje INT CONSTRAINT FK_COMPRA_VIAJE REFERENCES EL_TITANIC.Viaje(viaje_id),
	compra_medioDePago int CONSTRAINT FK_COMPRA_MEDIOPAGO REFERENCES EL_TITANIC.Medio_de_Pago(mediopago_id),
	compra_fecha datetime2(3) NOT NULL,
)


PRINT '----- COMIENZA LA CREACION DE DATOS -----'

PRINT 'Creando roles'
GO
INSERT INTO CRISPI.Rol (rol_nombre, rol_estado)
         values('Administrador', 1);
		 GO
INSERT INTO CRISPI.Rol (rol_nombre, rol_estado)    
         values('Usuario', 1);
		 GO
PRINT 'Roles creados correctamente'
GO

PRINT 'Creando funcionalidades'
INSERT INTO CRISPI.Funcionalidad (funcionalidad_descripcion)
         values('ABM Rol');
INSERT INTO CRISPI.Funcionalidad (funcionalidad_descripcion)
	     values('Registro de Usuario');
INSERT INTO CRISPI.Funcionalidad (funcionalidad_descripcion)
	     values('ABM Oferta');
INSERT INTO CRISPI.Funcionalidad (funcionalidad_descripcion)
	     values('ABM');
INSERT INTO CRISPI.Funcionalidad (funcionalidad_descripcion)
	     values('Compra ');
INSERT INTO CRISPI.Funcionalidad (funcionalidad_descripcion)
	     values('Listado Estadistico');
PRINT 'Funcionalidades creadas correctamente'
GO


PRINT 'Asignando funcionalidad a los roles'
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,1); --Administrador, ABM Rol
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,2); --Administrador, Registro de Usuario
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,3); --Administrador, 
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,4); --Administrador,  
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,6); --Usuario,
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,7) --Usuario,  
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,8) --Usuario, 
INSERT INTO CRISPI.Rol_Por_Funcionalidad (rol_id, funcionalidad_id)
         values(1,9); --Administrador, Listado Estadistico

PRINT 'Funcionalidades asignadas a los roles correctamente'
GO


-------------------------------------/* MIGRACION DE DATOS */-------------------------------------

PRINT '----- COMIENZA LA MIGRACION -----'



PRINT 'Migracion de clientes'
INSERT INTO CRISPI.Usuario(usuario_apellido,usuario_nombre,usuario_dni,usuario_fechanac,usuario_direccion,usuario_mail,usuario_telefono,usuario_cantidaderrores,usuario_habilitado)
	SELECT DISTINCT Cli_Apellido,Cli_Nombre, Cli_Dni,Cli_Fecha_Nac,Cli_Direccion,Cli_Mail,Cli_Telefono,0,1
		FROM gd_esquema.Maestra m
		where m.Cli_Dni is not null
		ORDER BY m.Cli_Dni
PRINT 'Fabricantes migrados correctamente'
GO

SELECT DISTINCT Cli_Apellido,Cli_Nombre, Cli_Dni
		FROM gd_esquema.Maestra m


PRINT 'Migracion de  Proveedores'
INSERT INTO CRISPI.Provedor(provedor_cuit,provedor_ciudad,provedor_dom,provedor_rs,provedor_rubro,provedor_telefono)
	SELECT DISTINCT Provee_CUIT,Provee_Ciudad,Provee_Dom,Provee_RS,Provee_Rubro,Provee_Telefono
    FROM gd_esquema.Maestra m
    where m.Provee_CUIT is not null
	ORDER BY m.Provee_CUIT
PRINT 'Fabricantes migrados correctamente'
GO

SELECT DISTINCT Provee_CUIT,Provee_Ciudad,Provee_Dom,Provee_RS,Provee_Rubro,Provee_Telefono
FROM gd_esquema.Maestra m
where m.Provee_CUIT is not null



PRINT 'Migracion de clientes'
INSERT INTO CRISPI.(usuario_apellido,usuario_nombre,usuario_dni,usuario_fechanac,usuario_direccion,usuario_mail,usuario_telefono,usuario_cantidaderrores,usuario_habilitado)
	SELECT DISTINCT Cli_Apellido,Cli_Nombre, Cli_Dni,Cli_Fecha_Nac,Cli_Direccion,Cli_Mail,Cli_Telefono,0,1
		FROM gd_esquema.Maestra m
		where m.Cli_Dni is not null
		ORDER BY m.Cli_Dni
PRINT 'Fabricantes migrados correctamente'
GO

SELECT Oferta_Codigo,Oferta_Cantidad,Oferta_Descripcion,Oferta_Fecha_Venc,Oferta_Precio,Oferta_Precio_Ficticio
FROM gd_esquema.Maestra m
where m.Oferta_Codigo is not null



SELECT Cli_Apellido,Cli_Dni
FROM gd_esquema.Maestra m 
where m.Carga_Credito is not null 
group by Cli_Apellido,Cli_Dni