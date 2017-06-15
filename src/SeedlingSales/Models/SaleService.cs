using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.Models
{
    public class SaleService : Sale
    {

        public static decimal GetTotal (IList<Sale> sales)
        {
            decimal total = 0;
            foreach (Sale sale in sales)
            {
                total = sale.Price + total;
            }
            return total;
        }

        public static IList<Sale> ConvertPrice(IList<Sale> Sales)
        {
            foreach (Sale sale in Sales)
            {
                sale.Price = sale.Price * sale.NumberSold;
            }
            return Sales;
        }
    }
}
