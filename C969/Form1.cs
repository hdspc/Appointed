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
	public partial class Form1 : Form
	{
		MySqlConnection connect = Database.DBConnection.conn;


		public Form1()
		{
			InitializeComponent();

			sqlStatusLabel.Text = connect.ToString();

			string userString = "SELECT userName FROM user";
			MySqlCommand getUsername = new MySqlCommand(userString, connect);
			MySqlDataAdapter userADP = new MySqlDataAdapter(getUsername);
			DataTable dt = new DataTable();
			userADP.Fill(dt);
			dgv1.DataSource = dt;

			string passwordString = "SELECT password FROM user";
			MySqlCommand getPassword = new MySqlCommand(passwordString, connect);


		}

		private void submitButton_Click(object sender, EventArgs e)
        {
			string userID = userIDTextBox.Text;
			string password = passwordTextBox.Text;


		





			if (String.IsNullOrEmpty(userID) || String.IsNullOrEmpty(password))
            {
				MessageBox.Show("Please enter a User ID and a Password");
            }

			else
            {
				try
				{

					String.Compare(userID, "test");
					String.Compare(password, "test");


					MessageBox.Show("login successful");
					Form dashboard = new Dashboard();
					
					dashboard.ShowDialog();
				}
				catch (Exception)
				{
					MessageBox.Show("fuck");
				}
                finally
                {
					this.Close();
                }
			}
		}
    }
}
