create table detalle_factura(
	dfa_codigo int not null identity primary key,
	dfa_cantidad int not null,
	dfa_precio decimal(8,2) not null,
	fac_codigo int not null,
	prod_codigo int not null,
	foreign key(fac_codigo) references factura(fac_codigo),
	foreign key(prod_codigo) references producto(prod_codigo));

create proc MostrarDetF as select * from detalle_factura order by dfa_codigo;
create proc InserDetalleF
@cantidad int,
@precio decimal(8,2),
@Fac_codigo int,
@prod_codigo int as insert into detalle_factura values (@cantidad, @precio, @Fac_codigo, @prod_codigo);

create proc EditarDeF
@cantidad int,
@precio decimal(8,2),
@Fac_codigo int,
@prod_codigo int,
@IdDTF int as update detalle_factura set dfa_cantidad=@cantidad, dfa_precio=@precio, fac_codigo=@Fac_codigo, prod_codigo=@prod_codigo where dfa_codigo=@IdDTF;

create proc EliminarDetF
@IdDTF int as delete from detalle_factura where dfa_codigo=@IdDTF; 

