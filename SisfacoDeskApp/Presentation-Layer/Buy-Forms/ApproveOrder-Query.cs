using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Buy_Forms
{
    public partial class ApproveOrder_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public ApproveOrder_Query()
        {
            InitializeComponent();
            aprovecheckbox.Checked = false;
            showpursachecheckbox.Checked = false;
            cancelallcheckbox.Checked = false;
            cancelcheckbox.Checked = false;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.Order_Submenu os = new Presentation_Layer.Buy_Forms.Order_Submenu();
            os.TopLevel = false;
            this.Controls.Add(os);
            os.Show();
        }
        private void sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cancelcheckbox.Checked == true)
                {
                    linq.Update_EstadoCompra(code, "Anulado");
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Producto Anulado con Exito", Alerts.AlertMessage.AlertType.success);
                }
                else
                {
                    linq.Update_EstadoCompra(code, "Aprobado");
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Producto Aprobado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
            catch (Exception)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se ha seleccionado un producto", Alerts.AlertMessage.AlertType.error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                ShowOrder();
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
            else
            {
                if (showpursachecheckbox.Checked == true)
                {
                    querygrid.DataSource = linq.DinamicQuery_Compra(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
                else
                {
                    querygrid.DataSource = linq.DinamicQuery_RequestedDetalleCompra(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void searchtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                ShowOrder();
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
            else
            {
                if (showpursachecheckbox.Checked == true)
                {
                    querygrid.DataSource = linq.DinamicQuery_Compra(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
                else
                {
                    querygrid.DataSource = linq.DinamicQuery_RequestedDetalleCompra(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (searchtxt.Text == "")
                {
                    ShowOrder();
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
                else
                {
                    if (showpursachecheckbox.Checked == true)
                    {
                        querygrid.DataSource = linq.DinamicQuery_Compra(searchtxt.Text);
                        registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                    }
                    else
                    {
                        querygrid.DataSource = linq.DinamicQuery_RequestedDetalleCompra(searchtxt.Text);
                        registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                    }
                }
            }
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
        }

        private void ApproveOrder_Query_Load(object sender, EventArgs e)
        {
            ShowOrder();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void cancelallcheckbox_OnChange(object sender, EventArgs e)
        {
            if (cancelcheckbox.Checked == false)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("La opcion de anular esta inactiva", Alerts.AlertMessage.AlertType.error);
                cancelallcheckbox.Checked = false;
            }
        }
        private void ShowOrder()
        {
            if (showpursachecheckbox.Checked == true)
            {
                querygrid.DataSource = linq.Query_Compra();
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
            else
            {
                querygrid.DataSource = linq.Query_RequestedDetalleCompra();
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
        }

        private void showpursachecheckbox_OnChange(object sender, EventArgs e)
        {
            ShowOrder();
        }

        private void aprovecheckbox_OnChange(object sender, EventArgs e)
        {
            Presentation_Layer.Alerts.AlertMessage.Show("Funcion en construccion", Alerts.AlertMessage.AlertType.info);
            aprovecheckbox.Checked = false;
        }
    }
}
