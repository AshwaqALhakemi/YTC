using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YTC.PL
{
    public partial class LOGIN_FRM : Form
    {
        DBL.LOGIN_CLS log = new DBL.LOGIN_CLS();
        public LOGIN_FRM()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txtID.Text, txtPSW.Text);
            if (Dt.Rows.Count > 0)
            {
                if (Dt.Rows[0][2].ToString() == "مدير")
                {
                    MAIN_FRM.getMainForm.floormenustrip.Enabled = true;
                    MAIN_FRM.getMainForm.RoomsStrip.Enabled = true;
                    MAIN_FRM.getMainForm.CustomersStrip.Enabled = true;
                    MAIN_FRM.getMainForm.usersstrip.Enabled = true;
                    MAIN_FRM.getMainForm.usersstrip.Visible = true;


                    this.Close();

                }
                else
                
                    if (Dt.Rows[0][2].ToString() == "مستخدم")


                    {
                        MAIN_FRM.getMainForm.floormenustrip.Enabled = true;
                        MAIN_FRM.getMainForm.RoomsStrip.Enabled = true;
                        MAIN_FRM.getMainForm.CustomersStrip.Enabled = true;
                        MAIN_FRM.getMainForm.usersstrip.Visible = false;

                        this.Close();


                    }
                } 
            else
            {
                MessageBox.Show("Login Failed !");


            }
            
        }
    }
}
