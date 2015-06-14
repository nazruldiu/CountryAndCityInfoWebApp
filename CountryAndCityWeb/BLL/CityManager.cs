using CountryAndCityWeb.DAL;
using CountryAndCityWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryAndCityWeb.BLL
{
    public class CityManager
    {
        CityGateway cityGateway = new CityGateway();
        public string SaveCity(City aCity)
        {
            int value = cityGateway.SaveCity(aCity);
            if (value > 0)
            {
                return "City Saved Successfully";
            }
            else
            {
                return "Sorry! saved failed.";
            }
        }
        public List<City> GetAllCityInro()
        {
            return cityGateway.GetAllCityInfo();
        }
        public List<City> SearchByCityName(City nameCity)
        {
            return cityGateway.SearchByCityName(nameCity);
        }
        public bool IfCityNameExists(City aCity)
        {
            return cityGateway.IfCityNameExists(aCity);
        }
    }
}