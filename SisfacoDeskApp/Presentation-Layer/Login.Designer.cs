namespace SisfacoDeskApp.Presentation_Layer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.passtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showcheckb = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.closepb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.queryuserimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryuserimage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // passtxt
            // 
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passtxt.ForeColor = System.Drawing.Color.White;
            this.passtxt.HintForeColor = System.Drawing.Color.White;
            this.passtxt.HintText = "";
            this.passtxt.isPassword = true;
            this.passtxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.passtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.passtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.passtxt.LineThickness = 3;
            this.passtxt.Location = new System.Drawing.Point(451, 242);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(370, 44);
            this.passtxt.TabIndex = 7;
            this.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passtxt.OnValueChanged += new System.EventHandler(this.passtxt_OnValueChanged);
            this.passtxt.Enter += new System.EventHandler(this.passtxt_Enter);
            this.passtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passtxt_KeyPress);
            this.passtxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passtxt_KeyUp);
            // 
            // usertxt
            // 
            this.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usertxt.ForeColor = System.Drawing.Color.White;
            this.usertxt.HintForeColor = System.Drawing.Color.White;
            this.usertxt.HintText = "";
            this.usertxt.isPassword = false;
            this.usertxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.usertxt.LineIdleColor = System.Drawing.Color.Gray;
            this.usertxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.usertxt.LineThickness = 3;
            this.usertxt.Location = new System.Drawing.Point(451, 110);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(370, 44);
            this.usertxt.TabIndex = 6;
            this.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usertxt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(447, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "CONTRASEÑA";
            // 
            // showcheckb
            // 
            this.showcheckb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.showcheckb.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.showcheckb.Checked = true;
            this.showcheckb.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.showcheckb.ForeColor = System.Drawing.Color.White;
            this.showcheckb.Location = new System.Drawing.Point(461, 319);
            this.showcheckb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showcheckb.Name = "showcheckb";
            this.showcheckb.Size = new System.Drawing.Size(20, 20);
            this.showcheckb.TabIndex = 11;
            this.showcheckb.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(488, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "MOSTRAR CONTRASEÑA";
            // 
            // loginbtn
            // 
            this.loginbtn.ActiveBorderThickness = 1;
            this.loginbtn.ActiveCornerRadius = 20;
            this.loginbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.loginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.loginbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbtn.BackgroundImage")));
            this.loginbtn.ButtonText = "Ingresar";
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginbtn.IdleBorderThickness = 1;
            this.loginbtn.IdleCornerRadius = 20;
            this.loginbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.loginbtn.IdleForecolor = System.Drawing.Color.White;
            this.loginbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.loginbtn.Location = new System.Drawing.Point(451, 369);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(370, 50);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // closepb
            // 
            this.closepb.Image = global::SisfacoDeskApp.Properties.Resources.cerrar;
            this.closepb.Location = new System.Drawing.Point(824, 0);
            this.closepb.Name = "closepb";
            this.closepb.Size = new System.Drawing.Size(24, 43);
            this.closepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepb.TabIndex = 5;
            this.closepb.TabStop = false;
            this.closepb.Click += new System.EventHandler(this.closepb_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SisfacoDeskApp.Properties.Resources.Login_SISFACO;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 442);
            this.panel1.TabIndex = 1;
            // 
            // queryuserimage
            // 
            this.queryuserimage.Location = new System.Drawing.Point(436, 0);
            this.queryuserimage.Name = "queryuserimage";
            this.queryuserimage.Size = new System.Drawing.Size(10, 10);
            this.queryuserimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queryuserimage.TabIndex = 0;
            this.queryuserimage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(860, 442);
            this.Controls.Add(this.queryuserimage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showcheckb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.closepb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryuserimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usertxt;
        private System.Windows.Forms.PictureBox closepb;
        private Bunifu.Framework.UI.BunifuThinButton2 loginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox showcheckb;
        private System.Windows.Forms.PictureBox queryuserimage;
    }
}