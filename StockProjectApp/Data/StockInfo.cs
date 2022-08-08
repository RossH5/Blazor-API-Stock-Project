namespace StockProjectApp.Data
{
    public class StockInfo
    {
        public string FK_Symbol { get; set; } = "";

        public DateTime Date { get; set; }

        public decimal Open { get; set; }

        public decimal High { get; set; }

        public decimal Low { get; set; }

        public decimal Close { get; set; }

        public int Volume { get; set; }

        public string FK_Exchange { get; set; } = "";
    }
}
