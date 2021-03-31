
namespace YTC.PL
{
    partial class MAIN_FRM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filemenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.loginmenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.floormenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FloorMangeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.floorsMstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomsStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomsTypeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RoommanagStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CustManagStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.orderstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.neworder = new System.Windows.Forms.ToolStripMenuItem();
            this.usersstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addusersstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenustrip,
            this.floormenustrip,
            this.RoomsStrip,
            this.CustomersStrip,
            this.orderstrip,
            this.usersstrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // filemenustrip
            // 
            this.filemenustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginmenustrip});
            this.filemenustrip.Name = "filemenustrip";
            this.filemenustrip.Size = new System.Drawing.Size(42, 20);
            this.filemenustrip.Text = "ملف";
            // 
            // loginmenustrip
            // 
            this.loginmenustrip.Name = "loginmenustrip";
            this.loginmenustrip.Size = new System.Drawing.Size(144, 22);
            this.loginmenustrip.Text = "تسجيل الدخول";
            this.loginmenustrip.Click += new System.EventHandler(this.loginmenustrip_Click);
            // 
            // floormenustrip
            // 
            this.floormenustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FloorMangeStrip,
            this.floorsMstrip});
            this.floormenustrip.Name = "floormenustrip";
            this.floormenustrip.Size = new System.Drawing.Size(51, 20);
            this.floormenustrip.Text = "المبنى";
            // 
            // FloorMangeStrip
            // 
            this.FloorMangeStrip.Name = "FloorMangeStrip";
            this.FloorMangeStrip.Size = new System.Drawing.Size(159, 22);
            this.FloorMangeStrip.Text = "إضافة طابق جديد";
            this.FloorMangeStrip.Click += new System.EventHandler(this.FloorMangeStrip_Click);
            // 
            // floorsMstrip
            // 
            this.floorsMstrip.Name = "floorsMstrip";
            this.floorsMstrip.Size = new System.Drawing.Size(159, 22);
            this.floorsMstrip.Text = "إدارة الطوابق";
            this.floorsMstrip.Click += new System.EventHandler(this.floorsMstrip_Click);
            // 
            // RoomsStrip
            // 
            this.RoomsStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoomsTypeStrip,
            this.RoommanagStrip});
            this.RoomsStrip.Name = "RoomsStrip";
            this.RoomsStrip.Size = new System.Drawing.Size(56, 20);
            this.RoomsStrip.Text = "القاعات";
            // 
            // RoomsTypeStrip
            // 
            this.RoomsTypeStrip.Name = "RoomsTypeStrip";
            this.RoomsTypeStrip.Size = new System.Drawing.Size(136, 22);
            this.RoomsTypeStrip.Text = "انواع القاعات";
            this.RoomsTypeStrip.Click += new System.EventHandler(this.RoomsTypeStrip_Click);
            // 
            // RoommanagStrip
            // 
            this.RoommanagStrip.Name = "RoommanagStrip";
            this.RoommanagStrip.Size = new System.Drawing.Size(136, 22);
            this.RoommanagStrip.Text = "إدارة القاعات";
            this.RoommanagStrip.Click += new System.EventHandler(this.RoommanagStrip_Click);
            // 
            // CustomersStrip
            // 
            this.CustomersStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustManagStrip});
            this.CustomersStrip.Name = "CustomersStrip";
            this.CustomersStrip.Size = new System.Drawing.Size(52, 20);
            this.CustomersStrip.Text = "العملاء";
            // 
            // CustManagStrip
            // 
            this.CustManagStrip.Name = "CustManagStrip";
            this.CustManagStrip.Size = new System.Drawing.Size(132, 22);
            this.CustManagStrip.Text = "إدارة العملاء";
            this.CustManagStrip.Click += new System.EventHandler(this.CustManagStrip_Click);
            // 
            // orderstrip
            // 
            this.orderstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neworder});
            this.orderstrip.Name = "orderstrip";
            this.orderstrip.Size = new System.Drawing.Size(78, 20);
            this.orderstrip.Text = "حجز القاعات";
            // 
            // neworder
            // 
            this.neworder.Name = "neworder";
            this.neworder.Size = new System.Drawing.Size(152, 22);
            this.neworder.Text = "إضافة حجز جديد";
            this.neworder.Click += new System.EventHandler(this.neworder_Click);
            // 
            // usersstrip
            // 
            this.usersstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addusersstrip});
            this.usersstrip.Name = "usersstrip";
            this.usersstrip.Size = new System.Drawing.Size(79, 20);
            this.usersstrip.Text = "المستخدمين";
            // 
            // addusersstrip
            // 
            this.addusersstrip.Name = "addusersstrip";
            this.addusersstrip.Size = new System.Drawing.Size(174, 22);
            this.addusersstrip.Text = "إضافة مستخدم جديد";
            this.addusersstrip.Click += new System.EventHandler(this.addusersstrip_Click);
            // 
            // MAIN_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.IsMdiContainer = true;
            this.Name = "MAIN_FRM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MAIN_FRM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem filemenustrip;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem loginmenustrip;
        public System.Windows.Forms.ToolStripMenuItem floormenustrip;
        public System.Windows.Forms.ToolStripMenuItem FloorMangeStrip;
        public System.Windows.Forms.ToolStripMenuItem floorsMstrip;
        private System.Windows.Forms.ToolStripMenuItem RoomsTypeStrip;
        private System.Windows.Forms.ToolStripMenuItem CustManagStrip;
        private System.Windows.Forms.ToolStripMenuItem RoommanagStrip;
        private System.Windows.Forms.ToolStripMenuItem addusersstrip;
        public System.Windows.Forms.ToolStripMenuItem RoomsStrip;
        public System.Windows.Forms.ToolStripMenuItem CustomersStrip;
        public System.Windows.Forms.ToolStripMenuItem usersstrip;
        private System.Windows.Forms.ToolStripMenuItem orderstrip;
        private System.Windows.Forms.ToolStripMenuItem neworder;
    }
}