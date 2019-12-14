create or alter function CRISPI.func_login (@username NVARCHAR(50),@pass NVARCHAR(50))
RETURNS int
AS 
BEGIN
    DECLARE @pass_enc varbinary(256)
	BEGIN
		SELECT @pass_enc = HASHBYTES('SHA2_256', @pass)
	END

	IF EXISTS(SELECT 1
	FROM CRISPI.Usuario
	WHERE usuario_username = @username and usuario_password = @pass_enc and usuario_habilitado = 1 and usuario_estado = 1)
	begin
		RETURN 1
	end
	
	RETURN 0

END
GO


create or alter function CRISPI.hasPermission (@rol_id int,@name_permission nvarchar(50))
RETURNS bit
AS 
BEGIN
	Declare @funcionalidad_id int;
	
	select @funcionalidad_id = funcionalidad_id from CRISPI.Funcionalidad where funcionalidad_descripcion = @name_permission;

	IF EXISTS(select 1 from CRISPI.Rol_Por_Funcionalidad where rol_id = @rol_id and funcionalidad_id = @funcionalidad_id)
	begin
		RETURN 1
	end
	
	RETURN 0

END
GO


create or alter procedure CRISPI.proc_create_usuario_cliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@username nvarchar(255),
	@password nvarchar(255),
	@fecha_nacimiento datetime,
	@dni numeric(18,0),
	@direccion nvarchar(255),
	@ciudad_nombre nvarchar(255),
	@codigo_postal int,
	@telefono numeric(18,0),
	@mail nvarchar(255)
as
begin try
	begin transaction
	declare @id_usuario int;
	declare @id_cliente int;

	exec CRISPI.proc_create_cliente @nombre,@apellido,@dni,@fecha_nacimiento,@direccion,@ciudad_nombre,@mail,@telefono,@codigo_postal,@id = @id_cliente output;
		
	INSERT INTO CRISPI.Usuario(usuario_username,usuario_password,usuario_cliente_id,usuario_habilitado,usuario_estado,usuario_cantidad_errores)
	values(@username,HASHBYTES('SHA2_256', CONVERT(nvarchar(50), @password)),@id_cliente,1,1,0);
	SET @id_usuario=SCOPE_IDENTITY();

	INSERT INTO CRISPI.Rol_Por_Usuario(usuario_id,rol_id)
	values(@id_usuario,2);
	
	commit transaction
end try
begin catch
	rollback transaction
end catch
GO


create or alter procedure CRISPI.proc_create_cliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(18,0),
	@fecha_nacimiento datetime,
	@direccion nvarchar(255),
	@ciudad_nombre nvarchar(255),
	@mail nvarchar(255),
	@telefono numeric(18,0),
	@codigo_postal int,
	@id int output

as
begin try
	begin transaction
	
	Declare @ciudad_id int;
	
	set @ciudad_id = (select top 1 ciudad_id from CRISPI.Ciudad where ciudad_nombre = @ciudad_nombre);
	
	INSERT INTO CRISPI.Cliente(cliente_nombre,cliente_apellido,cliente_dni,cliente_mail,cliente_telefono,
								cliente_direccion,cliente_fechanac,cliente_ciudad_id,cliente_codigo_postal,
								cliente_credito)
	values(@nombre,@apellido,@dni,@mail,@telefono,@direccion,@fecha_nacimiento,@ciudad_id,@codigo_postal,200)
	SET @id=SCOPE_IDENTITY();

	commit transaction
	RETURN  @id;
end try
begin catch
	rollback transaction
end catch
GO


create or alter procedure CRISPI.proc_update_cliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(18,0),
	@fecha_nacimiento datetime,
	@direccion nvarchar(255),
	@ciudad_nombre nvarchar(255),
	@mail nvarchar(255),
	@telefono numeric(18,0),
	@codigo_postal int,
	@id int

