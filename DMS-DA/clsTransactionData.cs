using DMS_DA;
using System;
using System.Data;
using System.Data.SqlClient;

public static class clsTransactionData
{
    public static DataTable GetAllTransactions()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllTransactions", connection))
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

    public static int AddTransaction(int customerID, string details, decimal debit, decimal credit, DateTime transactionDate)
    {
        int transactionID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Details", details);
                command.Parameters.AddWithValue("@Debit", debit);
                command.Parameters.AddWithValue("@Credit", credit);
                command.Parameters.AddWithValue("@TransactionDate", transactionDate);

                try
                {
                    connection.Open();
                    transactionID = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return transactionID;
    }

    public static bool UpdateTransaction(int transactionID, int customerID, string details, decimal debit, decimal credit, DateTime transactionDate)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TransactionID", transactionID);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Details", details);
                command.Parameters.AddWithValue("@Debit", debit);
                command.Parameters.AddWithValue("@Credit", credit);
                command.Parameters.AddWithValue("@TransactionDate", transactionDate);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
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

    public static bool DeleteTransaction(int transactionID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TransactionID", transactionID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
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

    public static bool GetTransactionByID(int transactionID, ref int customerID, ref string details, ref decimal debit, ref decimal credit, ref DateTime transactionDate)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetTransactionByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TransactionID", transactionID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        customerID = (int)reader["CustomerID"];
                        details = reader["Details"].ToString();
                        debit = (decimal)reader["Debit"];
                        credit = (decimal)reader["Credit"];
                        transactionDate = (DateTime)reader["TransactionDate"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return isFound;
    }
}
