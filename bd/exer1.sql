SELECT nome, evento
FROM tabela_pessoa tp
LEFT JOIN tabela_evento te ON te.pessoa_id = tp.id
