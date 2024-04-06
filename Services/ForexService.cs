using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ForexApp.Models;

namespace ForexApp.Services
{
    public class ForexService
    {
        private readonly HttpClient _httpClient;
        private readonly Dictionary<string, ForexData> _cache;

        public ForexService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _cache = new Dictionary<string, ForexData>();
        }

        public async Task<ForexData?> GetForexDataAsync(string fromSymbol, string toSymbol)
        {
            string cacheKey = $"{fromSymbol}_{toSymbol}";

            if (_cache.ContainsKey(cacheKey))
            {
                return _cache[cacheKey];
            }

            try
            {
                string apiUrl = $"https://www.alphavantage.co/query?function=FX_DAILY&from_symbol={fromSymbol}&to_symbol={toSymbol}&apikey=RM1P2EUHGDH8MMG8";

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(responseBody))
                {
                    return null;
                }

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };

                var forexData = JsonSerializer.Deserialize<ForexData>(responseBody, options);

                _cache[cacheKey] = forexData;

                return forexData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar dados forex: {ex.Message}");
                return null;
            }
        }
    }
}
