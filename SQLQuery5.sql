create table categoria(
	cat_codigo int not null identity primary key,
	cat_nombre varchar(100) not null,
	cat_descripcion varchar(300) not null);
create proc MostrarCategorias as select * from categoria order by cat_codigo;
create proc InsertarCat
@Cnombre nvarchar(20),
@Cdetalle nvarchar(50)
as insert into modo_pago values (@Cnombre, @Cdetalle);

create proc EditarCat
@Cnombre nvarchar(20),
@Cdetalle nvarchar(50),
@idCat int
as update categoria set cat_nombre=@Cnombre, cat_descripcion=@Cdetalle where cat_codigo=@idCat;

create proc EliminarCat
@idCat int as delete from categoria where cat_codigo=@idCat;
