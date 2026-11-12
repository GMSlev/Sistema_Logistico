# 🚚 Sistema Logístico (LogísticaPro)

Aplicação web de gestão de logística e estoque desenvolvida com **ASP.NET Core Razor Pages** e **Entity Framework Core**. O sistema centraliza o cadastro de produtos, fornecedores, pedidos e entregas, e traz um dashboard com indicadores gerenciais e alerta de estoque crítico.

## ✨ Funcionalidades

- **Dashboard** com totais de produtos, fornecedores, pedidos, entregas e quantidade de produtos em estoque crítico.
- **Produtos**: CRUD completo (nome, categoria, quantidade em estoque e preço).
- **Fornecedores**: CRUD completo (nome, telefone e e-mail).
- **Pedidos**: CRUD completo (cliente, data, status, valor total e observações).
- **Entregas**: CRUD completo (destino, data, status, motorista e veículo).
- **Relatório gerencial** com os totais do sistema e o número de produtos com estoque crítico (menos de 10 unidades).
- Validação de formulários no servidor e no cliente (Data Annotations + jQuery Validation).
- Interface responsiva com menu lateral, usando Bootstrap e Font Awesome.

### Status utilizados

| Entidade | Valores |
|----------|---------|
| Pedido   | Pendente, Processando, Enviado, Entregue |
| Entrega  | Em Transporte (padrão) |

## 🛠️ Tecnologias

- [.NET 8](https://dotnet.microsoft.com/) / ASP.NET Core Razor Pages
- Entity Framework Core 8 (Code First + Migrations)
- SQL Server (LocalDB por padrão)
- Bootstrap, jQuery e jQuery Validation
- Font Awesome 6 (via CDN)

## 🗂️ Estrutura do projeto

```
Sistema_Logistico/
├── Data/
│   └── AppDbContext.cs          # Contexto do EF Core (DbSets)
├── Migrations/                  # Migrations do banco de dados
├── Models/
│   ├── Produtos.cs              # Produto
│   ├── Fornecedores.cs          # Fornecedor
│   ├── Pedido.cs                # Pedido
│   └── Entrega.cs               # Entrega
├── Pages/
│   ├── Index.cshtml             # Dashboard
│   ├── ProdutoPages/            # CRUD de produtos
│   ├── FornecedorPages/         # CRUD de fornecedores
│   ├── PedidoPages/             # CRUD de pedidos
│   ├── EntregaPages/            # CRUD de entregas
│   ├── Relatorios/              # Relatório gerencial
│   └── Shared/                  # Layout e partials
├── wwwroot/                     # CSS, JS e bibliotecas estáticas
├── appsettings.json             # Configuração e string de conexão
└── Program.cs                   # Configuração da aplicação
```

## 🗃️ Modelo de dados

| Entidade   | Campos |
|------------|--------|
| **Produto**    | Id, Nome, Categoria, QuantidadeEstoque, Preco |
| **Fornecedor** | Id, Nome, Telefone, Email |
| **Pedido**     | Id, Cliente, DataPedido, Status, ValorTotal, Observacao |
| **Entrega**    | Id, Destino, DataEntrega, Status, Motorista, Veiculo |

## ✅ Pré-requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server ou SQL Server LocalDB (instalado junto com o Visual Studio no Windows)
- Ferramenta do EF Core:
  ```bash
  dotnet tool install --global dotnet-ef
  ```

## 🚀 Como executar

1. **Clone o repositório**
   ```bash
   git clone https://github.com/<seu-usuario>/Sistema_Logistico.git
   cd Sistema_Logistico
   ```

2. **Configure a string de conexão** em `appsettings.json` (a chave usada pela aplicação é `DefaultConnection`):
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=SistemaLogisticoDB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```
   Se usar uma instância de SQL Server própria, ajuste o servidor e as credenciais.

3. **Restaure os pacotes**
   ```bash
   dotnet restore
   ```

4. **Crie o banco de dados** aplicando as migrations
   ```bash
   dotnet ef database update
   ```

5. **Execute a aplicação**
   ```bash
   dotnet run
   ```

6. Acesse em `https://localhost:7060` ou `http://localhost:5244`.

## 🔮 Melhorias futuras

- Autenticação e perfis de usuário (hoje o sistema não possui login).
- Relacionar pedidos, produtos, fornecedores e entregas por chaves estrangeiras.
- Filtros e paginação nas listagens.
- Gráficos no dashboard e exportação de relatórios.
