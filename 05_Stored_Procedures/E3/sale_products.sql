CREATE DEFINER=`root`@`localhost` PROCEDURE `sale_products`(in _product_list text, in _amount text)
BEGIN
	declare _actual_length, _product_length, _current_p, _current_a, i int;
    set _product_length = length(_product_list);
    set i = 1;
    
    start transaction;
    
    set @_id_venta = 0;
    call mydb.add_sale(@_id_venta);
    iteracion: LOOP
		set _actual_length = length(substring_index(_product_list, ",", i));
        set _current_p = substring_index(substring_index(_product_list, ",", i), ",", -1);
        set _current_a = substring_index(substring_index(_amount, ",", i), ",", -1);
		
        call mydb.add_sale_row(@_id_venta, _current_p, _current_a);
        select i, _actual_length, _current_p, _current_a;
        
        set i = i + 1;
        IF _actual_length = _product_length THEN
			LEAVE iteracion;
		END IF;
    END LOOP iteracion;
    
    commit;
END
