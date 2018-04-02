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

namespace SisfacoDeskApp.Presentation_Layer
{
    public partial class Principal : Form
    {
        public string password;
        public decimal actualechange;
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public Principal()
        {
            InitializeComponent();
            /*toolTip1.SetToolTip(facebookbtn, "Facebook");
            toolTip1.SetToolTip(twitterbtn, "Twitter");
            toolTip1.SetToolTip(instagrambtn, "Instagram");
            toolTip1.SetToolTip(webbtn, "Web");
            toolTip1.SetToolTip(configurationbtn, "Configuration");
            toolTip1.SetToolTip(logo, "Cerrar Sesion");*/
            toolTip1.SetToolTip(userimage, "Imagen del Usuario");
            homeinit();
            Datetimer.Enabled = true;
            codegried.Visible = false;
        }
        private void closepb_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Alerts.OkCancel_Dialog dialog = new Presentation_Layer.Alerts.OkCancel_Dialog();
            dialog.ShowDialog(this);
            dialog.messagelbl.Text = "Seguro quieres salir del Sistema";
            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                linq.Update_InactiveUser(usernamelbl.Text);
                Application.Exit();
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            principalcontrol.Controls.Clear();
            Presentation_Layer.Home_Forms.Home h = new Home_Forms.Home();
            h.TopLevel = false;
            principalcontrol.Controls.Add(h);
            h.Show();
        }

        private void archivebtn_Click(object sender, EventArgs e)
        {
            principalcontrol.Controls.Clear();
            Presentation_Layer.Home_Forms.Archive_Menu am = new Home_Forms.Archive_Menu();
            am.TopLevel = false;
            principalcontrol.Controls.Add(am);
            am.Show();
        }

        private void sellbtn_Click(object sender, EventArgs e)
        {
            principalcontrol.Controls.Clear();
            Presentation_Layer.Sell_Forms.Sell_Menu sm = new Sell_Forms.Sell_Menu();
            sm.TopLevel = false;
            principalcontrol.Controls.Add(sm);
            sm.Show();
        }

        private void buybtn_Click(object sender, EventArgs e)
        {
            principalcontrol.Controls.Clear();
            Presentation_Layer.Buy_Forms.Buy_Menu bm = new Buy_Forms.Buy_Menu();
            bm.TopLevel = false;
            principalcontrol.Controls.Add(bm);
            bm.Show();
        }

        private void businessbtn_Click(object sender, EventArgs e)
        {
            principalcontrol.Controls.Clear();
            Presentation_Layer.Business_Forms.Business_Menu bm = new Presentation_Layer.Business_Forms.Business_Menu();
            bm.TopLevel = false;
            principalcontrol.Controls.Add(bm);
            bm.Show();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Admon_Forms.Admin_Menu ar = new Presentation_Layer.Admon_Forms.Admin_Menu();
            ar.user = usernamelbl.Text;
            principalcontrol.Controls.Clear();
            ar.TopLevel = false;
            principalcontrol.Controls.Add(ar);
            ar.Show();
        }

        private void facebookbtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/Comercial-LA-MERCED-484529391593730/?hc_ref=ARRle9P4cfLT7Rne-MKe26nHCrl7vUDlnaNHq5aca8Ix_QFrwLOrk1TPlItH8zonBv4&fref=nf");
        }

        private void twitterbtn_Click(object sender, EventArgs e)
        {

        }

        private void instagrambtn_Click(object sender, EventArgs e)
        {

        }

        private void webbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Alerts.Control_Dialog dialog = new Presentation_Layer.Alerts.Control_Dialog();
            dialog.ShowDialog(this);
            if (dialog.DialogResult.Equals(DialogResult.OK))
            {

            }
        }

        private void configurationbtn_Click(object sender, EventArgs e)
        {
            principalcontrol.Controls.Clear();
            Presentation_Layer.Configure_Forms.Configure_Menu cm = new Presentation_Layer.Configure_Forms.Configure_Menu();
            cm.TopLevel = false;
            principalcontrol.Controls.Add(cm);
            cm.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Alerts.OkCancel_Dialog dialog = new Presentation_Layer.Alerts.OkCancel_Dialog();
            dialog.ShowDialog(this);
            dialog.messagelbl.Text = "Seguro quieres Cerrar Sesion?";
            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                linq.Update_InactiveUser(usernamelbl.Text);
                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }

        private void Datetimer_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
            hourlbl.Text = DateTime.Now.ToString("HH:mm: ss");
        }
        private void homeinit()
        {
            Presentation_Layer.Home_Forms.Home h = new Home_Forms.Home();
            h.TopLevel = false;
            principalcontrol.Controls.Add(h);
            h.Show();
        }
        private void inventorycharge()
        {
            Presentation_Layer.Buy_Forms.Cellar_Submenu cs = new Presentation_Layer.Buy_Forms.Cellar_Submenu();
            cs.TopLevel = false;
            principalcontrol.Controls.Add(cs);
            cs.Show();
        }

        private void inactivitytimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void principalcontrol_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void loadactualechangerate()
        {
            codegried.DataSource = linq.Query_TasaCambio();
            try
            {
                for (int i = 0; i < codegried.Rows.Count; i++)
                {
                    actualechange = decimal.Parse(codegried.Rows[i].Cells[2].Value.ToString());
                }
                actualechangeratelbl.Text = "C$ " + Convert.ToString(actualechange);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            loadactualechangerate();
        }
    }
}
