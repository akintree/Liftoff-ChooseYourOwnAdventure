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
            List<Game> games = context.Games.ToList();
            //TODO: retrieve game from the list and pass it into the View
            //the View will display the Story - some text and a list of choices
            //since each View will have a different Story, will I need a different Controller for each page of the game?
            return View(games[0]);
        }

        //TODO: find a way to add items to the Story privately/internally - I don't want the player to be able to do this
        //Would I do this in the Model?
    }
}
