UPDATE tabela_evento
SET pessoa_id = (SELECT id FROM tabela_pessoa WHERE nome = 'John Doe')
WHERE evento = 'Evento D'
