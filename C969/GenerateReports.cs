﻿using System;
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
		}

		private void btn_NumberAppointmentTypesByMonth_Click(object sender, EventArgs e)
		{
			dgv_consultantSchedule.Visible = false;
			txt_ReportTextBox.Text = "";
			txt_ReportTextBox.Visible = true;
			dropdown_Months.Visible = true;



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
			//THEY WANT ALL APPOINTMENTS

			txt_ReportTextBox.Visible = false;
			dgv_consultantSchedule.Visible = true;
			dropdown_Months.Visible = false;


			MySqlConnection connect = Database.DBConnection.conn;
			string sqlString = "SELECT * FROM appointment";
			MySqlCommand refresh = new MySqlCommand(sqlString, connect);
			MySqlDataAdapter adp = new MySqlDataAdapter(refresh);
			DataTable dt = new DataTable();
			adp.Fill(dt);

			Dashboard.changeTimeFromUTC(dt);

			dgv_consultantSchedule.DataSource = dt;

		}

		private void btn_customReport_Click(object sender, EventArgs e)
		{

			txt_ReportTextBox.Visible = false;
			dgv_consultantSchedule.Visible = true;
			dropdown_Months.Visible = false;


			int currentUserID = _u.ID;

			MySqlConnection connect = Database.DBConnection.conn;
			string sqlString = $"SELECT * FROM appointment WHERE userId = {currentUserID}";
			MySqlCommand refresh = new MySqlCommand(sqlString, connect);
			MySqlDataAdapter adp = new MySqlDataAdapter(refresh);
			DataTable dt = new DataTable();
			adp.Fill(dt);

			Dashboard.changeTimeFromUTC(dt);

			dgv_consultantSchedule.DataSource = dt;

		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			Close();

		}
	}
}

