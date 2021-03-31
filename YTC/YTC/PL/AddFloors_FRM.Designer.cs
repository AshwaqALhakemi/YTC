
namespace YTC.PL
{
    partial class AddFloors_FRM
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
            this.Fgroupbox = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Fdesctxt = new System.Windows.Forms.TextBox();
            this.Fnametxt = new System.Windows.Forms.TextBox();
            this.Fdesclabl = new System.Windows.Forms.Label();
            this.Fnamelabl = new System.Windows.Forms.Label();
            this.Fgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fgroupbox
            // 
            this.Fgroupbox.Controls.Add(this.btnAdd);
            this.Fgroupbox.Controls.Add(this.btnCancel);
            this.Fgroupbox.Controls.Add(this.Fdesctxt);
            this.Fgroupbox.Controls.Add(this.Fnametxt);
            this.Fgroupbox.Controls.Add(this.Fdesclabl);
            this.Fgroupbox.Controls.Add(this.Fnamelabl);
            this.Fgroupbox.Location = new System.Drawing.Point(12, 12);
            this.Fgroupbox.Name = "Fgroupbox";
            this.Fgroupbox.Size = new System.Drawing.Size(403, 315);
            this.Fgroupbox.TabIndex = 0;
            this.Fgroupbox.TabStop = false;
            this.Fgroupbox.Text = "بيانات الطابق";
            this.Fgroupbox.Enter += new System.EventHandler(this.Fgroupbox_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(109, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Fdesctxt
            // 
            this.Fdesctxt.Location = new System.Drawing.Point(109, 127);
            this.Fdesctxt.Multiline = true;
            this.Fdesctxt.Name = "Fdesctxt";
            this.Fdesctxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Fdesctxt.Size = new System.Drawing.Size(152, 23);
            this.Fdesctxt.TabIndex = 1;
            // 
            // Fnametxt
            // 
            this.Fnametxt.Location = new System.Drawing.Point(109, 72);
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.Size = new System.Drawing.Size(152, 23);
            this.Fnametxt.TabIndex = 0;
            this.Fnametxt.TextChanged += new System.EventHandler(this.Fnametxt_TextChanged);
            this.Fnametxt.Validated += new System.EventHandler(this.Fnametxt_Validated);
            // 
            // Fdesclabl
            // 
            this.Fdesclabl.AutoSize = true;
            this.Fdesclabl.Location = new System.Drawing.Point(298, 130);
            this.Fdesclabl.Name = "Fdesclabl";
            this.Fdesclabl.Size = new System.Drawing.Size(79, 15);
            this.Fdesclabl.TabIndex = 1;
            this.Fdesclabl.Text = "وصف الطابق :";
            // 
            // Fnamelabl
            // 
            this.Fnamelabl.AutoSize = true;
            this.Fnamelabl.Location = new System.Drawing.Point(308, 75);
            this.Fnamelabl.Name = "Fnamelabl";
            this.Fnamelabl.Size = new System.Drawing.Size(69, 15);
            this.Fnamelabl.TabIndex = 0;
            this.Fnamelabl.Text = "اسم الطابق :";
            // 
            // AddFloors_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 339);
            this.Controls.Add(this.Fgroupbox);
            this.MaximizeBox = false;
            this.Name = "AddFloors_FRM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المبنى";
            this.Fgroupbox.ResumeLayout(false);
            this.Fgroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Fgroupbox;
        private System.Windows.Forms.Label Fdesclabl;
        private System.Windows.Forms.Label Fnamelabl;
        public System.Windows.Forms.TextBox Fdesctxt;
        public System.Windows.Forms.TextBox Fnametxt;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnCancel;
    }
}