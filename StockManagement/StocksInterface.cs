using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
        interface IStocks
        {
            void Details(List<StocksDetails.Stocks> stocksList);
            void EachShareValue(List<StocksDetails.Stocks> stocksList);
        void TotalShareValue(List<StocksDetails.Stocks> stocksList);
        }
}
