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
    public partial class CityEntry : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        CityManager cityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                countryDropDownList.DataSource = countryManager.GetCountryInfo();
                countryDropDownList.DataTextField = "CountryName";
                countryDropDownList.DataValueField = "Id";
                countryDropDownList.DataBind();

                cityGridView.DataSource = cityManager.GetAllCityInro();
                cityGridView.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            City aCity = new City();
            aCity.CityName = cityNameTextBox.Text;
            aCity.CityAbout = Request.Form["edit"];
            aCity.NoOfDwellers =int.Parse( noOfDwellersTextBox.Text);
            aCity.Location = lacationTextBox.Text;
            aCity.Weather = weatrerTextBox.Text;
            
            if(cityManager.IfCityNameExists(aCity)){
                msgCityLabel.Text = "City Name Already Exists!";
                return;
            }
            aCity.UseCountry=int.Parse( countryDropDownList.SelectedValue);

            msgCityLabel.Text = cityManager.SaveCity(aCity);

            cityGridView.DataSource = cityManager.GetAllCityInro();
            cityGridView.DataBind();
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            msgCityLabel.Text = "";
            cityNameTextBox.Text = "";
            lacationTextBox.Text = "";
            noOfDwellersTextBox.Text = "";
            weatrerTextBox.Text = "";
        }
    }
}