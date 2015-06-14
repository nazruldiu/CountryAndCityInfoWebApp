using CountryAndCityWeb.DAL;
using CountryAndCityWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryAndCityWeb.BLL
{
    public class CountryManager
    {
        CountryGateway countryGateway = new CountryGateway();

        public string SaveCountry(Country aCountry)
        {
            int value = countryGateway.SaveCountry(aCountry);
            if (value > 0)
            {
                return "Country Saved Successfully!";
            }
            else
            {
                return "Sorry! Save Failed!";
            }
        }

        public List<Country> GetCountryInfo()
        {
            return countryGateway.GetCountryInfo();
        }
        public List<City> SearchAllCityByCountry(int id)
        {
           return countryGateway.SearchAllCityInfo(id);
        }
        public List<Country> GetAllCountryInfo()
        {
            return countryGateway.GetAllCountryInformatin();
        }
        public List<Country> SearchAllCountryInformation(Country aCountry)
        {
            return countryGateway.SearchAllCountryInformatin(aCountry);
        }
        public bool IfCountryNameExists(Country aCountry)
        {
            return countryGateway.IfCountryNameExists(aCountry);
        }
        public string CountrySearchNotFound(Country aCountry)
        {
            if (countryGateway.CountrySearchNotFound(aCountry))
            {
                return "";
            }
            else
            {
                return "Search Not Found!";
            }
        }
    }
}