CREATE DATABASE CLIENTES_DB;
GO

use CLIENTES_DB;

GO

/*contiene los clientes*/
CREATE TABLE clientes(
tipo_cliente int NOT NULL,
nombre_completo varchar(50) NOT NULL,
cuit_cuil varchar(11) primary key not null,
categoria_cliente int NOT NULL,
domicilio_cliente varchar(20) NOT NULL
);


/*contiene los servicios*/
CREATE TABLE servicios(
idCuitOCuil_cliente varchar(11) foreign key references clientes(cuit_cuil)not null,
costo_servicio INT not null,
dificultad_servicio int not null,
tipo_infeccion int not null,
fecha_analisis date not null
);

/*agrego  clientes*/
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Oyope', '34852217538', 0, '40248 Carpenter Road');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Rhyloo', '34461235449', 0, '1 Barnett Street');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Twiyo', '37223180210', 0, '530 Coolidge Circle');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Tagfeed', '39816206822', 1, '28652 Carberry Plaza');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Omba', '30689082597', 0, '239 Surrey Plaza');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Ailane', '37284091357', 1, '90 Merchant Pass');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Youspan', '31362094000', 1, '6 Susan Junction');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Innotype', '35201017064', 1, '551 Doe Crossing');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Eare', '39126763216', 0, '1721 Eagle Crest Way');
insert into clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (1, 'Fliptune', '33948996941', 0, '2 Mcguire Court');

insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Randie Martinho', '21145730446', 0, '1 Susan Avenue');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Jackqueline Leyton', '23844397408', 0, '135 Homewood');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Fred Simester', '21028111375', 1, '120 Hollow');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Jorry Twatt', '28797445730', 1, '05230 Gerald Center');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Allina Dugald', '26609537447', 0, '9 Melvin Court');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Camila Yarranton', '20282187335', 0, '024 Jay Point');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Adaline Reedman', '26246446134', 0, '912 Columbus Lane');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Ardis Seakings', '25797187611', 0, '64 Anzinger Alley');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Christabella Knightley', '23627412001', 1, '81 Fisk Drive');
insert into clientes (tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values (2, 'Gus Offa', '27060337650', 1, '3088 Onsgard Court');




/*agrego  servicios*/
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'03/21/2020', '26609537447');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(20000, 1,2,'03/21/2022', '26246446134');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'02/22/2020', '33948996941');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'01/23/2020', '27060337650');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'04/24/2020', '28797445730');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'05/25/2020', '28797445730');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'02/26/2020', '28797445730');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'01/27/2020', '33948996941');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'07/20/2020', '33948996941');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'08/19/2020', '30689082597');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'09/16/2020', '30689082597');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'02/14/2020', '34852217538');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'04/13/2020', '34852217538');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'06/12/2020', '33948996941');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'06/11/2020', '33948996941');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'01/12/2020', '28797445730');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'08/05/2020', '28797445730');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'02/13/2020', '34852217538');
insert into servicios  (costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente)values(2000, 1,2,'06/13/2020', '34852217538');
