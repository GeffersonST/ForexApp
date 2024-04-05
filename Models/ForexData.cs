// ForexData.cs
namespace ForexApp.Models
{
    public class ForexData
    {
        public MetaData? MetaData { get; set; }
        public TimeSeriesFx? TimeSeriesFx { get; set; }

        public ForexData(MetaData metaData, TimeSeriesFx timeSeriesFx)
        {
            MetaData = metaData;
            TimeSeriesFx = timeSeriesFx;
        }
    }

    public class MetaData
    {
        public string? Information { get; set; }
        public string? FromSymbol { get; set; }
        public string? ToSymbol { get; set; }
        public string? LastRefreshed { get; set; }
        public string? TimeZone { get; set; }
    }

    public class TimeSeriesFx
    {
        public decimal? Open { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Close { get; set; }
    }
}
