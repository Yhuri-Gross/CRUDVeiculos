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

## Estrutura do Projeto

Abaixo, uma visão geral da estrutura de diretórios do projeto:

├── Controllers │ └── VeiculosController.cs # Controlador responsável pelas rotas da API │ ├── Data │ └── AppDbContext.cs # Contexto de banco de dados utilizando Entity Framework Core │ ├── Models │ └── Veiculo.cs # Modelo da entidade Veículo │ ├── Migrations │ └── * # Arquivos gerados automaticamente pelo Entity Framework para controlar as migrações do banco de dados │ ├── Properties │ └── launchSettings.json # Configurações de execução da aplicação │ ├── appsettings.json # Configurações da aplicação (como a conexão com o banco de dados) ├── CrudVeiculos.csproj # Arquivo de projeto do .NET └── Program.cs # Ponto de entrada da aplicação



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

## Como Executar o Projeto

### 2. Instale as Dependências

Após clonar o repositório, navegue até o diretório do projeto no terminal e execute o seguinte comando para restaurar as dependências do projeto:

```bash
dotnet restore


### 3. Configure o Banco de Dados
O projeto já está configurado para usar o SQLite como banco de dados. A conexão com o banco de dados é definida no arquivo appsettings.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=veiculos.db"
  }
}

O banco de dados será automaticamente criado ao executar as migrações.

### 4. Execute as Migrações
Para criar a estrutura do banco de dados, execute os seguintes comandos para aplicar as migrações do Entity Framework Core:

Isso criará o banco de dados SQLite chamado veiculos.db no diretório do projeto.


```bash
dotnet ef migrations add InitialCreate
dotnet ef database update

### 5. Execute o Projeto
Para iniciar a aplicação, execute o seguinte comando:

```bash
dotnet run

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
Implementar autenticação e autorização para proteger as rotas da API.
Adicionar paginação e ordenação na listagem de veículos.
Implementar testes unitários e de integração para garantir a qualidade do código.