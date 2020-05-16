using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSystem
{
    class Planet : PlanetInfo
    {
        public int Ocean { get; set; }
        public double DistanceFromSun { get; set; }
        public int Continents { get; set; }

        public Planet(int ocean, double distanceFromSun, int continents)
        {
            Ocean = ocean;
            DistanceFromSun = distanceFromSun;
            Continents = continents;
        }
    }
}
