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
        public Dashboard()
        {
            InitializeComponent();

            MySqlConnection connect = Database.DBConnection.conn;
            string sqlString = "SELECT * FROM appointment";
            MySqlCommand getCustomer = new MySqlCommand(sqlString, connect);
            MySqlDataAdapter adp = new MySqlDataAdapter(getCustomer);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            appointmentDGV.DataSource = dt;


            #region ALT reader method doesn't work

            //MySqlDataReader reader = getCustomer.ExecuteReader();
            //BindingList<Appointment> appointmentList = new BindingList<Appointment>();

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        appointmentList.Add(new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetDateTime(4)));
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("bummer");
            //}
            //reader.Close();
           // appointmentDGV.DataSource = appointmentList;

            #endregion

        }

        private void btn_AddAppointment_Click(object sender, EventArgs e)
        {
            Form addAppointment = new AddAppointment();

            addAppointment.ShowDialog();
            addAppointment.Close();



        }
    }
}