as
begin try
	begin transaction
	
	Declare @ciudad_id int;
	
	set @ciudad_id = (select top 1 ciudad_id from CRISPI.Ciudad where ciudad_nombre = @ciudad_nombre);
		
	update CRISPI.Cliente set cliente_nombre=@nombre,cliente_apellido=@apellido,cliente_dni=@dni,cliente_mail=@mail,cliente_telefono=@telefono,
								cliente_direccion=@direccion,cliente_fechanac = @fecha_nacimiento,cliente_ciudad_id=@ciudad_id,cliente_codigo_postal=@codigo_postal
	where cliente_id = @id

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
	@ciudad_nombre nvarchar(255),
	@telefono numeric(18,0),
	@mail nvarchar(255)
as
begin try
	begin transaction
	declare @id_proveedor int;
	declare @usuario_id int;

	set @id_proveedor = 0;
	
	exec CRISPI.proc_create_proveedor @cuit,@razon_social,@direccion,@mail,@ciudad_nombre,@telefono,@id = @id_proveedor output;
		
	INSERT INTO CRISPI.Usuario(usuario_username,usuario_password,usuario_proveedor_id,usuario_habilitado,usuario_estado,usuario_cantidad_errores)
	values(@username,HASHBYTES('SHA2_256', CONVERT(nvarchar(50), @password)),@id_proveedor,1,1,0);
	SET @usuario_id=SCOPE_IDENTITY();

	INSERT INTO CRISPI.Rol_Por_Usuario(usuario_id,rol_id)
	values(@usuario_id,3);
	
	commit transaction
end try
begin catch
	rollback transaction
	PRINT('Error al persistir usuario');
    THROW;
end catch
GO


create or alter procedure CRISPI.proc_create_proveedor
	@cuit nvarchar(20),
	@razon_social nvarchar(100),
	@direccion nvarchar(255),
	@mail nvarchar(255),
	@ciudad_nombre nvarchar(255),
	@telefono numeric(18,0),
	@id int output
as
begin try
	begin transaction
	
	Declare @ciudad_id int;
	
	set @ciudad_id = (select top 1 ciudad_id from CRISPI.Ciudad where ciudad_nombre = @ciudad_nombre);
	
	INSERT INTO CRISPI.Proveedor(proveedor_cuit,proveedor_rs,proveedor_dom,proveedor_mail,proveedor_ciudad_id,proveedor_telefono,proveedor_estado)
	values(@cuit,@razon_social,@direccion,@mail,@ciudad_id,@telefono,1)
	SET @id=SCOPE_IDENTITY()
	
	commit transaction
	return @id;
end try
begin catch
	rollback transaction
    THROW;
end catch
GO

create or alter procedure CRISPI.proc_update_proveedor
	@cuit nvarchar(20),
	@razon_social nvarchar(100),
	@direccion nvarchar(255),
	@mail nvarchar(255),
	@ciudad_nombre nvarchar(255),
	@telefono numeric(18,0),
	@id int
as
begin try
	begin transaction
	
	Declare @ciudad_id int;
	
	set @ciudad_id = (select top 1 ciudad_id from CRISPI.Ciudad where ciudad_nombre = @ciudad_nombre);
	
	update CRISPI.Proveedor set proveedor_cuit = @cuit,proveedor_rs=@razon_social,proveedor_dom=@direccion,
		proveedor_mail=@mail,proveedor_ciudad_id=@ciudad_id,proveedor_telefono=@telefono
	where proveedor_id = @id;
	
	commit transaction
end try
begin catch
	rollback transaction
    THROW;
end catch
GO


create or alter procedure CRISPI.proc_insert_rol_proveedor(@rubro_id int,@proveedor_id int)
as
begin try
	begin transaction
	
	INSERT INTO CRISPI.Rubro_Proveedor(rubro_id,rubro_proveedor)
	VALUES(@rubro_id,@proveedor_id);
	
	commit transaction
end try
begin catch
	rollback transaction
    THROW;
end catch
GO