# MVC Project - API de Gerenciamento de Clientes

## 📋 Visão Geral
API RESTful desenvolvida em .NET 8 seguindo o padrão de arquitetura MVC (Model-View-Controller). Esta aplicação fornece operações CRUD básicas para gerenciamento de clientes, utilizando um repositório em memória.

## 🏗️ Estrutura do Projeto

```
MVC_Project/
├── Controllers/
│   └── ClientController.cs      # Controlador de clientes
├── Models/
│   ├── Client/
│   │   └── Client.cs           # Modelo de cliente
│   └── Repository/
│       ├── IClientRepository.cs # Interface do repositório
│       └── ClientRepository.cs  # Implementação do repositório (memória)
├── Service/
│   └── ClientService.cs        # Camada de serviço
├── Properties/
├── Program.cs                   # Configuração da aplicação
└── appsettings.json             # Configurações
```

## 🚀 Como Executar

### Pré-requisitos
- .NET 8.0 SDK

### Passos

1. Execute a aplicação:
   ```bash
   dotnet run --project MVC_Project
   ```

2. Acesse o swagger:
   ```
   https://localhost:5000/swagger/index.html
   ```

## 📚 Endpoints da API

| Método | Endpoint | Descrição |
|--------|----------|------------|
| GET    | /api/Client | Listar todos os clientes |
| GET    | /api/Client/{id} | Obter cliente por ID |
| GET    | /api/Client/name/{name} | Buscar clientes por nome |
| POST   | /api/Client | Criar novo cliente |
| PUT    | /api/Client/{id} | Atualizar cliente existente |
| DELETE | /api/Client/{id} | Excluir cliente |
| GET    | /api/Client/count | Contar total de clientes |

### Exemplo de JSON para criar/atualizar cliente:
```json
{
  "name": "Nome do Cliente",
  "email": "cliente@exemplo.com"
}
```

## 🛠️ Tecnologias e Padrões
- **.NET 8.0**
- **MVC Architecture**
- **Repository Pattern**
- **Dependency Injection**
- **Swagger/OpenAPI**