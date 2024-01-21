SELECT CONCAT(ShipPostalCode, ' ', 
				ShipCountry, ' ',
				ShipCity,' ',
				ISNULL(ShipRegion, ''),' ',
				ShipAddress) 
FROM Orders o
LEFT JOIN 
	Customers c ON c.CustomerID = o.CustomerID


SELECT 
	o.OrderID, 
	o.CustomerID, 
	od.Quantity, 
	od.UnitPrice, 
	od.Discount, 
	(SELECT ProductName 
	 From Products
	 WHERE ProductID = od.ProductID) AS ProductName
FROM Orders o
LEFT JOIN 
	[Order Details] od ON od.OrderID = o.OrderID
WHERE o.OrderID = '10248';