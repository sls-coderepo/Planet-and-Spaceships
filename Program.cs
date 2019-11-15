using System;
using System.Collections.Generic;

namespace PlanetAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>()
            {
                "Mercury",
                "Mars"
            };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> planets = new List<string>()
            {
                "Neptune",
                "Uranus"
            };

            planetList.AddRange(planets);
            planetList.Insert(1, "Earth");
            planetList.Insert(2, "Venus");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 8);
            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            planetList.Remove("Pluto");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

        }

    }
}