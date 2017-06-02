using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int TransactionID { get; set; }
        public int SoldPlantID { get; set; }
        public int NumberSold { get; set; }
        public decimal Price { get; set; }
        

        public static IList<Sale> ConvertPrice (IList<Sale> Sales)
        {
            foreach(Sale sale in Sales)
            {
                sale.Price = sale.Price * sale.NumberSold;
            }
            return Sales;
        }
    }
}
