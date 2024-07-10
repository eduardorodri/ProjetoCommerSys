# CommerSys

## Descrição
O CommerSys é um sistema de gerenciamento de departamentos de vendas desenvolvido com ASP.NET Core 2.1. O sistema permite cadastrar vendedores, criar novos departamentos de vendas, verificar todas as vendas realizadas e mostrar quanto cada setor vendeu no mês.

## Tecnologias Utilizadas

- ASP.NET Core 2.1

- Bootstrap 3.3.7

- C#
  
- Entity Framework Core
  
- SQL Server
  
## Funcionalidades

- Cadastro de Vendedores: Permite adicionar vendedores com dados completos.
  
- Gerenciamento de Departamentos: Criação e edição de departamentos de vendas.
  
- Relatório de Vendas: Visualização das vendas realizadas por cada vendedor e total por setor.

## Estrutura do Projeto

ProjetoInterdisciplinar/
├── Controllers/
│├── DepartmentsController.cs
│├── HomeController.cs
│├── SalesRecordsController.cs
│├── SellersController.cs
├── Data/
│   ├── ProjetoInterdisciplinarContext.cs
│   ├── SeedingService.cs
├── Migrations/
├── Models/
│   ├── Enums/
│   │   ├── SaleStatus.cs
│   ├── ViewModels/
│   │   ├── ErrorViewModel.cs
│   │   ├── SellerFormViewModel.cs
│   ├── Department.cs
│   ├── SalesRecord.cs
│   ├── Seller.cs
├── Services/
│   ├── Exceptions/
│   │   ├── DbConcurrencyException.cs
│   │   ├── IntegrityException.cs
│   │   ├── NotFoundException.cs
│   ├── DepartmentService.cs
│   ├── SalesRecordService.cs
│   ├── SellerService.cs
├── Views/
│   ├── Departments/
│   ├── Home/
│   ├── SalesRecords/
│   ├── Sellers/
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _ViewImports.cshtml
│   │   ├── _ViewStart.cshtml
├── wwwroot/
│   ├── css/
│   │   ├── bootstrap-paper.css
│   │   ├── site.css
│   │   ├── custom.css
│   ├── js/
│   │   ├── site.js
│   ├── lib/
│   │   ├── bootstrap/
│   │   ├── jquery/
├── appsettings.json
├── Program.cs
├── Startup.cs

## Instalação

1. Clone o repositório:
git clone

2. Restaure os pacotes NuGet:
dotnet restore

3. Atualize as configurações do banco de dados em appsettings.json conforme necessário.

4. Aplique as migrações do Entity Framework:
dotnet ef database update

5. Execute o projeto:
dotnet run


