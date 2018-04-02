namespace SisfacoDeskApp.Presentation_Layer.Home_Forms
{
    partial class Home
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
            this.icontimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Transition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icontimer
            // 
            this.icontimer.Interval = 6000;
            this.icontimer.Tick += new System.EventHandler(this.icontimer_Tick);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(244, 678);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(634, 23);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "© Sistema de Inventario y Facturacion Comercial - Todos los Derechos Reservados";
            // 
            // Transition
            // 
            this.Transition.Delay = 1;
            this.Transition.TransitionEnd += new System.EventHandler(this.Transition_TransitionEnd);
            // 
            // icon
            // 
            this.icon.Image = global::SisfacoDeskApp.Properties.Resources.homeimage;
            this.icon.Location = new System.Drawing.Point(-1, -1);
            this.icon.Margin = new System.Windows.Forms.Padding(4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(1127, 659);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 8;
            this.icon.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer icontimer;
        private System.Windows.Forms.PictureBox icon;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFormFadeTransition Transition;
    }
}