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
    public partial class Order_Submenu : Form
    {
        public Order_Submenu()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.Buy_Menu buy = new Presentation_Layer.Buy_Forms.Buy_Menu();
            buy.TopLevel = false;
            this.Controls.Add(buy);
            buy.Show();
        }

        private void neworderbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.PurchaseOrder po = new Presentation_Layer.Buy_Forms.PurchaseOrder();
            po.TopLevel = false;
            //po.Dock = DockStyle.Fill;
            this.Controls.Add(po);
            //this.Tag = po;
            po.Show();
        }

        private void approveorderbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.ApproveOrder_Query ap = new Presentation_Layer.Buy_Forms.ApproveOrder_Query();
            ap.TopLevel = false;
            this.Controls.Add(ap);
            ap.Show();
        }

        private void receptionorderbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.ReceiveOrder_Query re = new Presentation_Layer.Buy_Forms.ReceiveOrder_Query();
            re.TopLevel = false;
            this.Controls.Add(re);
            re.Show();
        }

        private void cancelorderbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.CanceledOrder_Query can = new Presentation_Layer.Buy_Forms.CanceledOrder_Query();
            can.TopLevel = false;
            this.Controls.Add(can);
            can.Show();
        }

        private void purchasesmadebtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Presentation_Layer.Buy_Forms.PurchaseOrder_Query puq = new Presentation_Layer.Buy_Forms.PurchaseOrder_Query();
            puq.TopLevel = false;
            this.Controls.Add(puq);
            puq.Show();
        }
    }
}
