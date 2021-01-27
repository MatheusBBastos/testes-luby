DELETE FROM tabela_pessoa AS tp
WHERE NOT EXISTS (SELECT * FROM tabela_evento WHERE pessoa_id = tp.id)
