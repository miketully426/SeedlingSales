﻿using SeedlingSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.ViewModels
{
    public class SalesViewModel
    {
        public IList<Plant> Plants { get; set; }
        public IList<Sale> Sold { get; set; }
        public int Transaction { get; set; }
        public DateTime SaleDate { get; set; }
        public string SDate { get; set; }
        public decimal Total { get; set; }


    }
}
