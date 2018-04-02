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
    public partial class Coin_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public string coin;
        public string origin;
        public Coin_Query()
        {
            InitializeComponent();
        }

        private void Coin_Query_Load(object sender, EventArgs e)
        {
            grieddata();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource = linq.DinamicQuery_Moneda(searchtxt.Text);
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
                querygrid.DataSource = linq.DinamicQuery_Moneda(searchtxt.Text);
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
                    querygrid.DataSource = linq.DinamicQuery_Moneda(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
            coin = querygrid[1, pos].Value.ToString();
            origin = querygrid[2, pos].Value.ToString();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            Coin co = Owner as Coin;
            co.codetxt.Text = Convert.ToString(code);
            co.cointxt.Text = coin;
            co.origintxt.Text = origin;
            this.Close();
        }
        private void grieddata()
        {
            querygrid.DataSource = linq.Query_Moneda();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }
    }
}
