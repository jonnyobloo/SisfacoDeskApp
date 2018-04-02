using System;
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
    public partial class DetailEmployee : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        public int codeemployee;

        public DetailEmployee()
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
            if (codetxt.Text == "0")
            {
                if (employeetxt.Text == "" || authorizedtxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Insert_DetalleEmpleado(positioncombobox.SelectedIndex + 1, codeemployee,
                                                authorizedtxt.Text.Trim(), "edmiguedo","Si");
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    loadcode();
                    Clean();
                }
            }
            else
            {
                if (employeetxt.Text == "" || authorizedtxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_DetalleEmpleado(int.Parse(codetxt.Text.Trim()), positioncombobox.SelectedIndex + 1, codeemployee,
                                                authorizedtxt.Text.Trim(), "edmiguedo", "Si");
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                    Clean();
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            DetailEmployee_Query de = new DetailEmployee_Query();
            AddOwnedForm(de);
            de.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Employee_Submenu em = new Presentation_Layer.Admon_Forms.Employee_Submenu();
            em.TopLevel = false;
            this.Controls.Add(em);
            em.Show();
        }

        private void DetailEmployee_Load(object sender, EventArgs e)
        {
            loadcombo();
        }
        public void loadcode()
        {
            codegried.DataSource = linq.Query_Code_DetalleEmpleado();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }
        private void Clean()
        {
            employeetxt.Clear();
            authorizedtxt.Clear();
            positioncombobox.SelectedIndex = 0;
        }

        private void productsearchbtn_Click(object sender, EventArgs e)
        {
            Employee_Query em = new Employee_Query();
            AddOwnedForm(em);
            em.sendbtn.Visible = false;
            em.send2btn.Visible = true;
            em.Show();
        }
        public void loadcombo()
        {
            positioncombobox.DataSource = linq.Query_Cargo();
            positioncombobox.ValueMember = "Num_Cargo";
            positioncombobox.DisplayMember = "Descripcion_Cargo";
        }
    }
}
