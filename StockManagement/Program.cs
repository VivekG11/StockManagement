using System;
using System.IO;
using Newtonsoft.Json;

namespace StockManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stock Management....!");
            StockFunctions stockFunctions = new StockFunctions();
            string jsonPath = @"C:\Users\VIVEK\source\repos\StockManagement\StockManagement\Stocks.json";
            //read objects from json file
            StocksDetails stock = JsonConvert.DeserializeObject<StocksDetails>(File.ReadAllText(jsonPath));
            Console.WriteLine("Enter a number to select an operation :");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    stockFunctions.Details(stock.StockList);
                    break;
                case 2:
                    stockFunctions.EachShareValue(stock.StockList);
                    break;
                case 3:
                    stockFunctions.TotalShareValue(stock.StockList);
                    break;
                default:
                    Console.WriteLine("Enter a valid Option");
                    break;
            }
            Console.Read();
        }
    }
}
