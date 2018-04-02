using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SisfacoDeskApp.Presentation_Layer.Home_Forms
{
    public partial class Archive_Menu : Form
    {
        public Archive_Menu()
        {
            InitializeComponent();
        }

        private void calculatorbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Calculator c = new Calculator();
            c.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void excelbtn_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }
    }
}
