using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YTC.PL
{
    public partial class USERS_FRM : Form
    {
        
        public USERS_FRM()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtxt.Text == string.Empty || fullnametxt.Text == string.Empty || passWtxt.Text == string.Empty || passWCtxt.Text == string.Empty)
            {
                MessageBox.Show(" الرجاء ادخال جميع البيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            if (passWtxt.Text != passWCtxt.Text)
            {
                MessageBox.Show(" كلمة السر غير متطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DBL.LOGIN_CLS user = new DBL.LOGIN_CLS();
            user.USER_ADD(idtxt.Text, fullnametxt.Text, passWCtxt.Text, CBT.Text);
                MessageBox.Show(" تم إضافة المستخدم بنجاح", "إضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            idtxt.Clear();
            fullnametxt.Clear();
            passWCtxt.Clear();
            CBT.Focus();





        }

        private void passWCtxt_Validated(object sender, EventArgs e)
        {
            if (passWtxt.Text != passWCtxt.Text)
            {
                MessageBox.Show(" كلمة السر غير متطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
