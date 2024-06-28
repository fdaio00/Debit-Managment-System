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
    public partial class pgCustomers : DevExpress.XtraEditors.XtraUserControl
    {

        DataTable _dtCustomers = new DataTable(); 
        public pgCustomers()
        {
            InitializeComponent();
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer(); 
            frm.ShowDialog();
            pgCustomers_Load(null, null);
            
        }

        private void pgCustomers_Load(object sender, EventArgs e)
        {
            _dtCustomers = clsCustomer.GetAllCustomers();
            if (_dtCustomers != null)
            {
                dataGridView1.DataSource = _dtCustomers;
            }

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Columns[0].Visible = false; 
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            pgCustomers_Load(null, null);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            pgCustomers_Load(null, null);
        }
    }
}
