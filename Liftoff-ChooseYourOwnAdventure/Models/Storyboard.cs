using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liftoff_ChooseYourOwnAdventure.Models
{
    public class Storyboard : Game
    {
        public int StoryboardID { get; set; }
        public string Story { get; set; }
        public string Option1 { get; set; }
        public int NextStoryboardID1 { get; set; }
        public string Option2 { get; set; }
        public int NextStoryboardID2 { get; set; }
    }
}
