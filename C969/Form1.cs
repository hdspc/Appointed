using C969.Events;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace C969
{
    public partial class Form1 : Form
    {
        MySqlConnection connect = Database.DBConnection.conn;
        public event EventHandler<UserLogin> UserLogin;

        bool isSpanish = false;
        CultureInfo currentCulture = CultureInfo.CurrentCulture;

        public Form1()
        {
            InitializeComponent();
            string c = connect.DataSource;
            sqlStatusLabel.Text = "Connected to " + c;
            loginTitleLabel.Text = "hello:";

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<UserAccount> allUsers = Database.DBConnection.GetAllUserAccounts();

            string spanishPass = "Verifica tu contraseña";


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

                            if (isSpanish)
                            {
                                MessageBox.Show($"{u.Username} conectado");
                            }
                            else
                            {
                                MessageBox.Show($"User \"{u.Username}\" logged in.");

                            }

                            Form dashboard = new Dashboard(u);
                            List<Appointment> allAppointments = Database.DBConnection.GetAllAppointments();

                            AppointmentNotification(allAppointments, u);

                            dashboard.Show();
                            
                        }

                        else
                        {
                            // Password doesn't match
                            EventLogger.LogUnsuccessfulLogin(txt_UserIDTextBox.Text);



                            if (isSpanish)
                            {
                                MessageBox.Show("Verifica tu contraseña");
                            }
                            else
                            {
                                MessageBox.Show("Check your password.");
                            }
                        }
                        // No matching Username was found. Throw Exception

                    }

                    else
                    {
                        EventLogger.LogUnsuccessfulLogin(txt_UserIDTextBox.Text);
                        if (isSpanish)
                        {
                            MessageBox.Show("Verifica tu nombre de usuario");
                        }
                        else
                        {
                            MessageBox.Show("Check your username.");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OnUserLoggedIn(UserAccount user)
        {

            EventLogger.LogSuccessfulLogin(user);
           // UserLogin?.Invoke(null, new UserLogin(user));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UserAccount u = new UserAccount(1, "foo", "foo", true, DateTime.Now, "foo", DateTime.Now, "foo");

            Form dashboard = new Dashboard(u);

            dashboard.ShowDialog();

        }

        private void timer_1sTick_Tick(object sender, EventArgs e)
        {


            if (currentCulture.TwoLetterISOLanguageName == "es")
            {
                isSpanish = true;
                loginTitleLabel.Text = "Hola";
                userIDLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                SqlConnectionLabel.Text = "Estado de conexión SQL";
                submitButton.Text = "Enviar";
            }
            else
            {
                isSpanish = false;

            }


        }

        private void AppointmentNotification(List<Appointment> allAppointments, UserAccount _u)
        {
            foreach (Appointment appt in allAppointments)
            {
                if (appt.Start.ToLocalTime().Date == DateTime.Now.ToLocalTime().Date &&
                    appt.Start.ToLocalTime() <= DateTime.Now.AddMinutes(15) &&
                    appt.Start.ToLocalTime() > DateTime.Now.ToLocalTime() &&
                    appt.UserID == _u.ID
                    )
                {

                    MessageBox.Show($"You have an appointment #{appt.AppointmentID} at {appt.Start.ToLocalTime()}");

                }



            }
        }


    }
}


