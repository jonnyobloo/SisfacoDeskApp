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
    public partial class Query_Submenu : Form
    {
        public Query_Submenu()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Admin_Menu am = new Presentation_Layer.Admon_Forms.Admin_Menu();
            am.TopLevel = false;
            this.Controls.Add(am);
            am.Show();
        }
    }
}
