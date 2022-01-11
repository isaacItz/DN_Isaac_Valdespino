CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateCompany`(in _companyName varchar(100),
in _location char(2), in _adminEmail varchar(500), in _userEmail varchar(100),
out _idCompany int, out _idAdmin int, out _idUser int)
BEGIN

	declare _companyId int;
    declare _adminId, _userId int;
    
    select max(id_company) + 1 into _companyId from company;
    select max(iduser) + 1 into _adminId from users;
    set _userId = _adminId + 1;
    
    insert into company (id_company, company_name, location)
    values
    (_companyId, _companyName, _location);
    
    insert into users (iduser, username, email, id_company)
    values
    (_adminId, 'admin', _adminEmail, _companyId);
    
	insert into users (iduser, username, email, id_company)
    values
    (_userId, 'user', _userEmail, _companyId);
    
    set _idCompany = _companyId;
    set _idAdmin = _adminId;
    set _idUser = _userId;
END
