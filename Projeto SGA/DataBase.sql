
CREATE DATABASE IF NOT EXISTS academico;

USE academico;

CREATE TABLE IF NOT EXISTS aluno (
	id				int				NOT NULL AUTO_INCREMENT,
	matricula		varchar(15)		NOT NULL,		
	dt_nascimento	datetime		NOT NULL,		
	nome			varchar(100)	NOT NULL,		
	endereco		varchar(100)	NOT NULL,		
	bairro			varchar(100)	NOT NULL,		
	cidade			varchar(100)	NOT NULL,		
	estado			varchar(02)		NOT NULL,		
	senha			varchar(60)		NOT NULL,
PRIMARY KEY(id)	
);

CREATE TABLE IF NOT EXISTS Curso (
	id				int		NOT NULL AUTO_INCREMENT,
	nome			varchar(25),
	tipo			varchar(15),
	ano_criacao		int		NOT NULL,
	PRIMARY KEY(id)	
	
);
CREATE TABLE IF NOT EXISTS Professor (
	id				int				NOT NULL AUTO_INCREMENT,
	matricula		varchar(15)		NOT NULL,		
	dt_nascimento	datetime		NOT NULL,		
	nome			varchar(100)	NOT NULL,		
	titulacao		varchar(100)	NOT NULL,
	Area_Formacao   varchar(100)	NOT NULL,
	endereco		varchar(100)	NOT NULL,		
	bairro			varchar(100)	NOT NULL,		
	cidade			varchar(100)	NOT NULL,		
	estado			varchar(02)		NOT NULL,		
	PRIMARY KEY(id)	
);