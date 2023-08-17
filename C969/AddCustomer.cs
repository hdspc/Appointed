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

                    //checkOverlap(appt.Start, appt.End, proposedStart, proposedEnd)
                    // Success! Return to the HomeForm by triggering the FormSaved event (so HomeForm reloads its data from the Database)
                    MessageBox.Show($"{rowsAffected} record saved!");
                    EventLogger.LogUnspecifiedEntry($"{_u.Username.ToString()} created new Customer with ID {customerID}");
                    Close();



                }
                else
                {
                    // Something went wrong, exit with a warning
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
    }
}
