namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    partial class User_Submenu
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.changepassbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.userbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.backbtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.changepassbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cambiar Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Usuarios";
            // 
            // changepassbtn
            // 
            this.changepassbtn.BackColor = System.Drawing.Color.Transparent;
            this.changepassbtn.Image = global::SisfacoDeskApp.Properties.Resources.password;
            this.changepassbtn.ImageActive = null;
            this.changepassbtn.Location = new System.Drawing.Point(613, 317);
            this.changepassbtn.Name = "changepassbtn";
            this.changepassbtn.Size = new System.Drawing.Size(62, 67);
            this.changepassbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changepassbtn.TabIndex = 28;
            this.changepassbtn.TabStop = false;
            this.changepassbtn.Zoom = 10;
            this.changepassbtn.Click += new System.EventHandler(this.changepassbtn_Click);
            // 
            // userbtn
            // 
            this.userbtn.BackColor = System.Drawing.Color.Transparent;
            this.userbtn.Image = global::SisfacoDeskApp.Properties.Resources.Users;
            this.userbtn.ImageActive = null;
            this.userbtn.Location = new System.Drawing.Point(381, 317);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(62, 67);
            this.userbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userbtn.TabIndex = 26;
            this.userbtn.TabStop = false;
            this.userbtn.Zoom = 10;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = global::SisfacoDeskApp.Properties.Resources.back;
            this.backbtn.Location = new System.Drawing.Point(1073, 27);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(40, 40);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 72;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // User_Submenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.changepassbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Submenu";
            this.Text = "User_Submenu";
            ((System.ComponentModel.ISupportInitialize)(this.changepassbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton changepassbtn;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton userbtn;
        private System.Windows.Forms.PictureBox backbtn;
    }
}