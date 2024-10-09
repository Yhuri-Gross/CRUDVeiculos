# CRUD de Veículos

Este projeto é uma aplicação web desenvolvida em ASP.NET Core que implementa operações CRUD (Create, Read, Update, Delete) para gerenciar veículos. Ele utiliza o Entity Framework Core como ORM (Object-Relational Mapper) e um banco de dados SQLite para armazenar os dados dos veículos.

## Funcionalidades

- **Adicionar um veículo**: Permite cadastrar novos veículos com informações como marca, modelo, ano e cor.
- **Listar veículos**: Exibe uma lista de todos os veículos cadastrados.
- **Editar um veículo**: Permite editar as informações de um veículo já cadastrado.
- **Excluir um veículo**: Permite remover um veículo do banco de dados.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para construção de aplicações web.
- **Entity Framework Core**: ORM para mapeamento objeto-relacional e acesso ao banco de dados.
- **SQLite**: Banco de dados utilizado para armazenar os dados da aplicação.
- **Swagger**: Ferramenta para documentação e teste da API.
- **Postman**: Ferramenta para testar as requisições HTTP da API.

## Pré-requisitos

Antes de começar, certifique-se de ter instalado em seu ambiente:

- **.NET SDK 6.0 ou superior**: [Download aqui](https://dotnet.microsoft.com/download)
- **SQLite** (opcional, pois o Entity Framework gerencia o banco automaticamente)

## Como Executar o Projeto

Siga os passos abaixo para rodar o projeto em sua máquina local:

### 1. Clone o Repositório

```bash
git clone https://github.com/seu-usuario/crud-veiculos.git
cd crud-veiculos
```

### 2. Navegue até a pasta do projeto
Entre na pasta do projeto antes de executar qualquer comando do terminal:

```bash
cd CRUDVeiculos
```

Isso é importante, pois todos os comandos abaixo devem ser executados a partir dessa pasta.


### 3. Instale as Dependências

Após clonar o repositório, navegue até o diretório do projeto no terminal e execute o seguinte comando para restaurar as dependências do projeto:

```bash
dotnet restore
```

### 4. Configure o Banco de Dados
O projeto já está configurado para usar o SQLite como banco de dados. 

Migrações: As migrações do Entity Framework Core foram geradas para criar a estrutura do banco de dados. Se você ainda não tem o banco de dados em sua máquina, basta executar o comando abaixo para aplicar as migrações e criar o banco de dados:

```bash
dotnet ef database update
```

Isso irá criar o banco de dados crudveiculos.db em sua máquina, com a estrutura definida pelas migrações.

### 5. Execute o Projeto
Para iniciar a aplicação, execute o seguinte comando:

```bash
dotnet run
```

### 6. Testar a API com o Swagger
Uma vez que a aplicação esteja rodando, você pode acessar o Swagger para testar a API. O Swagger estará disponível na seguinte URL:

http://localhost:5007/swagger/index.html


### 7. Testar a API com o Postman
Você também pode testar as rotas da API usando o Postman. Aqui estão os principais endpoints:

GET /api/veiculos: Lista todos os veículos.
GET /api/veiculos/{id}: Retorna os detalhes de um veículo específico.
POST /api/veiculos: Cadastra um novo veículo.
Exemplo de corpo JSON para cadastrar um veículo:

{
  "marca": "Toyota",
  "modelo": "Corolla",
  "ano": 2020,
  "cor": "Prata"
}

PUT /api/veiculos/{id}: Atualiza um veículo existente.
Exemplo de corpo JSON para atualizar um veículo:

{
  "marca": "Honda",
  "modelo": "Civic",
  "ano": 2019,
  "cor": "Preto"
}

DELETE /api/veiculos/{id}: Remove um veículo do banco de dados.


## Possíveis Melhorias
- **Implementar autenticação e autorização para proteger as rotas da API**.
- **Adicionar paginação e ordenação na listagem de veículos**.
- **Implementar testes unitários e de integração para garantir a qualidade do código**.