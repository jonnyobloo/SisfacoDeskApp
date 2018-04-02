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
    public partial class ReceiveOrder_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public int codeproduct;
        public int productquantity; //variable used for existence and disponibility
        public ReceiveOrder_Query()
        {
            InitializeComponent();
            aprovecheckbox.Checked = false;
            showpursachecheckbox.Checked = false;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource = linq.DinamicQuery_ApprovedDetalleCompra(searchtxt.Text);
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.Order_Submenu os = new Presentation_Layer.Buy_Forms.Order_Submenu();
            os.TopLevel = false;
            this.Controls.Add(os);
            os.Show();
        }

        private void ReceiveOrder_Query_Load(object sender, EventArgs e)
        {
            ShowOrder();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
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
                querygrid.DataSource = linq.Query_ApprovedDetalleCompra();
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
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
                    querygrid.DataSource = linq.DinamicQuery_ApprovedDetalleCompra(searchtxt.Text);
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
                        querygrid.DataSource = linq.DinamicQuery_ApprovedDetalleCompra(searchtxt.Text);
                        registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                    }
                }
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            linq.Update_EstadoCompra(code, "Recibido");
            linq.SubmitChanges();
            linq.Update_SumaInventario(codeproduct,productquantity);
            linq.SubmitChanges();
            linq.Update_SumaDisponibilidad(codeproduct, productquantity);
            linq.SubmitChanges();
            Presentation_Layer.Alerts.AlertMessage.Show("Producto Recibido con Exito", Alerts.AlertMessage.AlertType.success);
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
            codeproduct = int.Parse(querygrid[2, pos].Value.ToString());
            productquantity = int.Parse(querygrid[4, pos].Value.ToString());
        }

        private void showpursachecheckbox_OnChange(object sender, EventArgs e)
        {
            ShowOrder();
        }

        private void aprovecheckbox_OnChange(object sender, EventArgs e)
        {
            if (aprovecheckbox.Checked == true)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("Funcion en construccion", Alerts.AlertMessage.AlertType.info);
                aprovecheckbox.Checked = false;
            }
        }
    }
}
