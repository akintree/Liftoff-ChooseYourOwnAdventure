using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Liftoff_ChooseYourOwnAdventure.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Liftoff_ChooseYourOwnAdventure.Controllers
{
    public class SpookyForestController : Controller
    {
        // GET: /<controller>/
        private readonly GameDbContext context;
        public SpookyForestController(GameDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
