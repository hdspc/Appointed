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
    public partial class EditCustomer : Form
    {

        private UserAccount _u;
        List<Address> allAddresses = Database.DBConnection.GetAllAddresses();

        public EditCustomer(Customer customer, UserAccount u)
        {
            InitializeComponent();

            _u = u;

            txt_customerID.Text = customer.CustomerID.ToString();
            txt_customerName.Text = customer.CustomerName;
            dropdown_AddressIDs.Text = customer.AddressID.ToString();
            checkbox_activeCustomer.Checked = IsCustomerActive(customer);


            dropdown_AddressIDs.Items.Clear();
          

            foreach (Address address in allAddresses)
            {
                dropdown_AddressIDs.Items.Add(address.AddressID);
            }


            AddressLoad();

            btn_Save.Enabled = false;
            txt_customerName.TextChanged += OnFormUpdated;
        }

        private bool IsCustomerActive(Customer customer)

        {
            if (customer.Active == 1)
            {
                return true;
            }
            return false;
        }

        #region VALIDATION
        private void OnFormUpdated(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {

            bool isFormValid = true;


            if (String.IsNullOrWhiteSpace(txt_customerName.Text) == false)

            {
                txt_customerName.BackColor = System.Drawing.Color.White;
            }


            if (String.IsNullOrWhiteSpace(txt_customerName.Text) == true)

            {
                btn_Save.Enabled = false;

                txt_customerName.BackColor = System.Drawing.Color.Salmon;
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

        private void btn_newAddress_Click(object sender, EventArgs e)
        {
            AddAddress addAddress = new AddAddress(_u);

            addAddress.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                int customerID = Int32.Parse(txt_customerID.Text);
                string customerName = txt_customerName.Text;
                int addressID = Int32.Parse(dropdown_AddressIDs.Text);


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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void AddressLoad()
        {


            int addressIDInForm = Int32.Parse(dropdown_AddressIDs.Text);

            string phone = Database.DBConnection.GetStringFromTable(addressIDInForm, "addressId", "phone", "address");

            string address1 = Database.DBConnection.GetStringFromTable(addressIDInForm, "addressId", "address", "address");
            string address2 = Database.DBConnection.GetStringFromTable(addressIDInForm, "addressId", "address2", "address");


            string cityIDRetrieval = Database.DBConnection.GetStringFromTable(addressIDInForm, "addressId", "cityId", "address");
            int cityID = Int32.Parse(cityIDRetrieval);
            string cityName = Database.DBConnection.GetStringFromTable(cityID, "cityId", "city", "city");

            string countryIDRetrieval = Database.DBConnection.GetStringFromTable(cityID, "cityID", "countryID", "city");
            int countryID = Int32.Parse(countryIDRetrieval);
            string countryName = Database.DBConnection.GetStringFromTable(countryID, "countryId", "country", "country");

            lbl_Phone.Text = phone;
            lbl_address1.Text = address1;
            lbl_address2.Text = address2;
            lbl_City.Text = cityName;
            lbl_Country.Text = countryName;
        }

        private void dropdown_AddressIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddressLoad();
        }



        private void dropdown_AddressIDs_Click(object sender, EventArgs e)
        {

            allAddresses = Database.DBConnection.GetAllAddresses();

            dropdown_AddressIDs.Items.Clear();


            foreach (Address address in allAddresses)
            {
                dropdown_AddressIDs.Items.Add(address.AddressID);
            }
        }


        //CANCELS TEXT INPUT INTO ID DROPDOWN
        private void dropdown_AddressIDs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}
