﻿CREATE TABLE usuarios(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
login VARCHAR(100),
senha VARCHAR(100)
);

CREATE TABLE estados(
id INT PRIMARY KEY IDENTITY (1,1),
<<<<<<< HEAD
nome_estado VACHAR(100),
=======
nome VARCHAR(100),
sigla VARCHAR (2)
);
