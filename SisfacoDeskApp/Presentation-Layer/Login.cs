using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace SisfacoDeskApp.Presentation_Layer
{
    public partial class Login : Form
    {
        public int attempts;
        string pass;
        MemoryStream ms;
        byte[] photo_aray;
        Presentation_Layer.Principal p = new Principal();
        Business_Layer.Encrypt en = new Business_Layer.Encrypt();
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public Login()
        {
            InitializeComponent();
            showcheckb.Checked = false;
            usertxt.Focus();
            queryuserimage.Visible = false;
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Alerts.OkCancel_Dialog dialog = new Presentation_Layer.Alerts.OkCancel_Dialog();
            dialog.ShowDialog(this);
            dialog.messagelbl.Text = "Seguro quieres salir del Sistema";
            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            if (passtxt.isPassword==true)
            {
                passtxt.Text = "";
            }
            if (passtxt.Text == "")
            {
                passtxt.isPassword = true;
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (showcheckb.Checked==true && passtxt.Text !="")
            {
                passtxt.isPassword = false;
            }
            else
            {
                if (passtxt.isPassword == false && passtxt.Text !="")
                {
                    passtxt.isPassword = true;
                }
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usertxt.Text == "")
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No has ingresado tu usuario", Alerts.AlertMessage.AlertType.warning);
            }
            else if (passtxt.Text == "")
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No has ingresado la contraseña", Alerts.AlertMessage.AlertType.error);
            }
            else
            {
                pass = en.Encriptapass(pass);
                p.usernamelbl.Text = usertxt.Text;
                Logear(usertxt.Text, pass);
                linq.Update_ActiveUser(usertxt.Text, pass);
            }
        }

        public void Logear(string usuario, string pass)
        {
            try
            {
                SqlConnection conex = Data_Layer.Connection.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("Select Num_Emp,Foto,Roles From Cat_Usuario Where NombreUsu = @NombreUsu and Pass = @Pass and Estado='Inactivo'", conex);
                cmd.Parameters.AddWithValue("NombreUsu", usuario);
                cmd.Parameters.AddWithValue("Pass", pass);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    p.usernamelbl.Text = usertxt.Text;
                    if (dt.Rows[0][2].ToString() == "1")
                    {
                        if (dt.Rows[0][1] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dt.Rows[0][1];
                            ms = new MemoryStream(photo_aray);
                            queryuserimage.Image = Image.FromStream(ms);
                            p.Show();
                            p.userimage.Image = queryuserimage.Image;
                            p.usernamelbl.Text = usertxt.Text;
                            this.Hide();
                        }
                    }
                    if (dt.Rows[0][2].ToString() == "2")
                    {
                        if (dt.Rows[0][1] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dt.Rows[0][1];
                            ms = new MemoryStream(photo_aray);
                            queryuserimage.Image = Image.FromStream(ms);
                            p.Show();
                            p.userimage.Image = queryuserimage.Image;
                            p.usernamelbl.Text = usertxt.Text;
                            this.Hide();
                        }
                    }
                    if (dt.Rows[0][2].ToString() == "3")
                    {
                        if (dt.Rows[0][1] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dt.Rows[0][1];
                            ms = new MemoryStream(photo_aray);
                            queryuserimage.Image = Image.FromStream(ms);
                            p.Show();
                            p.userimage.Image = queryuserimage.Image;
                            p.usernamelbl.Text = usertxt.Text;
                            p.businessbtn.Controls.Clear();
                            p.buybtn.Controls.Clear();
                            p.adminbtn.Location = new System.Drawing.Point(0, 304);
                            this.Hide();
                        }
                    }
                    if (dt.Rows[0][2].ToString() == "4")
                    {
                        if (dt.Rows[0][1] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dt.Rows[0][1];
                            ms = new MemoryStream(photo_aray);
                            queryuserimage.Image = Image.FromStream(ms);
                            p.Show();
                            p.userimage.Image = queryuserimage.Image;
                            p.usernamelbl.Text = usertxt.Text;
                            p.businessbtn.Visible = false;
                            p.sellbtn.Visible = false;
                            p.cjlbl.Visible = false;
                            p.moneylbl.Visible = false;
                            p.echangelbl.Visible = false;
                            p.actualechangeratelbl.Visible = false;
                            p.buybtn.Location = new System.Drawing.Point(0, 250);
                            p.adminbtn.Location = new System.Drawing.Point(0, 304);
                            this.Hide();
                        }
                    }
                }
                else
                {
                    attempts = attempts + 1;
                    if (attempts == 1)
                    {
                        Presentation_Layer.Alerts.AlertMessage.Show("Contraseña Incorrecta \n\nPrimer Intento", Alerts.AlertMessage.AlertType.warning);
                        passtxt.Text = "";
                        passtxt.Select();
                    }
                    else
                    {
                        if (attempts == 2)
                        {
                            Presentation_Layer.Alerts.AlertMessage.Show("Contraseña Incorrecta \n\nSegundo Intento", Alerts.AlertMessage.AlertType.warning);
                            passtxt.Text = "";
                            passtxt.Select();
                        }
                        if (attempts == 3)
                        {
                            linq.Update_BlockUser(usertxt.Text);
                            Presentation_Layer.Alerts.AlertMessage.Show("Usuario Bloqueado", Alerts.AlertMessage.AlertType.error);
                            Application.Exit();
                        }
                        passtxt.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Presentation_Layer.Alerts.AlertMessage.Show("Usuario Bloqueado, Acceso Denegado", Alerts.AlertMessage.AlertType.error);
            }
            finally
            {
                Data_Layer.Connection.CerrarConexion();
            }
        }

        private void usertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                passtxt.Focus();
            }
        }

        private void passtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                usertxt.Focus();
            }
        }

        private void passtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (passtxt.Text != "")
            {
                pass = passtxt.Text;
            }
        }

        private void passtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (usertxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No has ingresado tu usuario", Alerts.AlertMessage.AlertType.warning);
                }
                else if (passtxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No has ingresado la contraseña", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    pass = en.Encriptapass(pass);
                    p.usernamelbl.Text = usertxt.Text;
                    Logear(usertxt.Text, pass);
                    linq.Update_ActiveUser(usertxt.Text, pass);
                }
            }
        }
    }
}
