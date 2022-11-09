create table cliente (
	cli_codigo int not null identity primary key,
	cli_cedula varchar(10) not null,
	cli_apellidos varchar(100) not null,
	cli_nombres varchar(100) not null,
	cli_direccion varchar(200) not null,
	cli_fecha_nacimiento varchar(50) not null,
	cli_telefono varchar(15) not null,
	cli_mail varchar(100) not null);

create proc Mostrar as select * from cliente order by cli_codigo asc;
create proc insertarCliente 
@cedula nvarchar(10),
@apellido nvarchar(20),
@nombre nvarchar(50),
@direccion nvarchar(100),
@fechaDeNacimiento nvarchar(100),
@telefono nvarchar(10),
@email nvarchar(100) 
as insert into cliente values (@cedula, @apellido, @nombre, @direccion, @fechaDeNacimiento, @telefono, @email);

create proc eliminarCliente 
@id_Cliente int
as delete from cliente where cli_codigo=@id_Cliente;

create proc EditarCliente
@cedula nvarchar(10),
@apellido nvarchar(20),
@nombre nvarchar(50),
@direccion nvarchar(100),
@fechaDeNacimiento nvarchar(100),
@telefono nvarchar(10),
@email nvarchar(100),
@id_Cliente int
as update cliente set cli_cedula=@cedula, cli_apellidos=@apellido, cli_nombres=@nombre, cli_direccion=@direccion,
cli_fecha_nacimiento=@fechaDeNacimiento, cli_telefono=@telefono, cli_mail=@email where cli_codigo=@id_Cliente;


