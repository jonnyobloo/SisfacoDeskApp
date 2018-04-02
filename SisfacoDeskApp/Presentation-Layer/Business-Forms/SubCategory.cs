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
    public partial class SubCategory : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        public SubCategory()
        {
            InitializeComponent();
            codetxt.Text = "0";
            codetxt.Enabled = false;
            codegried.Visible = false;
            this.ttmessage.SetToolTip(this.subcategorytxt, "Ingresar la subcategoria del producto");
            this.ttmessage.SetToolTip(this.descriptiontxt, "Ingrese alguna Descripcion");
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
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
                if (subcategorytxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_SubCategoria(categorycombobox.SelectedIndex + 1, subcategorytxt.Text.Trim(), descriptiontxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                }
            }
            else
            {
                if (subcategorytxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_SubCategoriaProducto(int.Parse(codetxt.Text.Trim()), categorycombobox.SelectedIndex + 1, subcategorytxt.Text.Trim(), descriptiontxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            SubCategory_Query sb = new SubCategory_Query();
            AddOwnedForm(sb);
            sb.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            loadcode();
            loadcombo();
        }

        private void Clean()
        {
            subcategorytxt.Clear();
            categorycombobox.SelectedIndex = 0;
            descriptiontxt.Clear();
        }

        public void loadcode()
        {
            codegried.DataSource = linq.Query_Code_SubCategoriaProducto();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        public void loadcombo()
        {
            categorycombobox.DataSource = linq.Query_CategoriaProducto();
            categorycombobox.ValueMember = "Id_CategoriaProducto";
            categorycombobox.DisplayMember = "CategoriaProducto";
        }

        private void subcategorytxt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
