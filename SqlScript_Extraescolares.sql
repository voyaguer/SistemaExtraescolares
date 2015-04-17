-- Microsoft Transact-SQL
create database ExtraescolaresDB;
go

use ExtraescolaresDB;
go

create login login_Extraescolares with
	password = '1234',
	default_database = Extraescolares,
	check_policy = off;
go

create user user_Administrador
	for login Extraescolares
	with default_schema = Extraescolares;

create user user_Docente
	for login Extraescolares
	with default_schema = Extraescolares;

create user user_Alumno
	for login Extraescolares
	with default_schema = Extraescolares;
go

create role role_Administrador;
go

grant delete, insert, select, update 
	on Extraescolares.Alumnos
	to role_Administrador;
	
grant delete, insert, select, update 
	on Extraescolares.Docentes
	to role_Administrador;
	
grant delete, insert, select, update 
	on Extraescolares.Administradores
	to role_Administrador;
	
grant delete, insert, select, update 
	on Extraescolares.Actividades
	to role_Administrador;
	
grant delete, insert, select, update 
	on Extraescolares.Grupos
	to role_Administrador;
	
grant delete, insert, select, update 
	on Extraescolares.Listas
	to role_Administrador;
go

create table Alumnos
(
	IDAlumno int identity(1,1) unique not null,
	NumeroDeControl int unique,
	Nombre nvarchar(25),
	Apellidos nvarchar(50),
	Edad tinyint,
	Sexo (1), -- H -> Hombre || M -> Mujer
	Semestre tinyint,
	Carrera nvarchar(50),
	Email nvarchar(50),
	Telefono char(10),
	constraint PK_Alumnos primary key (IDAlumno),
	constraint CK_Alumnos_TelefonoSoloNumeros (Telefono like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);
go

create table Docentes
(
	IDDocente int identity(1,1) unique not null,
	Nombre nvarchar(25),
	Apellidos nvarchar(50),
	Edad tinyint,
	Sexo (1), -- H -> Hombre || M -> Mujer
	Email nvarchar(50),
	Telefono char(10),
	constraint PK_Docentes primary key (IDDocente),
	constraint CK_Docentes_TelefonoSoloNumeros (Telefono like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);
go

create table Administradores
(
	IDAdministrador int identity(1,1) unique not null,
	Nombre nvarchar(25),
	Apellidos nvarchar(50),
	Edad tinyint,
	Sexo (1), -- H -> Hombre || M -> Mujer
	Email nvarchar(50),
	Telefono char(10),
	constraint PK_Administradores primary key (IDAdministrador),
	constraint CK_Administradores_TelefonoSoloNumeros (Telefono like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
);
go

create table Actividades
(
	IDActividad int identity(1,1) unique not null,
	Nombre nvarchar(50),
	constraint PK_Actividades primary key (IDActividad)
);
go

create table Grupos
(
	IDGrupo int identity(1,1) unique not null,
	CicloEscolar_Anho smallint,
	CicloEscolar_MesPrimero tinyint,
	CicloEscolar_MesUltimo tinyint,
	Capacidad tinyint,
	Horario nvarchar(255),
	-- Formato para almacenar el horario
	-- La hora será expresada en un formato de 24 horas.
	-- {Dia,HH:MM,HH:MM}[&Dia,HH:MM,HH:MM][&...]...
	-- Ejemplo: Martes,14:00,16:00&Jueves,14:00,16:00
	IDActividad int not null,
	constraint PK_Grupos primary key (IDGrupo),
	constraint FK_Grupos foreign key (IDActividad)
		references Actividades (IDActividad) on delete cascade on update cascade
);
go

create table Listas
(
	IDAlumno int not null,
	IDGrupo int not null,
	Calificacion tinyint default 0,
	constraint PK_Listas primary key (IDAlumno, IDGrupo),
	constraint FK_Listas_IDAlumno foreign key (IDAlumno)
		references Alumnos (IDAlumno) on delete cascade on update cascade,
	constraint FK_Listas_IDGrupo foreign key (IDGrupo)
		references Grupos (IDGrupo) on delete cascade on update cascade
);
go