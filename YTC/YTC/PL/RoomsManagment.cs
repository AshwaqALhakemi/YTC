using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YTC.PL
{
    


    public partial class RoomsManagment : Form

    {
        
        DBL.RoomsCLScs rcl = new DBL.RoomsCLScs();
        public RoomsManagment()
        {
            InitializeComponent();
            this.RDGV.DataSource = rcl.GET_ALL_ROOMS();
            RDGV.Columns[0].Visible = false;

            fname.DataSource = rcl.GET_ALL_ROOMSTYPE();
            fname.DisplayMember = "R_Type";
            fname.ValueMember = "R_ID";

            rname.DataSource = rcl.GET_ALL_FLOORSNAMES();
           rname.DisplayMember = "F_name";
            rname.ValueMember = "F_ID";       
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            rcl.ADD_ROOMS(rname.Text, fname.Text, rnum.Text, textBox1.Text, textBox3.Text, checkBox1.Checked);

                MessageBox.Show(" تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.RDGV.DataSource = rcl.GET_ALL_ROOMS();
        }

        private void RDGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.rnum.Text = RDGV.CurrentRow.Cells[1].Value.ToString();
                
                this.rname.Text = RDGV.CurrentRow.Cells[3].Value.ToString();

                this.fname.Text = RDGV.CurrentRow.Cells[4].Value.ToString();
                this.textBox3.Text = RDGV.CurrentRow.Cells[5].Value.ToString();
                this.textBox1.Text = RDGV.CurrentRow.Cells[6].Value.ToString();
                
                
            }
            catch
            {
                return;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rnum.Clear();
            textBox1.Clear();
            textBox3.Clear();
            rname.Focus();

        }

        private void rnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();


            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();


            }

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBox1.Focus();


            }

        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.Focus();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                rcl.ROOMS_EDIT(rname.Text, fname.Text, rnum.Text, textBox1.Text, textBox3.Text, checkBox1.Checked);

                MessageBox.Show(" تمت التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RDGV.DataSource = rcl.GET_ALL_ROOMS();

            }
            catch
            {
                return;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف هذا السجل", "تمت عملية الحذف بنجاح", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rcl.DELETE_ROOMS(rnum.Text);
                MessageBox.Show(" تم الحذف بنجاح", "عملية الحذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RDGV.DataSource = rcl.GET_ALL_ROOMS();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RDGV.DataSource = rcl.SEARCH_ROOMS(search.Text);
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button5_Click(sender, e);

            }
        }
    }
}
