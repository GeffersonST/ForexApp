using System;
using System.Net.Http;
using System.Threading.Tasks;
using ForexApp.Models;

namespace ForexApp.Services
{
    public class ForexService
    {
        private readonly HttpClient _httpClient;

        public ForexService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ForexData?> GetForexDataAsync(string symbol, string interval)
        {
            try
            {
                // Construa a URL da API com os parâmetros fornecidos
                string apiUrl = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={symbol}&interval={interval}&apikey=demo";

                // Faça a solicitação HTTP para a API
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                // Verifique se a solicitação foi bem-sucedida
                response.EnsureSuccessStatusCode();

                // Leia o conteúdo da resposta como uma string
                string responseBody = await response.Content.ReadAsStringAsync();

                // Verifique se o corpo da resposta não é nulo ou vazio
                if (string.IsNullOrEmpty(responseBody))
                {
                    return null;
                }

                // Processar o responseBody conforme necessário para converter em um objeto ForexData

                return null; // Retorne os dados processados, se aplicável
            }
            catch (Exception ex)
            {
                // Manipule quaisquer exceções aqui
                Console.WriteLine($"Erro ao buscar dados forex: {ex.Message}");
                return null;
            }
        }
    }
}
