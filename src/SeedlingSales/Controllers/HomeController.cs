using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeedlingSales.Models;
using SeedlingSales.ViewModels;
using SeedlingSales.Data;

namespace SeedlingSales.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly PlantDbContext context;

        public HomeController(PlantDbContext dbContext)
        {
            context = dbContext;
        }
        

        public IActionResult Index()
        {
            
            
            return View();
        }

        public IActionResult Add()
        {
            AddViewModel viewModel = new AddViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(AddViewModel newPlant)
        {
            Plant addPlant = new Models.Plant
            {
                Name = newPlant.Name,
                Seeded = newPlant.Seeded,
                Ready = newPlant.Ready,
                Price = newPlant.Price
                
            };
            context.Plants.Add(addPlant);
            context.SaveChanges();



            return Redirect("/");
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
