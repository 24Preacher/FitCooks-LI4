
USE FitCooksDB

DELETE FROM receitas;
INSERT INTO receitas 
		(descricao, tempo, categoria, nome, nEtapas)
VALUES ('O acém pode ser uma carne muito macia, quando bem preparado',
		50,
		'Jantar',
		'Cozido de acém e legumes',
		7),

	   ('Excelente forma de preparar um pequeno almoço saudável e  de forma rápida',
	   	25,
	   	'Pequeno Almoço',
	   	'Pão de Frigideira',
		2)
		;
DELETE FROM etapas;
INSERT INTO etapas
		(id_Receita, instrucao, tempo, sugestao)
VALUES (1,
		'Tempere a carne com o sal e a pimenta.', 
		2,
		''),

		(1,
		'Junte a mostarda e refogue mais um pouco, mexendo sem parar.', 
		3, 
		''),

		(1,
		'Acrescente o caldo de carne, tampe a panela e cozinhe no fogo baixo (160 ºC), por 30 minutos.', 
		30, 
		''),

		(1,
		'Deixe sair a pressão e verifique se a carne está macia. Reserve.', 
		2, 
		''),
		
		(1,
		'Em uma frigideira, derreta a manteiga, junte o alho-poró e a cenoura.', 
		2, 
		''),

		(1,
		'Acrescente o sal e refogue até os legumes ficarem macios.', 
		5, 
		''),

		(1,
		'Sirva a carne com os legumes.', 
		1, 
		''),

		(2,
		'Juntar todos os ingredientes (excepto as sementes de girassol) e envolva até ficar uma mistura homogénea',
		5,
		''),

		(2,
		'Numa frigideira bem quente coloque o preparado, as sementes de girassol e coloque uma tampa e deixa cozinhar. Vire do outro lado até cozinhar.',
		20,
		'Pode acompanhar com queijo fresco e tomate cherry')
		;

DELETE FROM ingredientes;
INSERT INTO ingredientes(descricao,preco,Nome)
VALUES
		('', 
		0, 
		'acém'),

		( '', 
		0, 
		'óleo'),

		('', 
		0, 
		'cebola'),

		( '', 
		0, 
		'alho'),

		( '', 
		0, 
		'mostarda'),

		( '', 
		0, 
		'caldo de carne'),

		( '', 
		0, 
		'manteiga'),

		( '', 
		0, 
		'alho-poró'),

		('', 
		0, 
		'cenoura'),

		( '', 
		0, 
		'sal'),
	
		( '', 
		0, 
		'pimenta'),

		('',
		0,
		'bacalhau'),

		('',
		0,
		'farinha de aveia'),

		('',
		0,
		'ovo'),

		('',
		0,
		'linhaça moída'),

		('',
		0,
		'sementes de chia'),

		('',
		0,
		'sementes de girassol'),

		('',
		0,
		'fermento')
		;


INSERT INTO utensilios(nome,descricao)
VALUES
	('Panela de pressão',
	''),
	('Frigideira',
	'')
	;

DELETE FROM nutrientes;
INSERT INTO nutrientes(nome)
VALUES
	('Valor energetico'),
	('Gorduras Saturadas'),
	('Proteínas'),
	('Carboidratos')
	; 


DELETE FROM ingredientesNutrientes;
INSERT INTO ingredientesNutrientes(id_Ingredientes,id_Nutrientes,valor)
VALUES
	(1,1,212.4),    
	(1,3,26.7),    
	(1,2,4.8),    
	(3,1,39.4),    
	(3,3,1.7),    
	(3,4,8.9),    
	(4,1,113.1),    
	(4,3,7.4),    
	(4,4,23.9),    	
	(5,1,66.7),    
	(5,4,16.7),    	
	(6,1,240.6),    
	(6,3,8),    
	(6,4,15.1),    
	(6,2,7.8),    	
	(7,1,726.0),    
	(7,3,0.4),    
	(7,4,0.1),    
	(7,2,49.2),    	
	(8,1,31.5),    
	(8,3,1.4),    
	(8,4,6.9),    	
	(9,1,34.1),    
	(9,3,1.3),    
	(9,4,7.7),    
	(12,1,135.9),    
	(12,3,29),    
	(12,2,0.6),    
	(11,1,393.8),    
	(11,2,1.5),    
	(11,3,13.9),    
	(11,4,66.6),    
	(14,1,143.1),    
	(14,2,2.6),    
	(14,3,13),    
	(14,4,1.6),    
	(15,1,495.1),    
	(15,2,4.2),    
	(15,4,43.3),    
	(15,3,14.1),    
	(17,1,60),    
	(17,4,1.7),    
	(17,3,2)
	;



	DELETE FROM etapasIngredientes;
	INSERT INTO etapasIngredientes(id_Etapas,id_Ingredientes,quantidade)
	VALUES
		(1,1,'1,5kg'),
		(1,10,'a gosto'),
		(1,11,'a gosto'),
		(2,1,''),
		(2,2,'3 colheres de sopa'),
		(2,3,'1 cebola picada'),
		(2,4,'2 dentes de alho picados'),
		(3,5,'3 colheres de sopa'),
		(4,6,'1 xícara de chá'),
		(6,7,'1 colher de sopa'),
		(6,8,'2 talos de alho-poró cortados em rodelas finas'),
		(6,9,'1 cenoura cortada em rodelas finas'),
		(6,10,'a gosto'),
		(8,11,'1 colher de sopa'),
		(8,14,'1'),
		(8,15,'2 colheres de sopa'),
		(8,16,'1 colher de chá'),
		(8,18,'1 colher de café'),
		(9,17,'1 colher de chá')
		;
		
DELETE FROM etapasUtensilios;
INSERT INTO etapasUtensilios(id_Etapas,id_Utensilios)
VALUES 
	(2,1),
	(9,2)
	;


DELETE FROM alergias;
INSERT INTO alergias(FK_utilizador,FK_ingrediente,nome)
VALUES 
	(1,bacalhau,bacalhau)
	;

DELETE FROM classificacaos;
INSERT INTO classificacaos(id_Receita,id_Utilizador,dificuldade,sabor,tempo)
VALUES
	(1,1,3.5,4,64),
	(1,2,2.5,4.4,52),
	(2,1,4,3,20)
	;











