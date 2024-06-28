using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.Pages
{
    public partial class frmAddEditCustomer : DevExpress.XtraEditors.XtraForm
    {

        
        int _CustomerID;
        clsCustomer _Customer ; 
        DataTable _dt = new DataTable();



        public frmAddEditCustomer()
        {
            InitializeComponent();
            _Mode = enMode.AddNew; 
            
        }
         public frmAddEditCustomer(int CustomerID)
        {
            InitializeComponent();
            _Mode = enMode.Update; 
            _CustomerID = CustomerID;
            
        }
        enum enMode { AddNew=0, Update=1};
        enMode _Mode = enMode.AddNew; 

        void _FillCategoriesComboBox()
        {
              _dt = clsCategory.GetAllCategories();
            if(_dt != null)
            {
                foreach (DataRow r in _dt.Rows)
                {
                    cbCats.Items.Add(r["CatName"]);
                }
            }
        }
        void _ResetDefaultValues()
        {
            _FillCategoriesComboBox();
            if (_Mode == enMode.Update)
            {
                this.Text = "تعديل عميل سابق";
                btnSave.Text = "تعديل";

            }
            else
                _Customer = new clsCustomer(); 

            txtAddress.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            if (_dt != null)
                cbCats.SelectedIndex = 0; 
           

        }
        private void _LoadInfo()
        {
            _Customer = clsCustomer.FindCustomerByCustomerID(_CustomerID);
            if(_Customer==null)
            {
                MessageBox.Show("لم يتم ايجاد العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbCats.SelectedIndex = cbCats.FindString(clsCategory.FindCategoryByID(_Customer.CatID).CatName);
            txtFullName.Text = _Customer.FullName;
            txtAddress.Text = _Customer.Address;
            txtPhone.Text = _Customer.Phone;
            

        }
        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Customer.CatID = cbCats.SelectedIndex + 1;
            _Customer.FullName = txtFullName.Text.Trim();
            _Customer.Phone = txtPhone.Text.Trim();
            _Customer.Address = txtAddress.Text.Trim();

            if(_Customer.Save())
            {
                MessageBox.Show("تم حفظ العميل بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("لم يتم حفظ العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}