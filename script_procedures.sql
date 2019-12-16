create  FUNCTION CRISPI.func_login (@username NVARCHAR(50),@pass NVARCHAR(50))
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
		RETURN 1;
	end
	
	RETURN 0;
END
GO

 


create  function CRISPI.hasPermission (@rol_id int,@name_permission nvarchar(50))
RETURNS bit
AS 
BEGIN
	Declare @funcionalidad_id int;
	
	select @funcionalidad_id = funcionalidad_id from CRISPI.Funcionalidad where funcionalidad_descripcion = @name_permission;

	IF EXISTS(select 1 from CRISPI.Rol_Por_Funcionalidad where rol_id = @rol_id and funcionalidad_id = @funcionalidad_id)
	begin
		RETURN 1;
	end
	
	RETURN 0;

END
GO


create  procedure CRISPI.proc_create_usuario_cliente
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
	@mail nvarchar(255),
	@estado bit
as
begin try
	begin transaction
	declare @id_usuario int;
	declare @id_cliente int;

	exec CRISPI.proc_create_cliente @nombre,@apellido,@dni,@fecha_nacimiento,@direccion,@ciudad_nombre,@mail,@telefono,@codigo_postal,@estado,@id = @id_cliente output;
		
	INSERT INTO CRISPI.Usuario(usuario_username,usuario_password,usuario_cliente_id,usuario_habilitado,usuario_estado,usuario_cantidad_errores)
	values(@username,HASHBYTES('SHA2_256', CONVERT(nvarchar(50), @password)),@id_cliente,1,@estado,0);
	SET @id_usuario=SCOPE_IDENTITY();

	INSERT INTO CRISPI.Rol_Por_Usuario(usuario_id,rol_id)
	values(@id_usuario,2);
	
	commit transaction
end try
begin catch
	rollback
end catch
GO


create  procedure CRISPI.proc_create_cliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(18,0),
	@fecha_nacimiento datetime,
	@direccion nvarchar(255),
	@ciudad_nombre nvarchar(255),
	@mail nvarchar(255),
	@telefono numeric(18,0),
	@codigo_postal int,
	@estado bit,
	@id int output

as
begin try
	begin transaction
	
	Declare @ciudad_id int;
	
	set @ciudad_id = (select top 1 ciudad_id from CRISPI.Ciudad where ciudad_nombre = @ciudad_nombre);
	
	INSERT INTO CRISPI.Cliente(cliente_nombre,cliente_apellido,cliente_dni,cliente_mail,cliente_telefono,
								cliente_direccion,cliente_fechanac,cliente_ciudad_id,cliente_codigo_postal,
								cliente_credito,cliente_estado)
	values(@nombre,@apellido,@dni,@mail,@telefono,@direccion,@fecha_nacimiento,@ciudad_id,@codigo_postal,200,@estado);
	SET @id=SCOPE_IDENTITY();

	commit transaction
	RETURN  @id;
end try
begin catch
	rollback transaction
end catch
GO

create procedure CRISPI.proc_inabilitar 
@u nvarchar(50)
as
begin try
	begin transaction
		update CRISPI.Usuario
		set usuario_estado=0
		where usuario_username=@u  
		 
		
	commit transaction
end try
begin catch
	rollback transaction
end catch
go


create  procedure CRISPI.proc_update_cliente
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(18,0),
	@fecha_nacimiento datetime,
	@direccion nvarchar(255),
	@ciudad_nombre nvarchar(255),
	@mail nvarchar(255),
	@telefono numeric(18,0),
	@codigo_postal int,
	@estado bit,
	@id int

as
begin try
	begin transaction
	
	Declare @ciudad_id int;
	
	set @ciudad_id = (select top 1 ciudad_id from CRISPI.Ciudad where ciudad_nombre = @ciudad_nombre);
		
	update CRISPI.Cliente set cliente_nombre=@nombre,cliente_apellido=@apellido,cliente_dni=@dni,cliente_mail=@mail,cliente_telefono=@telefono,
								cliente_direccion=@direccion,cliente_fechanac = @fecha_nacimiento,cliente_ciudad_id=@ciudad_id,cliente_codigo_postal=@codigo_postal,cliente_estado = @estado
	where cliente_id = @id

	commit transaction
end try
begin catch
	rollback transaction
end catch
GO




create  procedure CRISPI.proc_create_usuario_proveedor
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


create  procedure CRISPI.proc_create_proveedor
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

create procedure CRISPI.proc_create_oferta
	@codigooferta nvarchar(50),
	@descripcion nvarchar(255),
	@precio numeric(18,2),
	@preciolista numeric(18,2),
	@fechainicio datetime,
	@fechafin  datetime,
	@cantidad numeric(18,0),
	@maximo int,
	@proveedor int,
	@usuario int,
	@rubro int
