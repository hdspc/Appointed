﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C969
{
    public partial class AddAddress : Form
    {

        private UserAccount _u;
        private List<City> allCities;

        public AddAddress(UserAccount u)
        {
            InitializeComponent();

            _u = u;


            txt_addressID.Text = Database.DBConnection.GetNewIdFromTable("address", "addressId").ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        


        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                int addressID = Int32.Parse(txt_addressID.Text);
                string address1 = txt_address_1.Text;
                string address2 = txt_address_2.Text;

                string cityName = txt_cityName.Text;

                string countryName = txt_CountryName.Text;

                

                string postalCode = txt_postalcode.Text;
                string phone = txt_phoneNumber.Text;
                DateTime createDate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string createdBy = _u.Username;
                DateTime lastUpdate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string lastUpdateBy = _u.Username;

                //Validating Country and adding to Database if necessary

                int retrieveCountryID = Database.DBConnection.GetCountryID(countryName, _u);



                //Validating City and adding to Database if necessary

                int retrieveCityID = Database.DBConnection.GetCityID(cityName, retrieveCountryID, _u);



                Address address = new Address(addressID, address1, address2, retrieveCityID, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy);

                string addressString = $"{addressID}, \"{address1}\", \"{address2}\", {retrieveCityID}, \"{postalCode}\", \"{phone}\", \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdateBy}\"";

                int rowsAffected = Database.DBConnection.InsertNewRecord("address", addressString);

                if (rowsAffected > 0)
                {

                    MessageBox.Show($"{rowsAffected} record saved!");
                    EventLogger.LogUnspecifiedEntry($"{_u.Username} created new Address with ID {addressID}");
                    Close();


                }
                else
                {
                    // Something went wrong, exit with a warning
                    MessageBox.Show("Record did not insert into the database. This address has not been saved.");
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


       

    }
}





//if (retrieveCountryID == -1)
//{

//    int newCountryID = Database.DBConnection.GetNewIdFromTable("country", "countryId");

//    Database.DBConnection.InsertNewRecord("country", $"{newCountryID}, \"{countryName}\", \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdateBy}\"");

//    MessageBox.Show($"New Country {countryName} added to the database.");

//    retrieveCountryID = newCountryID;
//}




//private void InsertIntoCityDatabase(int cityID, string cityName, string countryName, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
//{


//    if (retrieveCityID == -1)
//    {

//        Database.DBConnection.InsertNewRecord("city", $"{newCityID}, \"{cityName}\", {getCountryID(countryName)}, \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdateBy}\"");

//        MessageBox.Show($"New City {cityName} added to the database.");

//        retrieveCityID = newCityID;
//    }

//}