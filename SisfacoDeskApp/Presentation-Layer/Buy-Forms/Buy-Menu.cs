using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Buy_Forms
{
    public partial class Buy_Menu : Form
    {
        public Buy_Menu()
        {
            InitializeComponent();
        }

        private void purchaseorderbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.Order_Submenu order = new Presentation_Layer.Buy_Forms.Order_Submenu();
            order.TopLevel = false;
            this.Controls.Add(order);
            order.Show();
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.Cellar_Submenu cs = new Presentation_Layer.Buy_Forms.Cellar_Submenu();
            cs.TopLevel = false;
            cs.Dock = DockStyle.Fill;
            this.Controls.Add(cs);
            this.Tag = cs;
            cs.Show();
        }

        private void devbtn_Click(object sender, EventArgs e)
        {

        }

        private void stockbtn_Click(object sender, EventArgs e)
        {

        }

        private void querybtn_Click(object sender, EventArgs e)
        {

        }

        private void Buy_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
