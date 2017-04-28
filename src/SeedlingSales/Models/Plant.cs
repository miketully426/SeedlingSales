using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.Models
{
    public class Plant
    {
        public int PlantID { get; set; }
        public string Name { get; set; }
        public int Seeded { get; set; }
        public int Ready { get; set; }
        public decimal Price { get; set; }

    }
}
