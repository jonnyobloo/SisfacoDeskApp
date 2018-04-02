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
    public partial class User_Submenu : Form
    {
        public string user;
        public User_Submenu()
        {
            InitializeComponent();
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Admon_Forms.Users us = new Presentation_Layer.Admon_Forms.Users();
            us.approvetxt.Text = user;
            this.Controls.Clear();
            us.TopLevel = false;
            this.Controls.Add(us);
            us.Show();
        }

        private void changepassbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Admon_Forms.ChangePass cp = new Presentation_Layer.Admon_Forms.ChangePass();
            cp.usertxt.Text = user;
            this.Controls.Clear();
            cp.TopLevel = false;
            this.Controls.Add(cp);
            cp.Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Admon_Forms.Admin_Menu am = new Presentation_Layer.Admon_Forms.Admin_Menu();
            this.Controls.Clear();
            am.TopLevel = false;
            this.Controls.Add(am);
            am.Show();
        }
    }
}
