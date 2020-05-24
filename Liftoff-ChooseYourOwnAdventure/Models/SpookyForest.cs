using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liftoff_ChooseYourOwnAdventure.Models
{
    public class SpookyForest
    {
        public string Story { get; set; }
        public IList<string> Options { get; set; }
    }
}
