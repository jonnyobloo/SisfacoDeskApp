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
    public partial class Cellar_Submenu : Form
    {
        public Cellar_Submenu()
        {
            InitializeComponent();
        }

        private void warehousebtn_Click(object sender, EventArgs e)
        {

        }

        private void limitstockbtn_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.Buy_Menu buy = new Presentation_Layer.Buy_Forms.Buy_Menu();
            buy.TopLevel = false;
            this.Controls.Add(buy);
            buy.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
