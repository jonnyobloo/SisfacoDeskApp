using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Sell_Forms
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            codetxt.Text = "0";
            malecheckbox.Checked = false;
            femalecheckbox.Checked = false;
            othercheckbox.Checked = false;
        }

        private void newbtn_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clean()
        {
            codetxt.Text = "0";
            nametxt.Clear();
            lastnametxt.Clear();
            identificationtxt.Clear();
            birthtxt.ResetText();
            malecheckbox.Checked = false;
            femalecheckbox.Checked = false;
            othercheckbox.Checked = false;
            phonetxt.Clear();
            addresstxt.Clear();
            mailtxt.Clear();
        }

        private void malecheckbox_OnChange(object sender, EventArgs e)
        {
            if (femalecheckbox.Checked == true || othercheckbox.Checked == true)
            {
                malecheckbox.Checked = false;
            }
        }

        private void femalecheckbox_OnChange(object sender, EventArgs e)
        {
            if (malecheckbox.Checked == true || othercheckbox.Checked == true)
            {
                femalecheckbox.Checked = false;
            }
        }

        private void othercheckbox_OnChange(object sender, EventArgs e)
        {
            if (malecheckbox.Checked == true || femalecheckbox.Checked == true)
            {
                othercheckbox.Checked = false;
            }
        }
    }
}
