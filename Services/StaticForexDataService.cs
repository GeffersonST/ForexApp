using ForexApp.Models;

namespace ForexApp.Services
{
    public static class StaticForexDataService
    {
        public static ForexData GetStaticForexData()
        {
            var metaData = new MetaData
            {
                Information = "Forex Daily Prices (open, high, low, close)",
                FromSymbol = "EUR",
                ToSymbol = "USD",
                LastRefreshed = "2024-04-05 21:05:00",
                TimeZone = "UTC"
            };

            var timeSeriesFx = new TimeSeriesFx
            {
                Open = 1.08379m,
                High = 1.08480m,
                Low = 1.07912m,
                Close = 1.08360m
            };

            return new ForexData(metaData, timeSeriesFx);
        }
    }
}
