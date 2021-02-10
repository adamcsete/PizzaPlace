
USE [master]
GO
DROP DATABASE IF EXISTS [pizzaplace]
GO
-- creating database
CREATE DATABASE [pizzaplace] COLLATE Hungarian_CI_AS
GO
USE [pizzaplace]
EXEC sp_configure 'CONTAINED DATABASE AUTHENTICATION', 1
RECONFIGURE

USE [master]
ALTER DATABASE [pizzaplace] SET CONTAINMENT = PARTIAL
USE [pizzaplace]

CREATE USER pizzadmin WITH PASSWORD='1234', DEFAULT_SCHEMA=[dbo];

-- creating pizzas table
CREATE TABLE pizzas(
	pID smallint IDENTITY(1,1) PRIMARY KEY,
	pNAME varchar(255) NOT NULL,
	pPRICE smallint NOT NULL
)

INSERT INTO  pizzas (pNAME, pPRICE) VALUES ('Sonkás', 2500)
INSERT INTO  pizzas (pNAME, pPRICE) VALUES ('Sajtimádó', 2800)
INSERT INTO  pizzas (pNAME, pPRICE) VALUES ('SonGoKu', 3100)
INSERT INTO  pizzas (pNAME, pPRICE) VALUES ('Ananászos', 2700)
INSERT INTO  pizzas (pNAME, pPRICE) VALUES ('Húsimádó', 3500)

-- creating couriers table
CREATE TABLE couriers(
	cID smallint IDENTITY(1,1) PRIMARY KEY,
	cNAME varchar(255) NOT NULL,
)
INSERT INTO  couriers (cNAME) VALUES ('Horváth István')
INSERT INTO  couriers (cNAME) VALUES ('Kiss Béla')
INSERT INTO  couriers (cNAME) VALUES ('Nagy Péter')

--creating customers
CREATE TABLE customers(
	custID smallint IDENTITY(1,1) PRIMARY KEY,
	custNAME varchar(255) NOT NULL,
	custADDRESS varchar(255) NOT NULL,
	custNUMBER varchar(20) NOT NULL
)
INSERT INTO customers (custNAME, custADDRESS, custNUMBER) VALUES ('Pintér Sándor', '1114 Budapest Bocskai út 13', '+36301234567')
INSERT INTO customers (custNAME, custADDRESS, custNUMBER) VALUES ('Pintér Sándor', '1013 Budapest Attila út 17', '+36207654321')
INSERT INTO customers (custNAME, custADDRESS, custNUMBER) VALUES ('Kis Péter', '1056 Budapest Irányi út 25', '+36205654321')
INSERT INTO customers (custNAME, custADDRESS, custNUMBER) VALUES ('Erős Sándor', '1052 Budapest Petőfi Sándor út 8', '+36707654321')

--creating orders list
CREATE TABLE orders(
	oID int IDENTITY(1,1) PRIMARY KEY,
	oSTATE varchar(50) NOT NULL,
	oPIZZA varchar(50) NOT NULL,
	oCUSTOMER varchar(255) NOT NULL,
	oCOURIER varchar(50) NOT NULL,
	oPRICE smallint NOT NULL,
	oTIME varchar(50) NOT NULL
)

INSERT INTO [orders] (oSTATE, oPIZZA, oCUSTOMER, oCOURIER, oPRICE, oTIME) 
VALUES ('készül', 'Sonkás', 'Erős Sándor', '1052 Budapest Petőfi Sándor út 8', 2500, '10/02/2021 14:26:54');

INSERT INTO [orders] (oSTATE, oPIZZA, oCUSTOMER, oCOURIER, oPRICE, oTIME) 
VALUES ('szállítás alatt', 'Ananászos', 'Pintér Sándor', '1013 Budapest Attila út 17', 2700, '10/02/2021 14:25:54');

INSERT INTO [orders] (oSTATE, oPIZZA, oCUSTOMER, oCOURIER, oPRICE, oTIME) 
VALUES ('kiszállítva', 'Húsimádó', 'Kis Péter', '1056 Budapest Irányi út 25',  3500, '10/02/2021 14:24:54');


USE [pizzaplace]
GRANT SELECT TO pizzadmin;
GRANT INSERT TO pizzadmin;
GRANT UPDATE TO pizzadmin;
GRANT DELETE TO pizzadmin;


