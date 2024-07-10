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

## Instalação

1. Clone o repositório:
```
git clone https://github.com/eduardorodri/ProjetoCommerSys
```
2. Restaure os pacotes NuGet:
```
dotnet restore
```
3. Aplique as migrações do Entity Framework:
```
dotnet ef database update
```
4. Execute o projeto:
```
dotnet run
```

# Atualize as configurações do banco de dados em appsettings.json conforme necessário. 


