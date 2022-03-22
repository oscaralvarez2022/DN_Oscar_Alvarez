SELECT s.idSales, pt.ProductTypesName, max(s.SalesQuantity) bestSelled FROM sales s
LEFT JOIN producttypes pt ON s.ProductTypes_idProductTypes=pt.idProductTypes;