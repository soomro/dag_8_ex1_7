using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Employee : Person
    {
        public int Salary { get; set; }
        private double salary { get; set; }
        private List<Sales> SalesList = new List<Sales>();

        public void AddSale(Sales sale)
        {
            SalesList.Add(sale);
        }

        public void PrintSales()
        {
            foreach (Sales sale in SalesList)
            {
                Console.WriteLine(sale.ToString());
            }
        }
    }
}
