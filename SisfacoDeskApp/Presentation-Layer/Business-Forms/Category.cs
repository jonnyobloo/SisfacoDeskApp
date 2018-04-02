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
    public partial class Category : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        public Category()
        {
            InitializeComponent();
            codetxt.Text = "0";
            codetxt.Enabled = false;
            codegried.Visible = false;
            this.ttmessage.SetToolTip(this.categorytxt, "Ingresar el Nombre de la categoria");
            this.ttmessage.SetToolTip(this.descriptiontxt, "Ingrese alguna descripcion");
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
                if (categorytxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_Categoria(categorytxt.Text.Trim(), descriptiontxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                }
            }
            else
            {
                if (categorytxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_CategoriaProducto(int.Parse(codetxt.Text.Trim()), categorytxt.Text.Trim(), descriptiontxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Category_Query c = new Category_Query();
            AddOwnedForm(c);
            c.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            loadcode();
        }

        private void Clean()
        {
            categorytxt.Clear();
            descriptiontxt.Clear();
        }

        public void loadcode()
        {
            codegried.DataSource = linq.Query_Code_CategoriaProducto();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        private void categorytxt_KeyPress(object sender, KeyPressEventArgs e)
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
            Presentation_Layer.Business_Forms.Business_Menu bm = new Presentation_Layer.Business_Forms.Business_Menu();
            bm.TopLevel = false;
            this.Controls.Add(bm);
            bm.Show();
        }
    }
}
