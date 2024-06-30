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

namespace DMS.Debts
{
    public partial class pgDbts : DevExpress.XtraEditors.XtraUserControl
    {

        DataTable _dtDebts;
        clsDebt _Debt;
        int _DebtID; 
        public pgDbts()
        {
            InitializeComponent();
        }

        private void pgDbts_Load(object sender, EventArgs e)
        {
            _dtDebts = clsDebt.GetAllDebts();
            dataGridView1.DataSource = _dtDebts; 
            if(dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false; 
                dataGridView1.Columns[6].Visible = false; 
            }

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAddEditDebt frm = new frmAddEditDebt();
            frm.ShowDialog();
            pgDbts_Load(null, null);
        }
    }
}
