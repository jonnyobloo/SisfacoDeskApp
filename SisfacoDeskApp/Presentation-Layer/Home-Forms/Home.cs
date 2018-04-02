using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Home_Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            icon.Enabled = false;
        }

        private void icontimer_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            icontimer.Stop();
        }

        private void Transition_TransitionEnd(object sender, EventArgs e)
        {
            icontimer.Start();
            icon.Enabled = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Transition.ShowAsyc(this);
        }
    }
}
