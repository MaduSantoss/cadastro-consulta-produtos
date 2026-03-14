# 📦 Product Catalog API

API REST desenvolvida como desafio técnico para a vaga de Desenvolvedor(a) Back-End. O sistema gerencia o catálogo de produtos de um e-commerce, permitindo operações de CRUD e upload de imagens.

## 🚀 Tecnologias Utilizadas

* **.NET 8** (C#)
* **PostgreSQL** (Banco de Dados Relacional)
* **Entity Framework Core** (ORM)
* **xUnit** (Testes Unitários)
* **Docker & Docker Compose** (Containerização)
* **GitHub Actions** (CI/CD Pipeline)

## 🏗️ Arquitetura

O projeto foi construído utilizando os princípios de **Clean Code**, **SOLID** e **Arquitetura em Camadas** para garantir separação de responsabilidades:

* `API`: Controllers e configuração de injeção de dependência.
* `Application`: Regras de negócio, Serviços e DTOs.
* `Domain`: Entidades principais e interfaces de repositório.
* `Infrastructure`: Contexto do banco de dados, mapeamento do EF Core e implementação do repositório.

## ⚙️ Como executar o projeto

A forma mais fácil de rodar o projeto é utilizando o **Docker**. Certifique-se de ter o [Docker Desktop](https://www.docker.com/products/docker-desktop) instalado e rodando na sua máquina.

**Passo 1:** Clone este repositório:

```bash
git clone https://github.com/MaduSantoss/cadastro-consulta-produtos.git

```

**Passo 2:** Acesse a pasta do projeto:

```bash
cd SEU_REPOSITORIO

```

**Passo 3:** Suba a aplicação e o banco de dados com o Docker Compose:

```bash
docker-compose up --build -d

```

A API iniciará automaticamente, aplicará as *Migrations* no banco de dados e estará pronta para uso!

* **Acesse o Swagger em:** `http://localhost:8080/swagger`

## 🧪 Como rodar os testes

Para executar a suíte de testes unitários da camada de Domínio, execute na raiz do projeto:

```bash
dotnet test

```

## ✨ Diferenciais Implementados

* ✅ Arquitetura em Camadas.
* ✅ Upload de imagem simulando armazenamento em nuvem (salvo no File System e servido de forma estática).
* ✅ Dockerfile e Docker Compose para execução com um clique.
* ✅ Testes Unitários com xUnit.
* ✅ Pipeline de CI com GitHub Actions.
