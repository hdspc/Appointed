using System;
using System.Windows.Forms;

namespace C969
{
    public partial class AddUser : Form
    {
        private UserAccount _u;

        public AddUser(UserAccount u)
        {
            InitializeComponent();

            _u = u;

            txt_userID.Text = Database.DBConnection.GetNewIdFromTable("user", "userId").ToString();

            btn_Save.Enabled = false;
            lbl_passwordWarning.Visible = false;


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int newUserID = Int32.Parse(txt_userID.Text);
                string newUserName = txt_username.Text;
                string newPass = txt_password.Text;
                string verifyPass = txt_password2.Text;

                int active = 0;
                bool activeChecked = checkbox_active.Checked;

                DateTime createDate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string createdBy = _u.Username;
                DateTime lastUpdate = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                string lastUpdatedBy = _u.Username;

                if (activeChecked)
                {
                    active = 1;
                } 

                UserAccount userAccount = new UserAccount(newUserID, newUserName, newPass, active, createDate, createdBy, lastUpdate, lastUpdatedBy);

                 string userString = $"{newUserID}, \"{newUserName}\", \"{newPass}\", \"{active}\", \"{createDate:yyyy-MM-dd HH:mm:ss}\", \"{createdBy}\", \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", \"{lastUpdatedBy}\"";

                int rowsAffected = Database.DBConnection.InsertNewRecord("user", userString);

                if (rowsAffected > 0)
                {

                    MessageBox.Show($"{rowsAffected} record saved!");
                    EventLogger.LogUnspecifiedEntry($"{_u.Username.ToString()} created new Customer with ID {txt_userID.Text}");
                    Close();

                }
                else
                {
                    MessageBox.Show("Record did not insert into the database. This customer has not been saved.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_password2_TextChanged(object sender, EventArgs e)
        {
            string newPass = txt_password.Text;
            string verifyPass = txt_password2.Text;
            
            if (newPass == verifyPass)
            {
                btn_Save.Enabled = true;
                lbl_passwordWarning.Visible = false;

            }
            else
            {
                btn_Save.Enabled = false;
                lbl_passwordWarning.Visible = true;
            }

        }
    }
}
