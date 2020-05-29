create database Book_Shop on primary
(name = Book_Shop, filename = 'D:\SQLBook_Shop\Book_Shop.mdf',
size = 12MB,
maxsize = 20MB,
filegrowth = 2MB )
LOG ON
(name = Book_Shop_Log,
filename = 'D:\SQLBook_Shop\Book_Shop_Log.ldf',
size = 2MB,
maxsize = 12MB,
filegrowth = 1MB)

create table Books(
Id_Book int not null identity(1, 1) primary key,
Id_Theme int NOT NULL,
Id_Author int not null,
Id_Publisher int not null,
NameBook nvarchar(100) not null unique check (NameBook <> N''),
Pages int not null check (Pages>= 1),
DrawingOfBook int not null check (DrawingOfBook >= 1),
DateOfPublish date not null check (DateOfPublish <= getdate()) default getdate(),
[Year] int NOT NULL,
ProductPrice money NOT NULL check (ProductPrice > 0.0)
)
create table Publishers(
Id_Publisher int not null identity(1, 1) primary key,
NamePublisher nvarchar(100) NOT NULL check (NamePublisher<> N'')
)

create table Authors(
Id_Author int not null identity(1, 1) primary key,
FistName  nvarchar(100) not null,
LastName nvarchar(100) not null unique check (LastName <> N'')
)

create table Themes(
Id_Theme int not null identity(1, 1) primary key,
NameGenre nvarchar(100) not null unique check (NameGenre <> N'')
)
create table NextTome(
Id_NextTome int not null identity(1, 1) primary key,
Title nvarchar(100) not null unique check (Title <> N''),
Number int not null,
Id_Book int not null
)



create table Users (
	Id_User int identity(1,1) NOT NULL primary key,
	[Login] nvarchar(100) NOT NULL unique check ([Login] <> N'') ,
	[Password] nvarchar(100) NOT NULL unique check ([Password] <> N'')
)
create table Buyers(
Id_Buyer int identity(1,1) NOT NULL primary key,
FistName  nvarchar(100) not null,
LastName nvarchar(100) not null unique check (LastName <> N''),
Id_User int NOT NULL
)

CREATE TABLE Discounts (
	Id_Discounts int NOT NULL identity(1,1) primary key ,	
	DiscountPercent  float NOT NULL,
	Id_Book int NOT NULL	
)



CREATE TABLE Reservations (
	Id int NOT NULL identity(1,1) primary key,	
	Id_Book int NOT NULL,
	Id_Buyer int NOT NULL
)


create table Sales(
Id_Sale int not null identity(1, 1) primary key,
Id_Buyer int NOT NULL,
Id_Book int NOT NULL,
DateOfSale date not null check (DateOfSale <= getdate()) default getdate(),
SalePrice money not null check (SalePrice > 0.0),
Quantity int not null check (Quantity >= 1)
)



alter table Books add foreign key (Id_Publisher) references Publishers(Id_Publisher);
alter table  Books add foreign key (Id_Author) references Authors(Id_Author);
alter table  Books add foreign key (Id_Theme) references Themes(Id_Theme);

alter table NextTome add foreign key (Id_Book) references Books(Id_Book);

alter table Discounts add foreign key (Id_Book) references Books(Id_Book);

alter table Buyers add foreign key(Id_User) references Users(Id_User);

alter table Reservations add foreign key (Id_Book) references Books(Id_Book);
alter table Reservations add foreign key (Id_Buyer) references Buyers(Id_Buyer);

alter table Sales add foreign key (Id_Buyer) references Buyers(Id_Buyer);
alter table Sales add foreign key (Id_Book) references Books(Id_Book);



create trigger ChangeCounte on dbo.Sales after insert,update
as
declare @Id int,@quantity int
select @Id=Id_Book, @quantity=Quantity from inserted update dbo.Books
set DrawingOfBook=DrawingOfBook-@quantity where Id_Book=@id

create trigger SaleCount on dbo.Sales after insert,update
as
declare @Id int, @quantity int
select @Id=Id_Book, @quantity=Quantity from inserted
if @quantity>(select DrawingOfBook from dbo.Books where Id_Book=@Id)
begin raiserror ('error',11,1)
rollback tran end
update dbo.Books
set DrawingOfBook=DrawingOfBook-@quantity where Id_Book=@Id

create trigger ControlPrice on dbo.Sales after insert,update
as
declare @Id int, @price int
select @Id=Id_Book, @price=SalePrice from inserted
if @price<(select B.ProductPrice from dbo.Books as B where B.Id_Book=@Id)
begin raiserror ('Цена продажи не может быть меньше цены закупки книги!',11,1)
rollback tran end


