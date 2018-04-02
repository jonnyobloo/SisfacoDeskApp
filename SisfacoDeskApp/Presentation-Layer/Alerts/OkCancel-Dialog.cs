using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Alerts
{
    public partial class OkCancel_Dialog : Form
    {
        public OkCancel_Dialog()
        {
            InitializeComponent();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
