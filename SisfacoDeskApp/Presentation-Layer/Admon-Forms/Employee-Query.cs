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
    public partial class Employee_Query : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        public int pos;
        public int code;
        public string name;
        public string lastname;
        public string inss;
        public string identification;
        public string phone;
        public string mail;
        public string address;

        public Employee_Query()
        {
            InitializeComponent();
        }

        private void Employee_Query_Load(object sender, EventArgs e)
        {
            grieddata();
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            querygrid.DataSource = linq.DinamicQuery_Empleado(searchtxt.Text);
            registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
        }
        private void grieddata()
        {
            querygrid.DataSource = linq.Query_Empleado();
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
                querygrid.DataSource = linq.DinamicQuery_Empleado(searchtxt.Text);
                registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            Employee em = Owner as Employee;
            em.codetxt.Text = Convert.ToString(code);
            em.nametxt.Text = name;
            em.lastnametxt.Text = lastname;
            em.phonetxt.Text = phone;
            em.addresstxt.Text = address;
            em.insstxt.Text = inss;
            em.mailtxt.Text = mail;
            this.Close();
        }

        private void querygrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = querygrid.CurrentRow.Index;
            code = int.Parse(querygrid[0, pos].Value.ToString());
            name = querygrid[1, pos].Value.ToString();
            lastname = querygrid[2, pos].Value.ToString();
            phone = querygrid[4, pos].Value.ToString();
            address = querygrid[5, pos].Value.ToString();
            inss = querygrid[6, pos].Value.ToString();
            mail = querygrid[9, pos].Value.ToString();
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
                    querygrid.DataSource = linq.DinamicQuery_Empleado(searchtxt.Text);
                    registrylbl.Text = Convert.ToString(querygrid.Rows.Count);
                }
            }
        }

        private void send2btn_Click(object sender, EventArgs e)
        {
            DetailEmployee em = Owner as DetailEmployee;
            em.codeemployee = code;
            em.employeetxt.Text = name;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {



            //aqui se elimina la primera fila
            //querygrid.Rows.RemoveAt(0);


            //primer metodo (no funcional)
            /*
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea elminar los registros");

                if (opcion == DialogResult)
                {
                    string codigo;
                    string Rpta = "";

                    foreach (querygrid row)
                    {
                        if (Convert.ToBoolean(row.Cells[0].value))
                        {
                            codigo = Convert.ToString(row.Cell[1].Value);
                            Rpta = Employee.Row.RemoveAt(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Show();
            */

        }
    }
}
