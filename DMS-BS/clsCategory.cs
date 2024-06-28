using System;
using System.Data;

public class clsCategory
{
    private enum enMode { AddNew = 0, Update = 1 };
    enMode _Mode = enMode.AddNew;

    public int CatID { get; set; }
    public string CatName { get; set; }

    public clsCategory()
    {
        this.CatID = -1;
        this.CatName = "";
        _Mode = enMode.AddNew;
    }

    private clsCategory(int ?catID, string catName)
    {
        _Mode = enMode.Update;
        this.CatID = catID??-1;
        this.CatName = catName;
    }

    private bool _AddNewCategory()
    {
        this.CatID = clsCategoryData.AddNewCategory(this.CatName);
        return (this.CatID != -1);
    }

    private bool _UpdateCategory()
    {
        return clsCategoryData.UpdateCategory(this.CatID, this.CatName);
    }

    public bool Save()
    {
        switch (_Mode)
        {
            case enMode.AddNew:
                if (_AddNewCategory())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }
            case enMode.Update:
                return _UpdateCategory();
            default:
                return false;
        }
    }

    public static DataTable GetAllCategories()
    {
        return clsCategoryData.GetAllCategories();
    }

    public static clsCategory FindCategoryByID(int ?catID)
    {
        string catName = "";

        bool isFound = clsCategoryData.GetCategoryByID(catID, ref catName);
        if (isFound)
        {
            return new clsCategory(catID, catName);
        }
        else
        {
            return null;
        }
    }

    public static bool DeleteByCategoryID(int catID)
    {
        return clsCategoryData.DeleteCategory(catID);
    }
}
