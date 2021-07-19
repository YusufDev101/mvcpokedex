using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDrawer.Helpers
{

    public class Colors
    {
        private Dictionary<string, string> colors;

        public Colors()
        {
            colors = new Dictionary<string, string>
            {
                { "fire", "#FDDFDF" },
                { "grass", "#DEFDE0" },
                { "electric", "#FCF7DE" },
                { "water", "#DEF3FD" },
                { "ground", "#f4e7da" },
                { "rock", "#d5d5d4" },
                { "fairy", "#fceaff" },
                { "poison", "#98d7a5" },
                { "bug", "#f8d5a3" },
                { "dragon", "#97b3e6" },
                { "psychic", "#eaeda1" },
                { "flying", "#F5F5F5" },
                { "fighting", "#FDDFDF" },
                { "normal", "#E6E0D4" },
                { "fire", "#F5F5F5" }
            };

        }
    }
}