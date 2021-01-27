INSERT INTO tabela_evento (id, evento, pessoa_id)
VALUES (5, 'Evento E', (SELECT id FROM tabela_pessoa WHERE nome = 'Lisa Romero'))
