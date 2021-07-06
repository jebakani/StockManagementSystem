using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace StockManagementSystem
{
    class StockPortfolio
    {
        public void ReadInpu()
        {
            StockManager stockManager = new StockManager();
            string filePath = @"C:\Users\HP1\source\repos\StockManagementSystem\StockManagementSystem\Stock.json";
            StockUtility stockUtility = JsonConvert.DeserializeObject<StockUtility>(File.ReadAllText(filePath));
            Console.WriteLine( "Total share value :{0}" ,stockManager.PrintReport(stockUtility.stocksList));
        }
    }
}
