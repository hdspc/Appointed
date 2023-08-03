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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
            List<UserAccount> allUsers = Database.DBConnection.GetAllUserAccounts();

            txt_CustomerID.Text = "1";
           // txt_UserID.Text = "FUCKKKCKCUI";
            txt_AppointmentID.Text = Database.DBConnection.GetNewIdFromTable("appointment", "appointmentId").ToString();
            datetime_AppointmentStart.Format = DateTimePickerFormat.Custom;
            datetime_AppointmentEnd.Format = DateTimePickerFormat.Custom;
            txt_CreatedDate.Text = DateTime.Now.ToString();
            txt_LastUpdate.Text= DateTime.Now.ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

  
        private void btn_AddAppointment_Save_Click(object sender, EventArgs e)
        {
            int appointmentID = Int32.Parse(txt_AppointmentID.Text);
            int customerID = Int32.Parse(txt_CustomerID.Text);
            int userID = Int32.Parse(txt_UserID.Text);
            string title = txt_Title.Text;
            string description = txt_Description.Text;
            string location = txt_Location.Text;
            string contact = txt_Contact.Text;
            string type = dropdown_AppointmentType.Text;
            string url = txt_URL.Text;
            DateTime start = datetime_AppointmentStart.Value;
            DateTime end = datetime_AppointmentEnd.Value.AddHours(1);
            DateTime createDate = DateTime.Now;
            string createdBy = "CREATE USER IN FORM";
            DateTime lastUpdate = DateTime.Now;
            string lastUpdatedBy = "CREATE USER IN FORM";
            
            Appointment appointment = new Appointment(appointmentID, customerID, userID, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdatedBy);
        string insertString = $"{appointmentID}, {customerID}, {userID}, \"{title}\", \"{description}\", \"{location}\", \"{contact}\", \"{type}\", \"{url}\", \"{start:yyyy-MM-dd HH:mm:ss}\", \"{end:yyyy-MM-dd HH:mm:ss}\", \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdatedBy}\"";

            int rowsAffected = Database.DBConnection.InsertNewRecord("appointment", insertString);

            // Check Rows Affected to see if the record saved correctly
            if (rowsAffected > 0)
            {
                // Success! Return to the HomeForm by triggering the FormSaved event (so HomeForm reloads its data from the Database)
                MessageBox.Show($"{rowsAffected} record saved!");
                //EventLogger.LogUnspecifiedEntry($"{formOwner} created new Appointment with ID {appointmentId}");
             //  Dashboard.FormRefresh();
                Close();
            }
            else
            {
                // Something went wrong, exit with a warning
                MessageBox.Show("Record did not insert into the database. This appointment has not been saved.");
            }
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
