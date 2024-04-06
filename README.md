# ForexApp

O ForexApp é uma aplicação web desenvolvida utilizando o framework Blazor, permitindo aos usuários visualizar as cotações diárias de moedas estrangeiras e gerenciar beneficiários. Esta aplicação consome dados da API Alpha Vantage para obter as informações de Forex.

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

1. Clone este repositório para o seu ambiente local:

   git clone https://github.com/seuusuario/forex-app.git

2. Abra o projeto utilizando o Visual Studio ou Visual Studio Code.

3. Execute o aplicativo pressionando F5 ou utilizando o comando `dotnet run` no terminal.

4. Navegue até a página `/home` para visualizar as cotações de Forex.

## Configuração da API Alpha Vantage

Este aplicativo utiliza a API Alpha Vantage para obter as informações de Forex. Para configurar a API, siga as etapas abaixo:

1. Visite o [site da Alpha Vantage](https://www.alphavantage.co/support/#api-key) para se inscrever e obter uma chave de API gratuita.

2. Após obter a chave de API, insira-a no arquivo `appsettings.json` do projeto:
``json
{
  "AlphaVantageApiKey": "SuaChaveDeAPIAqui"
}``

## Limitações
A versão gratuita da API Alpha Vantage possui um limite de 25 requisições por dia. Após atingir esse limite, as atualizações automáticas da tabela serão interrompidas. Recomenda-se subscrever a um plano premium para remover esses limites.

## Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir um pull request ou relatar problemas.

## Autor
[Gefferson Severo]

Licença
Este projeto está licenciado sob a Licença MIT.
