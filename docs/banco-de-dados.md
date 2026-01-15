Tabelas:

Tabela Loja:
  Id  
  Nome  
  Whatsapp  
  LogoUrl 
  CorPrincipal  
  Ativa 
  DataCriacao 

Tabela Usuario:
  Id 
  LojaId  
  Nome  
  Email  
  SenhaHash  
  Ativo  
  DataCriacao 

Tabela Categoria:
  Id
  LojaId
  Nome
  Ativa
  DataCriacao

Tabela Produto:
  Id
  LojaId
  CategoriaId
  Nome
  Descricao
  Preco
  Estoque
  ImagemUrl
  Ativo
  DataCriacao
