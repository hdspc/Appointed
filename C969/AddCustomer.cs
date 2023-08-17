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
        }

        private void btn_newAddress_Click(object sender, EventArgs e)
        {
            AddAddress addAddress = new AddAddress();

            addAddress.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try {

                int customerID = Int32.Parse(txt_customerID.Text);
                string customerName = txt_customerName.Text;
                int addressID = Int32.Parse(txt_addressID.Text);
                bool activeChecked = checkbox_activeCustomer.Checked;




                int active = 0;
                DateTime createDate = DateTime.Now;
                string createdBy = _u.Username;

                DateTime lastUpdate = DateTime.Now;
                string lastUpdatedBy = _u.Username;


                Customer customer = new Customer(customerID, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdatedBy);

                //string insertString = $"{appointmentID}, {customerID}, {userID}, \"{title}\", \"{description}\", \"{location}\", \"{contact}\", \"{type}\", \"{url}\", \"{proposedStart:yyyy-MM-dd HH:mm:ss}\", \"{proposedEnd:yyyy-MM-dd HH:mm:ss}\", \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdatedBy}\"";

                //int rowsAffected = Database.DBConnection.InsertNewRecord("appointment", insertString);




            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
