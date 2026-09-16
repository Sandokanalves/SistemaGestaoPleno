# 🚀 Sistema de Gestão de Produtos

> Aplicação FullStack desenvolvida em **.NET 8.0 Core MVC**, utilizando **Entity Framework Core**, **SQL Server em Docker**, **jQuery/Bootstrap** no front-end, suíte de **Testes Unitários com xUnit** e automação com **CI/CD**.

---

## 📑 Sumário
- [Sobre o Projeto](#-sobre-o-projeto)
- [Arquitetura e Organização](#-arquitetura-e-organização)
- [Tecnologias Utilizadas](#-tecnologias-utilizadas)
- [Requisitos Técnicos Atendidos](#-requisitos-técnicos-atendidos)
- [Como Executar o Projeto](#-como-executar-o-projeto)
- [Testes Unitários](#-testes-unitários)
- [Pipeline de CI/CD](#-pipeline-de-cicd)

---

## ℹ️ Sobre o Projeto

O **Sistema de Gestão de Produtos** foi construído para simular um cenário real de mercado no padrão **FullStack .NET Pleno**. O sistema permite o cadastro, listagem e manipulação de produtos com chamadas assíncronas via AJAX/jQuery sem recarregamento de página, persistindo os dados em uma instância do **SQL Server 2022** rodando isolada dentro de um contêiner **Docker**.

---

## 🏗️ Arquitetura e Organização

A solução segue a **Arquitetura em Camadas (Layered Architecture)** para garantir baixo acoplamento e alta testabilidade:

```text
SistemaGestaoPleno/
├── src/
│   ├── SistemaGestao.Domain/      # Camada de Domínio (Entidades e Regras de Negócio)
│   ├── SistemaGestao.Infra/       # Camada de Infraestrutura (DbContext, Migrations e EF Core)
│   └── SistemaGestao.Web/         # Camada de Apresentação MVC (Controllers, Views, jQuery e CSS)
├── tests/
│   └── SistemaGestao.Tests/       # Testes Unitários automatizados com xUnit
├── docker-compose.yml             # Orquestração do SQL Server no Docker

Requisito da Vaga,Implementação no Projeto
Arquitetura 3 Camadas / MVC,"Separação física em .Domain, .Infra e .Web"
ORM / Entity Framework Core,AppDbContext com mapeamento e Migrations
Banco SQL Server em Container,Execução do SQL Server via docker-compose.yml
Front-end com jQuery & Bootstrap,Interface responsiva consumindo rotas JSON via $.ajax
Testes Unitários,Projeto de testes isolado em tests/SistemaGestao.Tests
DevOps & CI/CD,"Script .gitlab-ci.yml configurado com estágios de build, test e docker"
Versionamento Git,Histórico de commits semânticos e branches configuradas


🚀 Como Executar o Projeto
Pró-requisitos
.NET 8.0 SDK

Docker Desktop rodando

Git

1️⃣ Clonar o Repositório
Bash
git clone [https://github.com/SEU-USUARIO/SistemaGestaoPleno.git](https://github.com/SEU-USUARIO/SistemaGestaoPleno.git)
cd SistemaGestaoPleno
2️⃣ Subir o SQL Server no Docker
Bash
docker compose up -d
Confirme se o container está rodando com docker ps.

3️⃣ Aplicar as Migrations do Entity Framework
Bash
dotnet ef database update --project src/SistemaGestao.Infra --startup-project src/SistemaGestao.Web
4️⃣ Executar a Aplicação Web
Bash
dotnet run --project src/SistemaGestao.Web
Acesse a aplicação no navegador em:
👉 https://localhost:7148/Produto (ou na porta indicada pelo terminal)

🧪 Testes Unitários
Para rodar a suíte de testes automatizados e verificar as regras de negócio:

Bash
dotnet test
