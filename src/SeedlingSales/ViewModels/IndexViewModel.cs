﻿using SeedlingSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.ViewModels
{
    public class IndexViewModel:AddViewModel
    {
        public IList<Plant> Plants { get; set; }

    }
}
