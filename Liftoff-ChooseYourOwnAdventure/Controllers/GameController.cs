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
        private ApplicationDbContext context;
        public GameController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Storyboard> storyboards = context.Storyboards.ToList();
            return View(storyboards);
            
        }

        [HttpPost] 
        public IActionResult Index(int id)
        {
            Storyboard nextPage = context.Storyboards.SingleOrDefault(s => s.ID == id);
            if (nextPage != null)
            {
                return Redirect("Game/StoryPage/" + nextPage.ID);
            }
            return Redirect("/Game");
        }

        [HttpGet]
        public IActionResult StoryPage(int id)
        {
            Storyboard storyboard = context.Storyboards.Single(s => s.ID == id);
            return View(storyboard);
        }
    }
}
