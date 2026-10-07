# consumer-advice-api-net-console

Aplicação Console em C# (.NET) desenvolvida como parte da Lista de Exercícios da disciplina de **Desenvolvimento Web / Usabilidade, Dev. Web, Mobile e Jogos** (Prof. Daniel Henrique Matos de Paiva - Ânima Educação).

## 📋 Descrição da Atividade

A aplicação consome a API pública de conselhos aleatórios (*Advice Slip API*):
- **Endpoint:** `https://api.adviceslip.com/advice`
- **Objetivo:** Fazer uma requisição HTTP do tipo GET, desserializar o JSON retornado e exibir o conselho no console conforme o padrão solicitado.

## 🚀 Como Executar

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado (.NET 8.0 / 10.0 ou superior).

### Passos
1. Abra o terminal na raiz do projeto (`consumer-advice-api-net-console`).
2. Execute o comando:
   ```bash
   dotnet run
   ```

## 🖥️ Exemplo de Saída

```text
Iniciando requisição para obter dados de um conselho:

https://api.adviceslip.com/advice

Conselho de Hoje:
Do not compare yourself with others.
```

## 📁 Estrutura do Projeto

```text
consumer-advice-api-net-console/
├── Models/
│   └── AdviceSlipResponse.cs   # Modelos para desserialização do JSON (AdviceSlipResponse e Slip)
├── ConsumerAdviceApi.csproj     # Arquivo de configuração e dependências do projeto .NET
├── Program.cs                   # Ponto de entrada com requisição HTTP e exibição no console
├── .gitignore                   # Arquivos e pastas ignoradas pelo Git
└── README.md                    # Documentação do projeto
```

## 📤 Instruções para Envio ao GitHub

Para subir este repositório para a sua conta do GitHub:

1. Crie um novo repositório no GitHub com o nome: `consumer-advice-api-net-console`
2. No seu terminal, dentro da pasta do projeto, execute:
   ```bash
   git init
   git add .
   git commit -m "feat: implementa consumo da API Advice Slip via console app"
   git branch -M main
   git remote add origin https://github.com/<SEU_USUARIO>/consumer-advice-api-net-console.git
   git push -u origin main
   ```
