SELECT * 
FROM Products
WHERE ProductName LIKE 'C%';

SELECT * 
FROM Products
WHERE Price = (SELECT MIN(Price) FROM Products);

SELECT Price
FROM Products 
INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
WHERE Country = 'USA';

SELECT SupplierName
FROM Products 
INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
WHERE CategoryName = 'Condiments';