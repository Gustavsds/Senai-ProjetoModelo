CREATE TABLE funcionario 
( 
  id int NOT NULL AUTO_INCREMENT,
  nome_completo varchar(250) NOT NULL,
  data_nascimento datetime NOT NULL,  
  sexo tinyint NOT NULL,
  cpf varchar(14) NOT NULL,
  nacionalidade int,
  naturalidade int,
  email varchar(150) NOT NULL,
  telefone varchar(14) NOT NULL,
  telefone_contato varchar(14),
  cep varchar(9) NOT NULL,
  logradouro varchar(150) NOT NULL,
  numero_endereco int NOT NULL,
  complemento varchar(250),
  bairro varchar(100) NOT NULL,
  municipio varchar(100) NOT NULL,
  uf varchar(2) NOT NULL,
    CONSTRAINT pk_nacionalidade_id PRIMARY KEY (id),
    FOREIGN KEY (nacionalidade) REFERENCES nacionalidade (id),
    FOREIGN KEY (naturalidade) REFERENCES naturalidade (id)
);