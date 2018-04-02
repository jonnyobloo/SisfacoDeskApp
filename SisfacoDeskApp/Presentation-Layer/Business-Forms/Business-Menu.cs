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
    public partial class Business_Menu : Form
    {
        public Business_Menu()
        {
            InitializeComponent();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Business_Forms.Product pro = new Presentation_Layer.Business_Forms.Product();
            pro.TopLevel = false;
            this.Controls.Add(pro);
            pro.Show();
        }

        private void dealerbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Business_Forms.Dealer de = new Presentation_Layer.Business_Forms.Dealer();
            de.TopLevel = false;
            this.Controls.Add(de);
            de.Show();
        }

        private void postionbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Business_Forms.EchangeRate er = new Presentation_Layer.Business_Forms.EchangeRate();
            er.TopLevel = false;
            this.Controls.Add(er);
            er.Show();
        }

        private void querybtn_Click(object sender, EventArgs e)
        {
            //Aqui se encuentran los accesos a las consultas
        }

        private void Business_Menu_Load(object sender, EventArgs e)
        {
            //Nothing
        }

        private void coinbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Business_Forms.Coin co = new Presentation_Layer.Business_Forms.Coin();
            co.TopLevel = false;
            this.Controls.Add(co);
            co.Show();
        }
    }
}
