
namespace YTC.PL
{
    partial class Customers_FRM
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustDGV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.Ptxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Jtxt = new System.Windows.Forms.TextBox();
            this.Otxt = new System.Windows.Forms.TextBox();
            this.fNtxt = new System.Windows.Forms.TextBox();
            this.Ntxt = new System.Windows.Forms.TextBox();
            this.lNtxt = new System.Windows.Forms.TextBox();
            this.tNtxt = new System.Windows.Forms.TextBox();
            this.sntxt = new System.Windows.Forms.TextBox();
            this.idTtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustDGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Controls.Add(this.searchtxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(326, 29);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "بحث";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(431, 26);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(195, 23);
            this.searchtxt.TabIndex = 1;
            this.searchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchtxt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ادخل رقم الهوية للبحث:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustDGV);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // CustDGV
            // 
            this.CustDGV.AllowUserToAddRows = false;
            this.CustDGV.AllowUserToDeleteRows = false;
            this.CustDGV.AllowUserToResizeColumns = false;
            this.CustDGV.AllowUserToResizeRows = false;
            this.CustDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustDGV.Location = new System.Drawing.Point(6, 11);
            this.CustDGV.MultiSelect = false;
            this.CustDGV.Name = "CustDGV";
            this.CustDGV.ReadOnly = true;
            this.CustDGV.RowTemplate.Height = 25;
            this.CustDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustDGV.Size = new System.Drawing.Size(764, 149);
            this.CustDGV.TabIndex = 0;
            this.CustDGV.DoubleClick += new System.EventHandler(this.CustDGV_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.idtxt);
            this.groupBox3.Controls.Add(this.Ptxt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Jtxt);
            this.groupBox3.Controls.Add(this.Otxt);
            this.groupBox3.Controls.Add(this.fNtxt);
            this.groupBox3.Controls.Add(this.Ntxt);
            this.groupBox3.Controls.Add(this.lNtxt);
            this.groupBox3.Controls.Add(this.tNtxt);
            this.groupBox3.Controls.Add(this.sntxt);
            this.groupBox3.Controls.Add(this.idTtxt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(16, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات العميل ";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(595, 22);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 23);
            this.idtxt.TabIndex = 11;
            this.idtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idtxt_KeyDown);
            // 
            // Ptxt
            // 
            this.Ptxt.Location = new System.Drawing.Point(33, 123);
            this.Ptxt.Name = "Ptxt";
            this.Ptxt.Size = new System.Drawing.Size(100, 23);
            this.Ptxt.TabIndex = 15;
            this.Ptxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ptxt_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "رقم التلفون :";
            // 
            // Jtxt
            // 
            this.Jtxt.Location = new System.Drawing.Point(422, 120);
            this.Jtxt.Name = "Jtxt";
            this.Jtxt.Size = new System.Drawing.Size(100, 23);
            this.Jtxt.TabIndex = 15;
            this.Jtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jtxt_KeyDown);
            // 
            // Otxt
            // 
            this.Otxt.Location = new System.Drawing.Point(236, 117);
            this.Otxt.Name = "Otxt";
            this.Otxt.Size = new System.Drawing.Size(100, 23);
            this.Otxt.TabIndex = 14;
            this.Otxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Otxt_KeyDown);
            // 
            // fNtxt
            // 
            this.fNtxt.Location = new System.Drawing.Point(595, 75);
            this.fNtxt.Name = "fNtxt";
            this.fNtxt.Size = new System.Drawing.Size(100, 23);
            this.fNtxt.TabIndex = 17;
            this.fNtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fNtxt_KeyDown);
            // 
            // Ntxt
            // 
            this.Ntxt.Location = new System.Drawing.Point(595, 117);
            this.Ntxt.Name = "Ntxt";
            this.Ntxt.Size = new System.Drawing.Size(100, 23);
            this.Ntxt.TabIndex = 16;
            this.Ntxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ntxt_KeyDown);
            // 
            // lNtxt
            // 
            this.lNtxt.Location = new System.Drawing.Point(33, 73);
            this.lNtxt.Name = "lNtxt";
            this.lNtxt.Size = new System.Drawing.Size(100, 23);
            this.lNtxt.TabIndex = 15;
            this.lNtxt.TextChanged += new System.EventHandler(this.lNtxt_TextChanged);
            this.lNtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lNtxt_KeyDown);
            // 
            // tNtxt
            // 
            this.tNtxt.Location = new System.Drawing.Point(237, 76);
            this.tNtxt.Name = "tNtxt";
            this.tNtxt.Size = new System.Drawing.Size(100, 23);
            this.tNtxt.TabIndex = 13;
            this.tNtxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.tNtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tNtxt_KeyDown);
            // 
            // sntxt
            // 
            this.sntxt.Location = new System.Drawing.Point(422, 76);
            this.sntxt.Name = "sntxt";
            this.sntxt.Size = new System.Drawing.Size(100, 23);
            this.sntxt.TabIndex = 11;
            this.sntxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sntxt_KeyDown);
            // 
            // idTtxt
            // 
            this.idTtxt.Location = new System.Drawing.Point(337, 21);
            this.idTtxt.Name = "idTtxt";
            this.idTtxt.Size = new System.Drawing.Size(100, 23);
            this.idTtxt.TabIndex = 10;
            this.idTtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idTtxt_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "جهة العمل :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "المهنة :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "الجنسية :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "اللقب :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "الجد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "الأب :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "الأسم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم الهوية :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "نوع الهوية:";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 34);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(575, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "إلغاء";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(419, 421);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 27;
            this.delbtn.Text = "حذف";
            this.delbtn.UseVisualStyleBackColor = true;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(282, 421);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 26;
            this.editbtn.Text = "تعديل";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "إضافة";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "جديد";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Customers_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customers_FRM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة العملاء";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustDGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox fNtxt;
        private System.Windows.Forms.TextBox Ntxt;
        private System.Windows.Forms.TextBox lNtxt;
        private System.Windows.Forms.TextBox tNtxt;
        private System.Windows.Forms.TextBox sntxt;
        private System.Windows.Forms.TextBox idTtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CustDGV;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Jtxt;
        private System.Windows.Forms.TextBox Otxt;
        private System.Windows.Forms.TextBox Ptxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}