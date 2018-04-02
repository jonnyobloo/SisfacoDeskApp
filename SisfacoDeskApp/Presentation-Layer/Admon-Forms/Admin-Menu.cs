using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    public partial class Admin_Menu : Form
    {
        public string user;
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Employee_Submenu em = new Presentation_Layer.Admon_Forms.Employee_Submenu();
            em.TopLevel = false;
            this.Controls.Add(em);
            em.Show();
        }

        private void businessareabtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Business_Area ba = new Presentation_Layer.Admon_Forms.Business_Area();
            ba.TopLevel = false;
            this.Controls.Add(ba);
            ba.Show();
        }

        private void postionbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Position po = new Presentation_Layer.Admon_Forms.Position();
            po.TopLevel = false;
            this.Controls.Add(po);
            po.Show();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Admon_Forms.User_Submenu us = new Presentation_Layer.Admon_Forms.User_Submenu();
            us.user = user;
            this.Controls.Clear();
            us.TopLevel = false;
            this.Controls.Add(us);
            us.Show();
        }

        private void systembtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.System_Submenu sys = new Presentation_Layer.Admon_Forms.System_Submenu();
            sys.TopLevel = false;
            this.Controls.Add(sys);
            sys.Show();
        }

        private void querybtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Query_Submenu qsm = new Presentation_Layer.Admon_Forms.Query_Submenu();
            qsm.TopLevel = false;
            this.Controls.Add(qsm);
            qsm.Show();
        }
    }
}
