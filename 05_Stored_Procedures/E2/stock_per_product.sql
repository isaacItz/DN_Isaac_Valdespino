CREATE DEFINER=`root`@`localhost` PROCEDURE `stock`(in id_product int)
BEGIN
	select p.idproducttype, p.name, brand, stock, pt.name type 
	from 
		(select sum(stock) stock, producttype_idproducttype 
		from 
		inventory group by producttype_idproducttype having stock > 0) stock 
	join 
	product p on stock.producttype_idproducttype = p.idproducttype 
	join
	producttype pt on pt.idproducttype = p.id_producttype 
	where 
	pt.idproducttype = id_product and i.expiration > curdate();
END

-- probar procedimiento
-- call stock(1);
