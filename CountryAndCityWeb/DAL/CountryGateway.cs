using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using CountryAndCityWeb.Model;


namespace CountryAndCityWeb.DAL
{
    public class CountryGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectiondb"].ConnectionString;

        public int SaveCountry(Country aCountry)
        {
            string query = "INSERT INTO Country_tbl VALUES('"+aCountry.CountryName+"','"+aCountry.CountryAbout+"')";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();

            return rowAffect;
        }

        public List<Country> GetCountryInfo()
        {

            List<Country> countryList = new List<Country>();
            int count = 0;
            string query = "SELECT * FROM Country_tbl";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader =command.ExecuteReader();
            while(reader.Read()){
                Country aCountry = new Country();
                count++;
                aCountry.Id =int.Parse( reader["Id"].ToString());
                aCountry.CountryName=reader["CountryName"].ToString();
                aCountry.CountryAbout=reader["CountryAbout"].ToString();
                aCountry.SerialNo = count;

                countryList.Add(aCountry);
            }
            reader.Close();
            connection.Close();

            return countryList;
        }
        public List<City> SearchAllCityInfo(int CountryId)
        {
            List<City> cityList = new List<City>();
            int count = 0;
            string query = "SELECT * FROM City_tbl WHERE CountryId='"+CountryId+"'";
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

        public Country GetCountryInfo(int id)
        {
            Country aCountry = new Country();

            string query = "SELECT * FROM Country_tbl WHERE Id='" + id + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                aCountry.CountryName = reader["CountryName"].ToString();
                aCountry.CountryAbout = reader["CountryAbout"].ToString();
            }
            reader.Close();
            connection.Close();
            return aCountry;
        }
        public List<Country> GetAllCountryInformatin()
        {
            List<Country> countryList = new List<Country>();
            int serialNo = 0;
            string query = "SELECT * FROM Country_tbl";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Country aCountry = new Country();
                int id= aCountry.Id = int.Parse(reader["Id"].ToString());
                aCountry.CountryName = reader["CountryName"].ToString();
                aCountry.CountryAbout = reader["CountryAbout"].ToString();
                serialNo++;
                aCountry.SerialNo = serialNo;
                City aCity = GetAllCity(id);
                aCountry.aCity = new City();

                aCountry.aCity.SerialNo = aCity.SerialNo;
                aCountry.aCity.TotalDwellers = aCity.TotalDwellers;
                countryList.Add(aCountry);
            }
            reader.Close();
            connection.Close();
            return countryList;
        }
        public City GetAllCity(int id)
        {
            City aCity = new City();
            int count = 0;
            int totalDwellers = 0;
            string query = "SELECT * FROM City_tbl WHERE CountryId='" + id + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                aCity.NoOfDwellers =int.Parse(reader["NoOfDwellers"].ToString());
                totalDwellers += aCity.NoOfDwellers;
                aCity.TotalDwellers = totalDwellers;
                count++;
                aCity.SerialNo = count;
              
            }
            reader.Close();
            connection.Close();
            return aCity;
        }

        public List<Country> SearchAllCountryInformatin(Country myCountry)
        {
            List<Country> countryList = new List<Country>();
            int serialNo = 0;
            string query = "SELECT * FROM Country_tbl WHERE CountryName LIKE '%"+myCountry.CountryName+"%'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Country aCountry = new Country();
                int id = aCountry.Id = int.Parse(reader["Id"].ToString());
                aCountry.CountryName = reader["CountryName"].ToString();
                aCountry.CountryAbout = reader["CountryAbout"].ToString();
                serialNo++;
                aCountry.SerialNo = serialNo;
                City aCity = GetAllCity(id);
                aCountry.aCity = new City();

                aCountry.aCity.SerialNo = aCity.SerialNo;
                aCountry.aCity.TotalDwellers = aCity.TotalDwellers;
                countryList.Add(aCountry);
            }
            reader.Close();
            connection.Close();
            return countryList;
        }
        public bool IfCountryNameExists(Country aCountry)
        {
            string query = "SELECT * FROM Country_tbl WHERE CountryName='"+aCountry.CountryName+"'";
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
        public bool CountrySearchNotFound(Country aCountry)
        {
            string query = "SELECT * FROM Country_tbl WHERE CountryName LIKE '%" + aCountry.CountryName + "%'";
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