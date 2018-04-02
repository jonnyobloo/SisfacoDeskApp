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
    public partial class ChangePass : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        Business_Layer.Encrypt en = new Business_Layer.Encrypt();
        public ChangePass()
        {
            InitializeComponent();
            usertxt.Enabled = false;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (actualpasstxt.Text == "")
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
            }
            else
            {
                if (newpasstxt.Text != confirmnewpasstxt.Text)
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("Las contraseñas no coinciden", Alerts.AlertMessage.AlertType.error);
                    newpasstxt.Clear();
                    confirmnewpasstxt.Clear();
                }
                else
                {
                    actualpasstxt.Text = en.Encriptapass(actualpasstxt.Text);
                    newpasstxt.Text = en.Encriptapass(newpasstxt.Text);
                    confirmnewpasstxt.Text = en.Encriptapass(confirmnewpasstxt.Text);
                    linq.Update_UserPass(usertxt.Text.Trim(),actualpasstxt.Text.Trim(),newpasstxt.Text.Trim());
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Contraseña Actualizada con Exito", Alerts.AlertMessage.AlertType.success);
                    Clean();
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Admon_Forms.User_Submenu us = new Presentation_Layer.Admon_Forms.User_Submenu();
            this.Controls.Clear();
            us.user = usertxt.Text;
            us.TopLevel = false;
            this.Controls.Add(us);
            us.Show();
        }

        private void Clean()
        {
            actualpasstxt.Clear();
            newpasstxt.Clear();
            confirmnewpasstxt.Clear();
        }

    }
}
