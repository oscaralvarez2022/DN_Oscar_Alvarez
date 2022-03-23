CREATE DEFINER=`root`@`localhost` PROCEDURE `insertSale`(in _idProductTypes int, in _idUsers int, in _salesQuantity int,
out _idsale int, out _saleDate date, out _quantity int, out _productTypeId int)
BEGIN
	 declare _idSales int;
     declare _curdate date;
     set _curdate=curdate();
     
	 select max(idSales)+1 into _idSales from sales;
     
     insert into sales (idSales, ProductTypes_idProductTypes, SalesDate, SalesQuantity, users_idUsers)
	 values (_idSales, _idProductTypes, _curdate, _salesQuantity, _idUsers);   
     
     set _idsale=_idSales;
	 set _saleDate=_curdate;
     set _quantity=_salesQuantity;
     set _productTypeId=_idProductTypes;
     
END