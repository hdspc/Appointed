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
using C969.Events;

namespace C969
{
	public partial class Form1 : Form
	{
		MySqlConnection connect = Database.DBConnection.conn;
		public event EventHandler<UserLoginEventArgs> UserLogin;

		public Form1()
		{
			InitializeComponent();
			string c = connect.DataSource;
			sqlStatusLabel.Text = "Connected to "+ c;

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
							OnUserLoggedIn(u);
							Form dashboard = new Dashboard();


							MessageBox.Show("success");

							dashboard.ShowDialog();

							return;
						}
						else
						{
							// PAssword doesn't match
							EventLogger.LogUnsuccessfulLogin(txt_UserIDTextBox.Text);
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
				MessageBox.Show(/*ex.Message*/"catch exception");
			}

		}

		private void OnUserLoggedIn(UserAccount user)
		{
			MessageBox.Show("Login Successful");
			EventLogger.LogSuccessfulLogin(user);
			UserLogin?.Invoke(null, new UserLoginEventArgs(user));
			//Close();
		}


		private void button1_Click(object sender, EventArgs e)
        {
			Form dashboard = new Dashboard();

			dashboard.ShowDialog();
		}
    }
}
