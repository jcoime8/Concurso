create table modo_pago(
	mpo_codigo int not null identity primary key,
	mpo_nombre varchar(100) not null,
	mpo_detalle varchar(300) not null);

create proc MostrarModoP as select * from modo_pago order by mpo_codigo;

create proc InsertarModoP
@Mnombre nvarchar(20),
@Pdetalle nvarchar(50)
as insert into modo_pago values (@Mnombre, @Pdetalle);

create proc EditarMP
@Mnombre nvarchar(20),
@Pdetalle nvarchar(50),
@idMP int
as update modo_pago set mpo_nombre=@Mnombre, mpo_detalle=@Pdetalle where mpo_codigo=@idMP;

create proc EliminarMP
@idMP int as delete from modo_pago where mpo_codigo=@idMP;