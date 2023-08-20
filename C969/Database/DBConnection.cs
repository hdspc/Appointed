using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
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

		public static List<Address> GetAllAddresses()
		{
			List<Address> allAddresses = new List<Address>();

			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
			MySqlConnection db = new MySqlConnection(constr);

			string allAppointmentsQuery = $"SELECT * FROM address";
			MySqlCommand selectAllAppointmentsCommand = new MySqlCommand(allAppointmentsQuery, db);

			try
			{
				db.Open();

				MySqlDataReader reader = selectAllAppointmentsCommand.ExecuteReader();

				while (reader.Read())
				{
					Address address = new Address(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetDateTime(8), reader.GetString(9));


					allAddresses.Add(address);
				}

				return allAddresses;
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

		public static List<City> GetAllCities()
		{
			List<City> allCities = new List<City>();

			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
			MySqlConnection db = new MySqlConnection(constr);

			string allCitiesQuery = $"SELECT * FROM city";
			MySqlCommand selectAllCitiesCommand = new MySqlCommand(allCitiesQuery, db);

			try
			{
				db.Open();

				MySqlDataReader reader = selectAllCitiesCommand.ExecuteReader();

				while (reader.Read())
				{
					City city = new City(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(4), reader.GetDateTime(5), reader.GetString(6));


					allCities.Add(city);
				}

				return allCities;
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



		public static int GetAppointmentTypeCount(int userID, string appointmentType, string chosenMonth)
		{
			UserAccount _u = GetUserById(userID);

			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
			MySqlConnection db = new MySqlConnection(constr);

			string typeCountQuery = $"SELECT COUNT(type) FROM appointment WHERE type='{appointmentType}' && userId = {userID} && MONTHNAME(start) = '{chosenMonth}'";

			MySqlCommand countTypesCommand = new MySqlCommand(typeCountQuery, db);


			try
			{
				db.Open();
				MySqlDataReader rdr = countTypesCommand.ExecuteReader();

				while (rdr.Read())
				{
					//MessageBox.Show("appointments = " + rdr[0].ToString());
					//MessageBox.Show(rdr[0].ToString());

				}

				return Int32.Parse(rdr[0].ToString());
				


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

		public static int GetNumberAppointmentsForCustomer(int customerID)
		{

			string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
			MySqlConnection db = new MySqlConnection(constr);

			string typeCountQuery = $"SELECT COUNT(customerId) FROM appointment WHERE customerID = {customerID}";

			MySqlCommand countTypesCommand = new MySqlCommand(typeCountQuery, db);


			try
			{
				db.Open();
				MySqlDataReader rdr = countTypesCommand.ExecuteReader();

				while (rdr.Read())
				{
				}

				return Int32.Parse(rdr[0].ToString());



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


		public static string GetStringFromTable(int IDNumber, string IDType, string columnName, string table)
		{
			MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);

			string getStringQuery = $"SELECT {columnName} FROM {table} WHERE {IDType} = {IDNumber}";
			MySqlCommand selectUsersCommand = new MySqlCommand(getStringQuery, connect);

			try
			{
				connect.Open();

				MySqlDataReader reader = selectUsersCommand.ExecuteReader();

				while (reader.Read())
				{
				}

				return reader[0].ToString();
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

		public static int GetIntFromTable(string columnName, string table, string where, string lookup)
		{
			int retrievedInt = -1;

			MySqlConnection connect = new MySqlConnection(ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);

			string getIntQuery = $"SELECT {columnName} FROM {table} WHERE {where} = \"{lookup}\"";
			MySqlCommand selectIntCommand = new MySqlCommand(getIntQuery, connect);

			try
			{
				connect.Open();

				retrievedInt = (Int32)selectIntCommand.ExecuteScalar();

				//if (reader.Read())
				//{
				//}

			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
				return -1;
			}
				return /*Int32.Parse(reader[0].ToString());*/ retrievedInt;

				//connect.Close();
			
		}

		public static bool DoesCityExist(string CITYNAME)
		{
			List<City> allCities = Database.DBConnection.GetAllCities();
			foreach (City city in allCities)
				if (city.CityName == CITYNAME)
				{
					return true;
				}
			return false;
		}

		public static int GetCityID(string cityName)
		{
			bool cityExists = Database.DBConnection.DoesCityExist(cityName);
			int cityIDInit = -1;

			if (cityExists == false)
			{
				int newID = Database.DBConnection.GetNewIdFromTable("city", "cityId");
				cityIDInit = newID;



				return cityIDInit;

			}

			try
			{
				int cityID = Database.DBConnection.GetIntFromTable("cityId", "city", "city", cityName);

				return cityID;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return -1;
			}
		}




	}
}




