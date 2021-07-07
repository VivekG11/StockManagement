using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagement
{
    class StockFunctions: IStocks
    {
        public void Details(List<StocksDetails.Stocks> stocksList)
        {
            Console.WriteLine("The stock details are :");
            foreach(StocksDetails.Stocks i in stocksList)
            {
                Console.WriteLine("Stock Name :"+i.stockName);
                Console.WriteLine("Stock price :"+i.stockPrice);
                Console.WriteLine("Number of Shares :"+i.numOfShares);

            }
        }
        public void EachShareValue(List<StocksDetails.Stocks> stocksList)
        {
            int value = 0;
            foreach(StocksDetails.Stocks i in  stocksList)
            {
                value = i.numOfShares * i.stockPrice;
                Console.WriteLine($"Stock price for {i.stockName} is {i.stockPrice}");
            }
        }
        public void TotalShareValue(List<StocksDetails.Stocks> stocks)
        {
            int totalValue = 0;
            foreach(StocksDetails.Stocks i in stocks)
            {
                totalValue += i.numOfShares * i.stockPrice;
            }
            Console.WriteLine("Total Share Value is :"+totalValue);
        }
        
    }
}
