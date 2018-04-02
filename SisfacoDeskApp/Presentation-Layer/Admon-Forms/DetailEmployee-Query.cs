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
    public partial class DetailEmployee_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public string name;
        public DetailEmployee_Query()
        {
            InitializeComponent();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource = linq.Dinamic_DetalleCargoEmpleado(searchtxt.Text);
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Users us = Owner as Users;
                us.codeform = code;
                us.employeetxt.Text = name;
                this.Close();
            }
            catch (Exception)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se ha seleccionado ningun registro", Alerts.AlertMessage.AlertType.warning);
            }
            
        }

        private void searchtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                grieddata();
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
            else
            {
                querygrid.DataSource = linq.Dinamic_DetalleCargoEmpleado(searchtxt.Text);
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
        }

        private void searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (searchtxt.Text == "")
                {
                    grieddata();
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
                else
                {
                    querygrid.DataSource = linq.Dinamic_DetalleCargoEmpleado(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
            name = querygrid[1, pos].Value.ToString();
        }

        private void DetailEmployee_Query_Load(object sender, EventArgs e)
        {
            grieddata();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }
        private void grieddata()
        {
            querygrid.DataSource = linq.Query_DetalleCargoEmpleado();
        }
    }
}
