using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public List<Sale> ItemsSold { get; set; }
        public decimal Total { get; set; }

    }
}
