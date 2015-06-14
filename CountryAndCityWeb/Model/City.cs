using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryAndCityWeb.Model
{
    public class City
    {
        public string CityName { set; get; }
        public string CityAbout { set; get; }
        public int NoOfDwellers { set; get; }
        public string Location { set; get; }
        public string Weather { set; get; }
        public int UseCountry { set; get; }
        public Country aCountry { set; get; }
        public int SerialNo { set; get; }
        public int TotalDwellers { set; get; }
    }
}