using StockProjectApp.Data;

namespace StockProjectApp.Services
{
    public class StockInfoService : IStockInfoService
    {
        private readonly HttpClient http;
        public StockInfoService(HttpClient http)
        {
            this.http = http;
        }

        //public async Task<IEnumerable<StockInfo> GetStocks(string symbol)
        //{
        //    return await http.GetFromJsonAsync<List<StockInfo>>("https://localhost:7099/" + symbol);
        //}
    }
}
