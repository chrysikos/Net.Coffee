namespace Net.Coffee.Manager
{
    partial class ViewMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_AddUser = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ListUsers = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_AccountList = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_AddTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ListTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_AddUser,
            this.btn_ListUsers,
            this.btn_AccountList,
            this.btn_AddTransaction,
            this.btn_ListTransaction,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1278, 231);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Manage";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_AddUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ListUsers);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Users";
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Caption = "Add";
            this.btn_AddUser.Id = 1;
            this.btn_AddUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddUser.ImageOptions.Image")));
            this.btn_AddUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_AddUser.ImageOptions.LargeImage")));
            this.btn_AddUser.Name = "btn_AddUser";
            // 
            // btn_ListUsers
            // 
            this.btn_ListUsers.Caption = "List";
            this.btn_ListUsers.Id = 2;
            this.btn_ListUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ListUsers.ImageOptions.Image")));
            this.btn_ListUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ListUsers.ImageOptions.LargeImage")));
            this.btn_ListUsers.Name = "btn_ListUsers";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_AccountList);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Accounts";
            // 
            // btn_AccountList
            // 
            this.btn_AccountList.Caption = "List";
            this.btn_AccountList.Id = 3;
            this.btn_AccountList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_AccountList.ImageOptions.Image")));
            this.btn_AccountList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_AccountList.ImageOptions.LargeImage")));
            this.btn_AccountList.Name = "btn_AccountList";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_AddTransaction);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_ListTransaction);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Transactions";
            // 
            // btn_AddTransaction
            // 
            this.btn_AddTransaction.Caption = "Add";
            this.btn_AddTransaction.Id = 4;
            this.btn_AddTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddTransaction.ImageOptions.Image")));
            this.btn_AddTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_AddTransaction.ImageOptions.LargeImage")));
            this.btn_AddTransaction.Name = "btn_AddTransaction";
            // 
            // btn_ListTransaction
            // 
            this.btn_ListTransaction.Caption = "List";
            this.btn_ListTransaction.Id = 5;
            this.btn_ListTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ListTransaction.ImageOptions.Image")));
            this.btn_ListTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ListTransaction.ImageOptions.LargeImage")));
            this.btn_ListTransaction.Name = "btn_ListTransaction";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Monitoring";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Reporting";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Configuration";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 1023);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net.Coffee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_AddUser;
        private DevExpress.XtraBars.BarButtonItem btn_ListUsers;
        private DevExpress.XtraBars.BarButtonItem btn_AccountList;
        private DevExpress.XtraBars.BarButtonItem btn_AddTransaction;
        private DevExpress.XtraBars.BarButtonItem btn_ListTransaction;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

