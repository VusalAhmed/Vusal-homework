CREATE DATABASE MARKET

USE MARKET

CREATE TABLE Products
(
ID INT,
Name nvarchar(20),
Price Money
)

ALTER TABLE Products
ADD Brand nvarchar(25)

INSERT INTO Products
VALUES(1,'Sokolad',2,'Browni'),
(2,'Cips',3,'Lays'),
(3,'Suxari',1,'Bali'),
(4,'Pendir',4,'Ismayilli'),
(5,'Sud',5,'Palsud'),
(6,'Bal',9,'Balparmak'),
(7,'Sigaret',7,'Neo'),
(8,'Icki',8,'Coca-Cola'),
(9,'Mandalin',10,'Meyve'),
(10,'toyuq',6,'Siyezen')

Select * from Products where Price<(select AVG(Price) FROM Products)
Select * from Products where Price>5
Select  (Name + ' ' + Brand ) ProductInfo FROM Products
Select * from Products where LEN( (Select (Name + ' ' + Brand ) 'ProductInfo' FROM Products)) > 10
