# ForexApp :chart_with_upwards_trend:

O ForexApp é uma aplicação web desenvolvida utilizando o framework Blazor, permitindo aos usuários visualizar as cotações diárias de moedas estrangeiras e gerenciar beneficiários. Esta aplicação consome dados da API Alpha Vantage para obter as informações de Forex.

![d766ef42187478c022c9c5275b43fa41.png](https://imgtr.ee/images/2024/04/06/d766ef42187478c022c9c5275b43fa41.png)

[![0a80eb1fed352b83ec07c2c0c1a492c0.png](https://imgtr.ee/images/2024/04/06/0a80eb1fed352b83ec07c2c0c1a492c0.png)](https://imgtr.ee/image/IkhAZ5)

## Funcionalidades

- Visualização das cotações diárias de Forex para as moedas GBP, EUR e USD.
- Atualização automática da tabela de cotações ao selecionar diferentes pares de moedas.
- Atualização manual dos dados da tabela através do botão de "Refresh".

## Tecnologias Utilizadas

- ASP.NET Core MVC
- C#
- Razor
- HTML
- CSS
- JavaScript
- BUnit (Testes Unitários)

## Pré-requisitos

Antes de executar o aplicativo, certifique-se de ter o seguinte instalado:

- .NET Core SDK
- Visual Studio ou Visual Studio Code (opcional)

## Instalação

## Explicando para Outras Pessoas

Você pode compartilhar estas instruções com outras pessoas que desejam clonar o seu projeto:

### Passo a Passo:

1. Abra o terminal (ou prompt de comando) no seu sistema operacional.

2. Navegue até o diretório onde deseja clonar o projeto. Por exemplo:
 ```bash
   cd /caminho/do/seu/diretorio
   ```  
   
Execute o comando git clone seguido do URL do seu repositório:

```bash
git clone https://github.com/GeffersonST/ForexApp.git
```
Após a conclusão do clone, você terá uma cópia do projeto ForexApp no seu computador. Navegue até o diretório do projeto para começar a trabalhar:

 ```bash
   cd ForexApp
```

3. Execute o aplicativo pressionando F5 ou utilizando o comando `dotnet run` no terminal.

4. Navegue até a página `/home` para visualizar as cotações de Forex.

## Configuração da API Alpha Vantage

Este aplicativo utiliza a API Alpha Vantage para obter as informações de Forex. Para configurar a API, siga as etapas abaixo:

1. Visite o [site da Alpha Vantage](https://www.alphavantage.co/support/#api-key) para se inscrever e obter uma chave de API gratuita.

2. Após obter a chave de API, insira-a no arquivo `ForexService.cs` do projeto:

```
  apiUrl = $"https://www.alphavantage.co/query?function=FX_DAILY&from_symbol={fromSymbol}&to_symbol={toSymbol}&apikey=SUAKEYAQUI";
   ```

## Limitações

A versão gratuita da API Alpha Vantage possui um limite de 25 requisições por dia. Após atingir esse limite, as atualizações automáticas da tabela serão interrompidas. Recomenda-se subscrever a um plano premium para remover esses limites.

No entanto, para contornar essa limitação, foi implementado um botão que permite aos usuários acessar uma versão estática da tabela. Esta versão estática representa a tabela inteira sem depender das requisições da API. Assim, mesmo quando o limite diário de requisições é atingido, os usuários ainda podem visualizar as informações completas da tabela. 


## Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir um pull request ou relatar problemas.

## Autor

[Gefferson Severo]

Licença
Este projeto está licenciado sob a Licença MIT.
