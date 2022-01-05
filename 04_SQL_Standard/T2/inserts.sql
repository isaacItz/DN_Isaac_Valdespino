insert into country (idcountry, name) values 
(0, "USA"),
(1, "Argentina"),
(2, "Colombia"),
(3, "Mexico"),
(4, "Cuba");

insert into company (id_company, company_name, location) values
(0, "Company Test", "SU"),
(1, "Contoso", "NO"),
(2, "Tesla", 'AM');

insert into users (iduser, username, email, id_company) values
(0, 'admin', 'admin@gmail.com', 0),
(1, 'test', 'test@gmail.com', 1),
(2, 'lugo', 'lugo@gmail.com', 2),
(3, 'lugo', 'lugo@gmail.com', 2);

insert into city (idcity, name, idcountry) values
(0, 'CDMX', 3),
(1, 'Guadalajara', 3),
(2, 'Monterrey', 3),
(3, 'Los Ángeles', 0),
(4, 'New York', 0),
(5, 'Washington DC', 0),
(6, 'Buenos Aires', 1),
(7, 'La Habana', 4),
(8, 'Medeyin', 2),
(9, 'Barranquiya', 2);
