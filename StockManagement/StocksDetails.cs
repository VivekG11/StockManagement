using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    class StocksDetails
    {
        public List<Stocks> StockList { get; set; }

        public class Stocks
        {
            public string stockName { get; set; }
            public int stockPrice { get; set; }
            public int numOfShares { get; set; }
        }
    }
}
