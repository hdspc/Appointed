using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace C969
{
    public partial class Dashboard : Form
    {
        private UserAccount _u;
        private List<Appointment> allAppointments = Database.DBConnection.GetAllAppointments();

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

            btn_ViewAppointments.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            btn_ViewAppointments.FlatAppearance.BorderSize = 1;

            changeTimeFromUTC(dt);

           


            txt_currentUser.Text = u.Username.ToString();


            btn_EditCustomer.Enabled = false;
            btn_EditAppointment.Enabled = true;
        }






        private void btn_AddAppointment_Click(object sender, EventArgs e)
        {
            
            UserAccount currentUser = Database.DBConnection.GetUserById(_u.ID);

            Form addAppointment = new AddAppointment(currentUser);
            

            addAppointment.ShowDialog();
            //this.Close();

        }


        public void FormRefresh()
        {
            lbl_DashboardTitle.Text = "Appointment Dashboard";

            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM appointment";
            MySqlCommand refresh = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(refresh);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            changeTimeFromUTC(dt);

            appointmentDGV.DataSource = dt;


            btn_ViewAppointments.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            btn_ViewAppointments.FlatAppearance.BorderSize = 1;
            btn_ViewAppointments.BackColor = System.Drawing.Color.DarkGray;

            btn_ViewCustomers.FlatAppearance.BorderSize = 0;
            btn_ViewCustomers.BackColor = System.Drawing.Color.LightGray;

            btn_EditCustomer.Enabled = false;
            btn_EditAppointment.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // View Appointments BUTTON
            FormRefresh();



        }

        private void btn_EditAppointment_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = appointmentDGV.CurrentCell.RowIndex;
            var clickID = appointmentDGV.Rows[selectedRowIndex].Cells[0].Value;

            int editID = Int32.Parse(clickID.ToString());


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


                    EditAppointment appointmentEditor = new EditAppointment(selectedAppointment, _u);

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

        public static void changeTimeFromUTC(DataTable dt)
        {
            for (int idx = 0; idx < dt.Rows.Count; idx++)
            {
                dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();

                dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();

                dt.Rows[idx]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["createDate"], TimeZoneInfo.Local).ToString();

                dt.Rows[idx]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["lastUpdate"], TimeZoneInfo.Local).ToString();
            }
        }

        public static void CustomerViewChangeTimeFromUTC(DataTable dt)
        {
            for (int idx = 0; idx < dt.Rows.Count; idx++)
            {

                dt.Rows[idx]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["createDate"], TimeZoneInfo.Local).ToString();

                dt.Rows[idx]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["lastUpdate"], TimeZoneInfo.Local).ToString();
            }
        }

        private void btn_GenerateReports_Click(object sender, EventArgs e)
        {
            Form generateReports = new GenerateReports(_u);
            generateReports.ShowDialog();


        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            Form addCustomer = new AddCustomer(_u);
            addCustomer.ShowDialog();
        }

        private void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = appointmentDGV.CurrentCell.RowIndex;
            var clickID = appointmentDGV.Rows[selectedRowIndex].Cells[0].Value;

            int editID = Int32.Parse(clickID.ToString());


            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connect = new MySqlConnection(constr);

            try
            {
                connect.Open();

                string sqlString = $"SELECT * FROM customer WHERE customerId = {editID}";
                MySqlCommand getAppt = new MySqlCommand(sqlString, connect);
                MySqlDataReader rdr = getAppt.ExecuteReader();

                while (rdr.Read())
                {
                    Customer selectedCustomer = new Customer(rdr.GetInt32(0),   rdr[1].ToString(), rdr.GetInt32(2), rdr.GetInt32(3), rdr.GetDateTime(4), rdr[5].ToString(), rdr.GetDateTime(6), rdr[7].ToString());


                    EditCustomer customerEditor = new EditCustomer(selectedCustomer, _u);

                    customerEditor.ShowDialog();
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ViewCustomers_Click(object sender, EventArgs e)
        {
            lbl_DashboardTitle.Text = "All Customers";
            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM customer";
            MySqlCommand refresh = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(refresh);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            CustomerViewChangeTimeFromUTC(dt);

            appointmentDGV.DataSource = dt;


            btn_ViewCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            btn_ViewCustomers.FlatAppearance.BorderSize = 1;
            btn_ViewCustomers.BackColor = System.Drawing.Color.DarkGray;

            btn_ViewAppointments.FlatAppearance.BorderSize = 0;
            btn_ViewAppointments.BackColor = System.Drawing.Color.LightGray;

            btn_EditAppointment.Enabled = false;
            btn_EditCustomer.Enabled = true;
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            FormRefresh();
        }

        private void txt_appointmentSearch_TextChanged(object sender, EventArgs e)
        {
            string enteredText = txt_appointmentSearch.Text;

           
                MySqlConnection connect = Database.DBConnection.conn;
                string sqlString = $"SELECT * FROM appointment WHERE INSTR(description, '{enteredText}') OR INSTR (title, '{enteredText}') OR INSTR(type, '{enteredText}') OR INSTR(userId, '{enteredText}') OR INSTR(appointmentId, '{enteredText}') OR INSTR(customerId, '{enteredText}') OR INSTR(location, '{enteredText}') OR INSTR(contact, '{enteredText}') OR INSTR(url, '{enteredText}')";
                MySqlCommand refresh = new MySqlCommand(sqlString, connect);
                MySqlDataAdapter adp = new MySqlDataAdapter(refresh);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                changeTimeFromUTC(dt);

                appointmentDGV.DataSource = dt;


                btn_ViewAppointments.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
                btn_ViewAppointments.FlatAppearance.BorderSize = 1;
                btn_ViewAppointments.BackColor = System.Drawing.Color.DarkGray;

                btn_ViewCustomers.FlatAppearance.BorderSize = 0;
                btn_ViewCustomers.BackColor = System.Drawing.Color.LightGray;

                btn_EditCustomer.Enabled = false;
                btn_EditAppointment.Enabled = true;
            if (string.IsNullOrWhiteSpace(enteredText))
            {
                FormRefresh();
            }
        }


    }
}
