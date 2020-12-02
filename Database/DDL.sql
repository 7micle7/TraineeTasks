CREATE DATABASE MyShop;

CREATE TABLE [dbo].[Suppliers](
  [SupplierID] [int] PRIMARY KEY IDENTITY(1, 1) NOT NULL,
  [SupplierName] [nvarchar](50) NOT NULL,
  [City] [nvarchar](50) NOT NULL,
  [Country] [nvarchar](50) NOT NULL,
)
CREATE TABLE [dbo].[Categories](
  [CategoryID] [int] PRIMARY KEY IDENTITY(1, 1) NOT NULL,
  [CategoryName] [nvarchar](50) NOT NULL,
  [Description] [nvarchar](100) NOT NULL
  )

CREATE TABLE [dbo].[Products](
  [ProductID] [int] PRIMARY KEY IDENTITY(1 ,1) NOT NULL,
  [ProductName] [nvarchar](50) NOT NULL,
  [SupplierID] [int] NOT NULL,
  [CategoryID] [int] NOT NULL,
  [Price] [decimal](5, 2) NOT NULL,
  FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
  FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
  )

--Populate Suppliers
INSERT INTO [dbo].[Suppliers](SupplierName, City, Country)
VALUES ('Exotic Liquid', 'London', 'UK'),
	   ('New Orleans Cajun Delights', 'New Orleans', 'USA'),
	   ('Grandma Kelly’s Homestead', 'Ann Arbor', 'USA'),
	   ('Tokyo Traders', 'Tokyo', 'Japan'),
	   ('Cooperativa de Quesos ‘Las Cabras', 'Oviedo', 'Spain');

--Populate Categories
INSERT INTO [dbo].[Categories](CategoryName, Description)
VALUES ('Beverages', 'Soft drinks, coffees, teas, beers, and ales'),
	   ('Condiments', 'Sweet and savory sauces, relishes, spreads, and seasonings'),
	   ('Confections', 'Desserts, candies, and sweet breads'),
	   ('Dairy Products', 'Cheeses'),
	   ('Grains/Cereals', 'Breads, crackers, pasta, and cereal');

--Populate Products
INSERT INTO [dbo].[Products](ProductName, SupplierID, CategoryID, Price)
VALUES ('Chais', 
(SELECT SupplierID from [dbo].Suppliers where SupplierName = 'Exotic Liquid'),
(SELECT CategoryId from [dbo].Categories where CategoryName = 'Beverages'),
18);

INSERT INTO [dbo].[Products](ProductName, SupplierID, CategoryID, Price)
VALUES ('Chang', 
(SELECT SupplierID from [dbo].Suppliers where SupplierName = 'Exotic Liquid'),
(SELECT CategoryId from [dbo].Categories where CategoryName = 'Beverages'),
19);

INSERT INTO [dbo].[Products](ProductName, SupplierID, CategoryID, Price)
VALUES ('Aniseed Syrup', 
(SELECT SupplierID from [dbo].Suppliers where SupplierName = 'Exotic Liquid'),
(SELECT CategoryId from [dbo].Categories where CategoryName = 'Condiments'),
10);

INSERT INTO [dbo].[Products](ProductName, SupplierID, CategoryID, Price)
VALUES ('Chef Anton’s Cajun Seasoning', 
(SELECT SupplierID from [dbo].Suppliers where SupplierName = 'New Orleans Cajun Delights'),
(SELECT CategoryId from [dbo].Categories where CategoryName = 'Condiments'),
12);

INSERT INTO [dbo].[Products](ProductName, SupplierID, CategoryID, Price)
VALUES ('Chef Anton’s Gumbo Mix', 
(SELECT SupplierID from [dbo].Suppliers where SupplierName = 'New Orleans Cajun Delights'),
(SELECT CategoryId from [dbo].Categories where CategoryName = 'Condiments'),
21.35);

--Insert new items
INSERT INTO [dbo].Suppliers(SupplierName, City, Country)
VALUES ('Norske Meierier', 'Lviv', 'Ukraine')


INSERT INTO [dbo].Categories(CategoryName, [Description])
VALUES ('Green tea', 'Description')

INSERT INTO [dbo].[Products](ProductName, SupplierID, CategoryID, Price)
VALUES ('Aniseed Syrup', 
(SELECT SupplierID from [dbo].Suppliers where SupplierName = 'Norske Meierier'), 
(SELECT CategoryId from [dbo].Categories where CategoryName = 'Green tea'), 10.00)
