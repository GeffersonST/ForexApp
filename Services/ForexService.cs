using System;
using System.Net.Http;
using System.Net.Http.Json;
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

        public async Task<ForexData?> GetForexDataAsync(string fromSymbol, string toSymbol)
        {
            try
            {
                // Construa a URL da API com os parâmetros fornecidos
                string apiUrl = $"https://www.alphavantage.co/query?function=FX_DAILY&from_symbol={fromSymbol}&to_symbol={toSymbol}&apikey=Y98SAP045936P5WD";

                // Faça a solicitação HTTP para a API
                return await _httpClient.GetFromJsonAsync<ForexData>(apiUrl);
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
