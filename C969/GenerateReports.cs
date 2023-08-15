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
		}

		private void btn_NumberAppointmentTypesByMonth_Click(object sender, EventArgs e)
		{
			List<Appointment> dt = allAppointments;
			int currentUserID = _u.ID;
			string currentUsername = _u.Username;

			string chosenMonth = dropdown_Months.Text;


			int presentationNumber = Database.DBConnection.GetAppointmentTypeCount(currentUserID, "presentation", chosenMonth);

			int scrumNumber =
			Database.DBConnection.GetAppointmentTypeCount(currentUserID, "scrum", chosenMonth);

			

			txt_ReportTextBox.Text = $"Number of presentations for {currentUsername} in {chosenMonth}: {presentationNumber.ToString()} \r\n\r\n Number of scrums:  {scrumNumber.ToString()}";
		}

		private void btn_ConsultantSchedule_Click(object sender, EventArgs e)
		{

		}
	}
}



//////////////var dt = appointmentDGV.DataSource;

//////////////MySqlConnection connect = Database.DBConnection.conn;
//////////////string sqlString = "SELECT * FROM appointment";
//////////////MySqlCommand getCustomer = new MySqlCommand(sqlString, connect);
//////////////MySqlDataAdapter adp = new MySqlDataAdapter(getCustomer);
//////////////MessageBox.Show(clickID.ToString());



////////////// MySqlConnection connect = Database.DBConnection.conn;
////////////string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
////////////MySqlConnection connect = new MySqlConnection(constr);

////////////try
////////////{
////////////    connect.Open();

////////////    string sqlString = "SELECT * FROM appointment";
////////////    MySqlCommand getAppt = new MySqlCommand(sqlString, connect);
////////////    MySqlDataReader rdr = getAppt.ExecuteReader();

////////////    DataTable dt = (DataTable)appointmentDGV.DataSource;
////////////    ReportWriter(dt);
////////////    //for (int idx = 0; idx < dt.Rows.Count; idx++)
////////////    //{
////////////    //    int selectedRowIndex = appointmentDGV.CurrentCell.RowIndex;
////////////    //    var clickID = appointmentDGV.Rows[selectedRowIndex].Cells[0].Value;

////////////    //    int editID = Int32.Parse(clickID.ToString());
////////////    //    MessageBox.Show(dt.ToString());

////////////    //}

////////////    while (rdr.Read())
////////////    {
////////////        Appointment selectedAppointment = new Appointment(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetInt32(2), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(), rdr[8].ToString(), rdr.GetDateTime(9), rdr.GetDateTime(10), rdr.GetDateTime(11), rdr[12].ToString(), rdr.GetDateTime(13), rdr[14].ToString());


////////////        //EditAppointment appointmentEditor = new EditAppointment(selectedAppointment);
////////////        //appointmentEditor.ShowDialog();

////////////    }
////////////    connect.Close();
////////////}
////////////catch (Exception ex)
////////////{
////////////    MessageBox.Show(ex.ToString());
////////////}
///










//private void ReportWriter(DataTable dt)
//{
//	for (int idx = 0; idx < dt.Rows.Count; idx++)
//	{
//		//dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();

//		MessageBox.Show("REPORT GENERATOR " + dt.Rows[idx]["start"].ToString());

//	}
//}