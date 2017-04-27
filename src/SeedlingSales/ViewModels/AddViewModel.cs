using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.ViewModels
{
    public class AddViewModel
    {
        public string Name { get; set; }
        public int Seeded { get; set; }
        public int Ready { get; set; }
        public decimal Price { get; set; }

    }
}
