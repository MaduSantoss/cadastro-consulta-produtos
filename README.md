# 📦 Product Catalog API

![.NET 8](https://img.shields.io/badge/.NET_8-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2CA5E0?style=for-the-badge&logo=docker&logoColor=white)
![xUnit](https://img.shields.io/badge/xUnit-Test_Coverage-success?style=for-the-badge)
![CI/CD](https://img.shields.io/badge/GitHub_Actions-CI-2088FF?style=for-the-badge&logo=github-actions&logoColor=white)

API REST desenvolvida como desafio técnico para gerenciamento de um catálogo de produtos de e-commerce. O sistema permite o ciclo completo de vida do produto (CRUD), consultas com múltiplos filtros dinâmicos e upload de imagens.

---

## ✨ Diferenciais e Destaques Técnicos

Este projeto não se limitou apenas aos requisitos obrigatórios. Para demonstrar proficiência em práticas modernas de desenvolvimento, foram implementados os seguintes diferenciais:

* 🏆 **Arquitetura Desacoplada:** Utilização de **Clean Architecture** e princípios **SOLID** (com separação clara entre Domain, Application, Infrastructure e API).
* 🏆 **Qualidade e Segurança:** Cobertura de testes unitários na camada de Domínio utilizando **xUnit**.
* 🏆 **DevOps & CI/CD:** Pipeline de Integração Contínua configurado via **GitHub Actions** para rodar os testes a cada commit, além de containerização completa com **Docker** e **Docker Compose**.
* 🏆 **Design Orientado à Nuvem:** O upload de imagens foi implementado no *File System* local para facilitar a avaliação, mas a interface de *storage* foi desenhada visando a substituição nativa por um serviço de nuvem (como Amazon S3), refletindo as melhores práticas de desenvolvimento cloud-native.

---

## ✅ Funcionalidades Implementadas

- [x] Cadastro de novos produtos (`POST /api/Products`).
- [x] Atualização de produtos existentes (`PUT /api/Products/{id}`).
- [x] Inativação/Exclusão lógica de produtos (`DELETE /api/Products/{id}`).
- [x] Upload de imagens vinculado ao produto (`POST /api/Products/{id}/image`).
- [x] Consulta de produtos com filtros combináveis (`GET /api/Products`):
  - Por **Categoria** (ex: *Eletrônicos*).
  - Por **Faixa de Preço** (*minPrice* e *maxPrice*).
  - Por **Status** (*Ativo/Inativo*).

---

## ⚙️ Como executar o projeto (Passo a Passo Detalhado)

Para garantir que a avaliação seja rápida e sem a necessidade de instalar dependências complexas (como SDKs do .NET ou o banco de dados PostgreSQL), o projeto foi totalmente preparado para rodar via contêineres.

### 📌 Pré-requisitos
* Ter o **Git** instalado.
* Ter o **[Docker Desktop](https://www.docker.com/products/docker-desktop)** instalado e em execução na sua máquina.

### 🚀 Rodando a Aplicação

**1. Clone o repositório**
```bash
git clone https://github.com/MaduSantoss/cadastro-consulta-produtos.git

```

**2. Acesse a pasta do projeto**

```bash
cd cadastro-consulta-produtos

```

**3. Suba o ambiente com o Docker**
O comando abaixo irá baixar as imagens necessárias, compilar a API, inicializar o PostgreSQL e rodar as *Migrations* do Entity Framework automaticamente:

```bash
docker-compose up --build -d

```

**4. Acesse a Documentação Viva (Swagger)**
Com os contêineres em execução, digite a URL abaixo na aba de pesquisa do seu navegador para visualizar e testar todos os endpoints:
👉 **[http://localhost:8080/swagger]**

**5. (Opcional) Acesso Direto ao Banco de Dados**
Para consultas diretas, o PostgreSQL está acessível com as seguintes credenciais locais:

* **Host:** `localhost` | **Porta:** `5432` | **Database:** `ProductCatalogDb`
* **Username:** `admin` | **Password:** `adminpassword`

**6. Encerrando o ambiente**
Após a avaliação, você pode desligar e remover os contêineres com o comando:

```bash
docker-compose down -v

```

---

## 🧪 Como rodar os Testes Unitários

Caso queira executar a suíte de testes do projeto isoladamente na sua máquina, utilize o comando abaixo na raiz do diretório:

```bash
dotnet test

```
