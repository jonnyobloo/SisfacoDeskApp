using System;
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
    public partial class PurchaseOrder : Form
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
        public int detailcode;
        public double requestedquantity;
        public double buyedproduct = 0;
        public double productsubtotal = 0;
        public double subtotal = 0;
        public double price;
        public double productprice = 0;
        public double IVA = 0;
        public double total = 0;
        public double discount = 0;
        public double productdiscount = 0;
        public double percentagediscount = 0;
        public double textproductprice = 0;
        public double textrequestedquantity = 0;
        public double textsubtotal = 0;
        public double textdiscount = 0;
        public double textiva = 0;
        public double loadedrequestedquantity;
        public double loadedproductsubtotal = 0;
        public double loadedproductprice = 0;
        public double loadedproductiva = 0;
        public string product;
        public PurchaseOrder()
        {
            InitializeComponent();
            codetxt.Text = "0";
            codetxt.Enabled = false;
            codegried.Visible = false;
            detailgried.Visible = false;
            stategried.Visible = false;
            productdetailgried.Columns[7].Visible = false;
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            codetxt.Text = "0";
            Clean();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (codetxt.Text == "0")
            {
                //Ingresar Compra y Estado
                if (subtotaltxt.Text == "" || ivatxt.Text == "" || discounttxt.Text == "" || totaltxt.Text == "")
                {
                    Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
                }
                else
                {
                    linq.Update_Compra(code1, codeemployee, codedealer,
                                       typeofpaycombobox.Text, paymentcombobox.Text, double.Parse(subtotaltxt.Text),
                                       double.Parse(ivatxt.Text), double.Parse(discounttxt.Text), decimal.Parse(totaltxt.Text), "Si");
                    linq.SubmitChanges();
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                }
            }
            else
            {
                //Actualizar Detalles y Compra
                if (subtotaltxt.Text == "" || ivatxt.Text == "" || discounttxt.Text == "" || totaltxt.Text == "")
                {
                    linq.Update_Compra(code1, codeemployee, codedealer,
                                       typeofpaycombobox.Text, paymentcombobox.Text, double.Parse(subtotaltxt.Text),
                                       double.Parse(ivatxt.Text), double.Parse(discounttxt.Text), decimal.Parse(totaltxt.Text), "Si");
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Actualizado con Exito", Alerts.AlertMessage.AlertType.success);
                    linq.SubmitChanges();
                    //linq.Update_EstadoCompra(code3);
                }
            }
            Clean();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Alerts.AlertMessage.Show("Accion no Permitida", Alerts.AlertMessage.AlertType.warning);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            dbcode();
        }
        private void loadcode()
        {
            codegried.DataSource = linq.Query_Code_Compra();
            for (int i = 1; i < codegried.Rows.Count; i++)
            {
                codeform = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
            }
            this.codetxt.Text = Convert.ToString(codeform);
        }

        private void dbcode()
        {
            //Code of Buy
            code1 = 1;
            codegried.DataSource = linq.Query_Code_Compra();
            if (codegried.RowCount == 0)
            {
                code1 = 1;
            }
            else
            {
                for (int i = 1; i < codegried.Rows.Count; i++)
                {
                    code1 = int.Parse(codegried.Rows[i].Cells[0].Value.ToString());
                }
                code1 = code1 + 1;
            }

            //Code of Detail Buy
            code2 = 1;
            detailgried.DataSource = linq.Query_Code_DetalleCompra();
            if (detailgried.RowCount == 0)
            {
                code2 = 1;
            }
            else
            {
                for (int i = 1; i < detailgried.Rows.Count; i++)
                {
                    code2 = int.Parse(detailgried.Rows[i].Cells[0].Value.ToString());
                }
                code2 = code2 + 1;
            }

            //Code Of State
            code3 = 1;
            stategried.DataSource = linq.Query_Code_EstadoCompra();
            if (stategried.RowCount == 0)
            {
                code3 = 1;
            }
            else
            {
                for (int i = 1; i < stategried.Rows.Count; i++)
                {
                    code3 = int.Parse(stategried.Rows[i].Cells[0].Value.ToString());
                }
                code3 = code3 + 1;
            }
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
            buyedproduct = 0;
            subtotal = 0;
            productprice = 0;
            IVA = 0;
            total = 0;
            discount = 0;
            productsubtotal = 0;
    }

        private void DetailClean()
        {
            producttxt.Clear();
            typeofpaycombobox.SelectedIndex = 0;
            paymentcombobox.SelectedIndex = 0;
            requestedquantitytxt.Clear();
            productpricetxt.Clear();
            productdiscounttxt.Clear();
            productsubtotal = 0;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            dbcode();
            if (producttxt.Text == "" || requestedquantitytxt.Text == "" 
                || productpricetxt.Text == "" || productdiscounttxt.Text == "")
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se permiten campos vacios", Alerts.AlertMessage.AlertType.error);
            }
            else
            {
                if (productdetailgried.Rows.Count == 0)
                {
                    //Insercion de la compra nula + Primer Detalle y su respectivo Estado
                    product = producttxt.Text;
                    requestedquantity = double.Parse(requestedquantitytxt.Text);
                    productprice = double.Parse(productpricetxt.Text);
                    productsubtotal = Convert.ToDouble(requestedquantitytxt.Text) * Convert.ToDouble(productpricetxt.Text);
                    percentagediscount = Convert.ToDouble(productdiscounttxt.Text);
                    productdiscount = (productprice * Convert.ToDouble(productdiscounttxt.Text))/100;
                    productdetailgried.Rows.Add(codeproduct, product, requestedquantity, productprice, productsubtotal,percentagediscount,productdiscount,code2);
                    price = Convert.ToDouble(requestedquantitytxt.Text) * Convert.ToDouble(productpricetxt.Text);
                    subtotal += Convert.ToDouble(requestedquantitytxt.Text) * Convert.ToDouble(productpricetxt.Text);
                    subtotaltxt.Text = Convert.ToString(subtotal);
                    //compraproducto = Convert.ToDecimal(requestedquantitytxt.Text) * Convert.ToDecimal(productpricetxt.Text);
                    IVA = Convert.ToDouble(subtotal * 0.15);
                    ivatxt.Text = Convert.ToString(IVA);
                    discount += productprice * Convert.ToDouble(productdiscounttxt.Text);
                    discounttxt.Text = Convert.ToString(discount / 100);
                    total = (subtotal + IVA) - (discount / 100);
                    totaltxt.Text = Convert.ToString(total);
                    linq.Insert_Compra(code1, 1, codedealer,typeofpaycombobox.Text,
                                       paymentcombobox.Text,subtotal,
                                        IVA, discount, decimal.Parse(totaltxt.Text), "Si");
                    linq.SubmitChanges();
                    buycode = code1;
                    linq.Insert_DetalleCompra(code2,code1,codeproduct,double.Parse(requestedquantitytxt.Text),0
                                              ,percentagediscount,productdiscount,double.Parse(productpricetxt.Text),productsubtotal);
                    linq.SubmitChanges();
                    linq.Insert_EstadoCompra(code3,code2,"Solicitada");
                    Presentation_Layer.Alerts.AlertMessage.Show("Producto Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    DetailClean();
                }
                else
                {
                    //Insercion de los Detalles y su Estados relacionados al codigo de la compra nula;
                    product = producttxt.Text;
                    requestedquantity = double.Parse(requestedquantitytxt.Text);
                    productprice = double.Parse(productpricetxt.Text);
                    productsubtotal = Convert.ToDouble(requestedquantitytxt.Text) * Convert.ToDouble(productpricetxt.Text);
                    productdetailgried.Rows.Add(codeproduct, product, requestedquantity, productprice, productsubtotal, code2);
                    price = Convert.ToDouble(requestedquantitytxt.Text) * Convert.ToDouble(productpricetxt.Text);
                    subtotal += Convert.ToDouble(requestedquantitytxt.Text) * Convert.ToDouble(productpricetxt.Text);
                    subtotaltxt.Text = Convert.ToString(subtotal);
                    IVA = Convert.ToDouble(subtotal * 0.15);
                    ivatxt.Text = Convert.ToString(IVA);
                    discount += productprice * Convert.ToDouble(productdiscounttxt.Text);
                    discounttxt.Text = Convert.ToString(discount / 100);
                    total = (subtotal + IVA) - (discount / 100);
                    totaltxt.Text = Convert.ToString(total);
                    linq.Insert_DetalleCompra(code2, buycode, codeproduct, double.Parse(requestedquantitytxt.Text), 0
                                              ,percentagediscount,productdiscount, double.Parse(productpricetxt.Text), productsubtotal);
                    linq.SubmitChanges();
                    linq.Insert_EstadoCompra(code3, code2, "Solicitada");
                    Presentation_Layer.Alerts.AlertMessage.Show("Registro Agregado con Exito", Alerts.AlertMessage.AlertType.success);
                    DetailClean();
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productdetailgried.Rows.Count == 1)
                {
                    productdetailgried.Rows.RemoveAt(pos);
                    linq.Delete_EstadoCompra(detailcode);
                    linq.SubmitChanges();
                    linq.Delete_DetalleCompra(detailcode);
                    linq.SubmitChanges();
                    linq.Delete_Compra(buycode);
                    linq.SubmitChanges();
                    textproductprice = double.Parse(productpricetxt.Text);
                    textrequestedquantity = double.Parse(requestedquantitytxt.Text);
                    textsubtotal = double.Parse(subtotaltxt.Text);
                    requestedquantitytxt.Text = Convert.ToString(textrequestedquantity - loadedrequestedquantity);
                    productpricetxt.Text = Convert.ToString(textproductprice - loadedproductprice);
                    subtotaltxt.Text = Convert.ToString(textsubtotal - loadedproductsubtotal);
                }
                else
                {
                    productdetailgried.Rows.RemoveAt(pos);
                    linq.Delete_EstadoCompra(detailcode);
                    linq.SubmitChanges();
                    linq.Delete_DetalleCompra(detailcode);
                    linq.SubmitChanges();
                }
            }
            catch (Exception)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("No se ha cargado un Producto", Alerts.AlertMessage.AlertType.success);
            }
        }

        private void dealersearchbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Business_Forms.Dealer_Query de = new Business_Forms.Dealer_Query();
            AddOwnedForm(de);
            de.sendbtn.Visible = false;
            de.send2btn.Visible = true;
            de.Show();
        }

        private void productsearchbtn_Click(object sender, EventArgs e)
        {
            Presentation_Layer.Business_Forms.Product_Query prod = new Business_Forms.Product_Query();
            AddOwnedForm(prod);
            prod.sendbtn.Visible = false;
            prod.send2btn.Visible = true;
            prod.Show();
        }

        private void productdetailgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = productdetailgried.CurrentRow.Index;
            detailcode = int.Parse(productdetailgried[7, pos].Value.ToString());
            loadedrequestedquantity = double.Parse(productdetailgried[2, pos].Value.ToString());
            loadedproductprice = double.Parse(productdetailgried[3, pos].Value.ToString());
            loadedproductsubtotal = double.Parse(productdetailgried[4, pos].Value.ToString());
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
            else if ((e.KeyChar == '%') && (!ivatxt.Text.Contains("%")))
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.Order_Submenu os = new Presentation_Layer.Buy_Forms.Order_Submenu();
            os.TopLevel = false;
            this.Controls.Add(os);
            os.Show();
        }
    }
}
