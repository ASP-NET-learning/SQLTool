```
USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[NewRestock]    Script Date: 2024/11/3 下午 10:08:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[NewRestock]
AS
	SELECT 
		ProductID,
		ProductName,
		s.SupplierID,
		s.CompanyName,
		s.Phone,
		s.ContactName,
		CASE
			WHEN UnitsInStock < UnitsOnOrder 
			THEN (UnitsOnOrder - UnitsInStock) + ReorderLevel * 2
			ELSE 0
			END AS 'Restocks'
	FROM Products p
	LEFT JOIN
		Suppliers  s ON s.SupplierID = p.SupplierID

```
## 使用方法 :

簡易查詢可以讓使用者用下拉選單找指定表，以及透過輸入找前N筆資料

## 修改規則 :

```
<connectionStrings>
    <add name="NorthwindEntities" connectionString="你的連線字串" providerName="System.Data.EntityClient" />
  </connectionStrings>
```

---
感謝您提供的資訊和圖片！以下是維修文件的初步大綱，您可以進一步提供更多細節來補充每個模組的功能說明和維護指引：

---

**維修文件：C# WinForms ERP生產模組**

**系統概要**
- 使用技術：C# WinForms
- 資料庫：MS SQL
- 資料來源：北風資料庫

**模組功能簡介**
1. **查總表模組**（如圖一）
   - 功能：提供系統資料的快速查詢，包含紀錄數量的顯示。
   - UI 元件：查詢篩選、總筆數顯示、查詢結果顯示等。
   - ![image](https://github.com/user-attachments/assets/aaabe1f0-f315-4380-9ffd-5a0bfe2d862b)


2. **出貨資訊模組**（如圖二）
   - 功能：顯示訂單資訊，包括客戶名稱、公司名稱、寄送地址、總價格及出貨日期。
   - UI 元件：訂單編號查詢、顧客資訊、公司資訊等。
   - ![image](https://github.com/user-attachments/assets/f231b478-f991-4753-8d00-fa5cecd1a45b)


3. **營收資訊模組**（如圖三）
   - 功能：顯示各年份的熱銷產品銷售數據，包含每年總營收。
   - UI 元件：熱銷產品、銷量、總營收及當年利潤情況的顯示。
   - ![image](https://github.com/user-attachments/assets/4df749ea-16a0-433d-8337-4c6938eb2f0c)


4. **庫存管理模組**
   - 功能：管理庫存量，以及查看是哪個供應商供應以及顯示事是否補充庫存。
   - UI 元件：補充庫存、供應商資訊、單身資訊
   - ![image](https://github.com/user-attachments/assets/6aa8cc31-67ce-4611-9d84-b958192f34ee)


**維護指引**
1. **系統安裝與設定**
   - 需求：.NET Framework, MS SQL 伺服器
   - 資料庫連線設定：確保應用程式與北風資料庫的連線正常。

2. **問題排查**
   - 若查詢無結果：確認 SQL 查詢語法是否正確。
   - 若出現資料庫連線錯誤：檢查資料庫伺服器狀態及連線字串設定。

3. **常見錯誤與解決方案**
   - 錯誤訊息顯示「無法連接到資料庫」：檢查伺服器設定，重新配置連線字串。
   - UI 元件顯示異常：檢查各表單元件的屬性設定。

請告知是否需要更詳細的步驟，或是其他模組特定的維修建議！
