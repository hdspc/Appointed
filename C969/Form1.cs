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

			string c = connect.DataSource;

			sqlStatusLabel.Text = "Connected to "+ c;
			/*
			string userString = "SELECT userName FROM user";
			MySqlCommand getUsername = new MySqlCommand(userString, connect);
			MySqlDataAdapter userADP = new MySqlDataAdapter(getUsername);
			DataTable dt = new DataTable();
			userADP.Fill(dt);
			dgv1.DataSource = dt;

			string passwordString = "SELECT password FROM user";
			MySqlCommand getPassword = new MySqlCommand(passwordString, connect);

			*/
		}

		private void submitButton_Click(object sender, EventArgs e)
        {
			List<UserAccount> allUsers = Database.DBConnection.GetAllUserAccounts();

			try
			{
				foreach (UserAccount u in allUsers)
				{
					if (u.Username == txt_UserIDTextBox.Text)
					{
						if (u.Password == txt_PasswordTextBox.Text)
						{
							// Login Successfull
							//OnUserLoggedIn(u);
							Form dashboard = new Dashboard();


							MessageBox.Show("success");

							dashboard.ShowDialog();

							return;
						}
						else
						{
							// PAssword doesn't match
							//EventLogger.LogUnsuccessfulLogin(tboxUsername.Text);
							//throw new LoginInvalidException("Password does not match.");
							MessageBox.Show("Password don't match");
						}
					}
				}

				// No matching Username was found. Throw Exception
				EventLogger.LogUnsuccessfulLogin(txt_UserIDTextBox.Text);
				//throw new LoginInvalidException("User account does not exist");
				MessageBox.Show("no username match");

			}
			catch (/*LoginInvalidException ex*/Exception ex)
			{
				MessageBox.Show(/*ex.Message*/"fuck");
			}










			/*
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
					MessageBox.Show("Form 1 catch exception");
				}
               
			}*/
		}

		private void button1_Click(object sender, EventArgs e)
        {
			Form dashboard = new Dashboard();

			dashboard.ShowDialog();
		}
    }
}
