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

namespace C969
{
    public partial class Dashboard : Form
    {
        private UserAccount activeUser;

        public Dashboard()
        {
            InitializeComponent();

            // FormRefresh();
            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM appointment";
            MySqlCommand getCustomer = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(getCustomer);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            appointmentDGV.DataSource = dt;

            List<UserAccount> allUsers = Database.DBConnection.GetAllUserAccounts();
            //string currentUser = allUsers[0].Username.ToString();
            ////string currentUser = Database.DBConnection.GetCurrentUser(0);
            txt_currentUser.Text = allUsers[1].Username.ToString();
            txt_currentUser.Text = UserAccount.user.ToString();


        }

        //public static void FormRefresh()
        //{
        //    MySqlConnection connect = Database.DBConnection.conn;
        //    string sqlString = "SELECT * FROM appointment";
        //    MySqlCommand getCustomer = new MySqlCommand(sqlString, connect);
        //    MySqlDataAdapter adp = new MySqlDataAdapter(getCustomer);
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    appointmentDGV.DataSource = dt;
        //}

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


    }
}
