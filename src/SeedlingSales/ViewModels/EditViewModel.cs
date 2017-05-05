using SeedlingSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedlingSales.ViewModels
{
    public class EditViewModel:AddViewModel
    {
        public Plant Plant { get; set; }
        public int PlantID { get; set; }

    }
}
