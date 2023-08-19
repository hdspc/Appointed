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
    public partial class AddAddress : Form
    {

        private UserAccount _u;

        public AddAddress(UserAccount u)
        {
            _u = u;
            InitializeComponent();
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
                int cityID = Int32.Parse(txt_cityID.Text);
                string postalCode = txt_postalcode.Text;
                string phone = txt_phoneNumber.Text;
                DateTime createDate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string createdBy = _u.Username;
                DateTime lastUpdate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string lastUpdateBy = _u.Username;


                Address address = new Address(addressID, address1, address2, cityID, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy);

                string addressString = $"{addressID}, \"{address1}\", \"{address2}\", {cityID}, \"{postalCode}\", \"{phone}\", \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdateBy}\"";

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

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }







    }
}
