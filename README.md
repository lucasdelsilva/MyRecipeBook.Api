<div align="center">
  <h1>🍽️ Meu Livro de Receitas</h1>
  <p><em>Uma API para quem adora cozinhar e compartilhar receitas</em></p>

  ![badge-dot-net]
  ![badge-visual-studio]
  ![badge-windows]
  ![badge-swagger]
  ![badge-docker]

  ![badge-mysql]
  ![badge-sqlserver]
  ![badge-azure]
  ![badge-azure-devops]
  ![badge-azure-pipelines]

  ![badge-google]
  ![badge-openai]
  ![badge-sonarcloud]
</div>

---

## 📖 Sobre o projeto

O **Meu Livro de Receitas** é uma aplicação desenvolvida para quem adora cozinhar e compartilhar receitas. A plataforma foi projetada para facilitar a organização e o gerenciamento de receitas, tornando a experiência culinária mais prática e agradável.

A solução consiste em uma **API REST** desenvolvida em **.NET**, seguindo os princípios de **Domain-Driven Design (DDD)** e **SOLID**, com uma arquitetura modular e sustentável. Os usuários podem se cadastrar com nome, e-mail e senha e, após o login, criar, editar, filtrar e deletar receitas — podendo incluir título, ingredientes, instruções, tempo de preparo, nível de dificuldade e imagem ilustrativa.

A API oferece suporte para **MySQL** e **SQL Server**, proporcionando flexibilidade na escolha do ambiente. A qualidade é garantida por **testes de unidade e integração**, validação com **FluentValidation**, mapeamento objeto-relacional com **Entity Framework** e análise contínua via **SonarCloud**. Pipelines de **CI/CD** no **Azure DevOps** asseguram entregas consistentes e seguras.

O controle de versões segue a estratégia **GitFlow**, e o gerenciamento do projeto utiliza a metodologia ágil **SCRUM**.

---

## ⚡ Features

| Feature | Descrição |
|---|---|
| 🔐 **Cadastro e Login** | Registro com nome, e-mail e senha, com autenticação via JWT e Refresh Token |
| 🍳 **Gerenciamento de Receitas** | Criação, edição, exclusão e filtro de receitas com título, ingredientes e instruções |
| 🖼️ **Upload de Imagem** | Envio de imagem ilustrativa para cada receita |
| 🤖 **Geração com IA** | Integração com ChatGPT para gerar receitas a partir de ingredientes fornecidos |
| 🔑 **Login com Google** | Autenticação social via conta Google (OAuth 2.0) |
| 📨 **Mensageria** | Exclusão de contas gerenciada via Azure Service Bus (Queue) |

---

## 🏗️ Arquitetura e Boas Práticas

- **Domain-Driven Design (DDD)** — domínio isolado e bem delimitado
- **Princípios SOLID** — código coeso, extensível e de fácil manutenção
- **Injeção de Dependências** — modularidade e testabilidade elevadas
- **FluentValidation** — validação robusta de todas as entradas de dados
- **Entity Framework Core** — mapeamento objeto-relacional e migrações controladas
- **Testes de Unidade e Integração** — cobertura das regras de negócio e fluxos da API
- **JWT & Refresh Token** — autenticação segura e renovação de sessão
- **GitFlow** — organização e controle de versões por branches
- **SCRUM** — metodologia ágil para gerenciamento do projeto

---

## 🛠️ Construído com

![badge-dot-net]
![badge-visual-studio]
![badge-windows]
![badge-swagger]
![badge-docker]
![badge-mysql]
![badge-sqlserver]
![badge-azure]
![badge-azure-devops]
![badge-azure-pipelines]
![badge-google]
![badge-openai]
![badge-sonarcloud]

---

## 🗄️ Banco de Dados

A API suporta dois bancos de dados relacionais, configuráveis via `appsettings.json`:

| Banco | Versão |
|---|---|
| ![badge-mysql] | 8.0+ |
| ![badge-sqlserver] | 2019+ |

As migrações são gerenciadas pelo **Entity Framework Core**, garantindo uma evolução controlada do esquema de dados.

---

## 🚀 Como executar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/)
- [Docker](https://www.docker.com/) *(opcional)*
- MySQL 8.0+ ou SQL Server 2019+

### Passos

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/MyRecipeBook.git

# Acesse a pasta do projeto
cd MyRecipeBook

# Configure o appsettings.json com sua string de conexão
# Execute as migrations
dotnet ef database update

# Inicie a API
dotnet run --project src/MyRecipeBook.Api
```

Acesse a documentação Swagger em: `https://localhost:{porta}/swagger`

---

## 🧪 Testes

```bash
# Executar todos os testes
dotnet test

# Com relatório de cobertura
dotnet test --collect:"XPlat Code Coverage"
```
---

<div align="center">
  <p>Desenvolvido por <strong>Lucas de Lima</strong></p>
</div>

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-mysql]: https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge
[badge-sqlserver]: https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge
[badge-docker]: https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=fff&style=for-the-badge
[badge-azure-devops]: https://img.shields.io/badge/Azure%20DevOps-0078D7?logo=azuredevops&logoColor=fff&style=for-the-badge
[badge-azure]: https://img.shields.io/badge/Microsoft%20Azure-0078D4?logo=microsoftazure&logoColor=fff&style=for-the-badge
[badge-azure-pipelines]: https://img.shields.io/badge/Azure%20Pipelines-2560E0?logo=azurepipelines&logoColor=fff&style=for-the-badge
[badge-google]: https://img.shields.io/badge/Google-4285F4?logo=google&logoColor=fff&style=for-the-badge
[badge-openai]: https://img.shields.io/badge/OpenAI-412991?logo=openai&logoColor=fff&style=for-the-badge
[badge-sonarcloud]: https://img.shields.io/badge/SonarCloud-F3702A?logo=sonarcloud&logoColor=fff&style=for-the-badge
