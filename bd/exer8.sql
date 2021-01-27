CREATE TABLE tabela_telefone(
  id INT,
  telefone VARCHAR(200),
  pessoa_id INT,
  CONSTRAINT pk_telefone PRIMARY KEY (id),
  CONSTRAINT fk_telefone_pessoa FOREIGN KEY (pessoa_id)
  	REFERENCES tabela_pessoa (id)
)
