// ForexData.cs
namespace ForexApp.Models
{
    public class ForexData
    {
        public MetaData MetaData { get; set; }
        public TimeSeriesFx TimeSeriesFx { get; set; }
    }

    public class MetaData
    {
        public string Information { get; set; }
        public string FromSymbol { get; set; }
        public string ToSymbol { get; set; }
        public string LastRefreshed { get; set; }
        public string TimeZone { get; set; }
    }

    public class TimeSeriesFx
    {
        // Implemente propriedades para os dados de preços diários (open, high, low, close)
    }
}
