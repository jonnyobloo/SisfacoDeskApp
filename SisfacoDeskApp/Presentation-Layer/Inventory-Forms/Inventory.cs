using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Inventory_Forms
{
    public partial class Inventory : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public OpenFileDialog file = new OpenFileDialog();
        System.IO.MemoryStream im = new System.IO.MemoryStream();
        int codeform;
        int code1;
        int codeproduct;
        public Inventory()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            codetxt.Text = "0";
            codegried.Visible = false;
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
                                         dimentiontxt.Text, descriptiontxt.Text.Trim(), im.GetBuffer(), observationtxt.Text.Trim());
                    linq.SubmitChanges();
                    linq.Insert_Inventario(codeproduct, double.Parse(existencetxt.Text), double.Parse(disponibilitytxt.Text), double.Parse(minimunstocktxt.Text), double.Parse(maximumstock.Text));
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
            //Revisar este boton
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
            existencetxt.Clear();
            disponibilitytxt.Clear();
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

        private void Inventory_Load(object sender, EventArgs e)
        {
            dbcode();
            loadcombo();
        }
    }
}
