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

namespace SisfacoDeskApp.Presentation_Layer.Business_Forms
{
    public partial class Dealer : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        int code1;
        int code2;
        public Dealer()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            codetxt.Text = "0";
            persongried.Visible = false;
            codegried.Visible = false;
            countedcheckbox.Checked = false;
            creditcheckbox.Checked = false;
            activecheckbox.Checked = false;
            inactivecheckbox.Checked = false;
            birthtxt.MinDate = DateTime.Today.Subtract(TimeSpan.FromDays(29200));
            birthtxt.MaxDate = DateTime.Today.Subtract(TimeSpan.FromDays(6570));
            this.ttmessage.SetToolTip(this.nametxt, "Ingresar un Nombre");
            this.ttmessage.SetToolTip(this.lastnametxt, "Ingresar un Apellido");
            this.ttmessage.SetToolTip(this.identificationtxt, "Ingresar cedula de identidad");
            this.ttmessage.SetToolTip(this.phonetxt, "Ingresar numero telefonico");
            this.ttmessage.SetToolTip(this.addresstxt, "Ingresar direccion domiciliar");
            this.ttmessage.SetToolTip(this.webmailtxt, "Ingresar un correo electronico");
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
                if (nametxt.Text == "" || lastnametxt.Text == "" || identificationtxt.Text == ""
                    || phonetxt.Text == "" || addresstxt.Text == ""  || webmailtxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    if (countedcheckbox.Checked == true)
                    {
                        if (activecheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Proveedor(code2, code1, provincecombobox.SelectedIndex + 1, countedlbl.Text.Trim()
                            , webmailtxt.Text, activelbl.Text.Trim(), "Ninguna Observacion");
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                        }
                        if (inactivecheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Proveedor(code2, code1, provincecombobox.SelectedIndex + 1, countedlbl.Text.Trim()
                            , webmailtxt.Text, inactivelbl.Text.Trim(), "Ninguna Observacion");
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                        }
                    }
                    if (creditcheckbox.Checked == true)
                    {
                        if (activecheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Proveedor(code2, code1, provincecombobox.SelectedIndex + 1, creditlbl.Text.Trim()
                            , webmailtxt.Text, activelbl.Text.Trim(), "Ninguna Observacion");
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                        }
                        if (inactivecheckbox.Checked == true)
                        {
                            linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Insert_Proveedor(code2, code1, provincecombobox.SelectedIndex + 1, creditlbl.Text.Trim()
                            , webmailtxt.Text, inactivelbl.Text.Trim(), "Ninguna Observacion");
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                        }
                    }
                }
            }
            //Actualizar
            else
            {
                if (nametxt.Text == "" || lastnametxt.Text == "" || identificationtxt.Text == ""
                    || phonetxt.Text == "" || addresstxt.Text == "" || webmailtxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    if (countedcheckbox.Checked == true)
                    {
                        if (activecheckbox.Checked == true)
                        {
                            linq.Update_Persona(identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Update_Proveedor(code2,provincecombobox.SelectedIndex + 1, countedlbl.Text.Trim()
                            , webmailtxt.Text, activelbl.Text.Trim(), "Ninguna Observacion");
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                        }
                        if (inactivecheckbox.Checked == true)
                        {
                            linq.Update_Persona(identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Update_Proveedor(code2, provincecombobox.SelectedIndex + 1, countedlbl.Text.Trim()
                            , webmailtxt.Text, inactivelbl.Text.Trim(), "Ninguna Observacion");
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                        }
                    }
                    if (creditcheckbox.Checked == true)
                    {
                        if (activecheckbox.Checked == true)
                        {
                            linq.Update_Persona(identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Update_Proveedor(code2, provincecombobox.SelectedIndex + 1, creditlbl.Text.Trim()
                            , webmailtxt.Text, activelbl.Text.Trim(), "Ninguna Observacion");
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                        }
                        if (inactivecheckbox.Checked == true)
                        {
                            linq.Update_Persona(identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                            Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
                            linq.SubmitChanges();
                            linq.Update_Proveedor(code2, provincecombobox.SelectedIndex + 1, creditlbl.Text.Trim()
                            , webmailtxt.Text, inactivelbl.Text.Trim(), "Ninguna Observacion");
                            linq.SubmitChanges();
                            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                            loadcode();
                        }
                    }
                }
            }

            /*linq.Insert_Persona(code1, identificationtxt.Text.Trim(), nametxt.Text.Trim(), lastnametxt.Text.Trim(),
                Convert.ToDateTime(birthtxt.Value.Date.ToShortDateString()), phonetxt.Text.Trim(), addresstxt.Text.Trim());
            linq.SubmitChanges();
            linq.Insert_Proveedor(code2, code1, provincecombobox.SelectedIndex + 1, countedlbl.Text.Trim()
            , webmailtxt.Text, activelbl.Text.Trim(), "Ninguna Observacion");
            linq.SubmitChanges();
            Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
            loadcode();*/
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Dealer_Query de = new Dealer_Query();
            AddOwnedForm(de);
            de.sendbtn.Visible = true;
            de.send2btn.Visible = false;
            de.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            nametxt.Clear();
            lastnametxt.Clear();
            identificationtxt.Clear();
            birthtxt.ResetText();
            countedcheckbox.Checked = false;
            creditcheckbox.Checked = false;
            phonetxt.Clear();
            addresstxt.Clear();
            webmailtxt.Clear();
            activecheckbox.Checked = false;
            activecheckbox.Checked = false;
            inactivecheckbox.Checked = false;
            provincecombobox.SelectedIndex = 0;
        }
        private void loadcode()
        {
            codegried.DataSource = linq.Query_Code_Proveedor();
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
            }

            code2 = 1;
            codegried.DataSource = linq.Query_Code_Proveedor();
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
            }
        }

        private void countedcheckbox_OnChange(object sender, EventArgs e)
        {
            if (countedcheckbox.Checked == true)
            {
                creditcheckbox.Checked = false;
            }
        }

        private void creditcheckbox_OnChange(object sender, EventArgs e)
        {
            if (creditcheckbox.Checked == true)
            {
                countedcheckbox.Checked = false;
            }
        }

        private void activecheckbox_OnChange(object sender, EventArgs e)
        {
            if (activecheckbox.Checked == true)
            {
                inactivecheckbox.Checked = false;
            }
        }

        private void inactivecheckbox_OnChange(object sender, EventArgs e)
        {
            if (inactivecheckbox.Checked == true)
            {
                activecheckbox.Checked = false;
            }
        }

        public void loadcombo()
        {
            provincecombobox.DataSource = linq.Query_Provincia();
            provincecombobox.ValueMember = "Id_Provincia";
            provincecombobox.DisplayMember = "Provincia";
        }

        private void Dealer_Load(object sender, EventArgs e)
        {
            dbcode();
            loadcombo();
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

        private void webmailtxt_Leave(object sender, EventArgs e)
        {
            if (validateEmail(webmailtxt.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " +
                    " por favor seleccione un correo valido", "correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                webmailtxt.SelectAll();
                webmailtxt.Focus();
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
