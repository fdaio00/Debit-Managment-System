namespace DMS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTransaction = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAbout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lblUser = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.xpDataView1 = new DevExpress.Xpo.XPDataView(this.components);
            this.btnHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(62, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1125, 626);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnCustomer,
            this.btnTransaction,
            this.btnReport,
            this.btnSettings,
            this.btnAbout});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(62, 626);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnCustomer
            // 
            this.btnCustomer.ImageOptions.SvgImage = global::DMS.Properties.Resources.customers;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCustomer.Text = "العملاء";
            // 
            // btnTransaction
            // 
            this.btnTransaction.ImageOptions.SvgImage = global::DMS.Properties.Resources.currency;
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTransaction.Text = "العمليات";
            // 
            // btnReport
            // 
            this.btnReport.ImageOptions.SvgImage = global::DMS.Properties.Resources.printallpages;
            this.btnReport.Name = "btnReport";
            this.btnReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnReport.Text = "التقارير ";
            // 
            // btnSettings
            // 
            this.btnSettings.ImageOptions.SvgImage = global::DMS.Properties.Resources.properties;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSettings.Text = "الاعدادات";
            // 
            // btnAbout
            // 
            this.btnAbout.ImageOptions.SvgImage = global::DMS.Properties.Resources.about;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAbout.Text = "حول";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.lblUser});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1187, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblUser);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "اسم المستخدم:";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // lblUser
            // 
            this.lblUser.Caption = "اسم المستخدم";
            this.lblUser.Id = 1;
            this.lblUser.Name = "lblUser";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.lblUser});
            this.fluentFormDefaultManager1.MaxItemId = 2;
            // 
            // xpDataView1
            // 
            this.xpDataView1.CaseSensitive = false;
            // 
            // btnHome
            // 
            this.btnHome.ImageOptions.SvgImage = global::DMS.Properties.Resources.bo_address;
            this.btnHome.Name = "btnHome";
            this.btnHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHome.Text = "الرئيسية ";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 665);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ديوني";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCustomer;
        private DevExpress.Xpo.XPDataView xpDataView1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTransaction;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAbout;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem lblUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHome;
    }
}

