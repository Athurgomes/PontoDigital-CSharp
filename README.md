# Sistema de Ponto Digital em C\#

Um projeto de console simples em C\# para simular o registro de ponto (entrada e saída) de colaboradores, salvando os dados em um banco de dados local.

## Tecnologias

  * C\# e .NET 9
  * Entity Framework Core
  * SQLite

## Funcionalidades

  * **1. Registrar Ponto:** Salva um novo registro de `Entrada` ou `Saída` para um ID de colaborador. A lógica determina automaticamente se é uma entrada ou saída com base no último registro.
  * **2. Visualizar Registros de Hoje:** Exibe todos os registros de um colaborador para o dia atual.
  * **3. Sair:** Encerra a aplicação.

## Como Executar

**Pré-requisitos:**

  * SDK do .NET 9 (ou superior)
  * Ferramenta `dotnet-ef`

**Passos:**

1.  Clone o repositório:

    ```bash
    git clone https://github.com/athurgomes/pontodigital-csharp.git
    cd pontodigital-csharp
    ```

2.  Restaure os pacotes:

    ```bash
    dotnet restore
    ```

3.  Crie o banco de dados SQLite:

    ```bash
    dotnet ef database update
    ```

    *Isso criará o arquivo `registroPonto.db`.*

4.  Execute o projeto:

    ```bash
    dotnet run
    ```
