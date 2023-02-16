use [TECHGENERIC]

create table FUNCIONARIOS
(
	codigo int identity(1,1) primary key,
	nome varchar(50),
	endereco varchar(50),
	sexo varchar(9),
	salario numeric(18,2)
)