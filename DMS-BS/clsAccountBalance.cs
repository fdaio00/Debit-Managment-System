using System;

public class clsAccountBalance
{
    public int CustomerID { get; set; }
    public decimal Balance { get; set; }

    public clsAccountBalance(int customerID, decimal balance)
    {
        this.CustomerID = customerID;
        this.Balance = balance;
    }

    public bool Save()
    {
        return clsAccountBalanceData.UpdateAccountBalance(this.CustomerID, this.Balance);
    }

    public static decimal GetBalance(int customerID)
    {
        return clsAccountBalanceData.GetAccountBalance(customerID);
    }

    public static bool Delete(int customerID)
    {
        return clsAccountBalanceData.DeleteAccountBalance(customerID);
    }
}
