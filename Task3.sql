SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN ProductCategories ON Products.ID = ProductCategories.ProductId
LEFT JOIN Categories ON ProductCategories.CategoryID = Categories.ID
