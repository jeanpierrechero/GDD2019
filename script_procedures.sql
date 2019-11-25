create or alter procedure CRISPI.proc_create_usuario_cliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@username nvarchar(255),
	@password nvarchar(255),
	@fecha_nacimiento datetime,
	@dni numeric(18,0),
	@direccion nvarchar(255),
	@ciudad int,
	@codigo_postal int,
	@telefono numeric(18,0),
	@mail nvarchar(255)
as
begin try
	begin transaction

	declare @id_cliente int;

	exec CRISPI.proc_create_cliente @nombre,@apellido,@dni,@mail,@telefono,@direccion,@fecha_nacimiento,@ciudad,@codigo_postal,@id = @id_cliente;
		
	INSERT INTO CRISPI.Usuario(usuario_username,usuario_password,usuario_cliente_id,usuario_habilitado,usuario_estado,usuario_cantidad_errores)
	values(@username,HASHBYTES('SHA2_256', CONVERT(nvarchar(50), @password)),@id_cliente,1,1,0)

	commit transaction
end try
begin catch
	rollback transaction
end catch
GO


create or alter procedure CRISPI.proc_create_cliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@fecha_nacimiento datetime,
	@dni numeric(18,0),
	@direccion nvarchar(255),
	@ciudad int,
	@codigo_postal int,
	@telefono numeric(18,0),
	@mail nvarchar(255),
	@id int output

as
begin try
	begin transaction
	
	INSERT INTO CRISPI.Cliente(cliente_nombre,cliente_apellido,cliente_dni,cliente_mail,cliente_telefono,
								cliente_direccion,cliente_fechanac,cliente_ciudad_id,cliente_codigo_postal,
								cliente_credito)
	values(@nombre,@apellido,@dni,@mail,@telefono,@direccion,@fecha_nacimiento,@ciudad,@codigo_postal,200)
	SET @id=SCOPE_IDENTITY()
	RETURN  @id

	commit transaction
end try
begin catch
	rollback transaction
end catch
GO




create or alter procedure CRISPI.proc_create_usuario_proveedor
	@razon_social nvarchar(100),
	@username nvarchar(255),
	@password nvarchar(255),
	@cuit nvarchar(20),
	@direccion nvarchar(255),
	@ciudad int,
	@telefono numeric(18,0),
	@mail nvarchar(255)
as
begin try
	begin transaction

	declare @id_proveedor int;

	exec CRISPI.proc_create_proveedor @cuit,@razon_social,@direccion,@mail,@ciudad,@telefono,@id = @id_proveedor;
		
	INSERT INTO CRISPI.Usuario(usuario_username,usuario_password,usuario_proveedor_id,usuario_habilitado,usuario_estado,usuario_cantidad_errores)
	values(@username,HASHBYTES('SHA2_256', CONVERT(nvarchar(50), @password)),@id_proveedor,1,1,0)

	commit transaction
end try
begin catch
	rollback transaction
end catch
GO


create or alter procedure CRISPI.proc_create_proveedor
	@razon_social nvarchar(100),
	@cuit nvarchar(20),
	@direccion nvarchar(255),
	@ciudad int,
	@telefono numeric(18,0),
	@mail nvarchar(255),
	@id int output

as
begin try
	begin transaction
	
	INSERT INTO CRISPI.Proveedor(proveedor_cuit,proveedor_rs,proveedor_dom,proveedor_mail,proveedor_ciudad_id,proveedor_telefono,proveedor_estado)
	values(@cuit,@razon_social,@direccion,@mail,@ciudad,@telefono,1)
	SET @id=SCOPE_IDENTITY()
	RETURN  @id

	commit transaction
end try
begin catch
	rollback transaction
end catch
GO