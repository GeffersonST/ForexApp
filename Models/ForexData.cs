using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ForexApp.Models
{
    public class ForexData
    {
        [JsonPropertyName("Meta Data")]
        public MetaData? MetaData { get; set; }

        [JsonPropertyName("Time Series FX (Daily)")]
        public Dictionary<string, TimeSeriesData>? TimeSeries { get; set; }
    }

    public class MetaData
    {
        [JsonPropertyName("1. Information")]
        public string? Information { get; set; }

        [JsonPropertyName("2. From Symbol")]
        public string? FromSymbol { get; set; }

        [JsonPropertyName("3. To Symbol")]
        public string? ToSymbol { get; set; }

        [JsonPropertyName("5. Last Refreshed")]
        public string? LastRefreshed { get; set; }

        [JsonPropertyName("6. Time Zone")]
        public string? TimeZone { get; set; }
    }

    public class TimeSeriesData
    {
        [JsonPropertyName("1. open")]
        public string? Open { get; set; }

        [JsonPropertyName("2. high")]
        public string? High { get; set; }

        [JsonPropertyName("3. low")]
        public string? Low { get; set; }

        [JsonPropertyName("4. close")]
        public string? Close { get; set; }

        public decimal OpenAsDecimal
        {
            get
            {
                decimal.TryParse(Open, out var result);
                return result;
            }
        }

        public decimal HighAsDecimal
        {
            get
            {
                decimal.TryParse(High, out var result);
                return result;
            }
        }

        public decimal LowAsDecimal
        {
            get
            {
                decimal.TryParse(Low, out var result);
                return result;
            }
        }

        public decimal CloseAsDecimal
        {
            get
            {
                decimal.TryParse(Close, out var result);
                return result;
            }
        }
    }
}
