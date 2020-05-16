using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Earth Info.
            Planet earth = new Planet(5, 93.841, 7) 
            {
                Area = 196940000,
                Name = "Earth",
                Population = 7.594
            };
            Console.WriteLine($"Planet Name: {earth.Name}\nArea: {earth.Area} sq mi\nContinents {earth.Continents}\nTotal population {earth.Population} Billion\nOceans {earth.Ocean}\nDistance from Sun {earth.DistanceFromSun} million mi.");

            Console.WriteLine();
            Console.WriteLine();

            //Continent
            Continent africa = new Continent(54)
            {
                Name = "Africa",
                Population = 1.216,
                Area = 11730000
            };
            Console.WriteLine($"Continent Name: {africa.Name}\nArea: {africa.Area} sq mi\nCountries {africa.NumberOfCountries}\nTotal population {africa.Population} Billion");

            Console.WriteLine();
            Console.WriteLine();

            //Country
            Country us = new Country(50)
            {
                Name = "Unites States of America",
                Capital = "Washington D.C",
                Population = 328.2,
                Area = 2959064.44
            };
            Console.WriteLine($"Country Name: {us.Name}\nCapital: {us.Capital}\nTotal population {us.Population} Million\nState Area {us.Area}");

            Console.WriteLine();
            Console.WriteLine();

            //State
            State mi = new State()
            {
                Name = "Michigan",
                Capital = "Lansing",
                Population = 9.978,
                Area = 96.716
            };

            Console.WriteLine($"State Name: {mi.Name}\nCapital City: {mi.Capital}\nTotal population {mi.Population} Million\nState Area {mi.Area}");



            Console.ReadLine();
        }
    }
}
