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
            this.btnTransaction = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAbout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lblUser = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.btnHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.lblOnHim = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem3 = new DevExpress.XtraBars.BarHeaderItem();
            this.forHim = new DevExpress.XtraBars.BarHeaderItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(312, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(875, 626);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnTransaction,
            this.btnCustomer,
            this.btnReport,
            this.btnSettings,
            this.btnAbout});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(312, 626);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTransaction.Text = "الديون";
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCustomer.Text = "العملاء";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReport
            // 
            this.btnReport.Name = "btnReport";
            this.btnReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnReport.Text = "التقارير ";
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSettings.Text = "الاعدادات";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAbout.Text = "حول";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.lblUser,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barHeaderItem1,
            this.lblOnHim,
            this.barHeaderItem3,
            this.forHim});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1187, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblUser);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barHeaderItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblOnHim);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barHeaderItem3);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.forHim);
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
            this.lblUser,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barHeaderItem1,
            this.lblOnHim,
            this.barHeaderItem3,
            this.forHim});
            this.fluentFormDefaultManager1.MaxItemId = 8;
            // 
            // btnHome
            // 
            this.btnHome.Name = "btnHome";
            this.btnHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHome.Text = "الرئيسية ";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "عليه : ";
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "......";
            this.barStaticItem3.Id = 3;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "عليه: ";
            this.barHeaderItem1.Id = 4;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // lblOnHim
            // 
            this.lblOnHim.Caption = "....";
            this.lblOnHim.Id = 5;
            this.lblOnHim.Name = "lblOnHim";
            // 
            // barHeaderItem3
            // 
            this.barHeaderItem3.Caption = "له:";
            this.barHeaderItem3.Id = 6;
            this.barHeaderItem3.Name = "barHeaderItem3";
            // 
            // forHim
            // 
            this.forHim.Caption = "....";
            this.forHim.Id = 7;
            this.forHim.Name = "forHim";
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
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTransaction;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAbout;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem lblUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHome;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem lblOnHim;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem3;
        private DevExpress.XtraBars.BarHeaderItem forHim;
    }
}

