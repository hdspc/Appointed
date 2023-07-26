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
        
    


    public static void startConnection()
    {
        try
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            conn = new MySqlConnection(constr);

            //open connection

            conn.Open();
            MessageBox.Show("Opened succesfully");
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
    }
}

