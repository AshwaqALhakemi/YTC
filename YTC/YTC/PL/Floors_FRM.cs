using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YTC.PL
{
    public partial class Floors_FRM : Form
       
    {
        private static Floors_FRM frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;

        }
        public static Floors_FRM getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Floors_FRM();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }


        }
        DBL.AddFloorsCls prd = new DBL.AddFloorsCls();
        public Floors_FRM()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = prd.GET_ALL_FLOORS();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.SearchFloors(searchtxt.Text);
            this.dataGridView1.DataSource = Dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFloors_FRM frm = new AddFloors_FRM();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد القيام بعملية الحذف؟", " حذف", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.DeleteFloors(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());

                MessageBox.Show("تمت  عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFloors_FRM frm = new AddFloors_FRM();
            frm.Fnametxt.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.Fdesctxt.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.Text = "تحديث بيانات الطابق:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnAdd.Text = "تحديث";
            frm.state = "update";
            frm.ShowDialog();



        }
    }
}
