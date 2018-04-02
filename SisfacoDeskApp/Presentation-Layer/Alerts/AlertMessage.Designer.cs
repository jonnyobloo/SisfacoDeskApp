namespace SisfacoDeskApp.Presentation_Layer.Alerts
{
    partial class AlertMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertMessage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.message = new System.Windows.Forms.Label();
            this.showtransition = new System.Windows.Forms.Timer(this.components);
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.close = new System.Windows.Forms.Timer(this.components);
            this.closepb = new System.Windows.Forms.PictureBox();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ok.png");
            this.imageList1.Images.SetKeyName(1, "informacion.png");
            this.imageList1.Images.SetKeyName(2, "advertencia.png");
            this.imageList1.Images.SetKeyName(3, "cerrar (1).png");
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(90, 26);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(131, 23);
            this.message.TabIndex = 1;
            this.message.Text = "Sucess Message";
            // 
            // showtransition
            // 
            this.showtransition.Interval = 50;
            this.showtransition.Tick += new System.EventHandler(this.showtransition_Tick);
            // 
            // timeout
            // 
            this.timeout.Interval = 500;
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // close
            // 
            this.close.Tick += new System.EventHandler(this.close_Tick);
            // 
            // closepb
            // 
            this.closepb.Image = global::SisfacoDeskApp.Properties.Resources.cerrar;
            this.closepb.Location = new System.Drawing.Point(368, 2);
            this.closepb.Name = "closepb";
            this.closepb.Size = new System.Drawing.Size(15, 29);
            this.closepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepb.TabIndex = 6;
            this.closepb.TabStop = false;
            this.closepb.Click += new System.EventHandler(this.closepb_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Image = global::SisfacoDeskApp.Properties.Resources.Ok;
            this.icon.Location = new System.Drawing.Point(12, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // AlertMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(395, 76);
            this.Controls.Add(this.closepb);
            this.Controls.Add(this.message);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertMessage";
            this.Text = "AlertMessage";
            this.Load += new System.EventHandler(this.AlertMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox closepb;
        private System.Windows.Forms.Timer showtransition;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Timer close;
    }
}