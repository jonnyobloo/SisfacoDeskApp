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
    public partial class Product : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public OpenFileDialog file = new OpenFileDialog();
        System.IO.MemoryStream im = new System.IO.MemoryStream();
        int codeform;
        int code1;
        int codeproduct;
        public Product()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            codetxt.Text = "0";
            codegried.Visible = false;
            this.ttmessage.SetToolTip(this.productnametxt, "Ingresar Nombre del Producto");
            this.ttmessage.SetToolTip(this.modeltxt, "Ingresar el modelo del producto");
            this.ttmessage.SetToolTip(this.dimentiontxt, "Ingresar dimensiones del producto");
            this.ttmessage.SetToolTip(this.descriptiontxt, "Ingresar Alguna Descripcion");
            this.ttmessage.SetToolTip(this.observationtxt, "Ingresar Alguna Observacion");
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
                if (productnametxt.Text == "" || modeltxt.Text == "" || dimentiontxt.Text == ""
                    || descriptiontxt.Text == "" || observationtxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    codeproduct = code1;
                    this.productpicture.Image.Save(im, System.Drawing.Imaging.ImageFormat.Jpeg);
                    linq.Insert_Producto(code1, productnametxt.Text.Trim(), subcategorycombobox.SelectedIndex + 1,
                                         brandcombobox.SelectedIndex + 1, modeltxt.Text.Trim(), 
                                         warrantycombobox.SelectedIndex + 1, measurecombobox.SelectedIndex + 1,
                                         dimentiontxt.Text,descriptiontxt.Text.Trim(), im.GetBuffer(), observationtxt.Text.Trim());
                    linq.SubmitChanges();
                    linq.Insert_Inventario(codeproduct,0,0,double.Parse(minimunstocktxt.Text),double.Parse(maximumstock.Text));
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    Clean();
                    loadcode();
                }
            }
            else
            {
                if (productnametxt.Text == "" || modeltxt.Text == "" || dimentiontxt.Text == ""
                    || descriptiontxt.Text == "" || observationtxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    this.productpicture.Image.Save(im, System.Drawing.Imaging.ImageFormat.Jpeg);
                    linq.Update_Producto(int.Parse(codetxt.Text), productnametxt.Text.Trim(), subcategorycombobox.SelectedIndex + 1,
                                         brandcombobox.SelectedIndex + 1, modeltxt.Text.Trim(),
                                         warrantycombobox.SelectedIndex + 1, measurecombobox.SelectedIndex + 1,
                                         dimentiontxt.Text, descriptiontxt.Text.Trim(), im.GetBuffer(), observationtxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Product_Query pq = new Product_Query();
            AddOwnedForm(pq);
            pq.send2btn.Visible = false;
            pq.sendbtn.Visible = true;
            pq.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                file.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*";
                DialogResult res = file.ShowDialog();
                if (res == DialogResult.Abort)
                    return;
                if (res == DialogResult.Abort)
                    return;
                productpicture.Image = Image.FromFile(file.FileName);
            }
            catch (Exception)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se ha cargado una imagen", Alerts.AlertMessage.AlertType.error);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (productpicture.Image == null)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se ha cargado una imagen", Alerts.AlertMessage.AlertType.error);
            }
            else
            {
                productpicture.Image = null;
            }
        }

        private void Clean()
        {
            productnametxt.Clear();
            subcategorycombobox.SelectedIndex = 0;
            brandcombobox.SelectedIndex = 0;
            modeltxt.Clear();
            warrantycombobox.SelectedIndex = 0;
            measurecombobox.SelectedIndex = 0;
            dimentiontxt.Clear();
            descriptiontxt.Clear();
            productpicture.Image = null;
            observationtxt.Clear();
            minimunstocktxt.Clear();
            maximumstock.Clear();
        }
        private void loadcode()
        {
            codegried.DataSource = linq.Query_Code_Producto();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        private void dbcode()
        {
            code1 = 1;
            codegried.DataSource = linq.Query_Code_Producto();
            if (codegried.RowCount == 0)
            {
                code1 = 1;
            }
            else
            {
                for (int i = 1; i < codegried.Rows.Count; i++)
                {
                    code1 = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
                }
                code1 = code1 + 1;
            }

        }
        public void loadcombo()
        {
            //Subcategory
            subcategorycombobox.DataSource = linq.Query_SubCategoriaProducto();
            subcategorycombobox.ValueMember = "Id_SubCategoriaProducto";
            subcategorycombobox.DisplayMember = "SubCategoriaProducto";

            //Brand
            brandcombobox.DataSource = linq.Query_Marca();
            brandcombobox.ValueMember = "Id_Marca";
            brandcombobox.DisplayMember = "Marca_Producto";

            //Warranty
            warrantycombobox.DataSource = linq.Query_Garantia();
            warrantycombobox.ValueMember = "Id_Garantia";
            warrantycombobox.DisplayMember = "TipoGarantia";

            //Measure
            measurecombobox.DataSource = linq.Query_UnidadMedida();
            measurecombobox.ValueMember = "Id_UnidadMedida";
            measurecombobox.DisplayMember = "TipoMedida";
        }

        private void Product_Load(object sender, EventArgs e)
        {
            dbcode();
            loadcombo();
        }

        private void productnametxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dimentiontxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //con esta condiccion solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //con esta condicion nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == 'x') && (!dimentiontxt.Text.Contains("x")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
