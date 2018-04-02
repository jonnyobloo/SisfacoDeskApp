using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SisfacoDeskApp.Presentation_Layer.Alerts
{
    public partial class AlertMessage : Form
    {
        public AlertMessage(string _message, AlertType type)
        {
            InitializeComponent();
            message.Text = _message;
            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.info:
                    this.BackColor = Color.Gray;
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.warning:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    icon.Image = imageList1.Images[2];
                    break;
            }
        }
        public enum AlertType
        {
            success, info, warning, error
        }
        public static void Show(string message, AlertType type)
        {
            new SisfacoDeskApp.Presentation_Layer.Alerts.AlertMessage(message, type).Show();
        }

        private void AlertMessage_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            showtransition.Start();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showtransition_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval; // drop the alert
                interval += 2; // double the speed
            }
            else
            {
                showtransition.Stop();
                timeout.Start();
            }
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            close.Start();
        }
        int interval = 0;

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2; //reduce opacity to zero
            }
            else
            {
                this.Close(); //then close
            }
        }
    }
}
