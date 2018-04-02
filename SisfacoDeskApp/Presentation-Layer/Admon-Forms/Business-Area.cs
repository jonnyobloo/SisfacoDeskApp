using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    public partial class Business_Area : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        public Business_Area()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            codetxt.Text = "0";
            //savebtn.Enabled = false;
            this.ttmessage.SetToolTip(this.areanametxt, "Ingresar Nombre de la Area");
            this.ttmessage.SetToolTip(this.descriptiontxt, "Ingresar Alguna Descripcion de la Area");
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            /*newbtn.Enabled = false;
            savebtn.Enabled = true;*/
            codetxt.Text = "0";
            Clean();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "0")
            {
                if (areanametxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_AreaEmpresarial(areanametxt.Text.Trim(),descriptiontxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                    Clean();
                }
            }
            else
            {
                if (areanametxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_AreaEmpresarial(codetxt.Text.Trim(), areanametxt.Text.Trim(), descriptiontxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                    Clean();
                }
            }

            /*if (codetxt.Text=="0")
            {
                if (areanametxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    ae.Nombre_AreaEmp = areanametxt.Text.Trim();
                    ae.Descripcion_AreaEmp = descriptiontxt.Text.Trim();
                    using (Data_Layer.SisfacoDatabaseEntities db = new Data_Layer.SisfacoDatabaseEntities())
                    {
                        db.tbl_AreaEmpresarial.Add(ae);
                        db.SaveChanges();
                    }
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                }
            }
            else
            {
                using (Data_Layer.SisfacoDatabaseEntities db = new Data_Layer.SisfacoDatabaseEntities())
                {
                    db.Entry(ae).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
            }*/
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            BusinessArea_Query b = new BusinessArea_Query();
            AddOwnedForm(b);
            b.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Business_Area_Load(object sender, EventArgs e)
        {
            //loadcode();
        }
        
        private void Clean()
        {
            areanametxt.Clear();
            descriptiontxt.Clear();
        }

        private void codetxt_MouseHover(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.Help;
        }
        public void loadcode()
        {
            codegried.DataSource = linq.Query_Code_AreaEmpresarial();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        private void areanametxt_KeyPress(object sender, KeyPressEventArgs e)
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
