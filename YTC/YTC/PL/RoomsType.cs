using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YTC.PL
{
    public partial class RoomsType : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"server = .\; Database = YTC; Integrated Security = true ");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public RoomsType()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select R_ID as 'رقم القاعة', R_Type as 'نوع القاعة' ,R_Desc as 'وصف القاعة' from RoomType  ", sqlcon);
                da.Fill(dt);
            RYGV.DataSource = dt;
            
            Rtypetxt.DataBindings.Add("text", dt, "نوع القاعة");
            RTdesctxt.DataBindings.Add("text", dt, "وصف القاعة");
            bmb = this.BindingContext[dt];



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            addbtn.Enabled = false;
            btna.Enabled = true;
            RTdesctxt.Focus(); 
        }

        private void btna_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت  عملية الأضافة بنجاح", "عملية الأضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btna.Enabled = false;
            addbtn.Enabled = true;


        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت  عملية الحذف بنجاح", "عملية الحذف ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت  عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }

        private void RTdesctxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
