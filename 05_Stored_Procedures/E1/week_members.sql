CREATE DEFINER=`root`@`localhost` PROCEDURE `week_members`()
BEGIN
	declare start_day, end_day date;
    select date_sub(curdate(), interval dayofweek(curdate()) - 2 day) into start_day;
    select date_add(start_day, interval 6 day) into end_day;
    
    select m.idmember, m.name, m.lastname, mm.date, mt.name, mt.cost
    from membermembership mm join member m on m.idmember = mm.member_idmember
    join membershiptype mt on mt.idmembershiptype = mm.membershiptype_idmembershiptype
    where date between start_day and end_day;
END
