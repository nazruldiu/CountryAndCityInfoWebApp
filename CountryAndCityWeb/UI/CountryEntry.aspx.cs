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
    public partial class CountryEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            countryGridView.DataSource = countryManager.GetCountryInfo();
            countryGridView.DataBind();
        }

        CountryManager countryManager = new CountryManager();

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Country aCountry = new Country();
            aCountry.CountryName = countryNameTextBox.Text;
            aCountry.CountryAbout=Request.Form["edit"];
            if(aCountry.CountryName==""|| aCountry.CountryAbout==""){
                msgLabel.Text = "Please fill the taxt field carefully!";
                return;
            }
            if(countryManager.IfCountryNameExists(aCountry)){
                msgLabel.Text = "Country Name Already Exists!";
                return;
            }
            msgLabel.Text = countryManager.SaveCountry(aCountry);

            countryGridView.DataSource = countryManager.GetCountryInfo();
            countryGridView.DataBind();
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            countryNameTextBox.Text = "";
            msgLabel.Text = "";
            
        }
    }
}