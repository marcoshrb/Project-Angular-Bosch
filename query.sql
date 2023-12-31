use master
go

if exists(select * from sys.databases where name = 'Vasco')
    drop database Vasco

create database Vasco
go

use Vasco
go

create table Usuario(
    ID int identity primary key,
    Nome varchar(80) not null,
    Senha varchar(MAX) not null,
    Salt varchar(200) not null,
    Adm bit not null
);
go

create table Produto(
    ID int identity primary key,
    Imagem varbinary(MAX) null,
    Nome varchar(80) not null,
    Preco varchar(10) not null,
    Descricao varchar(500) not null,
    Promocao bit not null,
	PrecoPromocao float,
	Cupom varchar(50), 
    DescricaoPromocao varchar(100)
);
go


create table Pedido(
    ID int identity primary key,
    Nome varchar(80) not null,
    Total float,
    Hora dateTime,
    Entregue bit not null
);
go

create table ProdutoPedido(
    ID int identity primary key,
    ProdutoID int references Produto(ID) not null,
    PedidoID int references Pedido(ID) not null
);
go

create table Oferta(
    ID int identity primary key,
    Nome varchar(100) not null,
    ProdutoID int references Produto(ID),
    Descricao varchar(500) not null
);
go