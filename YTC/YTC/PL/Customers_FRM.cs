using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YTC.PL
{
    public partial class Customers_FRM : Form
    { 
        DBL.Customer_CL cust = new DBL.Customer_CL();
            int id ;
    
        public Customers_FRM()
        {
            InitializeComponent();
            this.CustDGV.DataSource = cust.GET_ALL_CUSTOMERS();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cust.ADD_CUSTOMERS(idtxt.Text, idTtxt.Text, fNtxt.Text, sntxt.Text, tNtxt.Text, lNtxt.Text, Ntxt.Text, Jtxt.Text, Otxt.Text, Ptxt.Text);

                MessageBox.Show(" تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CustDGV.DataSource = cust.GET_ALL_CUSTOMERS();

            }
            catch
            {
                return;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            idtxt.Clear();
            idTtxt.Clear();
            fNtxt.Clear();
            sntxt.Clear();
            tNtxt.Clear();
            lNtxt.Clear();
            Ntxt.Clear();
            Jtxt.Clear();
            Otxt.Clear();
            Ptxt.Clear();
            idtxt.Focus();
        }

        private void idtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                idTtxt.Focus();


            }
        }

        private void idTtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fNtxt.Focus();


            }
        }

        private void fNtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sntxt.Focus();


            }
        }

        private void sntxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tNtxt.Focus();


            }
        }

        private void tNtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               lNtxt.Focus();


            }
        }

        private void lNtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lNtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ntxt.Focus();


            }
        }

        private void Ntxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Jtxt.Focus();


            }
        }

        private void Jtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              Otxt.Focus();


            }
        }

        private void Otxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                     Ptxt.Focus();


            }
        }

        private void Ptxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();


            }



            
        }

        private void CustDGV_DoubleClick(object sender, EventArgs e)
        {
           id = Convert.ToInt32(CustDGV.CurrentRow.Cells[0].Value.ToString());
            this.idtxt.Text = CustDGV.CurrentRow.Cells[0].Value.ToString();
            this.idTtxt.Text = CustDGV.CurrentRow.Cells[1].Value.ToString();
            this.fNtxt.Text = CustDGV.CurrentRow.Cells[2].Value.ToString();
            this.sntxt.Text = CustDGV.CurrentRow.Cells[3].Value.ToString();
            this.tNtxt.Text = CustDGV.CurrentRow.Cells[4].Value.ToString();
            this.lNtxt.Text = CustDGV.CurrentRow.Cells[5].Value.ToString();
            this.Ntxt.Text = CustDGV.CurrentRow.Cells[6].Value.ToString();
            this.Jtxt.Text = CustDGV.CurrentRow.Cells[7].Value.ToString();
            this.Otxt.Text = CustDGV.CurrentRow.Cells[8].Value.ToString();
            this.Ptxt.Text = CustDGV.CurrentRow.Cells[9].Value.ToString();





        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                cust.DEIT_CUSTOMERS(idtxt.Text, idTtxt.Text, fNtxt.Text, sntxt.Text, tNtxt.Text, lNtxt.Text, Ntxt.Text, Jtxt.Text, Otxt.Text, Ptxt.Text);

                MessageBox.Show(" تمت التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CustDGV.DataSource = cust.GET_ALL_CUSTOMERS();

            }
            catch
            {
                return;

            }

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف هذا السجل", "تمت عملية الحذف بنجاح", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cust.DELETE_CUSTOMERS(idtxt.Text);
                MessageBox.Show(" تم الحذف بنجاح", "عملية الحذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CustDGV.DataSource = cust.GET_ALL_CUSTOMERS();

            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            CustDGV.DataSource = cust.SEARCH_CUSTOMERS(searchtxt.Text);

        }

        private void searchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchbtn_Click(sender, e);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
