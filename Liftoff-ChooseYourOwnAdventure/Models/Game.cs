using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liftoff_ChooseYourOwnAdventure.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FirstStoryBoardID { get; set; }
    }
}
