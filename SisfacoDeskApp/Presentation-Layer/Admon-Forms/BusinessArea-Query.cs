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
    public partial class BusinessArea_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public string areaname;
        public string description;

        public BusinessArea_Query()
        {
            InitializeComponent();
            ColumnsName();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource= linq.DinamicQuery_AreaEmpresarial(searchtxt.Text);
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void BusinessArea_Query_Load(object sender, EventArgs e)
        {
            grieddata();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void grieddata()
        {
            querygrid.DataSource = linq.Query_AreaEmpresarial();
            /*querygrid.AutoGenerateColumns = false;
            using (Data_Layer.SisfacoDatabaseEntities db = new Data_Layer.SisfacoDatabaseEntities())
            {
                querygrid.DataSource = db.tbl_AreaEmpresarial.ToList<Data_Layer.AreaEmpresarial>();
            }*/
        }
        private void ColumnsName()
        {
            try
            {
                querygrid.Columns[0].HeaderText = "Codigo";
            }
            catch (Exception)
            {

            }
        }

        private void searchtxt_OnValueChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text=="")
            {
                grieddata();
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
            else
            {
                querygrid.DataSource = linq.DinamicQuery_AreaEmpresarial(searchtxt.Text);
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            Business_Area area = Owner as Business_Area;
            area.codetxt.Text = Convert.ToString(code);
            area.areanametxt.Text = areaname;
            area.descriptiontxt.Text = description;
            this.Close();
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
            areaname = querygrid[1, pos].Value.ToString();
            description = querygrid[2, pos].Value.ToString();
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
                    querygrid.DataSource = linq.DinamicQuery_AreaEmpresarial(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void searchtxt_Enter(object sender, EventArgs e)
        {
            //Aqui no se hace nada
        }
    }
}
