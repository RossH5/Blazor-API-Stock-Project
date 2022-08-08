namespace StockProjectApp.Data
{
    public class Portfolio
    {
        public int PK_Portfolio_ID { get; set; }

        public int FK_Customer_ID { get; set; }

        public string Portfolio_Name { get; set; }
    }
}
