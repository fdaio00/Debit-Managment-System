using System;
using System.Data;

public class clsTransaction
{
    private enum enMode { AddNew = 0, Update = 1 };
    enMode _Mode = enMode.AddNew;

    public int TransactionID { get; set; }
    public int CustomerID { get; set; }
    public string Details { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public DateTime TransactionDate { get; set; }

    public clsTransaction()
    {
        this.TransactionID = -1;
        this.CustomerID = -1;
        this.Details = "";
        this.Debit = 0;
        this.Credit = 0;
        this.TransactionDate = DateTime.MinValue;
        _Mode = enMode.AddNew;
    }

    private clsTransaction(int transactionID, int customerID, string details, decimal debit, decimal credit, DateTime transactionDate)
    {
        _Mode = enMode.Update;
        this.TransactionID = transactionID;
        this.CustomerID = customerID;
        this.Details = details;
        this.Debit = debit;
        this.Credit = credit;
        this.TransactionDate = transactionDate;
    }

    private bool _AddTransaction()
    {
        this.TransactionID = clsTransactionData.AddTransaction(this.CustomerID, this.Details, this.Debit, this.Credit, this.TransactionDate);
        return (this.TransactionID != -1);
    }

    private bool _UpdateTransaction()
    {
        return clsTransactionData.UpdateTransaction(this.TransactionID, this.CustomerID, this.Details, this.Debit, this.Credit, this.TransactionDate);
    }

    public bool Save()
    {
        if (_Mode == enMode.AddNew)
            return _AddTransaction();
        else if (_Mode == enMode.Update)
            return _UpdateTransaction();
        else
            throw new InvalidOperationException("Invalid mode.");
    }

    public static bool Delete(int transactionID)
    {
        return clsTransactionData.DeleteTransaction(transactionID);
    }

    public static clsTransaction GetTransactionByID(int transactionID)
    {
        int customerID = 0;
        string details = string.Empty;
        decimal debit = 0;
        decimal credit = 0;
        DateTime transactionDate = DateTime.MinValue;

        bool isFound = clsTransactionData.GetTransactionByID(transactionID, ref customerID, ref details, ref debit, ref credit, ref transactionDate);
        if (isFound)
        {
            return new clsTransaction(transactionID, customerID, details, debit, credit, transactionDate);
        }
        else
        {
            return null;
        }
    }
}
