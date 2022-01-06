
create view user_role as 
select u.iduser, username, first_name, last_name, role_name 
from 
user u 
join 
userinrole ur on ur.user_iduser = u.iduser 
join role r on r.idrole = ur.role_idrole;

create view stock_and_type as 
select p.idproducttype, p.name, brand, stock, pt.name type 
from 
(select sum(stock) stock, producttype_idproducttype 
from 
inventory group by producttype_idproducttype having stock > 0) stock 
join 
product p on stock.producttype_idproducttype = p.idproducttype 
join
producttype pt on pt.idproducttype = p.id_producttype;

create view most_sold as 
select idproducttype, name, brand, sub.sum sold 
from 
(select sum(quantitty) sum, producttype_idproducttype 
from sale_row group by producttype_idproducttype) sub 
join 
(select sum(quantitty) sum 
from 
sale_row group by producttype_idproducttype order by sum desc limit 1) max 
on max.sum = sub.sum 
join 
product p on p.idproducttype = sub.producttype_idproducttype;

create view member_membership as 
select m.idmember, m.name, m.lastname, mt.idmembershiptype, mm.date, mt.name 
from 
membermembership mm 
join 
membershiptype mt on mt.idmembershiptype = mm.membershiptype_idmembershiptype 
join 
member m on m.idmember = mm.member_idmember 
where date = 
(select max(date) from membermembership);
