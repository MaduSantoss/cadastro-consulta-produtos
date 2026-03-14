# 📦 Product Catalog API

![.NET 8](https://img.shields.io/badge/.NET_8-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2CA5E0?style=for-the-badge&logo=docker&logoColor=white)
![AWS Ready](https://img.shields.io/badge/AWS_Ready-232F3E?style=for-the-badge&logo=amazon-aws&logoColor=white)

API REST desenvolvida como desafio técnico para a vaga de Desenvolvedor(a) Back-End. O sistema gerencia o catálogo de produtos de um e-commerce, permitindo operações de CRUD e upload de imagens.

## 🧠 Decisões de Arquitetura

O projeto foi construído utilizando os princípios de **Clean Code**, **SOLID** e **Arquitetura em Camadas** para garantir separação de responsabilidades e altíssima testabilidade.

* **Armazenamento de Imagens:** A interface de *storage* foi implementada utilizando o *File System* local para simplificar a avaliação da API isolada via Docker. No entanto, o design em *Clean Architecture* permite que essa camada seja substituída por um *bucket* no **Amazon S3** em ambiente de nuvem, bastando plugar uma nova implementação da interface, sem alterar em nada o domínio da aplicação.
* **Banco de Dados:** Utilização do PostgreSQL via Entity Framework Core, com execução automática de *Migrations* no momento de *startup* do contêiner para facilitar o deploy.

## ⚙️ Como executar o projeto

A forma mais rápida de testar a aplicação é utilizando o **Docker**. Certifique-se de ter o [Docker Desktop](https://www.docker.com/products/docker-desktop) rodando na sua máquina.

**Passo 1:** Clone este repositório:

```bash
git clone https://github.com/MaduSantoss/cadastro-consulta-produtos.git

```

**Passo 2:** Acesse a pasta do projeto:

```bash
cd cadastro-consulta-produtos

```

**Passo 3:** Suba a aplicação e o banco de dados com o Docker Compose:

```bash
docker-compose up --build -d

```

A API iniciará automaticamente, configurará o banco de dados e estará pronta para uso.

* **Acesse o Swagger interativo em:** `http://localhost:8080/swagger`

## 🧪 Como rodar os testes

A suíte de testes unitários foi escrita com **xUnit** cobrindo as regras de negócio do Domínio. Para executá-los, rode o comando abaixo na raiz do projeto:

```bash
dotnet test

```

## ✨ Diferenciais Implementados

* ✅ Arquitetura em Camadas e Injeção de Dependência.
* ✅ Upload de arquivo multipart/form-data.
* ✅ Dockerfile *multi-stage* e Docker Compose.
* ✅ Pipeline de Integração Contínua (CI) com GitHub Actions.
