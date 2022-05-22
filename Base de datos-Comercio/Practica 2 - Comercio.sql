drop database if exists comercio;
create database comercio;
use comercio;
drop table producto;
create table producto(
codigo varchar(8) not null primary key,
descripcion varchar(45) unique,
existencia int,
precio double,
estatus char(1)
);

insert into producto
(codigo,descripcion,existencia,precio,estatus)
values
('0001','Mantequilla','100','20','A'),
('0002','Pan','1250','10','A'),
('0003','Arroz','770','30','I'),
('0004','Cafe','3200','15','A'),
('0005','Azucar','17','17.5','A'),
('0006','Harina','17','16.45','A'),
('0007','Harina de Trigo','2500','35','A');

select*from producto;
