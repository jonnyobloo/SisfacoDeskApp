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
    public partial class Dealer_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public string name;
        public string lastname;
        public string identification;
        public string phone;
        public string webmail;
        public string address;
        public Dealer_Query()
        {
            InitializeComponent();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource = linq.DinamicQuery_Proveedor(searchtxt.Text);
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
                querygrid.DataSource = linq.DinamicQuery_Proveedor(searchtxt.Text);
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
                    querygrid.DataSource = linq.DinamicQuery_Proveedor(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            /*foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Presentation_Layer.Buy_Forms.PurchaseOrder))
                {
                    Presentation_Layer.Buy_Forms.PurchaseOrder po = Owner as Buy_Forms.PurchaseOrder;
                    po.codedealer = code;
                    po.dealertxt.Text = name;
                    this.Close();
                    break;
                }
                else
                {
                    Dealer de = Owner as Dealer;
                    de.codetxt.Text = Convert.ToString(code);
                    de.nametxt.Text = name;
                    de.lastnametxt.Text = lastname;
                    de.phonetxt.Text = phone;
                    de.addresstxt.Text = address;
                    de.webmailtxt.Text = webmail;
                    this.Close();
                }
            }*/
            Dealer de = Owner as Dealer;
            de.codetxt.Text = Convert.ToString(code);
            de.nametxt.Text = name;
            de.lastnametxt.Text = lastname;
            de.phonetxt.Text = phone;
            de.addresstxt.Text = address;
            de.webmailtxt.Text = webmail;
            this.Close();
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
            identification = querygrid[1, pos].Value.ToString();
            name = querygrid[2, pos].Value.ToString();
            phone = querygrid[3, pos].Value.ToString();
            address = querygrid[4, pos].Value.ToString();
            webmail = querygrid[8, pos].Value.ToString();
        }

        private void Dealer_Query_Load(object sender, EventArgs e)
        {
            grieddata();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }
        private void grieddata()
        {
            querygrid.DataSource = linq.Query_Proveedor();
        }

        private void send2btn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Buy_Forms.PurchaseOrder po = Owner as Buy_Forms.PurchaseOrder;
            po.codedealer = code;
            po.dealertxt.Text = name;
            this.Close();
        }
    }
}
