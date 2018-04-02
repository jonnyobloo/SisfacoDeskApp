using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Business_Forms
{
    public partial class newproductbtn : Form
    {
        public newproductbtn()
        {
            InitializeComponent();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {

        }

        private void Brandtbtn_Click(object sender, EventArgs e)
        {

        }

        private void categorybtn_Click(object sender, EventArgs e)
        {

        }

        private void subcategorybtn_Click(object sender, EventArgs e)
        {

        }

        private void measurebtn_Click(object sender, EventArgs e)
        {

        }

        private void warrantybtn_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Admin_Menu adm = new Presentation_Layer.Admon_Forms.Admin_Menu();
            adm.TopLevel = false;
            this.Controls.Add(adm);
            adm.Show();
        }
    }
}
