CREATE DATABASE projetounip2;

USE projetounip2;

-- DROP DATABASE projetounip2;

CREATE TABLE telefone_tipo(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    tipo VARCHAR(10) NOT NULL    
);

CREATE TABLE endereco(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(256) NOT NULL,
    numero INTEGER NOT NULL,
    cep INTEGER NOT NULL,
    bairro VARCHAR(50) NOT NULL,
    cidade VARCHAR(30) NOT NULL,
    estado VARCHAR(20) NOT NULL
);

CREATE TABLE pessoa(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(256) NOT NULL,
    cpf BIGINT,
    id_endereco INTEGER NOT NULL,
    
    FOREIGN KEY (id_endereco) REFERENCES endereco (id) 
);

CREATE TABLE telefone(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    numero INTEGER NOT NULL,
    DDD INTEGER NOT NULL,
    id_tipo INTEGER NOT NULL,
    
    FOREIGN KEY (id_tipo) REFERENCES telefone_tipo (id)
);

CREATE TABLE pessoa_telefone(
	id_pessoa INTEGER NOT NULL REFERENCES pessoa (id),
    id_telefone INTEGER NOT NULL REFERENCES telefone (id),
    
    FOREIGN KEY (id_pessoa) REFERENCES pessoa (id),
    FOREIGN KEY (id_telefone) REFERENCES telefone (id)
);