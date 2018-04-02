using System;
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
    public partial class EchangeRate_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public EchangeRate_Query()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource = linq.DinamicQuery_TasaCambio(searchtxt.Text);
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void searchtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                grieddata();
            }
            else
            {
                querygrid.DataSource = linq.DinamicQuery_TasaCambio(searchtxt.Text);
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
                }
                else
                {
                    querygrid.DataSource = linq.DinamicQuery_TasaCambio(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            EchangeRate er = Owner as EchangeRate;
            er.codetxt.Text = Convert.ToString(code);
            this.Close();
        }

        private void EchangeRate_Query_Load(object sender, EventArgs e)
        {
            grieddata();
        }
        private void grieddata()
        {
            querygrid.DataSource = linq.Query_TasaCambio();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }
    }
}
