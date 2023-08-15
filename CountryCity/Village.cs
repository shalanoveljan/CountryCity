using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CountryCity
{
    internal class Village
    {
        public string Name { get; set; }
        public double Population { get; set; }

        public Village(string name,double population) 
        {
            Name= name;
            Population= population;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
