-- 任務:找出熱銷產品
--drop procedure HotProduct
CREATE PROCEDURE HotProduct
	@year varchar(10) = null
AS
	if(@year is null) begin
		set @year = 1996
	end

	SELECT TOP 1 p.ProductName, SUM(od.Quantity) AS 'total'
	FROM [Order Details] od
	INNER JOIN
		Orders o ON o.OrderID = od.OrderID
	INNER JOIN
		Products p ON p.ProductID = od.ProductID
	WHERE YEAR(o.OrderDate) = @year
	GROUP BY p.ProductName
	ORDER BY 'total' DESC
GO

execute HotProduct 1996







