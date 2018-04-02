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
    public partial class Province : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        public Province()
        {
            InitializeComponent();
            codetxt.Text = "0";
            codetxt.Enabled = false;
            codegried.Visible = false;
            this.ttmessage.SetToolTip(this.provincetxt, "Ingresar un provincia");
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            codetxt.Text = "0";
            Clean();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //areacombobox.SelectedIndex + 1
            if (codetxt.Text == "0")
            {
                if (provincetxt.Text == "" )
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_Provincia(countrycombobox.SelectedIndex + 1, provincetxt.Text);
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                }
            }
            else
            {
                if (provincetxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_Provincia(int.Parse(codetxt.Text.Trim()), countrycombobox.SelectedIndex + 1, provincetxt.Text);
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Province_Query p = new Province_Query();
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
            countrycombobox.SelectedIndex = 0;
            provincetxt.Clear();
        }

        public void loadcode()
        {
            codegried.DataSource = linq.Query_Code_Provincia();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        public void loadcombo()
        {
            countrycombobox.DataSource = linq.Query_Pais();
            countrycombobox.ValueMember = "Id_Pais";
            countrycombobox.DisplayMember = "Nombre_Pais";
        }

        private void Province_Load(object sender, EventArgs e)
        {
            loadcombo();
            loadcode();
        }

        private void provincetxt_KeyPress(object sender, KeyPressEventArgs e)
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
