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
                return ConvertStringToDecimal(Open);
            }
        }

        public decimal HighAsDecimal
        {
            get
            {
                return ConvertStringToDecimal(High);
            }
        }

        public decimal LowAsDecimal
        {
            get
            {
                return ConvertStringToDecimal(Low);
            }
        }

        public decimal CloseAsDecimal
        {
            get
            {
                return ConvertStringToDecimal(Close);
            }
        }

        private decimal ConvertStringToDecimal(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            decimal result;
            if (decimal.TryParse(value, out result))
                return result;
            else
                return 0;
        }
    }
}
