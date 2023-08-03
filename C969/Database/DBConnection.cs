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


        public static List<UserAccount> GetAllUserAccounts()
        {
            List<UserAccount> allUsers = new List<UserAccount>();
            
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection db = new MySqlConnection(constr);

            string allUsersQuery = "SELECT * FROM user";
            MySqlCommand selectAllUsersCommand = new MySqlCommand(allUsersQuery, db);

            try
            {
                // startConnection();
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
                 //conn.Close();
              //closeConnection();
                db.Close();
            }
        }

        //////public static CurrentUser GetCurrentUser()
        //////{



        //////}





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






    }
}

