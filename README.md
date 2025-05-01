# MotosApi - API REST para Gerenciamento de Motos

Esta API foi criada para gerenciar informações de motos. Ela fornece um endpoint para listar e adicionar motos.

## Tecnologias Utilizadas

- **.NET 8** (ASP.NET Core)
- **Swagger** para documentação e teste da API

## Funcionalidades

1. **GET** `/api/motos`: Retorna a lista de motos cadastradas.
2. **POST** `/api/motos`: Permite adicionar uma nova moto na lista.

## Workflow utilizado: GitHub Flow

Optei por usar o **GitHub Flow** por ser um fluxo de trabalho simples, direto e adequado para projetos com deploys frequentes na branch principal.  
O processo foi:

1. Criar a rota GET diretamente na branch `main` e em seguida o README.
2. Criar uma branch feature (`feat`) a partir da `main`.
3. Desenvolver a rota `POST`.
4. Abrir Pull Request e fazer o merge para a `main` após revisão.
5. Atualizar o README com o resumo do fluxo adotado.

## Como executar

### Requisitos
- .NET 8 SDK ou superior instalado

### Passos

```bash
git clone https://github.com/Ian-Pessoa/MotosApi.git
cd MotosApi
dotnet run
