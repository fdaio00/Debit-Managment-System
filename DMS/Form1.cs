using DevExpress.XtraBars;
using DMS.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DMS
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        
        public Form1()
        {
            InitializeComponent();
            pgCustomers pg = new pgCustomers();
            LoadPage(pg);   
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pgCustomers pg = new pgCustomers();
            LoadPage(pg);
        }

        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                fluentDesignFormContainer1.Controls.Clear(); 
                Page.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(Page);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
