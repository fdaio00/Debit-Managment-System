
using DMS_DA;
using System;
using System.Data;
using System.Data.SqlClient;

public static class clsCustomerData
{
    public static DataTable GetAllCustomers()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllCustomers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                        dt.Load(reader);
                }
                catch (Exception ex)
                {
                    // Handle exception
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return dt;
    }

    public static int AddNewCustomer(string fullName, string phone, string address, int? catID)
    {
        int rowsAffected = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@CatID", catID);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    rowsAffected = result; 


                }
                catch (Exception ex)
                {
                    // Handle exception
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return rowsAffected;
    }

    public static bool UpdateCustomer(int customerID, string fullName, string phone, string address, int? catID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@CatID", catID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return success;
    }

    public static bool DeleteCustomer(int customerID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return success;
    }

    public static bool GetCustomerByID(int? customerID, ref string fullName, ref string phone, ref string address, ref int? catID)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetCustomerByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        fullName = reader["FullName"].ToString();
                        phone = reader["Phone"].ToString();
                        address = reader["Address"].ToString();
                        catID = (int)reader["CatID"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exception
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
               
            }
        }

        return isFound;
    }


    public static bool GetCustomerByFullName(string fullName, ref int customerID, ref string phone, ref string address, ref int catID)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetCustomerByFullName", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FullName", fullName);


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        customerID = Convert.ToInt32( reader["CustomerID"]);
                        phone = reader["Phone"].ToString();
                        address = reader["Address"].ToString();
                        catID = (int)reader["CatID"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Handle exception
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return isFound;
    }

}
