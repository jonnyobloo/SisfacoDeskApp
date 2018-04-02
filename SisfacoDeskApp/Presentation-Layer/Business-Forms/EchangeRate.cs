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
    public partial class EchangeRate : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        public EchangeRate()
        {
            InitializeComponent();
            codetxt.Text = "0";
            codetxt.Enabled = false;
            codegried.Visible = false;
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            codetxt.Text = "0";
            actualechangetxt.Enabled = true;
            coincombobox.Enabled = true;
            Clean();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "0")
            {
                if (actualechangetxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_TasaCambio(coincombobox.SelectedIndex + 1, decimal.Parse(actualechangetxt.Text.Trim()),"Si");
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                    Clean();
                }
            }
            else
            {
                if (actualechangetxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_TasaMoneda(int.Parse(codetxt.Text.Trim()), "No");
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            //actualechangetxt.Enabled = false;
            //coincombobox.Enabled = false;
            EchangeRate_Query c = new EchangeRate_Query();
            AddOwnedForm(c);
            c.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            coincombobox.SelectedIndex = 0;
            actualechangetxt.Clear();
        }

        public void loadcode()
        {
            codegried.DataSource = linq.Query_Code_TasaCambio();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        public void loadcombo()
        {
            coincombobox.DataSource = linq.Query_Moneda();
            coincombobox.ValueMember = "Id_Moneda";
            coincombobox.DisplayMember = "Moneda";
        }

        private void EchangeRate_Load(object sender, EventArgs e)
        {
            loadcombo();
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
