using System;
using System.Data;

public class clsDebt
{
    private enum enMode { AddNew = 0, Update = 1 };
    enMode _Mode = enMode.AddNew;

    public int DebtID { get; set; }
    public int CustomerID { get; set; }
    public string Details { get; set; }
    public decimal Amount { get; set; }
    public DateTime DebtDate { get; set; }
    public bool Status { get; set; }

    public clsDebt()
    {
        this.DebtID = -1;
        this.CustomerID = -1;
        this.Details = "";
        this.Amount = 0;
        this.DebtDate = DateTime.MinValue;
        this.Status = false;
        _Mode = enMode.AddNew;
    }

    private clsDebt(int debtID, int customerID, string details, decimal amount, DateTime debtDate, bool status)
    {
        _Mode = enMode.Update;
        this.DebtID = debtID;
        this.CustomerID = customerID;
        this.Details = details;
        this.Amount = amount;
        this.DebtDate = debtDate;
        this.Status = status;
    }

    private bool _AddNewDebt()
    {
        this.DebtID = clsDebtData.AddNewDebt(this.CustomerID, this.Details, this.Amount, this.DebtDate, this.Status);
        return (this.DebtID != -1);
    }

    private bool _UpdateDebt()
    {
        return clsDebtData.UpdateDebt(this.DebtID, this.CustomerID, this.Details, this.Amount, this.DebtDate, this.Status);
    }

    public bool Save()
    {
        switch (_Mode)
        {
            case enMode.AddNew:
                if (_AddNewDebt())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }
            case enMode.Update:
                return _UpdateDebt();
            default:
                return false;
        }
    }

    public static DataTable GetAllDebts()
    {
        return clsDebtData.GetAllDebts();
    }

    public static clsDebt FindDebtByID(int debtID)
    {
        int customerID = -1;
        string details = "";
        decimal amount = 0;
        DateTime debtDate = DateTime.MinValue;
        bool status = false;

        bool isFound = clsDebtData.GetDebtByID(debtID, ref customerID, ref details, ref amount, ref debtDate, ref status);
        if (isFound)
        {
            return new clsDebt(debtID, customerID, details, amount, debtDate, status);
        }
        else
        {
            return null;
        }
    }

    public static bool DeleteByDebtID(int debtID)
    {
        return clsDebtData.DeleteDebt(debtID);
    }
}
