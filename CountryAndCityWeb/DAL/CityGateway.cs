using CountryAndCityWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace CountryAndCityWeb.DAL
{
    public class CityGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectiondb"].ConnectionString;

        public int SaveCity(City aCity)
        {
            string query = "INSERT INTO City_tbl VALUES('"+aCity.CityName+"','"+aCity.CityAbout+"','"+aCity.NoOfDwellers+"','"+aCity.Location+"','"+aCity.Weather+"','"+aCity.UseCountry+"')";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;

        }

        public List<City> GetAllCityInfo()
        {
            List<City> cityList = new List<City>();
            int count = 0;
            string query = "SELECT * FROM City_tbl";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader =command.ExecuteReader();
            while (reader.Read())
            {
                City aCity = new City();
                aCity.CityName = reader["CityName"].ToString();
                aCity.CityAbout = reader["CityAbout"].ToString();
                aCity.NoOfDwellers = int.Parse(reader["NoOfDwellers"].ToString());
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                count++;
                aCity.SerialNo = count;
                int id=int.Parse(reader["CountryId"].ToString());

                Country aCountry = GetCountryInfo(id);
                aCity.aCountry = new Country();
                aCity.aCountry.CountryName = aCountry.CountryName;
                aCity.aCountry.CountryAbout = aCountry.CountryAbout;

                cityList.Add(aCity);
            }
            reader.Close();
            connection.Close();
            return cityList;
        }

        public Country GetCountryInfo(int id)
        {
            Country aCountry = new Country();

            string query = "SELECT * FROM Country_tbl WHERE Id='"+id+"'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader =command.ExecuteReader();
            while (reader.Read())
            {
               
                aCountry.CountryName = reader["CountryName"].ToString();
                aCountry.CountryAbout = reader["CountryAbout"].ToString();
            }
            reader.Close();
            connection.Close();
            return aCountry;
        }
        public List<City> SearchByCityName(City nameCity)
        {
            List<City> cityList = new List<City>();
            int count = 0;
            string query = "SELECT * FROM City_tbl WHERE CityName LIKE '%"+nameCity.CityName+"%'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                City aCity = new City();
                aCity.CityName = reader["CityName"].ToString();
                aCity.CityAbout = reader["CityAbout"].ToString();
                aCity.NoOfDwellers = int.Parse(reader["NoOfDwellers"].ToString());
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                count++;
                aCity.SerialNo = count;
                int id = int.Parse(reader["CountryId"].ToString());

                Country aCountry = GetCountryInfo(id);
                aCity.aCountry = new Country();
                aCity.aCountry.CountryName = aCountry.CountryName;
                aCity.aCountry.CountryAbout = aCountry.CountryAbout;

                cityList.Add(aCity);
            }
            reader.Close();
            connection.Close();
            return cityList;
        }
        public bool IfCityNameExists(City aCity)
        {
            string query = "SELECT * FROM City_tbl WHERE CityName='" + aCity.CityName + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}