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
    public partial class Dashboard : Form
    {
        private UserAccount _u;

        public Dashboard(UserAccount u)
        {
            _u = u;

            InitializeComponent();

            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM appointment";
            MySqlCommand getCustomer = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(getCustomer);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            appointmentDGV.DataSource = dt;
            appointmentDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentDGV.MultiSelect = false;
            appointmentDGV.RowHeadersVisible = false;
            appointmentDGV.AllowUserToAddRows = false;



            changeTimeFromUTC(dt);



            txt_currentUser.Text = u.Username.ToString();
        }






        private void btn_AddAppointment_Click(object sender, EventArgs e)
        {
            this.Dispose();

            UserAccount currentUser = Database.DBConnection.GetUserById(_u.ID);

            Form addAppointment = new AddAppointment(currentUser);

            addAppointment.ShowDialog();

        }


        public void FormRefresh()
        {
            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM appointment";
            MySqlCommand refresh = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(refresh);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            changeTimeFromUTC(dt);

            appointmentDGV.DataSource = dt;
            //UserAccount currentUser = Database.DBConnection.GetUserById(_u.ID);

            //Form dashboard = new Dashboard(_u);

            //dashboard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // REFRESH APPOINTMENT BUTTON
            FormRefresh();
        }

        private void btn_EditAppointment_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = appointmentDGV.CurrentCell.RowIndex;
            var clickID = appointmentDGV.Rows[selectedRowIndex].Cells[0].Value;

            int editID = Int32.Parse(clickID.ToString());


            // MySqlConnection connect = Database.DBConnection.conn;
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connect = new MySqlConnection(constr);

            try
            {
                connect.Open();

                string sqlString = $"SELECT * FROM appointment WHERE appointmentId = {editID}";
                MySqlCommand getAppt = new MySqlCommand(sqlString, connect);
                MySqlDataReader rdr = getAppt.ExecuteReader();

                while (rdr.Read())
                {
                    Appointment selectedAppointment = new Appointment(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetInt32(2), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(), rdr[8].ToString(), rdr.GetDateTime(9), rdr.GetDateTime(10), rdr.GetDateTime(11), rdr[12].ToString(), rdr.GetDateTime(13), rdr[14].ToString());

                    this.Dispose();

                    EditAppointment appointmentEditor = new EditAppointment(selectedAppointment);

                    appointmentEditor.ShowDialog();
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rdo_ALL_CheckedChanged(object sender, EventArgs e)
        {
            FormRefresh();
        }


///////////////////////////////////CHECKKCKCK


private void rdo_Weekly_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM appointment WHERE YEARWEEK(start)= YEARWEEK(CURRENT_DATE()) AND YEAR(start) = YEAR(CURRENT_DATE())";
            MySqlCommand getCustomer = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(getCustomer);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            changeTimeFromUTC(dt);
            appointmentDGV.DataSource = dt;
        }

        private void rdo_Monthly_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM appointment WHERE MONTH(start)= MONTH(CURRENT_DATE()) AND YEAR(start) = YEAR(CURRENT_DATE())";
            MySqlCommand getCustomer = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(getCustomer);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            changeTimeFromUTC(dt);
            appointmentDGV.DataSource = dt;
        }

        private static void changeTimeFromUTC(DataTable dt)
        {
            for (int idx = 0; idx < dt.Rows.Count; idx++)
            {
                dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();

                dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();

                dt.Rows[idx]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["createDate"], TimeZoneInfo.Local).ToString();

                dt.Rows[idx]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["lastUpdate"], TimeZoneInfo.Local).ToString();
            }
        }

        private void btn_GenerateReports_Click(object sender, EventArgs e)
        {
            Close();
            Form generateReports = new GenerateReports(_u);
            generateReports.ShowDialog();


        }

      
    }
}
