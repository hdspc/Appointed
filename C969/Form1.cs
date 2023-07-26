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
		public Form1()
		{
			InitializeComponent();
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

					MessageBox.Show("login succesaful");
				}
				catch ()
				{
					MessageBox.Show("fuck");
				}
			}
		}
    }
}
