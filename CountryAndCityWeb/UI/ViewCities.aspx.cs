using CountryAndCityWeb.BLL;
using CountryAndCityWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryAndCityWeb.UI
{
    public partial class ViewCities : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        CityManager cityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                countryDropDownList.DataSource = countryManager.GetCountryInfo();
                countryDropDownList.DataTextField = "CountryName";
                countryDropDownList.DataValueField = "Id";
                countryDropDownList.DataBind();
            }
            viewCityGridView.DataSource = cityManager.GetAllCityInro();
            viewCityGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if(cityRadioButton.Checked){
                City aCity = new City();
                aCity.CityName = citiViweTextBox.Text;
                viewCityGridView.DataSource = cityManager.SearchByCityName(aCity);
                viewCityGridView.DataBind();
            }
            if(countryRadioButton.Checked){
                City aCity = new City();
                aCity.UseCountry =int.Parse( countryDropDownList.SelectedValue);
                int id = aCity.UseCountry;
                countryManager.SearchAllCityByCountry(id);

                viewCityGridView.DataSource = countryManager.SearchAllCityByCountry(id);
                viewCityGridView.DataBind();
            }
        }

        protected void onPagging(object sender, GridViewPageEventArgs e)
        {
            viewCityGridView.PageIndex = e.NewPageIndex;
                viewCityGridView.DataBind();
        }
    }
}