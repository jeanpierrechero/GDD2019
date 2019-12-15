create trigger CRISPI.tr_delete_cliente
on CRISPI.Cliente
instead of delete
as
begin try

	update CRISPI.Cliente set cliente_estado = 0 where cliente_id in (select cliente_id from deleted)
	
	commit;
end try
begin catch
	rollback;
end catch
GO
