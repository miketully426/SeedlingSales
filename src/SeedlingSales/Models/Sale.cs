using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.Models
{
    public class Sale
    {
        public int TransactionID { get; set; }
        public Plant SoldPlant { get; set; }
        public int SoldPlantID { get; set; }
        public int NumberSold { get; set; }
        public decimal Price { get; set; }
    }
}
