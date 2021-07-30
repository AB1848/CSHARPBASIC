using System;
using System.Collections.Generic;

namespace LearnCollections
{
    public class Collections
    {
        void LearnList()
        {
            List<byte> ages = new List<byte> { 2, 3 };

            ages.Add(1);
            ages.Add(12);
            ages.Add(255);

            List<Country> countries = new List<Country>();
            countries.Add(new Country());

        }
        public void LearnDictonary()
        {
            Dictionary<string,string> countryCapital = new Dictionary<string, string>
            {
               ["nepal"]="kathmandu"
            };
            foreach (var country in countryCapital)
            {
            Console.WriteLine($"country:{country.Key} Capital city{country.Value}");
            }
        }
    }
    public class Country
    {
        public string Name{get; set;}
    }
}
