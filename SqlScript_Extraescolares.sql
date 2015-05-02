-- Microsoft Transact-SQL
--drop database ExtraescolaresDB;
create database ExtraescolaresDB;
go

use ExtraescolaresDB;
go

create login login_Extraescolares with
	password = '1234',
	default_database = ExtraescolaresDB,
	check_policy = off;
go

create user user_Extraescolares
	for login login_Extraescolares
	with default_schema = ExtraescolaresDB;
go

create table Usuarios 
(
	IDUsuario int identity(1,1) unique not null,
	Usuario nvarchar(50) not null,
	Passwrd nvarchar(50) not null,
	Rango tinyint not null default 0,
	constraint PK_Usuario primary key (IDUsuario)
);
go

create table Alumnos
(
	IDAlumno int identity(1,1) unique not null,
	NumeroDeControl int unique not null,
	Nombre nvarchar(25) not null,
	Apellidos nvarchar(50) not null,
	Edad tinyint not null,
	Sexo char(1) not null, -- H -> Hombre || M -> Mujer
	Semestre tinyint not null,
	Carrera nvarchar(50) not null,
	Email nvarchar(50),
	Telefono char(10) not null,
	IDUsuario int not null,
	constraint PK_Alumnos primary key (IDAlumno),
	constraint CK_Alumnos_TelefonoSoloNumeros check (Telefono like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint CK_Alumnos_Sexo check (Sexo like '[H,M]'),
	constraint FK_Alumnos_Usuario foreign key (IDUsuario)
		references Usuarios(IDUsuario)
);
go

create table Docentes
(
	IDDocente int identity(1,1) unique not null,
	Nombre nvarchar(25) not null,
	Apellidos nvarchar(50) not null,
	Edad tinyint not null,
	Sexo char(1) not null, -- H -> Hombre || M -> Mujer
	Email nvarchar(50),
	Telefono char(10) not null,
	IDUsuario int not null,
	constraint PK_Docentes primary key (IDDocente),
	constraint CK_Docentes_TelefonoSoloNumeros check (Telefono like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint CK_Docentes_Sexo check (Sexo like '[H,M]'),
	constraint FK_Docentes_Usuario foreign key (IDUsuario)
		references Usuarios(IDUsuario)
);
go

create table Administradores
(
	IDAdministrador int identity(1,1) unique not null,
	Nombre nvarchar(25) not null,
	Apellidos nvarchar(50) not null,
	Edad tinyint not null,
	Sexo char(1) not null, -- H -> Hombre || M -> Mujer
	Email nvarchar(50),
	Telefono char(10) not null,
	IDUsuario int not null,
	constraint PK_Administradores primary key (IDAdministrador),
	constraint CK_Administradores_TelefonoSoloNumeros check (Telefono like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint CK_Administradores_Sexo check (Sexo like '[H,M]'),
	constraint FK_Administradores_Usuario foreign key (IDUsuario)
		references Usuarios(IDUsuario)
);
go

create table Actividades
(
	IDActividad int identity(1,1) unique not null,
	Nombre nvarchar(50) not null,
	constraint PK_Actividades primary key (IDActividad)
);
go

create table Grupos
(
	IDGrupo int identity(1,1) unique not null,
	CicloEscolar_Anho smallint not null,
	CicloEscolar_MesPrimero tinyint not null,
	CicloEscolar_MesUltimo tinyint not null,
	Capacidad tinyint not null,
	Horario nvarchar(255) not null,
	-- Formato para almacenar el horario
	-- La hora será expresada en un formato de 24 horas.
	-- {Dia,HH:MM,HH:MM}[&Dia,HH:MM,HH:MM][&...]...
	-- Ejemplo: Martes,14:00,16:00&Jueves,14:00,16:00
	IDActividad int not null,
	constraint PK_Grupos primary key (IDGrupo),
	constraint CK_Grupos_Meses 
		check (1 <= CicloEscolar_MesPrimero and CicloEscolar_MesPrimero <= 12 and 
		1 <= CicloEscolar_MesUltimo and CicloEscolar_MesUltimo <= 12),
	constraint FK_Grupos foreign key (IDActividad)
		references Actividades (IDActividad) on delete cascade on update cascade
);
go

create table Listas
(
	IDAlumno int not null,
	IDGrupo int not null,
	Calificacion tinyint default 0 not null,
	constraint PK_Listas primary key (IDAlumno, IDGrupo),
	constraint CK_Listas_Calificacion check (0 <= Calificacion and Calificacion <= 100),
	constraint FK_Listas_IDAlumno foreign key (IDAlumno)
		references Alumnos (IDAlumno) on delete cascade on update cascade,
	constraint FK_Listas_IDGrupo foreign key (IDGrupo)
		references Grupos (IDGrupo) on delete cascade on update cascade
);
go

insert into Usuarios (Usuario, Passwrd, Rango) values ('1','1', 2);

insert into Actividades (Nombre) values ('Volleyball');
insert into Actividades (Nombre) values ('Basketball');
insert into Actividades (Nombre) values ('Natación');
insert into Actividades (Nombre) values ('Futball');
insert into Actividades (Nombre) values ('Ajedrez');
insert into Actividades (Nombre) values ('Yu-gi-oh!');
insert into Actividades (Nombre) values ('Taller de Programación');
insert into Actividades (Nombre) values ('Rondalla');
insert into Actividades (Nombre) values ('Danza');
insert into Actividades (Nombre) values ('Atletismo');

insert into Usuarios (Usuario, Passwrd, Rango) values ('2', '2', 0);

insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0000, 'Alumno0', 'Apellido', 20, 'H', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0001, 'Alumno1', 'Apellido', 20, 'M', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0002, 'Alumno2', 'Apellido', 20, 'H', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0003, 'Alumno3', 'Apellido', 20, 'M', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0004, 'Alumno4', 'Apellido', 20, 'H', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0005, 'Alumno5', 'Apellido', 20, 'M', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0006, 'Alumno6', 'Apellido', 20, 'H', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0007, 'Alumno7', 'Apellido', 20, 'M', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0008, 'Alumno8', 'Apellido', 20, 'H', 1, 'Sistemas', '0123456789', 2);
insert into Alumnos (NumeroDeControl, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Telefono, IDUsuario)
	values (0009, 'Alumno9', 'Apellido', 20, 'M', 1, 'Sistemas', '0123456789', 2); 
