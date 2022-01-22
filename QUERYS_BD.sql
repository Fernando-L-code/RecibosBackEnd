CREATE DATABASE RECIBOS_BD
GO
USE RECIBOS_BD
GO


 CREATE TABLE PROVEEDORES( 
		CLA_PROVEEDOR  INT NOT NULL IDENTITY(1,1) PRIMARY KEY ,
		NOM_PROVEEDOR VARCHAR (80));

 CREATE TABLE MONEDAS( 
		CLA_MONEDA  INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		NOM_MONEDA VARCHAR (80));


CREATE TABLE USUARIOS(
	CLA_USUARIO	INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NOM_USUARIO	varchar(30) NOT NULL,
	PASSWORD 	varchar(30) NOT NULL);


 CREATE TABLE RECIBOS( 
		CLA_RECIBO INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		PROVEEDOR INT NOT NULL,
		MONTO	FLOAT NOT NULL,
		MONEDA	INT NOT NULL,
		FECHA	 DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL,
		COMENTARIO TEXT,
		FOREIGN KEY ( PROVEEDOR ) REFERENCES PROVEEDORES( CLA_PROVEEDOR),
		FOREIGN KEY ( MONEDA ) REFERENCES MONEDAS( CLA_MONEDA ));


insert into PROVEEDORES (NOM_PROVEEDOR) values ('AmTrust Financial Services, Inc.');
insert into PROVEEDORES (NOM_PROVEEDOR) values ('Mettler-Toledo International, Inc.');
insert into PROVEEDORES (NOM_PROVEEDOR) values ('Southern California Edison Company');
insert into PROVEEDORES (NOM_PROVEEDOR) values ('Gildan Activewear, Inc.');
insert into PROVEEDORES (NOM_PROVEEDOR) values ('USANA Health Sciences, Inc.');

insert into MONEDAS (NOM_MONEDA ) values ('MXN');
insert into MONEDAS (NOM_MONEDA ) values ('USD');
insert into MONEDAS (NOM_MONEDA ) values ('EUR');

insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (10, '1045.26', 3, '12/19/2021', 'vel nisl duis ac nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio in hac habitasse platea dictumst maecenas ut massa');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (6, '3468.75', 3, '10/20/2021', 'vel ipsum praesent blandit lacinia erat vestibulum sed magna at nunc commodo placerat praesent blandit nam nulla integer pede justo lacinia eget tincidunt eget tempus vel pede morbi porttitor lorem id ligula suspendisse ornare consequat');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (3, '1820.39', 2, '7/25/2021', 'neque libero convallis eget eleifend luctus ultricies eu nibh quisque id justo sit amet sapien dignissim vestibulum vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat et');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (8, '6646.28', 2, '2/25/2021', 'nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio in hac habitasse platea dictumst maecenas ut massa quis augue luctus tincidunt');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (1, '3621.97', 2, '7/26/2021', 'dapibus augue vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices aliquet maecenas leo odio condimentum');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (3, '620.25', 1, '1/2/2021', 'in faucibus orci luctus et ultrices posuere cubilia curae duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel lectus in quam fringilla rhoncus mauris enim leo rhoncus sed vestibulum sit amet cursus id turpis integer aliquet massa id lobortis convallis');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (9, '5286.60', 1, '1/1/2021', 'faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna pretium nisl ut volutpat sapien arcu sed augue');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (4, '7507.31', 2, '2/25/2021', 'ac nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio in hac habitasse platea dictumst maecenas ut massa quis augue luctus');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (5, '5320.80', 2, '11/8/2021', 'risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero quis orci nullam molestie nibh in lectus pellentesque at nulla suspendisse potenti cras in purus eu magna vulputate luctus cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (2, '9723.48', 1, '1/12/2021', 'blandit nam nulla integer pede justo lacinia eget tincidunt eget tempus vel pede morbi porttitor lorem id ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus sit amet');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (7, '4830.37', 3, '8/7/2021', 'bibendum imperdiet nullam orci pede venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis nam congue risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero');
insert into RECIBOS (PROVEEDOR , MONTO	, MONEDA, FECHA, COMENTARIO ) values (1, '3017.78', 3, '9/2/2021', 'est quam pharetra magna ac consequat metus sapien ut nunc vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor lacus at turpis donec posuere');



