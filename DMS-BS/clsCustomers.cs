using System;
using System.Data;

public class clsCustomer
{
    private enum enMode { AddNew = 0, Update = 1 };
    enMode _Mode = enMode.AddNew;

    public int CustomerID { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public int?CatID { get; set; }

    public clsCustomer()
    {
        this.CustomerID = -1;
        this.FullName = "";
        this.Phone = "";
        this.Address = "";
        this.CatID = null;
        _Mode = enMode.AddNew;
    }

    private clsCustomer(int customerID, string fullName, string phone, string address, int? catID)
    {
        _Mode = enMode.Update;
        this.CustomerID = customerID;
        this.FullName = fullName;
        this.Phone = phone;
        this.Address = address;
        this.CatID = catID;
    }

    private bool _AddNewCustomer()
    {
        this.CustomerID = clsCustomerData.AddNewCustomer(this.FullName, this.Phone, this.Address, this.CatID);
        return (this.CustomerID != -1);
    }

    private bool _UpdateCustomer()
    {
        return clsCustomerData.UpdateCustomer(this.CustomerID, this.FullName, this.Phone, this.Address, this.CatID);
    }

    public bool Save()
    {
        switch (_Mode)
        {
            case enMode.AddNew:
                if (_AddNewCustomer())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }
            case enMode.Update:
                return _UpdateCustomer();
            default:
                return false;
        }
    }

    public static DataTable GetAllCustomers()
    {
        return clsCustomerData.GetAllCustomers();
    }

    public static clsCustomer FindCustomerByCustomerID(int customerID)
    {
        string fullName = "";
        string phone = "";
        string address = "";
        int? catID = null;

        bool IsFound = clsCustomerData.GetCustomerByID(customerID, ref fullName, ref phone, ref address, ref catID);
        if (IsFound)
        {
            return new clsCustomer(customerID, fullName, phone, address, catID);
        }
        else
        {
            return null;
        }
    }

    public static bool DeleteByCustomerID(int customerID)
    {
        return clsCustomerData.DeleteCustomer(customerID);
    }
}
