namespace StockProjectApp.Data
{
    public class StockHolding
    {

        public int FK_Portfolio_ID { get; set; }

        public string Symbol { get; set; }

        public DateTime Purchase_Date { get; set; }

        public decimal Purchase_Price { get; set; }

        public decimal Current_Price { get; set; }

        public int Shares { get; set; }
    }
}
