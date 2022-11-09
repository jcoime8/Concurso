create table producto(
	prod_codigo int not null identity primary key,
	prod_nombre varchar(200) not null,
	prod_precio decimal(8,2) not null,
	prod_stock integer not null,
	cat_codigo int not null,
	foreign key(cat_codigo) references categoria(cat_codigo));

create proc MostrarPro as select * from producto order by prod_codigo;

create proc InsertarPro 
@Nombre nvarchar(200),
@precio decimal(20,2),
@stock int,
@Catcodigo int as insert into producto values (@Nombre, @precio, @stock, @Catcodigo);

create proc EditarPro 
@Nombre nvarchar(200),
@precio decimal(20,2),
@stock int,
@Catcodigo int,
@Codigo int as update producto set prod_nombre=@Nombre, prod_precio=@precio, prod_stock=@stock, cat_codigo=@Catcodigo where prod_codigo=@Codigo;

create proc EliminarPro
@IdCodigo int as delete from producto where prod_codigo=@IDCodigo;

