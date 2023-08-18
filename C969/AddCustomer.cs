using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969
{
    public partial class AddCustomer : Form
    {
        private UserAccount _u;

        public AddCustomer(UserAccount u)
        {
            _u = u;
            InitializeComponent();

            txt_customerID.Text = Database.DBConnection.GetNewIdFromTable("customer", "customerId").ToString();
            AddressLoad();
        }

        private void btn_newAddress_Click(object sender, EventArgs e)
        {
            AddAddress addAddress = new AddAddress(_u);

            addAddress.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try {

                int customerID = Int32.Parse(txt_customerID.Text);
                string customerName = txt_customerName.Text;
                int addressID = Int32.Parse(txt_addressID.Text);
                string phoneNumber = txt_PhoneNumber.Text;


                DateTime createDate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string createdBy = _u.Username;
                DateTime lastUpdate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string lastUpdatedBy = _u.Username;

                int active = 0;

                bool activeChecked = checkbox_activeCustomer.Checked;

                if (activeChecked)
                {
                    active = 1;
                }


                Customer customer = new Customer(customerID, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdatedBy);

                string customerString = $"{customerID}, \"{customerName}\", {addressID}, \"{active}\", \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdatedBy}\"";

                int rowsAffected = Database.DBConnection.InsertNewRecord("customer", customerString);

                if (rowsAffected > 0)
                {

                    MessageBox.Show($"{rowsAffected} record saved!");
                    EventLogger.LogUnspecifiedEntry($"{_u.Username.ToString()} created new Customer with ID {customerID}");
                    Close();
                    
                }
                else
                {
                    MessageBox.Show("Record did not insert into the database. This customer has not been saved.");
                }
            }
       




        

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_addressID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressLoad();
            }
            catch 
            {
                MessageBox.Show("Check that the address ID is valid. If you'd like to add an address, click the \"New Address\" button.");
            }
        }

        private void AddressLoad()
        {

            int addressIDInForm = Int32.Parse(txt_addressID.Text);



            string phone = Database.DBConnection.GetStringFromTable(addressIDInForm, "addressId", "phone", "address");

            string cityIDRetrieval = Database.DBConnection.GetStringFromTable(addressIDInForm, "addressId", "cityId", "address");
            int cityID = Int32.Parse(cityIDRetrieval);
            string cityName = Database.DBConnection.GetStringFromTable(cityID, "cityId", "city", "city");

            string countryIDRetrieval = Database.DBConnection.GetStringFromTable(cityID, "cityID", "countryID", "city");
            int countryID = Int32.Parse(countryIDRetrieval);
            string countryName = Database.DBConnection.GetStringFromTable(countryID, "countryId", "country", "country");

            lbl_Phone.Text = phone;
            lbl_City.Text = cityName;
            lbl_Country.Text = countryName;
        }
    }
}
