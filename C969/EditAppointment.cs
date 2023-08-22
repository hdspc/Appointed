using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace C969
{
    public partial class EditAppointment : Form
    {
        private Appointment _appointment;
        private List<Appointment> allAppointments = Database.DBConnection.GetAllAppointments();
        private List<UserAccount> allUsers = Database.DBConnection.GetAllUserAccounts();

        List<Customer> allCustomers = Database.DBConnection.GetAllCustomers();

        public EditAppointment(Appointment appointment)
        {
            _appointment = appointment;

            InitializeComponent();

            #region Previous appointment details

            dropdown_customerName.Text = Database.DBConnection.GetStringFromTable(appointment.UserID, "customerId", "customerName", "customer");
                
                //appointment.CustomerID.ToString();
             dropdown_UserID.Text = appointment.UserID.ToString();
            txt_AppointmentID.Text = appointment.AppointmentID.ToString();
            txt_Title.Text = appointment.Title.ToString();
            txt_Description.Text = appointment.Description.ToString();
            txt_Location.Text = appointment.Location.ToString();
            txt_Contact.Text = appointment.Contact.ToString();
            dropdown_AppointmentType.Text = appointment.Type.ToString();
            txt_URL.Text = appointment.URL.ToString();
            datetime_AppointmentStart.Value = appointment.Start;
            datetime_AppointmentEnd.Value = appointment.End;
            txt_CreatedDate.Text = appointment.CreateDate.ToLocalTime().ToString();
            txt_CreatedBy.Text = appointment.CreatedBy.ToString();
            txt_LastUpdate.Text = appointment.LastUpdate.ToLocalTime().ToString();
            txt_LastUpdateBy.Text = appointment.LastUpdateBy.ToString();

            #endregion

            dropdown_UserID.Items.Clear();

            foreach (UserAccount user in allUsers)
            {
                dropdown_UserID.Items.Add(user.ID);
            }

            dropdown_customerName.Items.Clear();


            foreach (Customer customer in allCustomers)
            {
                dropdown_customerName.Items.Add(customer.CustomerName);
            }


        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();

            
        }

        private void btn_EditAppointment_Save_Click(object sender, EventArgs e)
        {

            int appointmentID = Int32.Parse(txt_AppointmentID.Text);
            int customerID = Database.DBConnection.GetIntFromTable("customerId", "customer", "customerName", dropdown_customerName.Text);
            int userID = Int32.Parse(dropdown_UserID.Text);
            string title = txt_Title.Text;
            string description = txt_Description.Text;
            string location = txt_Location.Text;
            string contact = txt_Contact.Text;
            string type = dropdown_AppointmentType.Text;
            string url = txt_URL.Text;

            DateTime start = TimeZoneInfo.ConvertTimeToUtc(datetime_AppointmentStart.Value);
            DateTime end = TimeZoneInfo.ConvertTimeToUtc(datetime_AppointmentEnd.Value.AddHours(1));
            DateTime createDate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(txt_CreatedDate.Text));
            string createdBy = txt_CreatedBy.Text;
            DateTime lastUpdate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            string lastUpdatedBy = _appointment.UserID.ToString();

            MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);

            Appointment appointment = new Appointment(appointmentID, customerID, userID, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdatedBy);

            string insertString = $"appointmentId = {appointmentID}, customerId = {customerID}, userId =  {userID}, title = \"{title}\", description = \"{description}\", location =  \"{location}\", contact =  \"{contact}\", type =  \"{type}\", url = \"{url}\", start = \"{start:yyyy-MM-dd HH:mm}\", end = \"{end:yyyy-MM-dd HH:mm}\", createDate =  \"{createDate:yyyy-MM-dd HH:mm}\", createdBy =  \"{createdBy}\", lastUpdate = \"{lastUpdate:yyyy-MM-dd HH:mm}\", lastUpdateBy = \"{lastUpdatedBy}\"";

            int rowsAffected = Database.DBConnection.UpdateRecord("appointment", insertString, $"appointmentID = {appointmentID}");

            // Check Rows Affected to see if the record saved correctly
            if (rowsAffected > 0)
            {
                MessageBox.Show($"{rowsAffected} record(s) saved!");
                EventLogger.LogUnspecifiedEntry($"User ID {userID} created new Appointment with ID {appointmentID}");
                

                Close();
            }
            else
            {
                // Something went wrong, exit with a warning
                MessageBox.Show("Record did not insert into the database. This appointment has not been saved.");
            }
        }

        private void btn_DeleteAppointment_Click(object sender, EventArgs e)
        {
            int appointmentID = Int32.Parse(txt_AppointmentIDa.Text);

            MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);

            string deleteUserQuery = $"DELETE FROM appointment WHERE appointmentId = {appointmentID}";

            MySqlCommand deleteUsersCommand = new MySqlCommand(deleteUserQuery, connect);


            try
            {
                connect.Open();
                deleteUsersCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Appointment deleted.");
                connect.Close();
                Close();
            }
        }

        private void dropdown_UserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dropdown_customerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
