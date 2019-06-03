
USE FitCooksDB


INSERT INTO Receita 
		(descricao, tempo, categoria, nome)
VALUES ('O acém pode ser uma carne muito macia, quando bem preparado. Inclua a carne no cardápio nesta receita que acompanha legumes na panela de pressão!',
		50,
		'Jantar',
		'Cozido de acém e legumes')
		;

INSERT INTO Etapas
		(FK_receita, intrucao, tempo, sugestao)
VALUES (1,
		"Tempere a carne com o sal e a pimenta.", 
		2,
		NULL),
		(1,
		"Junte a mostarda e refogue mais um pouco, mexendo sem parar.", 
		3, 
		null),
		(1,
		"Acrescente o caldo de carne, tampe a panela e cozinhe no fogo baixo (160 ºC), por 30 minutos, após o início da pressão.", 
		30, 
		null)
		;