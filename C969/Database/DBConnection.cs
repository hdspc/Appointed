using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969.Database
{
    class DBConnection
    {
        public static MySqlConnection conn { get; set; }


        #region Start Connection from webinars

        public static void startConnection()
    {
        try
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            conn = new MySqlConnection(constr);

            //open connection

            conn.Open();
          //  MessageBox.Show(conn);
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);

        }
    }
    public static void closeConnection()
    {
        try
        {
            //close the connection
            if (conn != null)
            {
                conn.Close();
            }

            conn = null;
        }

        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);

        }


}

        #endregion

        public static int InsertNewRecord(string table, string values)
        {

            // Build the Query to Run
            StringBuilder insertQueryBuilder = new StringBuilder();
            insertQueryBuilder.Append($"INSERT INTO {table} VALUES ({values});");
            string addQuery = insertQueryBuilder.ToString();

            MySqlCommand insertCommand = new MySqlCommand(addQuery, conn);

            // Attempt to run the query against the database, and return the number of rows affected
            try
            {
                
                return insertCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
              // Dashboard.FormRefresh();
            }
        }

        public static int UpdateRecord(string table, string values, string where = "")
        {
            MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);

            // Build the Query to Run
            StringBuilder updateQueryBuilder = new StringBuilder();
            updateQueryBuilder.Append($"UPDATE {table} SET {values}");

            if (where != "")
            {
                updateQueryBuilder.Append($" WHERE {where};");
            }
            else
            {
                updateQueryBuilder.Append(";");
            }



            string query = updateQueryBuilder.ToString();

            MySqlCommand updateCommand = new MySqlCommand(query, connect);

            // Attempt to run the query against the database, and return the number of rows affected
            try
            {
                connect.Open();
                return updateCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

                return -1;
            }
            finally
            {
                connect.Close();
            }
        }

        
        public static List<UserAccount> GetAllUserAccounts()
        {
            List<UserAccount> allUsers = new List<UserAccount>();
            
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection db = new MySqlConnection(constr);

            string allUsersQuery = "SELECT * FROM user";
            MySqlCommand selectAllUsersCommand = new MySqlCommand(allUsersQuery, db);

            try
            {
                db.Open();
                MySqlDataReader reader = selectAllUsersCommand.ExecuteReader();

                while (reader.Read())
                {
                    UserAccount user = new UserAccount(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetDateTime(4), reader.GetString(5));
                    allUsers.Add(user);
                }

                return allUsers;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                db.Close();
            }
        }



            public static int GetNewIdFromTable(string table, string idColumnName)
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            
            string query = $"SELECT MAX({idColumnName}) FROM {table}";
            MySqlCommand selectCommand = new MySqlCommand(query, conn);

            try
            {
                conn.Open();

                int maxID = 9998;
                MySqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    maxID = reader.GetInt32(0);
                }

                return maxID + 1;
            }
            catch (MySqlException ex)
            {
                EventLogger.LogConnectionIssue();
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

 
        public static UserAccount GetUserById(int userId)
        {
            MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);

            string selectUsersQuery = $"SELECT * FROM user WHERE userId = {userId}";
            MySqlCommand selectUsersCommand = new MySqlCommand(selectUsersQuery, connect);

            try
            {
                connect.Open();

                MySqlDataReader reader = selectUsersCommand.ExecuteReader();
                UserAccount selectedUser = null;

                while (reader.Read())
                {
                    selectedUser = new UserAccount(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetDateTime(4), reader.GetString(5));
                }

                return selectedUser;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                connect.Close();
            }
        }
        /*
        public static DateTime GetAllStartTimesByID(int userID)
        {
            DateTime startTime = new DateTime();
            List<Appointment> allAppointments = new List<Appointment>();

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection db = new MySqlConnection(constr);

            string allStartsQuery = $"SELECT start FROM appointment where userId = {userID}";
            MySqlCommand selectAllStartTimesCommand = new MySqlCommand(allStartsQuery, db);

            try
            {
                db.Open();
                return selectAllStartTimesCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

                return DateTime.Now;
            }
            finally
            {
                db.Close();
            }
        }
*/

        public static List<Appointment> GetAllAppointments()
        {
            List<Appointment> allAppointments = new List<Appointment>();

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection db = new MySqlConnection(constr);
            
            string allAppointmentsQuery = "SELECT * FROM appointment";
            MySqlCommand selectAllAppointmentsCommand = new MySqlCommand(allAppointmentsQuery, db);

            try
            {
                db.Open();

                MySqlDataReader reader = selectAllAppointmentsCommand.ExecuteReader();

                while (reader.Read())
                {
                    Appointment appointment = new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                        reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetDateTime(10), reader.GetDateTime(11), reader.GetString(12), reader.GetDateTime(13), reader.GetString(14));

                    allAppointments.Add(appointment);
                }

                return allAppointments;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                db.Close();
            }
        }


        
    public static int GetAppointmentTypeCount(int userID)
    {
        List<Appointment> allAppointments = new List<Appointment>();

        string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        MySqlConnection db = new MySqlConnection(constr);

        string typeCountQuery = $"SELECT COUNT(type) as typez FROM appointment where userId = {userID}";
        MySqlCommand countTypesCommand = new MySqlCommand(typeCountQuery, db);

        try
        {
            db.Open();
            return countTypesCommand.ExecuteNonQuery();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.ToString());
                return -1;
        }
        finally
        {
            db.Close();
        }
    }











    }
}

