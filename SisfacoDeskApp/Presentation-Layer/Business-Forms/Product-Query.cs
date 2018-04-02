using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SisfacoDeskApp.Presentation_Layer.Business_Forms
{
    public partial class Product_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        MemoryStream ms;
        public int pos;
        public int code;
        public string productname;      
        public string model;
        public string dimentions;
        public string description;
        public byte[] productimage;
        public string observation;
        public Product_Query()
        {
            InitializeComponent();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource = linq.DinamicQuery_Producto(searchtxt.Text);
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            //ms = new MemoryStream(productimage);
            Product pr = Owner as Product;
            pr.codetxt.Text = Convert.ToString(code);
            pr.productnametxt.Text = productname;
            pr.modeltxt.Text = model;
            pr.dimentiontxt.Text = dimentions;
            pr.descriptiontxt.Text = description;
            //pr.productpicture.Image = Image.FromStream(ms);
            pr.observationtxt.Text = observation;
            this.Close();
            /*foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Presentation_Layer.Buy_Forms.PurchaseOrder))
                {
                    Presentation_Layer.Buy_Forms.PurchaseOrder po = Owner as Buy_Forms.PurchaseOrder;
                    po.codeproduct = code;
                    po.producttxt.Text = productname;
                    this.Close();
                    break;
                }
                else
                {
                    ms = new MemoryStream(productimage);
                    Product pr = Owner as Product;
                    pr.codetxt.Text = Convert.ToString(code);
                    pr.productnametxt.Text = productname;
                    pr.modeltxt.Text = model;
                    pr.dimentiontxt.Text = dimentions;
                    pr.descriptiontxt.Text = description;
                    pr.productpicture.Image = Image.FromStream(ms);
                    pr.observationtxt.Text = observation;
                    this.Close();
                }
            }*/
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
                querygrid.DataSource = linq.DinamicQuery_Producto(searchtxt.Text);
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
                    querygrid.DataSource = linq.DinamicQuery_Producto(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
            productname = querygrid[1, pos].Value.ToString();
            model = querygrid[4, pos].Value.ToString();
            dimentions = querygrid[7, pos].Value.ToString();
            description = querygrid[8, pos].Value.ToString();
            productimage = System.Text.Encoding.UTF8.GetBytes(querygrid[9, pos].Value.ToString());
            observation = querygrid[10, pos].Value.ToString();
        }

        private void Product_Query_Load(object sender, EventArgs e)
        {
            grieddata();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void grieddata()
        {
            querygrid.DataSource = linq.Query_Producto();
        }

        private void send2btn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Buy_Forms.PurchaseOrder po = Owner as Buy_Forms.PurchaseOrder;
            po.codeproduct = code;
            po.producttxt.Text = productname;
            this.Close();
        }
    }
}
