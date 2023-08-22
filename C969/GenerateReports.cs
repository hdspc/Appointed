using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace C969
{
	public partial class GenerateReports : Form
	{

		private UserAccount _u;
		private List<Appointment> allAppointments = Database.DBConnection.GetAllAppointments();
		private List<UserAccount> allUsers = Database.DBConnection.GetAllUserAccounts();

		public GenerateReports(UserAccount u)
		{
			InitializeComponent();
			_u = u;

			dropdown_Months.DropDownStyle = ComboBoxStyle.DropDownList;

			txt_UserID.Visible = false;
			btn_UserIDRefresh.Visible = false;

			lbl_UserIDEntry.Text = "Month:";
		}

		private void btn_NumberAppointmentTypesByMonth_Click(object sender, EventArgs e)
		{
			dgv_consultantSchedule.Visible = false;
			txt_ReportTextBox.Text = "";
			txt_ReportTextBox.Visible = true;
			dropdown_Months.Visible = true;
			txt_UserID.Visible = false;
			btn_UserIDRefresh.Visible = false;
			lbl_UserIDEntry.Text = "User ID:";



			List<Appointment> dt = allAppointments;
			int currentUserID = _u.ID;
			string currentUsername = _u.Username;

			string chosenMonth = dropdown_Months.Text;


			int presentationNumber = Database.DBConnection.GetAppointmentTypeCount(currentUserID, "presentation", chosenMonth);

			int scrumNumber =
			Database.DBConnection.GetAppointmentTypeCount(currentUserID, "scrum", chosenMonth);

			

			txt_ReportTextBox.Text = $"Appointments for {currentUsername} in {chosenMonth} \r\n\r\nNumber of presentations: {presentationNumber.ToString()} \r\n\r\nNumber of scrums:  {scrumNumber.ToString()}";
		}

		private void btn_ConsultantSchedule_Click(object sender, EventArgs e)
		{

			txt_ReportTextBox.Visible = false;
			dgv_consultantSchedule.Visible = true;
			dropdown_Months.Visible = false;
			txt_UserID.Visible = true;
			btn_UserIDRefresh.Visible = true;
			lbl_UserIDEntry.Text = "User:";

			int userIDEntry = Int32.Parse(txt_UserID.Text);


			MySqlConnection connect = Database.DBConnection.conn;
			string sqlString = $"SELECT * FROM appointment WHERE UserID = {userIDEntry}";
			MySqlCommand refresh = new MySqlCommand(sqlString, connect);
			MySqlDataAdapter adp = new MySqlDataAdapter(refresh);
			DataTable dt = new DataTable();
			adp.Fill(dt);

			Dashboard.changeTimeFromUTC(dt);

			dgv_consultantSchedule.DataSource = dt;

		}

		private void btn_UserIDRefresh_Click(object sender, EventArgs e)
		{
			try
			{
				txt_ReportTextBox.Visible = false;
				dgv_consultantSchedule.Visible = true;
				dropdown_Months.Visible = false;
				txt_UserID.Visible = true;
				btn_UserIDRefresh.Visible = true;
				lbl_UserIDEntry.Visible = true;
				lbl_UserIDEntry.Text = "User ID:";

				int userIDEntry = Int32.Parse(txt_UserID.Text);


				MySqlConnection connect = Database.DBConnection.conn;
				string sqlString = $"SELECT * FROM appointment WHERE UserID = {userIDEntry}";
				MySqlCommand refresh = new MySqlCommand(sqlString, connect);
				MySqlDataAdapter adp = new MySqlDataAdapter(refresh);
				DataTable dt = new DataTable();
				adp.Fill(dt);

				Dashboard.changeTimeFromUTC(dt);

				dgv_consultantSchedule.DataSource = dt;
			}

			catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
		}



		private void btn_customReport_Click(object sender, EventArgs e)
		{

			txt_ReportTextBox.Visible = true;
			dgv_consultantSchedule.Visible = false;
			dropdown_Months.Visible = false;
			txt_UserID.Visible = false;
			btn_UserIDRefresh.Visible = false;
			lbl_UserIDEntry.Visible = false;


			//////int appointmentNumber = Database.DBConnection.GetNumberAppointmentsForCustomer(1);

			//Localized Lambda function which turns 35 lines of code from DBConnection into 2.

			int NumberOfAppointments = allAppointments.Where(appt => appt.CustomerID == 2).Count();

			txt_ReportTextBox.Text = $"Number of appointments with Alfred E Newman: {NumberOfAppointments.ToString()}";

		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			Close();

		}

       
    }
}

