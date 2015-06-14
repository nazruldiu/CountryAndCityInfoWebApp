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
    public partial class ViewCountry : System.Web.UI.Page
    {

        CountryManager countryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            countrySearchGridView.DataSource = countryManager.GetAllCountryInfo();
            countrySearchGridView.DataBind();

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            Country aCountry = new Country();
            aCountry.CountryName = countryNameTextBox.Text;
            if(aCountry.CountryName== ""){
                msgSearchLabel.Text = "";
                return;
            }

            msgSearchLabel.Text = countryManager.CountrySearchNotFound(aCountry);

            countrySearchGridView.DataSource = countryManager.SearchAllCountryInformation(aCountry);
            countrySearchGridView.DataBind();

        }

        protected void onPagging(object sender, GridViewPageEventArgs e)
        {
            countrySearchGridView.PageIndex = e.NewPageIndex;
            countrySearchGridView.DataBind();
        }
    }
}