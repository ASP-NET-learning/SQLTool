-- task : 96 97 98 �禬
--drop procedure HotProduct
SELECT ROUND(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)),3) AS '�禬'
FROM Orders o
LEFT JOIN
	[Order Details] od ON o.OrderID = od.OrderID
WHERE YEAR(o.OrderDate) = '1998'