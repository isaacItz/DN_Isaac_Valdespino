/* pasamos dos listas, una con los id de productos que se van a vender
y otra lista con la cantidad que venderemos por cada producto */
set @list = "1,2,3";
set @list2 = "1,2,4";

call sale_products(@list, @list2);
