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
    public partial class Users : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public OpenFileDialog file = new OpenFileDialog();
        System.IO.MemoryStream im = new System.IO.MemoryStream();
        public int codeform;
        public string code;
        public string user;
        public Users()
        {
            InitializeComponent();
            codetxt.Enabled = false;
            approvetxt.Enabled = false;
            codetxt.Text = "0";
            codegried.Visible = false;
            this.ttmessage.SetToolTip(this.employeetxt, "Ingresar Nombre del empleado que desea buscar");
            this.ttmessage.SetToolTip(this.usernametxt, "Ingresar Nombre de Usuario");
            this.ttmessage.SetToolTip(this.passtxt, "Ingrese una constraseña Porfavor");
            this.ttmessage.SetToolTip(this.confirmpasstxt, "Digite la constraseña nuevamente");
            this.ttmessage.SetToolTip(this.approvetxt, "Ingresar Nombre que lo autoriza");
            //this.ttmessage.SetToolTip(this.areanametxt, "Ingresar Nombre de la Area");
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
                Business_Layer.Encrypt en = new Business_Layer.Encrypt();

                if (employeetxt.Text == "" || approvetxt.Text == ""
                    || userpicture.Image == null)
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    if (confirmpasstxt.Text == passtxt.Text)
                    {
                        passtxt.Text = en.Encriptapass(passtxt.Text);
                        confirmpasstxt.Text = en.Encriptapass(confirmpasstxt.Text);
                        this.userpicture.Image.Save(im, System.Drawing.Imaging.ImageFormat.Jpeg);
                        linq.Insert_Usuario(codeform, usernametxt.Text, passtxt.Text, im.GetBuffer(), rolecombobox.SelectedIndex + 1, approvetxt.Text.Trim(), "Inactivo");
                        linq.SubmitChanges();
                        Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                        dbcode();
                        Clean();
                    }
                    else
                    {
                        Presentation_Layer.Alerts.AlertMessage.Show("Las contraseñas no coinciden", Alerts.AlertMessage.AlertType.error);
                        passtxt.Clear();
                        confirmpasstxt.Clear();
                    }
                }
            }
            else
            {
                //actualizacion
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Users_Query u = new Users_Query();
            AddOwnedForm(u);
            u.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                file.Filter = "image files|*.jpeg;*.jpg;*.png;*.gif;*.ico;.*";
                DialogResult res = file.ShowDialog();
                if (res == DialogResult.Abort)
                    return;
                if (res == DialogResult.Abort)
                    return;
                userpicture.Image = Image.FromFile(file.FileName);
            }
            catch
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se ha cargado una imagen", Alerts.AlertMessage.AlertType.error);
            }
            
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (userpicture.Image == null)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se ha cargado una imagen", Alerts.AlertMessage.AlertType.error);
            }
            else
            {
                userpicture.Image = null;
            }
            
        }

        private void Users_Load(object sender, EventArgs e)
        {
            //dbcode();
            loadcombo();
        }

        private void Clean()
        {
            employeetxt.Clear();
            usernametxt.Clear();
            passtxt.Clear();
            confirmpasstxt.Clear();
            approvetxt.Clear();
            rolecombobox.SelectedIndex = 0;
            userpicture.Image = null;
            im.Equals("");
        }
        public void dbcode()
        {
            this.codegried.DataSource = linq.Query_Code_Usuario();
            try
            {
                for (int i = 0; i < codegried.Rows.Count; i++)
                {
                    codetxt.Text = codegried.Rows[i].Cells[0].Value.ToString();
                }
            }
            catch (Exception)
            {
                //Nothing to add
            }
        }

        public void loadcombo()
        {
            rolecombobox.DataSource = linq.Query_Roles();
            rolecombobox.ValueMember = "Id_Rol";
            rolecombobox.DisplayMember = "Tipo_Rol";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            DetailEmployee_Query de = new DetailEmployee_Query();
            AddOwnedForm(de);
            de.Show();
        }

        private void employeetxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void usernametxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void approvetxt_KeyPress(object sender, KeyPressEventArgs e)
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
            Presentation_Layer.Admon_Forms.User_Submenu us = new Presentation_Layer.Admon_Forms.User_Submenu();
            this.Controls.Clear();
            us.user = approvetxt.Text;
            us.TopLevel = false;
            this.Controls.Add(us);
            us.Show();
        }
    }
}
