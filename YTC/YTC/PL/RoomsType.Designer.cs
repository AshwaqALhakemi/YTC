
namespace YTC.PL
{
    partial class RoomsType
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.Rid = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.btna = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.RTdesctxt = new System.Windows.Forms.TextBox();
            this.Rtypetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RYGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RYGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editbtn);
            this.groupBox1.Controls.Add(this.delbtn);
            this.groupBox1.Controls.Add(this.Rid);
            this.groupBox1.Controls.Add(this.closebtn);
            this.groupBox1.Controls.Add(this.btna);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.RTdesctxt);
            this.groupBox1.Controls.Add(this.Rtypetxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "القاعات";
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(216, 217);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 9;
            this.editbtn.Text = "تعديل";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(17, 173);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 8;
            this.delbtn.Text = "حذف";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // Rid
            // 
            this.Rid.AutoSize = true;
            this.Rid.Location = new System.Drawing.Point(247, 23);
            this.Rid.Name = "Rid";
            this.Rid.Size = new System.Drawing.Size(0, 15);
            this.Rid.TabIndex = 7;
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(64, 219);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 6;
            this.closebtn.Text = "خروج";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // btna
            // 
            this.btna.Enabled = false;
            this.btna.Location = new System.Drawing.Point(112, 173);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(75, 23);
            this.btna.TabIndex = 5;
            this.btna.Text = "اضافة";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Click += new System.EventHandler(this.btna_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(216, 173);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "جديد";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // RTdesctxt
            // 
            this.RTdesctxt.Location = new System.Drawing.Point(112, 92);
            this.RTdesctxt.Multiline = true;
            this.RTdesctxt.Name = "RTdesctxt";
            this.RTdesctxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RTdesctxt.Size = new System.Drawing.Size(100, 23);
            this.RTdesctxt.TabIndex = 3;
            this.RTdesctxt.TextChanged += new System.EventHandler(this.RTdesctxt_TextChanged);
            // 
            // Rtypetxt
            // 
            this.Rtypetxt.Location = new System.Drawing.Point(112, 48);
            this.Rtypetxt.Name = "Rtypetxt";
            this.Rtypetxt.Size = new System.Drawing.Size(100, 23);
            this.Rtypetxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "الوصف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع القاعة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RYGV);
            this.groupBox2.Location = new System.Drawing.Point(349, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 269);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات القاعات ";
            // 
            // RYGV
            // 
            this.RYGV.AllowUserToAddRows = false;
            this.RYGV.AllowUserToDeleteRows = false;
            this.RYGV.AllowUserToResizeColumns = false;
            this.RYGV.AllowUserToResizeRows = false;
            this.RYGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RYGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RYGV.Location = new System.Drawing.Point(7, 22);
            this.RYGV.Name = "RYGV";
            this.RYGV.RowTemplate.Height = 25;
            this.RYGV.Size = new System.Drawing.Size(331, 212);
            this.RYGV.TabIndex = 0;
            // 
            // RoomsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 316);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomsType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomsType";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RYGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox RTdesctxt;
        private System.Windows.Forms.TextBox Rtypetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView RYGV;
        private System.Windows.Forms.Label Rid;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button editbtn;
    }
}