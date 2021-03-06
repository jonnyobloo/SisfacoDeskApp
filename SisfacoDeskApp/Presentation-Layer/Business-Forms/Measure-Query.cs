﻿using System;
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
    public partial class Measure_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public string measure;
        public string description;

        public Measure_Query()
        {
            InitializeComponent();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource = linq.DinamicQuery_UnidadMedida(searchtxt.Text);
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
            measure = querygrid[1, pos].Value.ToString();
            description = querygrid[2, pos].Value.ToString();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            Measure m = Owner as Measure;
            m.codetxt.Text = Convert.ToString(code);
            m.measuretxt.Text = measure;
            m.descriptiontxt.Text = description;
            this.Close();
        }

        private void Measure_Query_Load(object sender, EventArgs e)
        {
            grieddata();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
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
                querygrid.DataSource = linq.DinamicQuery_UnidadMedida(searchtxt.Text);
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
                    querygrid.DataSource = linq.DinamicQuery_UnidadMedida(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void grieddata()
        {
            querygrid.DataSource = linq.Query_UnidadMedida();
        }
    }
}
