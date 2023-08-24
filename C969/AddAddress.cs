using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace C969
{
    public partial class AddAddress : Form
    {

        private UserAccount _u;

        public AddAddress(UserAccount u)
        {
            InitializeComponent();

            _u = u;


            txt_addressID.Text = Database.DBConnection.GetNewIdFromTable("address", "addressId").ToString();

            List<Country> allCountries = Database.DBConnection.GetAllCountries();


            List<City> allCities = Database.DBConnection.GetAllCities();

            dropdown_Countries.Items.Clear();
            dropdown_Cities.Items.Clear();

            foreach (City city in allCities)
            {
                dropdown_Cities.Items.Add(city.CityName);
            }

            foreach (Country country in allCountries)
            {
                dropdown_Countries.Items.Add(country.CountryName);
            }

            btn_Save.Enabled = false;

            txt_address_1.TextChanged += OnFormUpdated;
            dropdown_Cities.TextChanged += OnFormUpdated;
            dropdown_Countries.TextChanged += OnFormUpdated;
            txt_postalcode.TextChanged += OnFormUpdated;
            txt_phoneNumber.TextChanged += OnFormUpdated;



        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region VALIDATION
        private void OnFormUpdated(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {

            bool isFormValid = true;

            if ((String.IsNullOrWhiteSpace(txt_address_1.Text)) == false)

            {
                
                txt_address_1.BackColor = System.Drawing.Color.White;

            }


            if (String.IsNullOrWhiteSpace(txt_address_1.Text) == true)

            {
                isFormValid = false;

                txt_address_1.BackColor = System.Drawing.Color.Salmon;
            }


            //CITY DROPDOWN
            if ((String.IsNullOrWhiteSpace(dropdown_Cities.Text)) == false)

            {
                
                dropdown_Cities.BackColor = System.Drawing.Color.White;

            }


            if ((String.IsNullOrWhiteSpace(dropdown_Cities.Text)) == true)

            {
                isFormValid = false;

                dropdown_Cities.BackColor = System.Drawing.Color.Salmon;
            }


            //COUNTRIES DROPDOWN
            if ((String.IsNullOrWhiteSpace(dropdown_Countries.Text)) == false)

            {
                dropdown_Countries.BackColor = System.Drawing.Color.White;

            }


            if ((String.IsNullOrWhiteSpace(dropdown_Countries.Text)) == true)

            {
                isFormValid = false;

                dropdown_Countries.BackColor = System.Drawing.Color.Salmon;
            }

            //POSTAL CODE
            if ((String.IsNullOrWhiteSpace(txt_postalcode.Text)) == false)

            {
                txt_postalcode.BackColor = System.Drawing.Color.White;

            }


            if ((String.IsNullOrWhiteSpace(txt_postalcode.Text)) == true)

            {
                isFormValid = false;

                txt_postalcode.BackColor = System.Drawing.Color.Salmon;
            }

            //PHONE

            if (PhoneNumberValidation(txt_phoneNumber.Text) == false)
            {
                isFormValid = false;
            }



            if (isFormValid == true)
            {
                btn_Save.Enabled = true;

            }
            else
            {
                btn_Save.Enabled = false;
            }

        }

        #endregion




        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                int addressID = Int32.Parse(txt_addressID.Text);
                string address1 = txt_address_1.Text;
                string address2 = txt_address_2.Text;

                string cityName = dropdown_Cities.Text;

                string countryName = dropdown_Countries.Text;

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

                    MessageBox.Show($"{_u.Username} created new Address with ID {addressID}");
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


        private bool PhoneNumberValidation(string phoneNumber)
        {
            if (String.IsNullOrWhiteSpace(phoneNumber) == false)

            {
                txt_phoneNumber.BackColor = System.Drawing.Color.White;


            }


            if ((String.IsNullOrWhiteSpace(phoneNumber)) == true)

            {
                txt_phoneNumber.BackColor = System.Drawing.Color.Salmon;

                return false;

            }

            char[] phoneChars = phoneNumber.ToCharArray();

            // Check if field is too long (8 characters including dash)
            if (phoneChars.Length != 8)
            {
                txt_phoneNumber.BackColor = System.Drawing.Color.Salmon;

                return false;
            }

            // Check for dashes in correct places
            if (phoneChars[3] != '-')
            {
                txt_phoneNumber.BackColor = System.Drawing.Color.Salmon;

                return false;
            }

            // Check that all other characters are only digits
            IEnumerable<char> phoneNoDashes =
                from c in phoneChars
                where c != '-'
                select c;

            foreach (char c in phoneNoDashes)
            {
                if (c < '0' || c > '9')
                {
                    txt_phoneNumber.BackColor = System.Drawing.Color.Salmon;

                    return false;
                }
            }

            // Validation Passed!
            return true;

        }

    }
}