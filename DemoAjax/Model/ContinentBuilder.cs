using System.Collections.Generic;

namespace DemoAjax.Model
{
    public class ContinentBuilder
    {
        #region Continents
        public ContinentViewModel Continents()
        {
            ContinentViewModel vm = new ContinentViewModel();

            List<Continent> continents = new List<Continent>();

            Continent continent = new Continent();
            continent.Id = 1;
            continent.Name = "Europe";
            continents.Add(continent);

            continent = new Continent();
            continent.Id = 2;
            continent.Name = "Asie";
            continents.Add(continent);

            continent = new Continent();
            continent.Id = 3;
            continent.Name = "Afrique";
            continents.Add(continent);

            vm.Continents = continents;
            return vm;
        }
        #endregion

        public List<Country> Countries(int continentId)
        {
            List<Country> countries = new List<Country>();

            Country country = new Country();
    
            if (continentId == 1)
            {
                country = new Country();
                country.ContinentId = continentId;
                country.Id = 1;
                country.Name = "France";
                countries.Add(country);

                country = new Country();
                country.ContinentId = continentId;
                country.Id = 2;
                country.Name = "Italie";
                countries.Add(country);
            }

            if (continentId == 2)
            {
                country = new Country();
                country.ContinentId = continentId;
                country.Id = 3;
                country.Name = "Chine";
                countries.Add(country);

                country = new Country();
                country.ContinentId = continentId;
                country.Id = 4;
                country.Name = "Japon";
                countries.Add(country);
            }

            if (continentId == 3)
            {
                country = new Country();
                country.ContinentId = continentId;
                country.Id = 5;
                country.Name = "Tunisie";
                countries.Add(country);

                country = new Country();
                country.ContinentId = continentId;
                country.Id = 6;
                country.Name = "Egypte";
                countries.Add(country);
            }

            return countries;
        }
    }
}