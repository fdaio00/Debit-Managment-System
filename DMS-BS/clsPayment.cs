using System;
using System.Data;

public class clsPayment
{
    private enum enMode { AddNew = 0, Update = 1 };
    enMode _Mode = enMode.AddNew;

    public int PaymentID { get; set; }
    public int DebtID { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }

    public clsPayment()
    {
        this.PaymentID = -1;
        this.DebtID = -1;
        this.Amount = 0;
        this.PaymentDate = DateTime.MinValue;
        _Mode = enMode.AddNew;
    }

    private clsPayment(int paymentID, int debtID, decimal amount, DateTime paymentDate)
    {
        _Mode = enMode.Update;
        this.PaymentID = paymentID;
        this.DebtID = debtID;
        this.Amount = amount;
        this.PaymentDate = paymentDate;
    }

    private bool _AddNewPayment()
    {
        this.PaymentID = clsPaymentData.AddNewPayment(this.DebtID, this.Amount, this.PaymentDate);
        return (this.PaymentID != -1);
    }

    private bool _UpdatePayment()
    {
        return clsPaymentData.UpdatePayment(this.PaymentID, this.DebtID, this.Amount, this.PaymentDate);
    }

    public bool Save()
    {
        switch (_Mode)
        {
            case enMode.AddNew:
                if (_AddNewPayment())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }
            case enMode.Update:
                return _UpdatePayment();
            default:
                return false;
        }
    }

    public static DataTable GetAllPayments()
    {
        return clsPaymentData.GetAllPayments();
    }

    public static clsPayment FindPaymentByID(int paymentID)
    {
        int debtID = -1;
        decimal amount = 0;
        DateTime paymentDate = DateTime.MinValue;

        bool isFound = clsPaymentData.GetPaymentByID(paymentID, ref debtID, ref amount, ref paymentDate);
        if (isFound)
        {
            return new clsPayment(paymentID, debtID, amount, paymentDate);
        }
        else
        {
            return null;
        }
    }

    public static bool DeleteByPaymentID(int paymentID)
    {
        return clsPaymentData.DeletePayment(paymentID);
    }
}
