using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ConnectionString = @"SERVER = .\SQLEXPRESS; Database = CityInfoDB; Integrated Security = True ";

        public bool UpdateMode = false;

        public bool SearchByCity = false;
        public bool SearchByCountry = false;

        public string CityName;
        City aCity = new City();

        private void saveButton_Click(object sender, EventArgs e)
        {
            aCity.cityName = nameTextBox.Text;
            aCity.cityAbout = aboutTextBox.Text;
            aCity.country = countryTextBox.Text;



            if (UpdateMode)
            {
                SqlConnection Connection = new SqlConnection(ConnectionString);

                string query = "UPDATE CityTable SET About='" + aCity.cityAbout + "',Country='"+ aCity.country +"' WHERE CityName='" + aCity.cityName +
                               "' ";
                SqlCommand command = new SqlCommand(query, Connection);
                Connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                Connection.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Info updated successfully!");
                    GetTextBoxesClear();
                    ShowAllInfo();
                    nameTextBox.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Update Failed !");
                }
                

            }

            else 
            {
                if (nameTextBox.Text.Length < 4)
                {
                    MessageBox.Show("You Must Enter City Name at least FOUR Characters!");
                }

                else if (IsCityNameExists(aCity.cityName))
                {
                    MessageBox.Show("City Name Already Exist!");

                }

                else
                {
                    SqlConnection Connection = new SqlConnection(ConnectionString);

                    string query = "INSERT INTO CityTable VALUES('" + aCity.cityName + "','" + aCity.cityAbout + "','" +
                                   aCity.country + "')";

                    SqlCommand command = new SqlCommand(query, Connection);
                    Connection.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    Connection.Close();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Information inserted successfully!");
                        GetTextBoxesClear();
                    }
                    else
                    {
                        MessageBox.Show("Insertion Failed !");
                    }

                    ShowAllInfo();
                }
                

            }
        }

        private void GetTextBoxesClear()
        {
            nameTextBox.Clear();
            aboutTextBox.Clear();
            countryTextBox.Clear();
        }

        public bool IsCityNameExists(string name)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string query = "SELECT CityName FROM CityTable WHERE CityName='" + name + "'";

            bool isCityNameExists = false;

            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                isCityNameExists = true;
                break;
            }
            reader.Close();
            Connection.Close();

            return isCityNameExists;
        }


        public void LoadCityListView(List<City>city)

        {
            CitylistView.Items.Clear();
            int count = 1;

            foreach (var Citylist in city)
            {
                ListViewItem item = new ListViewItem(count.ToString() );
                item.SubItems.Add(Citylist.cityName);
                item.SubItems.Add(Citylist.cityAbout);
                item.SubItems.Add(Citylist.country);
                CitylistView.Items.Add(item);
                count++;

            }
        }

        public void ShowAllInfo()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string query = " SELECT * FROM CityTable ";

            SqlCommand command = new SqlCommand(query,Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<City> cityList = new List<City>();
            while (reader.Read())
            {
                City city = new City();
                city.cityName = reader[0].ToString();
                city.cityAbout = reader[1].ToString();
                city.country = reader[2].ToString();

                cityList.Add(city);
            }
            reader.Close();
            Connection.Close();

            LoadCityListView(cityList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllInfo();
        }

      
        

        private void CitylistView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = CitylistView.SelectedItems[0];

            string name = item.SubItems[1].Text.ToString();
          

            City cityDetails = GetCityDetails(name);

            if (cityDetails != null)
            {
                UpdateMode = true;
                saveButton.Text = "Update";
                nameTextBox.Enabled = false;
                CityName = nameTextBox.Text = cityDetails.cityName;
                aboutTextBox.Text = cityDetails.cityAbout;
                countryTextBox.Text = cityDetails.country;

            }
        }


        public City GetCityDetails(string name)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string query = "SELECT * FROM CityTable WHERE CityName='" + name + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

           
            City nwCity = new City();
            while (reader.Read())
            {
                
                nwCity.cityName = reader["CityName"].ToString();
                nwCity.cityAbout = reader["About"].ToString();
                nwCity.country = reader["Country"].ToString();

                
            }
            reader.Close();
            Connection.Close();
            
            return nwCity;
        }



        private void cityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchByCity = true;
            SearchByCountry = false;

        }

        private void countryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchByCity = false;
            SearchByCountry = true;
        }




        public void Search(string searchByText, int operation)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string query = "SELECT * FROM CityTable";

            SqlCommand command = new SqlCommand(query, Connection);
            int count = 0;
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<City> infoList = new List<City>();

            

            if (operation == 1)
            {
                while (reader.Read())
                {
                    City infoCity = new City();
                    if (reader[0].ToString().Contains(searchByText) ||
                        reader[0].ToString().Contains(searchByText.ToUpper()) ||
                        reader[0].ToString().Contains(searchByText.ToLower()))
                    {
                        infoCity.cityName = reader[0].ToString();
                        infoCity.cityAbout = reader[1].ToString();
                        infoCity.country = reader[2].ToString();

                        infoList.Add(infoCity);
                        count++;
                    }
                         
                
               }
                reader.Close();
                Connection.Close();
                if (count > 0)
                    LoadCityListView(infoList);
                else
                {
                    MessageBox.Show("City is not Found");
                }

            }

            else
            {
                while (reader.Read())
                {
                    City infoCity = new City();
                    if (reader[2].ToString().Contains(searchByText) ||
                        reader[2].ToString().Contains(searchByText.ToUpper()) ||
                        reader[2].ToString().Contains(searchByText.ToLower()))
                    {
                        infoCity.cityName = reader[0].ToString();
                        infoCity.cityAbout = reader[1].ToString();
                        infoCity.country = reader[2].ToString();

                        infoList.Add(infoCity);
                        count++;
                    }


                }
                reader.Close();
                Connection.Close();
                if (count > 0)
                    LoadCityListView(infoList);
                else
                {
                    MessageBox.Show("Country is not Found");
                }
                
            }
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchByText = searchTextBox.Text;
            if (SearchByCity)
            {
                Search(searchByText, 1);

            }
            else
            {
                Search(searchByText, 2);

            }
        }

    }
}
