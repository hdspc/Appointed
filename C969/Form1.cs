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
using System.Globalization;

namespace C969
{
	public partial class Form1 : Form
	{
		MySqlConnection connect = Database.DBConnection.conn;
		public event EventHandler<UserLogin> UserLogin;

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
							// Login Successful
							OnUserLoggedIn(u);
							AssignCurrentUser(u);
							Form dashboard = new Dashboard(u);

							dashboard.ShowDialog();
							return;
						}
						else
						{
							// Password doesn't match
							EventLogger.LogUnsuccessfulLogin(txt_UserIDTextBox.Text);
						//	throw new LoginInvalidException("Password does not match.");
							MessageBox.Show("Check your password.");
						}
					}

				}
				// No matching Username was found. Throw Exception
				EventLogger.LogUnsuccessfulLogin(txt_UserIDTextBox.Text);
				//throw new LoginInvalidException("User account does not exist");
				MessageBox.Show("Check your username.");
				
			}
			catch (/*LoginInvalidException ex*/Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void OnUserLoggedIn(UserAccount user)
		{
			EventLogger.LogSuccessfulLogin(user);
			UserLogin?.Invoke(null, new UserLogin(user));
		}

		public static CurrentUser AssignCurrentUser(UserAccount user)
		{
			MessageBox.Show("Login successful, current user: "+ user.Username.ToString());
			CurrentUser currentUser = new CurrentUser(user.ID, user.Username, user.Password, user.IsActive, user.DateCreated, user.CreatedBy, user.LastUpdated, user.LastUpdatedBy);

			return currentUser;

		}


		private void button1_Click(object sender, EventArgs e)
		{
			UserAccount u = new UserAccount(1, "foo", "foo", true, DateTime.Now, "foo", DateTime.Now , "foo");

			Form dashboard = new Dashboard(u);

			dashboard.ShowDialog();
		}

        private void timer_1sTick_Tick(object sender, EventArgs e)
        {
			//System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
			//MessageBox.Show("pw");
		}
	}
}
