using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using DMS.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS.Debts
{
    public partial class frmAddEditDebt : DevExpress.XtraEditors.XtraForm
    {

        DataTable _dt = new DataTable();
        clsDebt _Debt;

        int? _CustomerID = -1; 
        public frmAddEditDebt()
        {
            InitializeComponent();
        }


        void _FillCustomersComboBox()
        {
            //if (_dt == null)
            //    return;
            //foreach (DataRow r in _dt.Rows)
            //{
            //    comboBox1.Items.Add(r["الاسم الكامل"]);
            //}
        }
        private void frmAddEditDebt_Load(object sender, EventArgs e)
        {

            _dt = clsCustomer.GetAllCustomers();
            listBox1.Items.AddRange(_dt.AsEnumerable().Select(row => row.Field<string>("الاسم الكامل")).ToArray());
            SetAutoCompleteSource();

            //_FillCustomersComboBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtCusstomerName.Text.ToLower();
            var filteredItems = _dt.AsEnumerable()
                                        .Where(row => row.Field<string>("الاسم الكامل").ToLower().Contains(filterText))
                                        .Select(row => row.Field<string>("الاسم الكامل"))
                                        .ToArray();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(filteredItems);
             if (filteredItems.Any())
            {
                listBox1.Visible = true; // Show ListBox when there are matching items
            }
            else
            {
                listBox1.Visible = false; // Hide ListBox when there are no matching items
            }
        }
        private void SetAutoCompleteSource()
        {
            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            autoCompleteData.AddRange(_dt.AsEnumerable().Select(row => row.Field<string>("الاسم الكامل")).ToArray());

            txtCusstomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCusstomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCusstomerName.AutoCompleteCustomSource = autoCompleteData;
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox1.Visible = false;
            txtCusstomerName.Text = listBox1.Text;
            listBox1.Items.Clear();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                    {
                        listBox1.SelectedIndex++;
                    }
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (listBox1.SelectedIndex > 0)
                    {
                        listBox1.SelectedIndex--;
                    }
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (listBox1.SelectedIndex != -1)
                    {
                        txtCusstomerName.Text = listBox1.SelectedItem.ToString();
                        listBox1.Visible = false; // Hide ListBox after selecting an item
                        listBox1.Items.Clear();   // Clear ListBox items
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true; // Suppress the Enter key to prevent the 'ding' sound
                }
            }
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
           
            listBox1.Items.Clear(); // Clear ListBox when TextBox loses focus

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                txtCusstomerName.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false; // Hide ListBox after selecting an item
                listBox1.Items.Clear();   // Clear ListBox items
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                txtCusstomerName.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false; // Hide ListBox after selecting an item
                listBox1.Items.Clear();   // Clear ListBox items
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SendToBack(object sender , int CustomerID)
        {
            _CustomerID = CustomerID; 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            clsCustomer Customer = clsCustomer.GetCustomerByFullName(txtCusstomerName.Text.Trim());
            _Debt = new clsDebt();
            _Debt.DebtDate = dtpDate.Value;
            //1 => Creadit , 0 => Debit
            _Debt.Amount = Convert.ToDecimal(txtAmount.Text.Trim());
            _Debt.Status = rbCredit.Checked;
            _Debt.IsPaid = false;
            _Debt.Details = txtDetails.Text.Trim(); 

            if (Customer == null)

            {
                Customer = new clsCustomer();
                MessageBox.Show($"هل تريد اضافة عميل جديد باسم {txtCusstomerName.Text}؟", "اضافة عميل", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                frmAddEditCustomer frm = new frmAddEditCustomer(txtCusstomerName.Text.Trim());
                frm._SendData += SendToBack;
                frm.ShowDialog();
                Customer.CustomerID= _CustomerID??-1; 

            }
            _Debt.CustomerID = Customer.CustomerID;

            if (_Debt.Save())
            {
                MessageBox.Show($"تم الحفظ بنجاح", "jتم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                MessageBox.Show($"لم يتم الحفظ بنجاح","jتم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}