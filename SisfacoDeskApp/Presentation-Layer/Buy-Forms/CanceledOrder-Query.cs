﻿using System;
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
    public partial class CanceledOrder_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public CanceledOrder_Query()
        {
            InitializeComponent();
            showpursachecheckbox.Checked = false;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.Order_Submenu os = new Presentation_Layer.Buy_Forms.Order_Submenu();
            os.TopLevel = false;
            this.Controls.Add(os);
            os.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            ShowOrder();
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
                    querygrid.DataSource = linq.DinamicQuery_CanceledDetalleCompra(searchtxt.Text);
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
                        querygrid.DataSource = linq.DinamicQuery_CanceledDetalleCompra(searchtxt.Text);
                        registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                    }
                }
            }
        }
        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nothing
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
                querygrid.DataSource = linq.Query_CanceledDetalleCompra();
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
        }

        private void showpursachecheckbox_OnChange(object sender, EventArgs e)
        {
            ShowOrder();
        }

        private void CanceledOrder_Query_Load(object sender, EventArgs e)
        {
            ShowOrder();
        }
    }
}
