using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Liftoff_ChooseYourOwnAdventure.Models;

namespace Liftoff_ChooseYourOwnAdventure.Data
{
    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
