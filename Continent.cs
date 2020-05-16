using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSystem
{
    class Continent : PlanetInfo
    {
        public int NumberOfCountries { get; set; }

        public Continent(int numberOfCountries)
        {
            NumberOfCountries = numberOfCountries;
        }
    }
}
