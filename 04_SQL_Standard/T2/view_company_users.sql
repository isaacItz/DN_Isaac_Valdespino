create view companyusers
as
select u.id_company, u.iduser, u.email, c.company_name from users u
inner join company c on u.id_company = c.id_company
