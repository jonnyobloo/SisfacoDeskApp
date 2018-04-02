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
    public partial class Measure : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        public Measure()
        {
            InitializeComponent();
            codetxt.Text = "0";
            codetxt.Enabled = false;
            codegried.Visible = false;
            this.ttmessage.SetToolTip(this.measuretxt, "Ingresar Tipo de Medida");
            this.ttmessage.SetToolTip(this.descriptiontxt, "Ingresar una Descripcion");
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
                if (measuretxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_UnidadMedida(measuretxt.Text.Trim(), descriptiontxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                }
            }
            else
            {
                if (measuretxt.Text == "" || descriptiontxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_UnidadMedida(int.Parse(codetxt.Text.Trim()), measuretxt.Text.Trim(), descriptiontxt.Text.Trim());
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Measure_Query m = new Measure_Query();
            AddOwnedForm(m);
            m.Show();
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
            measuretxt.Clear();
            descriptiontxt.Clear();
        }
        public void loadcode()
        {
            codegried.DataSource = linq.Query_Code_UnidadMedida();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        private void Measure_Load(object sender, EventArgs e)
        {
            loadcode();
        }

        private void measuretxt_KeyPress(object sender, KeyPressEventArgs e)
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
