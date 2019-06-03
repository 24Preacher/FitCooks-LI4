
USE FitCooksDB

CREATE TABLE Receita (
  id_Receita INT NOT NULL PRIMARY KEY,
  Descrição VARCHAR(128) NOT NULL,
  tempo FLOAT NOT NULL,
  imagem IMAGE NULL,
  categoria VARCHAR(45) NOT NULL,
  nome VARCHAR(45) NOT NULL,)
GO

GO
CREATE TABLE Etapas (
  id_Etapas INT NOT NULL PRIMARY KEY,
  FK_receita INT NOT NULL,
  intrucao VARCHAR(512) NOT NULL,
  tempo FLOAT NOT NULL,
  sugestão VARCHAR(128) NULL,
CONSTRAINT FK_receita FOREIGN KEY (FK_receita)
    REFERENCES Receita (id_Receita)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
	)
GO 

CREATE TABLE Utilizador (
  id_utilizador INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  username VARCHAR(45) NOT NULL,
  Nome VARCHAR(45) NOT NULL,
  email VARCHAR(45) NOT NULL,
  sexo VARCHAR(45) NULL,
  Data_nascimento DATE NULL,
  password VARCHAR(45) NOT NULL,
  morada VARCHAR(128) NULL,
  )
  GO

  GO
CREATE TABLE Classificacao (
   FK_receita INT NOT NULL,
   FK_utilizador INT NOT NULL,
  PRIMARY KEY (FK_receita,FK_utilizador),
   facilidade FLOAT NOT NULL,
   sabor FLOAT NOT NULL,
   tempo FLOAT NOT NULL,
  CONSTRAINT FK_ClassificaçãoReceita FOREIGN KEY (FK_receita)
    REFERENCES Receita (id_Receita)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT FK_ClassificaçãoUtilizador FOREIGN KEY (FK_utilizador) 
	REFERENCES Utilizador (id_utilizador)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
	)
  GO
   
 
 GO
CREATE TABLE preferencias (
  FK_utilizador INT NOT NULL,
  FK_receita INT NOT NULL,
  PRIMARY KEY (FK_utilizador, FK_receita),
  CONSTRAINT FK_PreferenciasReceita FOREIGN KEY (FK_receita)
    REFERENCES Receita (id_Receita)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT FK_PreferenciasUtilizador FOREIGN KEY (FK_utilizador) 
	REFERENCES Utilizador (id_utilizador)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
 )
 GO

 
GO
CREATE TABLE Ingredientes(
  id_Ingredientes INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  imagem IMAGE,
  descrição VARCHAR(45) NOT NULL,
  preço FLOAT NOT NULL,
  nome VARCHAR(45) NOT NULL,)
GO

GO
CREATE TABLE Utensilios (
  id_Utensilios INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  imagem IMAGE,
  nome VARCHAR(45) NOT NULL,
  descrição VARCHAR(45) NOT NULL,)
  GO

 GO
CREATE TABLE etapas_ingredientes (
  FK_etapa INT NOT NULL,
  FK_ingredientes INT NOT NULL,
  PRIMARY KEY (FK_etapa, FK_ingredientes),
  CONSTRAINT FK_etapa FOREIGN KEY ( FK_etapa )
    REFERENCES Etapas (id_Etapas)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT FK_Etapasingredientes FOREIGN KEY (FK_ingredientes)
    REFERENCES Ingredientes (id_Ingredientes)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,)
GO

GO
CREATE TABLE etapas_utensilios (
  FK_etapa INT NOT NULL,
  FK_utensilios INT NOT NULL,
  PRIMARY KEY (FK_etapa, FK_utensilios),
  CONSTRAINT FK_UtensiliosEtapas FOREIGN KEY (FK_etapa)
    REFERENCES Etapas (id_Etapas)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT FK_UtensiliosUtensilios FOREIGN KEY (FK_utensilios)
    REFERENCES Utensilios ( id_Utensilios)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
GO

GO
CREATE TABLE alergias (
  FK_utilizador INT NOT NULL,
  FK_ingredientes INT NOT NULL,
  nome VARCHAR(45) NOT NULL,
  PRIMARY KEY (FK_utilizador, FK_ingredientes),
  CONSTRAINT FK_Alergiasutilizador FOREIGN KEY (FK_utilizador)
    REFERENCES utilizador ( id_utilizador )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT FK_AlergiasIngredients	FOREIGN KEY ( FK_ingredientes )
    REFERENCES Ingredientes ( id_ingredientes)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,)
GO

GO
CREATE TABLE Nutrientes (
  id_Nutrientes INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  nome VARCHAR(45) NOT NULL,
  valor FLOAT NOT NULL,
  FK_ingrediente INT NOT NULL, 
  CONSTRAINT FK_NutrientesIngrediente FOREIGN KEY (FK_ingrediente)
    REFERENCES Ingredientes (id_ingredientes)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,)
GO



