using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer.Sell_Forms
{
    public partial class Sells : Form
    {
        Data_Layer.ConnectionLinqDataContext linq = new Data_Layer.ConnectionLinqDataContext();
        int codeform;
        int code1;
        int code2;
        int code3;
        int pos;
        public int codeemployee;
        public int codeproduct;
        public int codedealer;
        public int codetemporal;
        public int buycode;
        public int detail;
        public double requestedquantity;
        public double sellproduct = 0;
        public double productsubtotal = 0;
        public double subtotal = 0;
        public double price;
        public double productprice = 0;
        public double IVA = 0;
        public double total = 0;
        public double discount = 0;
        public string product;
        public Sells()
        {
            InitializeComponent();
            codetxt.Text = "";
            codegried.Visible = false;
            detailgried.Visible = false;
            stategried.Visible = false;
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "0") {
                // ingresar venta
                if (subtotaltxt.Text == "" || ivatxt.Text == "" || discounttxt.Text == "" || totaltxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {

                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void productdetailgried_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Clean()
        {
            dealertxt.Clear();
            producttxt.Clear();
            typeofpaycombobox.SelectedIndex = 0;
            paymentcombobox.SelectedIndex = 0;
            requestedquantitytxt.Clear();
            productpricetxt.Clear();
            productdiscounttxt.Clear();
            subtotaltxt.Clear();
            ivatxt.Clear();
            discounttxt.Clear();
            totaltxt.Clear();
            sellproduct = 0;
            subtotal = 0;
            productprice = 0;
            IVA = 0;
            total = 0;
            discount = 0;
            productsubtotal = 0;
        }

        private void DetailClean()
        {
            dealertxt.Clear();
            producttxt.Clear();
            typeofpaycombobox.SelectedIndex = 0;
            paymentcombobox.SelectedIndex = 0;
            requestedquantitytxt.Clear();
            productpricetxt.Clear();
            productdiscounttxt.Clear();
            productsubtotal = 0;
        }

        private void dealertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se acepta datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admite datos de tipo texto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //workwarrantytxt.CharacterCasing = CharacterCasing.Upper;
                //workwarrantytxt.CharacterCasing = CharacterCasing.Lower;
            }
        }

        private void requestedquantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //con esta condiccion solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //con esta condicion nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!requestedquantitytxt.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void productpricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //con esta condiccion solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //con esta condicion nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!productpricetxt.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void productdiscounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //con esta condiccion solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //con esta condicion nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '%') && (!productdiscounttxt.Text.Contains("%")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void subtotaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //con esta condiccion solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //con esta condicion nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!subtotaltxt.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ivatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //con esta condiccion solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //con esta condicion nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!ivatxt.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void discounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //con esta condiccion solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //con esta condicion nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '%') && (!discounttxt.Text.Contains("%")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void totaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //con esta condiccion solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //con esta condicion nos permite utilizar la letra backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!totaltxt.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
