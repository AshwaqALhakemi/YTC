using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YTC.PL
{
    public partial class Orders_FRM : Form
    {
        DBL.Orders_CLcs ord = new DBL.Orders_CLcs();

        public Orders_FRM()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderid.Text = ord.GET_LAST_ORDERID().Rows[0][0].ToString();

            button1.Enabled = false;
            addbtn.Enabled = true;

           
                ord.ADD_ORDER(orderid.Text, textBox2.Text, textBox3.Text, textBox10.Text, textBox9.Text, textBox8.Text, textBox7.Text, textBox4.Text,
         textBox6.Text, textBox5.Text, textBox12.Text, textBox11.Text, checkBox1.Checked);
                MessageBox.Show(" تمت التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                return;

            }



        }
    }
}
