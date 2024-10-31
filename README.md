# VendaPesca


Este projeto é um sistema web de vendas de produtos desenvolvido em C# utilizando o padrão arquitetural MVC (Model-View-Controller) no Visual Studio 2022. O sistema permite o cadastro e a gestão de clientes, fornecedores, produtos e vendas.

## Sumário

1. [Funcionalidades](#funcionalidades)
2. [Requisitos](#requisitos)
3. [Estrutura do Projeto](#estrutura-do-projeto)
4. [Instruções de Instalação e Execução](#instruções-de-instalação-e-execução)
5. [Configuração do Banco de Dados](#configuração-do-banco-de-dados)
6. [Descrição das Funcionalidades](#descrição-das-funcionalidades)
7. [Licença](#licença)

---

## Funcionalidades

- **Cadastro de Clientes**: Permite registrar clientes com campos essenciais como Nome, CPF/CNPJ, Endereço, Telefone, E-mail, e Status (Ativo/Inativo).
- **Cadastro de Fornecedores**: Permite cadastrar fornecedores com Nome da Empresa, CNPJ, Endereço, Telefone, e E-mail.
- **Gestão de Produtos**: Cada produto contém Nome, Descrição, Preço, Quantidade em Estoque e Fornecedor associado.
- **Cadastro e Registro de Vendas**: Realiza o registro de vendas associando um cliente e produtos selecionados, gerando automaticamente o valor total da venda e a data de emissão.

## Requisitos

- Visual Studio 2022 (ou superior)
- .NET Core SDK 6.0 (ou superior)
- Banco de Dados SQL Server

## Estrutura do Projeto

O projeto está estruturado em camadas seguindo o padrão MVC:

- **Models**: Contém as classes de modelo que representam as entidades do sistema (Cliente, Fornecedor, Produto, e Venda).
- **Views**: Contém as páginas de visualização responsáveis pela interface com o usuário.
- **Controllers**: Contém os controladores que gerenciam as interações entre o usuário e o sistema, controlando a lógica de negócios e a exibição de dados.
  
### Diretórios Principais

- `/Models`: Modelos do sistema, incluindo classes e suas propriedades para Cliente, Fornecedor, Produto e Venda.
- `/Views`: Views com páginas Razor para as interfaces de cadastro e listagem.
- `/Controllers`: Controladores para manipulação das requisições do usuário, organizados conforme as funcionalidades.
  
---

## Instruções de Instalação e Execução

1. **Clone o Repositório**
   ```bash
   git clone https://github.com/B4g4rini/VendaPesca
   cd vendapesca
   ```

2. **Abra o Projeto no Visual Studio 2022**
   - Abra o Visual Studio 2022 e selecione **"Abrir um projeto ou solução"**.
   - Navegue até o diretório clonado e selecione o arquivo `.sln` do projeto.

3. **Configuração do Banco de Dados**
   - Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.
   - A estrutura do banco de dados pode ser criada utilizando **Code First Migration** (caso o Entity Framework esteja configurado) ou manualmente, seguindo as instruções da seção [Configuração do Banco de Dados](#configuração-do-banco-de-dados).

4. **Restaurar Pacotes NuGet**
   - No Visual Studio, vá até **Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes** e execute:
     ```powershell
     Update-Package
     ```

5. **Compilar e Executar o Projeto**
   - Após a configuração, clique em **"Iniciar Depuração"** (ou pressione `F5`) para executar o projeto.
   - O sistema estará disponível no navegador no endereço `https://localhost:5001` (ou conforme configuração local).

---

## Configuração do Banco de Dados

### Estrutura do Banco

O banco de dados deve conter as tabelas para os seguintes modelos:

- **Clientes**: Campos para `ClienteID`, `Nome`, `CPF/CNPJ`, `Endereço`, `Telefone`, `Email`, `Status`.
- **Fornecedores**: Campos para `FornecedorID`, `NomeEmpresa`, `CNPJ`, `Endereço`, `Telefone`, `Email`.
- **Produtos**: Campos para `ProdutoID`, `Nome`, `Descrição`, `Preço`, `QuantidadeEmEstoque`, `FornecedorID`.
- **Vendas**: Campos para `VendaID`, `ClienteID`, `DataVenda`, `ValorTotal`.
- **ItensVenda**: Tabela de relação para associar produtos às vendas, com `VendaID`, `ProdutoID`, `Quantidade`, e `SubTotal`.

### Conexão com o Banco

No arquivo `appsettings.json`, ajuste a string de conexão conforme o nome da instância do SQL Server e credenciais:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=nome_do_servidor;Database=SistemaDeVendasDB;User Id=usuario;Password=senha;"
  }
}
```

### Aplicar Migrações (caso esteja usando EF Core)

Se estiver usando Entity Framework Core, execute os comandos abaixo no Console do Gerenciador de Pacotes:

```powershell
Add-Migration InitialCreate
Update-Database
```

---


