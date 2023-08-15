using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryCity
{
    internal class City
    {
        public string Name { get; set; }
        public double Population { get; set; }

        public City(string name, double population)
        {
            Name = name;
            Population = population;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
