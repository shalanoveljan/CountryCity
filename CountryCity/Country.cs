using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryCity
{
    internal class  Country
    {
        public string Name { get; set; }
        public  List<City> Cities { get; set; }
        public List<Village> Villages { get; set; }

        public Country(string name) 
        {
           
            Name = name;
            Cities = new List<City>();
            Villages = new List<Village>();
        }

        

        
        public double TotalPopulation(List<City> cities, List<Village> villages) 
        {
            double CitiesPopulation = 0;
            double VillagesPopulation = 0;

            foreach (City city in cities)
            {
                CitiesPopulation = CitiesPopulation + city.Population;
            }
            foreach (Village village in villages)
            {
                VillagesPopulation = VillagesPopulation + village.Population;
            }
            double CountryPopulation = CitiesPopulation + VillagesPopulation;
            return CountryPopulation;

        }

       public delegate bool CityDelegate(City city,int min, int max);
        public delegate bool VillageDelegate(Village village,int min , int max);
        public void FindAllByPopulation(CityDelegate citydelegate,VillageDelegate villageDelegate,int min , int max )
        {
            foreach (City city in Cities)
            {
                if (citydelegate(city,min,max))
                {
                    Console.WriteLine(city);
                }
            }
            foreach (Village village in Villages)
            {
                if (villageDelegate(village,min,max))
                    Console.WriteLine(village);
            }


        }

        public bool CheckCity(City city,int min,int max)
        {
            
           
            if (city.Population > min && city.Population < max)
            {
                return true;
            }
                   return false;
            
        }

        public bool CheckVillage(Village village, int min, int max)
        {

            if (village.Population > min && village.Population < max)
            {
                return true;
            }
            return false;
        }





    }
}