create view InfoBook as select 'NameBook'=B.NameBook, 'Fullname Author'= concat(A.LastName,' ',A.FistName), 
'StateBook'=case
when B.DrawingOfBook>1000 then 'Bestseller'
when DATEDIFF(MONTH, B.DateOfPublish, GETDATE())>1 then 'New Book' 
else 'Other' end
from dbo.Books as B
join dbo.Authors as A on A.Id_Author=B.Id_Author

drop view InfoBook




insert into dbo.Themes(NameGenre) values ('роман'),('фантастика'),('детектив'),('комедия,'),('повесть')

insert into dbo.Authors(FistName,LastName)
values ('Туи','Сазерланд'),('Анна','Пэтчутт'),('Джоан','Роулинг'),('Левис','Кэролл'),('Эдгар','Аллан'),('Уилки','Коллинз'),('Николай','Гоголь'),('Антон','Чехов'),('Уильям','Шекспир'),('Александр','Пушкин')

insert into dbo.Publishers(NamePublisher) values ('Nelson'),('Harper'),('Arthur A. Levine Books'),('Macmillan'),('Mesheryakova'),('Provincia'),('Life'),('Profmedia')

insert into dbo.Books (Id_Theme,Id_Author,Id_Publisher, NameBook, Pages, DrawingOfBook,DateOfPublish, [Year], ProductPrice)
values (1,1,1,'Это не хорошо, чтобы чувствовать себя синим',280,550,'2019.01.02','2018',350), (1,2,2,'Голландский Дом', 352,450,'2019.01.09','2018', 410),(1,1,2,'Воспитание идеалиста',980,300,'2017.01.05','2017',400),
 (2,3,3,'Гарри Поттер и филосовский камень', 564,600,'2000.01.08', '1997',400),(2,3,3,'Гарри Поттер и Узник Азкабана',464, 1500,'2015.01.01','1999', 480),
  (2,3,3,'Гарри Поттер и проклятое дитя',464,1800,'2019.01.04', '2016',400),(2,4,4,'Алиса в стране чудес',980,2000,'1990.01.03','1865',500), (3,5,5, 'Убийство на улице Морг', 248,3000,'2000.01.10','1841',200),
(3,6,6, 'Лунный камень',510,2000,'2005.01.03','1866' ,500), (4,7,7,'Ревизор', 355, 1800,'2001.01.11', '1836',405), (4, 8,4,'Вишневый сад',380,1500,'2004.01.05','1896',180),(4,9,5,'Укрощение строптивой',407,1100,'2003.01.06','1594',210),
 (5,10,8,'Пиковая дама', 248,2700,'2008.01.02','1834',225),(5,7,6,'Вечера на хуторе вблизь Диканьки',366,1400,'2000.01.07','1926',364),(5,8,7,'Дама на охоте',412,1600,'2003.01.12','1885',199)
 
insert into dbo.NextTome(Title,Number,Id_Book) values ('Гарри Поттер и филосовский камень',3,4), ('Гарри Поттер и Узник Азкабана',4,5),('Гарри Поттер и проклятое дитя',5,6)

insert into dbo.Discounts (DiscountPercent,Id_Book) values(0.50,2), (0.10,7), (0.20,11), (0.30,10),(0.40, 13),(0.05,5)

insert into dbo.Users([Login],[Password]) values ('SV','SV'), ('VP','VP'),('NN','NN'), ('PY','PY'), ('VV','VV')

insert into dbo.Buyers(FistName, LastName, Id_User)values ('Victorya', 'Sushko',1), ('Vlad', 'Poheil',2), ('Nadya', 'Nikol',3), ('Pavel', 'Yakovlev',4), ('Veronika', 'Vero',5)

 insert into Reservations(Id_Book,Id_Buyer) values (10,2),(8,4),(3,5)

 insert into dbo.Sales(Id_Buyer,Id_Book,DateOfSale,SalePrice,Quantity)
 values (4,2,'2019.08.01', 460,1),(3,3,'2019.10.02',450,3), (2,4,'2019.10.03',430,1),(1,5,'2019.10.04', 535,4),(2,6,'2019.10.05',450,3),(3,7,'2019.09.01',550,5),(4,8,'2019.08.05',250,2),
 (5,9,'2019.09.02',560,1),(1,10,'2019.10.09',468,3),(2,11,'2019.10.07',230,10),(3,12,'2019.10.09',260,4),(4,13,'2019.09.20', 275,2),(5,5, '2019.03.05',535,2),(1,7,'2019.09.27',550,2),
(2,1,'2019.09.10',400, 2)

