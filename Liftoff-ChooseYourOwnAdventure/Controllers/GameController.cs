using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Liftoff_ChooseYourOwnAdventure.Data;
using Liftoff_ChooseYourOwnAdventure.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Liftoff_ChooseYourOwnAdventure.Controllers
{
    public class GameController : Controller
    {
        // GET: /<controller>/
        private GameDbContext context;
        public GameController(GameDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Game> games = context.Games.ToList();

            return View(games);
        }
    }
}
