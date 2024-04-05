// ForexService.cs
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

        public async Task<ForexData> GetForexDataAsync(string fromSymbol, string toSymbol)
        {
            string apiKey = "6PIAOT6X61UUMOJP";
            string apiUrl = $"https://www.alphavantage.co/query?function=FX_DAILY&from_symbol={fromSymbol}&to_symbol={toSymbol}&apikey={apiKey}";

            try
            {
                return await _httpClient.GetFromJsonAsync<ForexData>(apiUrl);
            }
            catch (Exception ex)
            {
                // Tratar exceções
                Console.WriteLine($"Erro ao obter os dados de forex: {ex.Message}");
                return null;
            }
        }
    }
}
