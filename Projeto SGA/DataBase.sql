 /*DROP DATABASE IF NOT EXISTS academico*/

CREATE DATABASE IF NOT EXISTS academico;

USE academico;

CREATE TABLE aluno (
	id				int				NOT NULL AUTO_INCREMENT,
	matricula		varchar(15)		NOT NULL,		
<<<<<<< HEAD
	dt_nascimento	datetime		NOT NULL,		
=======
	dt_nascimento	datatime		NOT NULL,		
>>>>>>> 773fd912ea609c729888cca09b2e500f436bb0f2
	nome			varchar(100)	NOT NULL,		
	endereco		varchar(100)	NOT NULL,		
	bairro			varchar(100)	NOT NULL,		
	cidade			varchar(100)	NOT NULL,		
	estado			varchar(02)		NOT NULL,		
	senha			varchar(60)		NOT NULL,
PRIMARY KEY(id)	
);
