using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryAndCityWeb.Model
{
    public class Country
    {
        public int Id { set; get; }
        public string CountryName { set; get; }
        public string CountryAbout { set; get; }
        public int SerialNo { set; get; }
        public City aCity { set; get; }
    }
}