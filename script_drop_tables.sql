CREATE OR ALTER PROCEDURE CRISPI.proc_drop_tables
AS
BEGIN TRY
	BEGIN TRANSACTION	

	ALTER TABLE CRISPI.Usuario DROP CONSTRAINT fk_usuario_cliente_id;

	ALTER TABLE CRISPI.Usuario DROP CONSTRAINT fk_usuario_proveedor_id;

	ALTER TABLE CRISPI.Cliente DROP CONSTRAINT fk_cliente_ciudad_id;

	ALTER TABLE CRISPI.Funcionalidad DROP CONSTRAINT uq_funcionalidad_descripcion;

	ALTER TABLE CRISPI.Proveedor DROP CONSTRAINT fk_proveedor_ciudad_id;

	ALTER TABLE CRISPI.Rol_Por_Usuario DROP CONSTRAINT fk_rolusuario_usuario;

	ALTER TABLE CRISPI.Rol_Por_Usuario DROP CONSTRAINT fk_rolusuario_rol;

	ALTER TABLE CRISPI.Rol_Por_Funcionalidad DROP CONSTRAINT fk_rolfuncionalidad_rol;

	ALTER TABLE CRISPI.Rol_Por_Funcionalidad DROP CONSTRAINT fk_rolfuncionalidad_funcionalidad;

	ALTER TABLE CRISPI.Rubro_Proveedor DROP CONSTRAINT fk_rubro_proveedor;

	ALTER TABLE CRISPI.Rubro_Proveedor DROP CONSTRAINT fk_rubro_id;

	ALTER TABLE CRISPI.Credito DROP CONSTRAINT fk_credito_cliente_id;

	ALTER TABLE CRISPI.Credito DROP CONSTRAINT fk_credito_tipo_pago_id;

	ALTER TABLE CRISPI.Oferta DROP CONSTRAINT fk_oferta_proveedor_id;

	ALTER TABLE CRISPI.Oferta DROP CONSTRAINT fk_oferta_usuario_creador_id;

	ALTER TABLE CRISPI.Facturacion DROP CONSTRAINT fk_facturacion_proveedor_id;

	ALTER TABLE CRISPI.Item_factura DROP  CONSTRAINT fk_item_factura_facturacion_id;

	ALTER TABLE CRISPI.Item_factura DROP  CONSTRAINT fk_item_factura_cliente_id;

	ALTER TABLE CRISPI.Item_factura DROP  CONSTRAINT fk_item_factura_oferta_id;

	ALTER TABLE CRISPI.Cupones DROP  CONSTRAINT fk_cupones_estado_id;

	ALTER TABLE CRISPI.Cupones DROP  CONSTRAINT fk_cupones_cliente_id;

	ALTER TABLE CRISPI.Cupones DROP  CONSTRAINT fk_cupones_oferta_id;

	ALTER TABLE CRISPI.Historial_cupones DROP  CONSTRAINT fk_historial_cupon_id;

	ALTER TABLE CRISPI.Historial_cupones DROP  CONSTRAINT fk_historial_estado_id;

	ALTER TABLE CRISPI.Venta DROP  CONSTRAINT fk_venta_oferta_id;

	ALTER TABLE CRISPI.Venta DROP  CONSTRAINT fk_venta_cliente_id;

	ALTER TABLE CRISPI.Venta DROP  CONSTRAINT fk_venta_cliente_destino_id;
	

	DROP TABLE IF EXISTS CRISPI.Rol_Por_Funcionalidad;
	DROP TABLE IF EXISTS CRISPI.Rol;
	DROP TABLE IF EXISTS CRISPI.Funcionalidad;
	DROP TABLE IF EXISTS CRISPI.Rubro_Proveedor;
	DROP TABLE IF EXISTS CRISPI.Rubro;
	DROP TABLE IF EXISTS CRISPI.Item_factura;
	DROP TABLE IF EXISTS CRISPI.Facturacion;
	DROP TABLE IF EXISTS CRISPI.Historial_cupones;
	DROP TABLE IF EXISTS CRISPI.Cupones;
	DROP TABLE IF EXISTS CRISPI.Estado;
	DROP TABLE IF EXISTS CRISPI.Venta;
	DROP TABLE IF EXISTS CRISPI.Oferta;
	DROP TABLE IF EXISTS CRISPI.Credito;
	DROP TABLE IF EXISTS CRISPI.Tipo_pago;
	DROP TABLE IF EXISTS CRISPI.Rol_Por_Usuario;
	DROP TABLE IF EXISTS CRISPI.Usuario;
	DROP TABLE IF EXISTS CRISPI.Cliente;
	DROP TABLE IF EXISTS CRISPI.Proveedor;
	DROP TABLE IF EXISTS CRISPI.Ciudad;

	COMMIT
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER() AS errNumber,
		   ERROR_SEVERITY() AS errSeverity,
		   ERROR_STATE() AS errState,
		   ERROR_PROCEDURE() AS errProcedure,
		   ERROR_LINE() AS errLine,
		   ERROR_MESSAGE() AS errMessage
    ROLLBACK 
END CATCH