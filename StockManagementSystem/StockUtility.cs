using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    class StockUtility
    {
       public LinkedList<Stock> stocksList { get; set; }


        public class Stock
        {
            public string companyName { get; set; }
            public int numberOfShare { get; set; }
            public int sharePrice { get; set; }
        }
    }
}
