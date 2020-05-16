using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSystem
{
    class Country : PoliticalDetails
    {
        public int NumberOfStates { get; set; }

        public Country(int numberOfStates)
        {
            NumberOfStates = numberOfStates;
        }
    }
}
