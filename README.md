# 🚀 Projeto .NET 9 - Minimal API com SQLite e Entity Framework

Um projeto moderno usando as últimas tecnologias da plataforma .NET!

---

## 📌 Tecnologias Utilizadas

- ⚡ **.NET 9** - A mais recente versão do framework
- 🌐 **Minimal APIs** - Para criar APIs de forma simples e eficiente
- 🗃️ **SQLite** - Banco de dados leve e embarcado
- 🔄 **Entity Framework Core** - ORM para acesso a dados

---

## 📋 Pré-requisitos

- .NET SDK 9

---

## 🚀 Como Executar

Clone o repositório:

```bash
    git clone https://github.com/dev-azevedo/minimal-api-dotnet-9.git
    cd minimal-api-dotnet-9
```
## Restaure as dependências:
```bash
    dotnet restore
```
## Execute as migrations:
```bash
    dotnet ef database update
```

## Inicie a aplicação:

```bash
    dotnet run
```

## 📂 Estrutura do Projeto

📦 Projeto.NET9
```
├── 📂 Models                # Entidades do domínio
├── 📂 Data                  # Contexto do EF e configurações
├── 📂 Migrations            # Migrações do banco de dados
├── 📂 Routes                # Definições das rotas
├── appsettings.json         # Configurações da aplicação
└── Program.cs              # Ponto de entrada da aplicação
```

### Feito com por ✌🏼 Jhonatan Azevedo | [🔗 LinkedIn](https://www.linkedin.com/in/dev-azevedo/) | [🐱 GitHub](https://github.com/dev-azevedo)