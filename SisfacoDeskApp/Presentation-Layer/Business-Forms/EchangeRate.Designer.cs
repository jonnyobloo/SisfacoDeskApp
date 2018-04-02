namespace SisfacoDeskApp.Presentation_Layer.Business_Forms
{
    partial class EchangeRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EchangeRate));
            this.codegried = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.coincombobox = new System.Windows.Forms.ComboBox();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.cancelbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.savebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.newbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.codetxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.actualechangetxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.codegried)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // codegried
            // 
            this.codegried.AllowUserToAddRows = false;
            this.codegried.AllowUserToDeleteRows = false;
            this.codegried.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codegried.Location = new System.Drawing.Point(11, 689);
            this.codegried.Name = "codegried";
            this.codegried.ReadOnly = true;
            this.codegried.RowTemplate.Height = 24;
            this.codegried.Size = new System.Drawing.Size(10, 10);
            this.codegried.TabIndex = 89;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(528, 21);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(322, 59);
            this.bunifuCustomLabel1.TabIndex = 84;
            this.bunifuCustomLabel1.Text = "Tasa de Cambio";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(34, 124);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(268, 12);
            this.bunifuProgressBar1.TabIndex = 83;
            this.bunifuProgressBar1.Value = 0;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(29, 98);
            this.bunifuCustomLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(273, 25);
            this.bunifuCustomLabel13.TabIndex = 82;
            this.bunifuCustomLabel13.Text = "Informacion del Cambio Actual";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.coincombobox);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 464);
            this.panel2.TabIndex = 81;
            // 
            // coincombobox
            // 
            this.coincombobox.BackColor = System.Drawing.Color.Gainsboro;
            this.coincombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coincombobox.FormattingEnabled = true;
            this.coincombobox.Location = new System.Drawing.Point(560, 195);
            this.coincombobox.Name = "coincombobox";
            this.coincombobox.Size = new System.Drawing.Size(194, 31);
            this.coincombobox.TabIndex = 27;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = global::SisfacoDeskApp.Properties.Resources.back;
            this.backbtn.Location = new System.Drawing.Point(1073, 21);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(40, 40);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 90;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.ActiveBorderThickness = 1;
            this.cancelbtn.ActiveCornerRadius = 20;
            this.cancelbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.cancelbtn.ActiveForecolor = System.Drawing.Color.White;
            this.cancelbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.cancelbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.cancelbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelbtn.BackgroundImage")));
            this.cancelbtn.ButtonText = "Cancelar";
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.IdleBorderThickness = 1;
            this.cancelbtn.IdleCornerRadius = 20;
            this.cancelbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.cancelbtn.IdleForecolor = System.Drawing.Color.White;
            this.cancelbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.cancelbtn.Location = new System.Drawing.Point(923, 665);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(150, 50);
            this.cancelbtn.TabIndex = 88;
            this.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.ActiveBorderThickness = 1;
            this.editbtn.ActiveCornerRadius = 20;
            this.editbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.editbtn.ActiveForecolor = System.Drawing.Color.White;
            this.editbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.editbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.editbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editbtn.BackgroundImage")));
            this.editbtn.ButtonText = "Editar";
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.IdleBorderThickness = 1;
            this.editbtn.IdleCornerRadius = 20;
            this.editbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.editbtn.IdleForecolor = System.Drawing.Color.White;
            this.editbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.editbtn.Location = new System.Drawing.Point(651, 665);
            this.editbtn.Margin = new System.Windows.Forms.Padding(5);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(150, 50);
            this.editbtn.TabIndex = 87;
            this.editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.ActiveBorderThickness = 1;
            this.savebtn.ActiveCornerRadius = 20;
            this.savebtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.savebtn.ActiveForecolor = System.Drawing.Color.White;
            this.savebtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.savebtn.BackColor = System.Drawing.Color.Gainsboro;
            this.savebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebtn.BackgroundImage")));
            this.savebtn.ButtonText = "Guardar";
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.IdleBorderThickness = 1;
            this.savebtn.IdleCornerRadius = 20;
            this.savebtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.savebtn.IdleForecolor = System.Drawing.Color.White;
            this.savebtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.savebtn.Location = new System.Drawing.Point(373, 665);
            this.savebtn.Margin = new System.Windows.Forms.Padding(5);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(150, 50);
            this.savebtn.TabIndex = 86;
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.ActiveBorderThickness = 1;
            this.newbtn.ActiveCornerRadius = 20;
            this.newbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.newbtn.ActiveForecolor = System.Drawing.Color.White;
            this.newbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.newbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.newbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newbtn.BackgroundImage")));
            this.newbtn.ButtonText = "Nuevo";
            this.newbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newbtn.ForeColor = System.Drawing.Color.White;
            this.newbtn.IdleBorderThickness = 1;
            this.newbtn.IdleCornerRadius = 20;
            this.newbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.newbtn.IdleForecolor = System.Drawing.Color.White;
            this.newbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.newbtn.Location = new System.Drawing.Point(87, 665);
            this.newbtn.Margin = new System.Windows.Forms.Padding(5);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(150, 50);
            this.newbtn.TabIndex = 85;
            this.newbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(337, 344);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(77, 23);
            this.bunifuCustomLabel6.TabIndex = 96;
            this.bunifuCustomLabel6.Text = "Moneda:";
            // 
            // codetxt
            // 
            this.codetxt.AccessibleName = "";
            this.codetxt.BackColor = System.Drawing.Color.Gainsboro;
            this.codetxt.BorderColor = System.Drawing.Color.Gainsboro;
            this.codetxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.Location = new System.Drawing.Point(593, 251);
            this.codetxt.Margin = new System.Windows.Forms.Padding(4);
            this.codetxt.Multiline = true;
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(194, 34);
            this.codetxt.TabIndex = 95;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(337, 254);
            this.bunifuCustomLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(69, 23);
            this.bunifuCustomLabel15.TabIndex = 94;
            this.bunifuCustomLabel15.Text = "Codigo:";
            // 
            // actualechangetxt
            // 
            this.actualechangetxt.AccessibleName = "";
            this.actualechangetxt.BackColor = System.Drawing.Color.Gainsboro;
            this.actualechangetxt.BorderColor = System.Drawing.Color.Gainsboro;
            this.actualechangetxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualechangetxt.Location = new System.Drawing.Point(593, 435);
            this.actualechangetxt.Margin = new System.Windows.Forms.Padding(4);
            this.actualechangetxt.Multiline = true;
            this.actualechangetxt.Name = "actualechangetxt";
            this.actualechangetxt.Size = new System.Drawing.Size(194, 34);
            this.actualechangetxt.TabIndex = 93;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(337, 437);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(126, 23);
            this.bunifuCustomLabel2.TabIndex = 92;
            this.bunifuCustomLabel2.Text = "Cambio Actual:";
            // 
            // EchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.codetxt);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.actualechangetxt);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.codegried);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EchangeRate";
            this.Text = "EchangeRate";
            this.Load += new System.EventHandler(this.EchangeRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codegried)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView codegried;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 editbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 savebtn;
        private Bunifu.Framework.UI.BunifuThinButton2 newbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox backbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox codetxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox actualechangetxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public System.Windows.Forms.ComboBox coincombobox;
    }
}