as

begin try

	begin transaction
	declare @r int
	select @r=rubro_proveedor_id from CRISPI.Rubro_Proveedor where rubro_id=@rubro and rubro_proveedor=@proveedor
	insert into CRISPI.Oferta (oferta_codigo,oferta_descripcion,oferta_precio,oferta_lista,oferta_cantidad,oferta_maxima,oferta_fecha_inicio,oferta_fecha_fin,oferta_rubro_proveedor_id,oferta_usuario_creador_id)

	values(@codigooferta,@descripcion,@precio,@preciolista,@cantidad,@maximo,@fechainicio,@fechafin,@r,@usuario);
	commit transaction
end try
begin catch

	rollback transaction

	throw;
end catch
GO	

create procedure CRISPI.proc_update_proveedor
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
end try	
begin catch
	rollback transaction
	throw;
end catch
go

create procedure CRISPI.proc_actualizar_oferta
@oferta int,
@codigooferta nvarchar(50),
@descripcion nvarchar(255),
@precio numeric(18,2),
@preciolista numeric(18,2),
@fechainicio datetime,
@fechafin  datetime,
@cantidad numeric(18,0),
@maximo int,
@proveedor int,
@usuario int,
@rubro int 
as 
begin try 
	begin transaction
	declare @r int 
	select @r=rubro_proveedor_id from CRISPI.Rubro_Proveedor where rubro_id=@rubro and rubro_proveedor=@proveedor
	update CRISPI.Oferta
	set oferta_codigo=@codigooferta,
	oferta_descripcion=@descripcion,
	oferta_precio=@precio,
	oferta_lista=@preciolista,
	oferta_cantidad=@cantidad,
	oferta_maxima=@maximo,
	oferta_fecha_inicio=@fechainicio,
	oferta_fecha_fin=@fechafin,
	oferta_rubro_proveedor_id=@r,
	oferta_usuario_creador_id=@usuario
	where oferta_id =@oferta

	commit transaction
end try
begin catch
	rollback transaction
	throw;
end catch
go

create procedure CRISPI.proc_eliminar_oferta
@oferta int
as
begin try 
	begin transaction
	update CRISPI.Oferta
	set oferta_eliminado=1
	where oferta_id=@oferta



	commit transaction
end try
begin catch
	rollback transaction
	throw;
end catch
go

alter procedure CRISPI.proc_comprar_oferta
@oferta int,
@cliente int,
--@fecha datetime,
@cliente_destino numeric(18,0),
@cantidad int,
@credito numeric(18,2) 
as 
begin try
	begin transaction
	declare @c int 
	select @c=cliente_id from CRISPI.Cliente where cliente_dni=@cliente_destino
	 insert into CRISPI.Venta(venta_oferta_id,venta_cliente_id,venta_fecha,venta_cliente_destino_id,venta_cantidad)
	 values(@oferta,@cliente,GETDATE(),@c,@cantidad)
	 declare @precio numeric(18,2) ,@precio2 numeric(18,2)
	 select @precio=oferta_precio,@precio2=oferta_lista from CRISPI.Oferta where oferta_id=@oferta
	 insert into CRISPI.Cupones(cupones_oferta_id,cupones_precio_oferta,cupones_precio_lista,cupones_cliente_id,cupones_estado_id)
	 values(@oferta,@precio,@precio2,@cliente,1)
	 update CRISPI.Cliente
	 set cliente_credito=@credito
	 where cliente_id=@cliente

	commit transaction
end try
begin catch
	rollback transaction
	throw;
end catch
go

create procedure CRISPI.proc_cargar_credito
@cliente int,
@tipo int,
@credito numeric(18,2),
@a nvarchar(255),
@tarjeta numeric(18,0)
as 
begin try
	begin transaction
	
	 insert into CRISPI.Credito(credito_cliente_id,credito_monto,credito_tarjeta,credito_tipo_pago_id,credito_datos,credito_fecha)
	 values(@cliente,@credito,@tarjeta,@tipo,@a,GETDATE())
	 
	 update CRISPI.Cliente
	 set cliente_credito=cliente_credito+@credito
	 where cliente_id=@cliente

	commit transaction
end try
begin catch
	rollback transaction
	throw;
end catch
go

create procedure CRISPI.proc_mostrar_ofertas
as


	select oferta_id,oferta_descripcion from CRISPI.Oferta
	where YEAR(GETDATE())<=YEAR(oferta_fecha_inicio) and MONTH(GETDATE())<=MONTH(oferta_fecha_inicio) and oferta_eliminado=0  


go

