using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeedlingSales.Data;
using SeedlingSales.ViewModels;
using SeedlingSales.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SeedlingSales.Controllers
{
    public class SalesController : Controller
    {

        private readonly PlantDbContext context;

        public SalesController(PlantDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Sales()
        {
            SalesViewModel salesViewModel = new SalesViewModel();
            salesViewModel.Plants = Plant.CheckReady(context.Plants.ToList());
            salesViewModel.SaleDate = DateTime.Now;
            
            return View(salesViewModel);
        }

        public IActionResult Confirm(SalesViewModel salesViewModel)
        {
            salesViewModel.Plants = context.Plants.ToList();
            salesViewModel.Sold = SaleService.ConvertPrice(salesViewModel.Sold);
            salesViewModel.Total = SaleService.GetTotal(salesViewModel.Sold);
            salesViewModel.SaleDate = DateTime.Parse(salesViewModel.SDate);


            return View(salesViewModel);
        }
    }
}
