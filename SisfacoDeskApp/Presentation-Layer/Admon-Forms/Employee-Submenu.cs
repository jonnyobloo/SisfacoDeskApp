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
    public partial class Employee_Submenu : Form
    {
        public Employee_Submenu()
        {
            InitializeComponent();
        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Employee em = new Presentation_Layer.Admon_Forms.Employee();
            em.TopLevel = false;
            this.Controls.Add(em);
            em.Show();
        }

        private void detailemployeebtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.DetailEmployee em = new Presentation_Layer.Admon_Forms.DetailEmployee();
            em.TopLevel = false;
            this.Controls.Add(em);
            em.Show();
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
