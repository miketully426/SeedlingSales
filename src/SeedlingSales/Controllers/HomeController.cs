using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeedlingSales.Models;
using SeedlingSales.ViewModels;
using SeedlingSales.Data;
using Microsoft.EntityFrameworkCore;

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
            IndexViewModel homeViewModel = new IndexViewModel();
            homeViewModel.Plants = context.Plants.ToList();
            
            return View(homeViewModel);
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

        [HttpPost]
        public IActionResult Remove(int plantid)
        {
            Plant thePlant = context.Plants.Single(p => p.PlantID == plantid);
            return View(thePlant);
        }

        [HttpPost]
        public IActionResult RemovePlant (int removeplant)
        {
            Plant thePlant = context.Plants.Single(p => p.PlantID == removeplant);
            context.Plants.Remove(thePlant);
            context.SaveChanges();
            return Redirect("/");
        }

        [HttpPost]
        public IActionResult Edit(int plantid)
        {
            Plant thePlant = context.Plants.Single(p => p.PlantID == plantid);
            EditViewModel editViewModel = new EditViewModel
            {
                Plant = thePlant
            };

            return View(editViewModel);
        }

        [HttpPost]
        public IActionResult EditPlant(EditViewModel editViewModel)
        {
            Plant toUpdate = context.Plants.Single(p => p.PlantID == editViewModel.PlantID);
            toUpdate.Name = editViewModel.Name;
            toUpdate.Seeded = editViewModel.Seeded;
            toUpdate.Ready = editViewModel.Ready;
            toUpdate.Price = editViewModel.Price;

            context.SaveChanges();
            return Redirect("/");

        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
