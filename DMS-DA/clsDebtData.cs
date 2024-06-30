using DMS_DA;

using System;
using System.Data;
using System.Data.SqlClient;

public static class clsDebtData
{
    public static DataTable GetAllDebts()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllDebts", connection))
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
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return dt;
    }

    public static int AddNewDebt(int customerID, string details, decimal amount, DateTime debtDate, bool status, bool isPaid)
    {
        int debtID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddDebt", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Details", details);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@DebtDate", debtDate);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@IsPaid", isPaid);

                try
                {
                    connection.Open();
                    debtID = command.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return debtID;
    }


    public static double SumDebitCredit(int Status)
    {
        double Sum = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            string query = "select s = Sum(Amount) from Debts where Status =@Status; ";
            using (SqlCommand command = new SqlCommand(query, connection))
            {;
                command.Parameters.AddWithValue("@Status", Status);
               
                try
                {
                    connection.Open();
                    object result  = command.ExecuteScalar();
                    if (result != null && double.TryParse(result.ToString() , out double TheSum))
                            Sum = TheSum;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
               
            }
        }

        return Sum;
    }

    public static bool UpdateDebt(int debtID, int customerID, string details, decimal amount, DateTime debtDate, bool status, bool isPaid)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateDebt", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DebtID", debtID);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Details", details);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@DebtDate", debtDate);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@IsPaid", isPaid);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return success;
    }

    public static bool DeleteDebt(int debtID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteDebt", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DebtID", debtID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return success;
    }

    public static bool GetDebtByID(int debtID, ref int customerID, ref string details, ref decimal amount, ref DateTime debtDate, ref bool status , ref bool isPaid)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetDebtByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DebtID", debtID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        customerID = (int)reader["CustomerID"];
                        details = reader["Details"].ToString();
                        amount = (decimal)reader["Amount"];
                        debtDate = (DateTime)reader["DebtDate"];
                        status = (bool)reader["Status"];
                        isPaid = (bool)reader["IsPaid"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
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
