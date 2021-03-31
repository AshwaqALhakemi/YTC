using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YTC.PL
{
    public partial class MAIN_FRM : Form
    {
        private static MAIN_FRM frm;
        static void frm_FormClosed(object sender , FormClosedEventArgs e)
        {
            frm = null;

        }

        public static MAIN_FRM getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new MAIN_FRM();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }


        }

        public MAIN_FRM()
        {
            InitializeComponent();
            this.floormenustrip.Enabled = false;
            

            if (frm == null)
                frm = this;
            


        }

        private void loginmenustrip_Click(object sender, EventArgs e)
        {
            LOGIN_FRM frm = new LOGIN_FRM();
            frm.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FloorMangeStrip_Click(object sender, EventArgs e)
        {
            AddFloors_FRM frm = new AddFloors_FRM();
            frm.ShowDialog();
        }
        private void floorsMstrip_Click(object sender, EventArgs e)
        {
            Floors_FRM frm = new Floors_FRM();
            frm.ShowDialog();
        }

        private void MAIN_FRM_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void RoomsTypeStrip_Click(object sender, EventArgs e)
        {
            RoomsType frm = new RoomsType();
            frm.ShowDialog();


        }

        private void CustManagStrip_Click(object sender, EventArgs e)
        {
            Customers_FRM frm = new Customers_FRM();
            frm.ShowDialog();

        }

        private void RoommanagStrip_Click(object sender, EventArgs e)
        {
            RoomsManagment frm = new RoomsManagment();
            frm.ShowDialog();
        }

        private void addusersstrip_Click(object sender, EventArgs e)
        {
            USERS_FRM frm = new USERS_FRM();
            frm.ShowDialog();

        }

        private void neworder_Click(object sender, EventArgs e)
        {
            Orders_FRM frm = new Orders_FRM();
            frm.ShowDialog();

        }
    }
}
