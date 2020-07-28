use master;
go

create database Pizzadb;
go

use Pizzadb;
go

create schema Pizzas;
go

create table Pizzas.Pizza
(
    PizzaId int not null identity(1,1),
    CrustId int null,
    SizeId int null,
    [Name] nvarchar(250) not null,
    DateModified datetime2(0) not null,
    IsValid bit not null default 1,
    constraint PK_Pizza_PizzaID primary key (PizzaID),
    constraint FK_SizeId foreign key (SizeId) references Pizzas.Size(SizeId),
    constraint FK_CrustId foreign key (CrustId) references Pizzas.Crust(CrustId)
);

create table Pizzas.Crust
(
    CrustId int not null IDENTITY(1,1),
    [Name] nvarchar(100) not null,
    IsValid bit not null,
    constraint PK_CrustId primary key (CrustId)
    
);

create table Pizzas.Size
(
    SizeId int not null IDENTITY(1,1),
    [Name] nvarchar(100) not null,
    IsValid bit not null,
    constraint PK_SizeId primary key (SizeId)
);

create table Pizzas.Topping
(
    ToppingId int not null identity(1,1),
    [Name] nvarchar(250) not null,
    IsValid bit not null,
    constraint PK_ToppingID primary key (ToppingId),
);

create table Pizzas.PizzaTopping
(
    PizzaToppingId int not null IDENTITY(1,1),
    PizzaId int not null,
    ToppingId int,
    IsValid bit not null,
    constraint FK_PizzaId foreign key (PizzaId) references Pizzas.Pizza(PizzaId),
    constraint FK_ToppingId foreign key (ToppingId) references Pizzas.Topping(ToppingId)
);

create table Pizzas.Users
(
    UserId int not null identity(1,1),
    [Name] nvarchar(250) not null,
    IsValid bit not null,
    constraint PK_UsersID primary key (UserId)
);

create table Pizzas.Store
(
    Storeid int not null IDENTITY(1,1),
    [Name] nvarchar(250) not null,
    IsValid bit not null,
    constraint PK_StoreID primary key (StoreId)
);
go