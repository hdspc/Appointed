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
        private UserAccount _u;
        List<Appointment> allAppointments = Database.DBConnection.GetAllAppointments();

        public AddAppointment(UserAccount u)
        {

            _u = u;
            InitializeComponent();
            List<UserAccount> allUsers = Database.DBConnection.GetAllUserAccounts();

            txt_CustomerID.Text = 1.ToString();
            txt_UserID.Text = _u.ID.ToString();
            txt_AppointmentID.Text = Database.DBConnection.GetNewIdFromTable("appointment", "appointmentId").ToString();


            datetime_AppointmentStart.Format = DateTimePickerFormat.Custom;
            datetime_AppointmentEnd.Format = DateTimePickerFormat.Custom;
            datetime_AppointmentStart.Value = DateTime.Now;
            datetime_AppointmentEnd.Value = DateTime.Now.AddHours(1);





            txt_CreatedBy.Text = _u.ID.ToString();
            txt_CreatedDate.Text = DateTime.Now.ToString();
            txt_LastUpdateBy.Text= _u.ID.ToString();
            txt_LastUpdate.Text= DateTime.Now.ToString();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void btn_AddAppointment_Save_Click(object sender, EventArgs e)
        {

            try
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
                DateTime proposedStart = TimeZoneInfo.ConvertTimeToUtc(datetime_AppointmentStart.Value);
                DateTime proposedEnd = TimeZoneInfo.ConvertTimeToUtc(datetime_AppointmentEnd.Value/*.AddHours(1)*/);
                DateTime createDate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string createdBy = txt_CreatedBy.Text;
                DateTime lastUpdate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string lastUpdatedBy = txt_LastUpdateBy.Text;



				#region exceptions 

				if (datetime_AppointmentStart.Value > datetime_AppointmentEnd.Value)
				{
                    MessageBox.Show("Meeting must end after it starts");
					throw new Exceptions.AppointmentTimesInvalidException("Check appointment times. Business hours are 8am-5pm PST.");
				}

				if (datetime_AppointmentStart.Value.Hour < 8 || datetime_AppointmentStart.Value.Hour > 17)
				{
                    throw new Exceptions.AppointmentTimesInvalidException("Check appointment times. Business hours are 8am-5pm PST.");
                }



                IEnumerable<Appointment> userAppointments =
                                from appt in allAppointments
                                where appt.Start.ToLocalTime().Date == datetime_AppointmentStart.Value.Date || appt.End.ToLocalTime().Date == datetime_AppointmentEnd.Value.Date
                                select appt;

                foreach (Appointment appt in userAppointments)
                {
                    DateTime apptStart = appt.Start.ToLocalTime();
                    DateTime apptEnd = appt.End.ToLocalTime();

                    DateTime exStart = datetime_AppointmentStart.Value;
                    DateTime exEnd = datetime_AppointmentEnd.Value; 

                    if ((apptStart >= exStart && apptStart <= exEnd)
                        || (apptEnd >= exStart && apptEnd <= exEnd)
                        || (exStart >= apptStart && exStart <= apptEnd)
                        || (exEnd >= apptStart && exEnd <= apptEnd))
                    {


                        throw new Exceptions.AppointmentTimesInvalidException($"Appointment overlaps with another appointment [Apptointment #{appt.AppointmentID} at {appt.Start}]");
                      

                    }
                }


                #endregion






                Appointment appointment = new Appointment(appointmentID, customerID, userID, title, description, location, contact, type, url, proposedStart, proposedEnd, createDate, createdBy, lastUpdate, lastUpdatedBy);

                string insertString = $"{appointmentID}, {customerID}, {userID}, \"{title}\", \"{description}\", \"{location}\", \"{contact}\", \"{type}\", \"{url}\", \"{proposedStart:yyyy-MM-dd HH:mm:ss}\", \"{proposedEnd:yyyy-MM-dd HH:mm:ss}\", \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdatedBy}\"";

                int rowsAffected = Database.DBConnection.InsertNewRecord("appointment", insertString);

                // Check Rows Affected to see if the record saved correctly
                if (rowsAffected > 0)
                {

                    //checkOverlap(appt.Start, appt.End, proposedStart, proposedEnd)
                    // Success! Return to the HomeForm by triggering the FormSaved event (so HomeForm reloads its data from the Database)
                     MessageBox.Show($"{rowsAffected} record saved!");
                    EventLogger.LogUnspecifiedEntry($"{userID} created new Appointment with ID {appointmentID}");
                    // Form dash = new Dashboard(_u);
                    Close();

                    UserAccount currentUser = Database.DBConnection.GetUserById(userID);
                    Form dashboard = new Dashboard(currentUser);

                    dashboard.ShowDialog();

                }
                else
                {
                    // Something went wrong, exit with a warning
                    MessageBox.Show("Record did not insert into the database. This appointment has not been saved.");
                }
            }
            catch (Exceptions.AppointmentTimesInvalidException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

    }
}
