using CountryCity;

Country country = new Country("Azerbaijan");
Country country1 = new Country("Turkey");
//country.Cities.Add()
City city = new City("Baku", 300);
City city1 = new City("Sumqayit", 500);
City city2 = new City("Gence", 700);
Village village = new Village("Slovyanka", 150);
Village village1 = new Village("Qosabulaq", 270);
country.Cities.Add(city);
country.Cities.Add(city1);
country.Cities.Add(city2);
country.Villages.Add(village);
country.Villages.Add(village1);
country1.Cities.Add(city);
country1.Cities.Add(city1);
country1.Cities.Add(city2);
country1.Villages.Add(village);
country1.Villages.Add(village1);


Console.WriteLine("total Population :{0} people", country.TotalPopulation(country.Cities,country.Villages));
Console.WriteLine("------------Country--------------");
country.FindAllByPopulation(country.CheckCity, country.CheckVillage, 250, 650);
Console.WriteLine("------------Country1--------------");
country.FindAllByPopulation(country1.CheckCity, country1.CheckVillage, 400, 650);
