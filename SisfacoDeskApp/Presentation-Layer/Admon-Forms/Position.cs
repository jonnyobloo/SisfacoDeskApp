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

namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    public partial class Position : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        int code1;

        public Position()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            codetxt.Text = "0";
            codegried.Visible = false;
            this.ttmessage.SetToolTip(this.descriptiontxt, "Ingresar Alguna Descripcion");
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            codetxt.Text = "0";
            Clean();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            dbcode();
            if (codetxt.Text == "0")
            {
                if (descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_Cargo(code1, descriptiontxt.Text.Trim(), areacombobox.SelectedIndex + 1, "Si");
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                    Clean();
                }
            }
            else
            {
                if (descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_Cargo(int.Parse(codetxt.Text.Trim()),descriptiontxt.Text.Trim(), areacombobox.SelectedIndex + 1, "Si");
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                    Clean();
                }
            }
            
            
            /*if (codetxt.Text == "0")
            {
                if (descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    c.Num_Cargo = int.Parse(codetxt.Text.Trim());
                    c.Descripcion_Cargo = descriptiontxt.Text.Trim();
                    c.Area_Empresarial = 1;
                    c.Vigencia = "Si";
                    c.Fecha_Creacion = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                    using (Data_Layer.SisfacoDatabaseEntities db = new Data_Layer.SisfacoDatabaseEntities())
                    {
                        db.tbl_Cargo.Add(c);
                        db.SaveChanges();
                    }
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                }
            }*/
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Position_Query p = new Position_Query();
            AddOwnedForm(p);
            p.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clean()
        {
            descriptiontxt.Clear();
            areacombobox.ResetText();
        }
        public void loadcombo()
        {
            areacombobox.DataSource = linq.Query_AreaEmpresarial();
            areacombobox.ValueMember = "Id_AreaEmpresarial";
            areacombobox.DisplayMember = "Nombre_AreaEmp";
        }

        private void Position_Load(object sender, EventArgs e)
        {
            loadcombo();
        }
        private void loadcode()
        {
            codegried.DataSource = linq.Query_Code_Cargo();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        private void dbcode()
        {
            code1 = 1;
            codegried.DataSource = linq.Query_Code_Cargo();
            if (codegried.RowCount == 0)
            {
                code1 = 1;
            }
            else
            {
                for (int i = 1; i <codegried.Rows.Count; i++)
                {
                    code1 = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
                }
                code1 = code1 + 1;
                //this.codetxt.Text = Convert.ToString(code1);
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
