using System.Collections.Generic;
using StockProjectApp.Data;

namespace StockProjectApp
{
    public class CustomerState
    {
        public Customer ClientCustomer { get; set; }

        public Portfolio CurrentPortfolio { get; set; }

        public List<Portfolio> CustomerPortfoliosList { get; set; }

        public Portfolio SelectedPortfolio { get; set; }

        public DateTime SetDate = Convert.ToDateTime("07/01/2022");

        public List<StockHolding> PortHoldings { get; set; }
        public StockInfo SelectedStock { get; set; }
    }
}
