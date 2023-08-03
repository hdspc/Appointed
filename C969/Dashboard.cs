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

        public Dashboard(UserAccount u)
        {
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


            txt_currentUser.Text = u.Username;
        }

        private void btn_AddAppointment_Click(object sender, EventArgs e)
        {
            Form addAppointment = new AddAppointment();

            addAppointment.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FormRefresh();


            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM appointment";
            MySqlCommand getCustomer = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(getCustomer);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            appointmentDGV.DataSource = dt;




        }

        private void btn_EditAppointment_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = appointmentDGV.CurrentCell.RowIndex+1;
            MessageBox.Show(selectedRowIndex.ToString());

            // MySqlConnection connect = Database.DBConnection.conn;
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection connect = new MySqlConnection(constr);

            try
            {
                connect.Open();

                string sqlString = $"SELECT * FROM appointment WHERE appointmentId = {selectedRowIndex}";
                MySqlCommand getAppt = new MySqlCommand(sqlString, connect);
                MySqlDataReader rdr = getAppt.ExecuteReader();
            
            while (rdr.Read())
                {
                Appointment selectedAppointment = new Appointment(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetInt32(2), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(), rdr[8].ToString(), rdr.GetDateTime(9), rdr.GetDateTime(10), rdr.GetDateTime(11), rdr[12].ToString(), rdr.GetDateTime(13), rdr[14].ToString());
                 

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
    }
}
