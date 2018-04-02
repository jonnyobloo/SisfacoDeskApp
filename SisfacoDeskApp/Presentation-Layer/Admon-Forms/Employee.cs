using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    public partial class Employee : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        int code1;
        int code2;
        public Employee()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            codetxt.Text = "0";
            malecheckbox.Checked = false;
            femalecheckbox.Checked = false;
            marriedcheckbox.Checked = false;
            singlecheckbox.Checked = false;
            divorcedcheckbox.Checked = false;
            persongried.Visible = false;
            codegried.Visible = false;
            birthtxt.MinDate = DateTime.Today.Subtract(TimeSpan.FromDays(29200));
            birthtxt.MaxDate = DateTime.Today.Subtract(TimeSpan.FromDays(6570));
            this.ttmessage.SetToolTip(this.nametxt, "Ingresar un Nombre");
            this.ttmessage.SetToolTip(this.lastnametxt, "Ingresar un Apellido");
            this.ttmessage.SetToolTip(this.insstxt, "Ingresar el codigo INSS");
            this.ttmessage.SetToolTip(this.identificationtxt, "Ingresar cedula de identidad");
            this.ttmessage.SetToolTip(this.phonetxt, "Ingresar numero telefonico");
            this.ttmessage.SetToolTip(this.addresstxt, "Ingresar direccion domiciliar");
            this.ttmessage.SetToolTip(this.mailtxt, "Ingresar un correo electronico");
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            //newbtn.Enabled = false;
            codetxt.Text = "0";
            Clean();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            dbcode();
            if (codetxt.Text == "0")
            {
                if (nametxt.Text == "" || lastnametxt.Text == "" || identificationtxt.Text == "" 
                    || phonetxt.Text == "" || addresstxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    if (malecheckbox.Checked == true)
                    {
                        if (marriedcheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1,identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()),phonetxt.Text.Trim(),addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Empleado(code2, code1, insstxt.Text.Trim(), malelbl.Text.Trim()
                            ,marriedlbl.Text, mailtxt.Text);
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                            Clean();
                        }
                        if (singlecheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Empleado(code2, code1, insstxt.Text.Trim(), malelbl.Text.Trim()
                            ,singlelbl.Text, mailtxt.Text);
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                            Clean();
                        }
                        if (divorcedcheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.Insert_Empleado(code2, code1, insstxt.Text.Trim(), malelbl.Text.Trim()
                            ,divorcedlbl.Text, mailtxt.Text);
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                            Clean();
                        }
                        
                    }
                    if (femalecheckbox.Checked == true)
                    {
                        if (marriedcheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Empleado(code2, code1, insstxt.Text.Trim(), femalelbl.Text.Trim()
                            ,marriedlbl.Text,mailtxt.Text);
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                            Clean();
                        }
                        if (singlecheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Empleado(code2, code1, insstxt.Text.Trim(), femalelbl.Text.Trim()
                            ,singlelbl.Text, mailtxt.Text);
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                            Clean();
                        }
                        if (divorcedcheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Empleado(code2, code1, insstxt.Text.Trim(), femalelbl.Text.Trim()
                            ,divorcedlbl.Text, mailtxt.Text);
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                            Clean();
                        }
                    }
                }
            }
            else
            {
                if (nametxt.Text == "" || lastnametxt.Text == "" || identificationtxt.Text == ""
                    || phonetxt.Text == "" || addresstxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    //linq.Update_Cargo(code1, descriptiontxt.Text.Trim(), areacombobox.SelectedIndex + 1, "Si");
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Employee_Query em = new Employee_Query();
            AddOwnedForm(em);
            em.sendbtn.Visible = true;
            em.send2btn.Visible = false;
            em.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dbcode();
        }

        private void Clean()
        {
            nametxt.Clear();
            lastnametxt.Clear();
            identificationtxt.Clear();
            birthtxt.ResetText();
            malecheckbox.Checked = false;
            femalecheckbox.Checked = false;
            phonetxt.Clear();
            addresstxt.Clear();
            marriedcheckbox.Checked = false;
            singlecheckbox.Checked = false;
            divorcedcheckbox.Checked = false;
        }
        private void loadcode()
        {
            codegried.DataSource = linq.Query_Code_Empleado();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        private void dbcode()
        {
            code1 = 1;
            persongried.DataSource = linq.Query_Code_Persona();
            if (persongried.RowCount == 0)
            {
                code1 = 1;
            }
            else
            {
                for (int i = 1; i < persongried.Rows.Count; i++)
                {
                    code1 = int.Parse(persongried.Rows[i].Cells[0].Value.ToString());
                }
                code1 = code1 + 1;
                //nametxt.Text = Convert.ToString(code1);
            }

            code2 = 1;
            codegried.DataSource = linq.Query_Code_Empleado();
            if (codegried.RowCount == 0)
            {
                code2 = 1;
            }
            else
            {
                for (int i = 1; i < codegried.Rows.Count; i++)
                {
                    code2 = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
                }
                code2 = code2 + 1;
                //lastnametxt.Text = Convert.ToString(code2);
            }
        }

        private void malecheckbox_OnChange(object sender, EventArgs e)
        {
            if (malecheckbox.Checked ==true)
            {
                femalecheckbox.Checked = false;
            }
        }

        private void femalecheckbox_OnChange(object sender, EventArgs e)
        {
            if (femalecheckbox.Checked == true)
            {
                malecheckbox.Checked = false;
            }
        }

        private void marriedcheckbox_OnChange(object sender, EventArgs e)
        {
            if (marriedcheckbox.Checked ==true)
            {
                singlecheckbox.Checked = false;
                divorcedcheckbox.Checked = false;
            }
        }

        private void singlecheckbox_OnChange(object sender, EventArgs e)
        {
            if (singlecheckbox.Checked == true)
            {
                marriedcheckbox.Checked = false;
                divorcedcheckbox.Checked = false;
            }
        }

        private void divorcedcheckbox_OnChange(object sender, EventArgs e)
        {
            if (divorcedcheckbox.Checked == true)
            {
                marriedcheckbox.Checked = false;
                singlecheckbox.Checked = false;
            }
        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lastnametxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!phonetxt.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static bool validateEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }

        private void mailtxt_Leave(object sender, EventArgs e)
        {
            if (validateEmail(mailtxt.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " +
                    " por favor seleccione un correo valido", "correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mailtxt.SelectAll();
                mailtxt.Focus();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Admon_Forms.Employee_Submenu em = new Presentation_Layer.Admon_Forms.Employee_Submenu();
            em.TopLevel = false;
            this.Controls.Add(em);
            em.Show();
        }
    }
}
