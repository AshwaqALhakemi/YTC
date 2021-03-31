using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YTC.PL
{
    public partial class AddFloors_FRM : Form
        
    {
        public string state = "add";

        DBL.AddFloorsCls prd = new DBL.AddFloorsCls ();

        public AddFloors_FRM()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            prd.ADD_Floors(Fnametxt.Text, Fdesctxt.Text);

            MessageBox.Show(" تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Floors_FRM.getMainForm.dataGridView1.DataSource = prd.GET_ALL_FLOORS();
        }

        private void Fnametxt_TextChanged(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.VerifyFloorsName(Fnametxt.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show(" هذا الاسم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Fnametxt.Focus();
                    Fnametxt.SelectionStart = 0;
                    Fnametxt.SelectionLength = Fnametxt.TextLength;


                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Fnametxt_Validated(object sender, EventArgs e)
        {

        }

        private void Fgroupbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
