﻿using System;
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
    public partial class Role : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        public Role()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            codetxt.Text = "0";
            codegried.Visible = false;
            this.ttmessage.SetToolTip(this.rolenametxt, "Ingresar un Nombre del Rol");
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            codetxt.Text = "0";
            Clean();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "0")
            {
                if (rolenametxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_Rol(rolenametxt.Text.Trim());
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                    Clean();
                }
            }
            else
            {
                if (rolenametxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_Rol(int.Parse(codetxt.Text), rolenametxt.Text.Trim());
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                    Clean();
                }
            }
          }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Role_Query r = new Role_Query();
            AddOwnedForm(r);
            r.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Role_Load(object sender, EventArgs e)
        {
            loadcode();
        }

        private void Clean()
        {
            rolenametxt.Clear();
        }
        public void loadcode()
        {
            codegried.DataSource = linq.Query_Code_Rol();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        private void rolenametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se acepta datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admite datos de tipo texto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //workwarrantytxt.CharacterCasing = CharacterCasing.Upper;
                //workwarrantytxt.CharacterCasing = CharacterCasing.Lower;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Admin_Menu am = new Presentation_Layer.Admon_Forms.Admin_Menu();
            am.TopLevel = false;
            this.Controls.Add(am);
            am.Show();
        }
    }
}
