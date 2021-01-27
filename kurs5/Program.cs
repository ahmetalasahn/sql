--Select
Select ContactName Adi, CompanyName SirketAdi, City Sehir From Customers

Select * From Customers where City = 'Berlin'

Select * From Products where CategoryID=1 and SupplierID=1

Select * From Products order by CategoryID --asc=ascending,-desc=descending

Select count(*) From Products

Select CategoryID, count(*) From Products group by CategoryID having count(*)< 10

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
From Products inner join Categories on Products.CategoryID= Categories.CategoryID
where Products.UnitPrice>25
--DTA (DATA TRANSFORMATİON OBJECT)

Select* From Products p left join [Order Details] od
on p.ProductID = od.ProductID

Select * From Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null