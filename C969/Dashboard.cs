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
            customerDGV.DataSource = dt;
        }

        private void btn_AddAppointment_Click(object sender, EventArgs e)
        {
            Form addAppointment = new AddAppointment();

            addAppointment.ShowDialog();
            this.Close();



        }
    }
}
