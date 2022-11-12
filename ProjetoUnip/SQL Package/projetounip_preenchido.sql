/*** POPULANDO O BANCO COM DADOS ***/
INSERT INTO telefone_tipo (tipo)
	VALUES ("CEL"), ("RES"), ("COM");

INSERT INTO endereco (logradouro, numero, cep, bairro, cidade, estado)
	VALUES
    ("Rua Loguetown", 56, 1204573, "East Sea", "Salvador", "Bahia"),
    ("Rua Caçador de Recompensa", 3, 9850412, "Shimotsuki",	"Belo Horizonte", "Minas Gerais"),
	("Rua West Blue", 4, 6928940, "Ohara", "Iranduba", "Amazonas"),
	("Rua Drum", 16, 6928940, "Torino", "Iranduba", "Amazonas"),
	( "Rua dos Robôs", 37, 8945278, "Water 7", "Los Angeles", "California");
    
INSERT INTO telefone (numero, DDD, id_tipo)
	VALUES
    (96385274, 71, 1),
    (87561249, 31, 1),
    (89561234, 92, 1),
    (98767541, 92, 1),
    (98653245, 1, 1);

INSERT INTO pessoa (nome, cpf, id_endereco)
	VALUES
    ("Luffy D. Monkey", 12345678910, 1),
    ("Zoro Roronoa", 98765432123, 2),
    ("Nico Robin", 12378945610, 3),
    ("Chopper Tony", 12378978645, 4),
    ("Cutty Flame", 12368945680, 5);
    
INSERT INTO pessoa_telefone (id_pessoa, id_telefone)
	VALUES 
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (5, 5);
