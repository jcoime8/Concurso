create table factura(
	fac_codigo int not null identity primary key,
	cli_codigo int not null,
	mpo_codigo int not null,
	fac_fecha_emision varchar(50),
	foreign key(cli_codigo) references cliente(cli_codigo),
	foreign key(mpo_codigo) references modo_pago(mpo_codigo));

	create proc MostrarFActura as select * from factura order by fac_codigo;
	create proc InsertarFechaF
	@Ccodigo int,
	@Mcodigo int,
	@Fecha nvarchar
	as insert into factura values (@Ccodigo, @Mcodigo, @Fecha);

	create proc EditarFecha
	@Fecha nvarchar,
	@IdFactura int as update factura set fac_fecha_emision=@Fecha where fac_codigo=@IdFactura;

	create proc EliminarFactura 
	@IdFactura int as delete factura where fac_codigo=@IdFactura; 