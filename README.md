# Consumer Advice API .NET Console

Aplicação de console em C# que consome a API pública de conselhos [Advice Slip API](https://api.adviceslip.com) e exibe um conselho aleatório no terminal.

## Objetivo

Este projeto demonstra como:

- consumir uma API HTTP em uma aplicação .NET;
- realizar desserialização JSON em objetos tipados;
- utilizar `HttpClient` e `System.Text.Json`;
- exibir dados de resposta em um console.

## Tecnologias

- C#
- .NET 10
- `HttpClient`
- `System.Text.Json`

## Pré-requisitos

Antes de executar o projeto, certifique-se de ter instalado:

- [.NET SDK 10.0](https://dotnet.microsoft.com/download)
- Git

## Estrutura do projeto

```text
consumer-advice-api-net-console/
├── ConsumerAdviceApi.csproj
├── Program.cs
├── Models/
│   └── AdviceSlipResponse.cs
└── README.md
```

## Como executar

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/consumer-advice-api-net-console.git
cd consumer-advice-api-net-console
```

2. Restore os pacotes:

```bash
dotnet restore
```

3. Execute a aplicação:

```bash
dotnet run --project consumer-advice-api-net-console/ConsumerAdviceApi.csproj
```

## Como funciona

A aplicação envia uma requisição GET para a URL:

```text
https://api.adviceslip.com/advice
```

A resposta JSON retorna um objeto com o campo `slip`, contendo um `id` e o texto do conselho em `advice`.

O modelo da resposta é representado pela classe `AdviceSlipResponse` e os dados são convertidos para objetos C# usando `JsonSerializer.Deserialize`.

## Exemplo de saída

```text
Iniciando requisição para obter dados de um conselho:

https://api.adviceslip.com/advice

Conselho de Hoje:
Nunca deixe para amanhã o que você pode fazer hoje.
```

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