create procedure CRISPI.proc_ofertas
@u int
as
	

	select oferta_id,oferta_codigo,oferta_descripcion,oferta_precio,oferta_lista,oferta_cantidad,oferta_maxima,oferta_fecha_inicio,oferta_fecha_fin,oferta_eliminado,oferta_rubro_proveedor_id from CRISPI.Oferta join CRISPI.Rubro_Proveedor on oferta_rubro_proveedor_id=rubro_proveedor_id 
	where rubro_proveedor=@u
	--where YEAR(GETDATE())<=YEAR(oferta_fecha_inicio) and MONTH(GETDATE())<=MONTH(oferta_fecha_inicio) and oferta_eliminado=0  


go
select * from CRISPI.Rol

create procedure CRISPI.proc_mostrar_rubro
as
	select rubro_id,rubro_nombre from CRISPI.Rubro
	
go

create procedure CRISPI.proc_mostrar_proveedor
as
	select proveedor_id,proveedor_rs from CRISPI.Proveedor
	
go

create  procedure CRISPI.proc_insert_rol_proveedor(@rubro_id int,@proveedor_id int)
as
begin try
	begin transaction
	
	INSERT INTO CRISPI.Rubro_Proveedor(rubro_id,rubro_proveedor)
	VALUES(@rubro_id,@proveedor_id);
	
	commit transaction
end try
begin catch
	rollback transaction
end catch
go


create procedure CRISPI.mostrar_ofertas_vendidad(@proveedor_rs nvarchar(100),@fecha_inicio date,@fecha_fin date)
as
	declare @proveedor_id int;

	set @proveedor_id = (select top 1 proveedor_id from CRISPI.Proveedor where proveedor_rs = @proveedor_rs);

	select * from CRISPI.ofertas_facturas 
	where format(CONVERT(date,fecha_compra),'yyyy-MM-dd')>= @fecha_inicio and 
		format(CONVERT(date,fecha_compra),'yyyy-MM-dd') <= @fecha_fin and 
		proveedor_id = @proveedor_id;
	
go


create function CRISPI.func_monto_factura(@proveedor_rs nvarchar(100),@fecha_inicio date,@fecha_fin date)
returns decimal(18,2)
as
begin
	declare @monto decimal(18,2);

	select @monto = ISNULL(sum(o.oferta_precio * v.venta_cantidad),0)
	from CRISPI.Venta v
	join CRISPI.Oferta o on o.oferta_id = v.venta_oferta_id
	join CRISPI.Cliente c on c.cliente_id = v.venta_cliente_id
	join CRISPI.Rubro_Proveedor rp on rp.rubro_proveedor_id = o.oferta_rubro_proveedor_id
	join CRISPI.Proveedor p on p.proveedor_rs = @proveedor_rs
	where format(CONVERT(date,v.venta_fecha),'yyyy-MM-dd')>= @fecha_inicio and 
		format(CONVERT(date,v.venta_fecha),'yyyy-MM-dd') <= @fecha_fin and 
		p.proveedor_rs = @proveedor_rs;

		return @monto;
end
go



create procedure CRISPI.facturar
	@proveedor_rs nvarchar(100),
	@fecha_inicio date,
	@fecha_fin date
as
begin try
	
	declare @factura_id int;
	declare @proveedor_id int;

	set @proveedor_id = (select top 1 proveedor_id from CRISPI.Proveedor where proveedor_rs = @proveedor_rs);

	insert into CRISPI.Facturacion(facturacion_nro,facturacion_tipo,facturacion_proveedor_id,facturacion_fecha)
	values ((select max(facturacion_nro) + 1 from CRISPI.Facturacion),'A',@proveedor_id,GETDATE())
	SET @factura_id=SCOPE_IDENTITY();


	insert into CRISPI.Item_factura(facturacion_id,cliente_id,oferta_id,item_factura_cantidad)
	select @factura_id,c.cliente_id,o.oferta_id,v.venta_cantidad
	from CRISPI.Venta v
	join CRISPI.Oferta o on o.oferta_id = v.venta_oferta_id
	join CRISPI.Cliente c on c.cliente_id = v.venta_cliente_id
	join CRISPI.Rubro_Proveedor rp on rp.rubro_proveedor_id = o.oferta_rubro_proveedor_id
	where format(CONVERT(date,v.venta_fecha),'yyyy-MM-dd')>= @fecha_inicio and 
		format(CONVERT(date,v.venta_fecha),'yyyy-MM-dd') <= @fecha_fin and 
		rp.rubro_proveedor = @proveedor_id;

	update CRISPI.Facturacion set facturacion_monto = (
	select ISNULL(sum(o.oferta_precio * it.item_factura_cantidad),0) from CRISPI.Item_factura it
	join CRISPI.Oferta o on o.oferta_id = it.oferta_id)
	where facturacion_id = @factura_id

end try
begin catch
	rollback transaction
end catch



