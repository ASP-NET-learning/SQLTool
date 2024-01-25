-- task : 96 97 98 營收
--drop procedure Revenue
CREATE PROCEDURE Revenue
	@year varchar(10)
AS
	if(@year is null) 
		begin
			set @year = 1996
		commit
	end

	SELECT ROUND(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)),3) AS '營收'
	FROM Orders o
	LEFT JOIN
		[Order Details] od ON o.OrderID = od.OrderID
	WHERE YEAR(o.OrderDate) = @year
GO

exec Revenue 1998