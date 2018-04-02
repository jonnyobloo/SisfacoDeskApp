namespace SisfacoDeskApp.Presentation_Layer.Business_Forms
{
    partial class Measure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Measure));
            this.codegried = new System.Windows.Forms.DataGridView();
            this.closepb = new System.Windows.Forms.PictureBox();
            this.cancelbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.savebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.newbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptiontxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.codetxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.measuretxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ttmessage = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.codegried)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codegried
            // 
            this.codegried.AllowUserToAddRows = false;
            this.codegried.AllowUserToDeleteRows = false;
            this.codegried.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codegried.Location = new System.Drawing.Point(12, 662);
            this.codegried.Name = "codegried";
            this.codegried.ReadOnly = true;
            this.codegried.RowTemplate.Height = 24;
            this.codegried.Size = new System.Drawing.Size(10, 10);
            this.codegried.TabIndex = 80;
            // 
            // closepb
            // 
            this.closepb.Image = global::SisfacoDeskApp.Properties.Resources.black_close;
            this.closepb.Location = new System.Drawing.Point(1080, 7);
            this.closepb.Name = "closepb";
            this.closepb.Size = new System.Drawing.Size(35, 55);
            this.closepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepb.TabIndex = 79;
            this.closepb.TabStop = false;
            this.closepb.Click += new System.EventHandler(this.closepb_Click);
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
            this.cancelbtn.Location = new System.Drawing.Point(929, 643);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(150, 50);
            this.cancelbtn.TabIndex = 78;
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
            this.editbtn.Location = new System.Drawing.Point(657, 643);
            this.editbtn.Margin = new System.Windows.Forms.Padding(5);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(150, 50);
            this.editbtn.TabIndex = 77;
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
            this.savebtn.Location = new System.Drawing.Point(379, 643);
            this.savebtn.Margin = new System.Windows.Forms.Padding(5);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(150, 50);
            this.savebtn.TabIndex = 76;
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
            this.newbtn.Location = new System.Drawing.Point(93, 643);
            this.newbtn.Margin = new System.Windows.Forms.Padding(5);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(150, 50);
            this.newbtn.TabIndex = 75;
            this.newbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(425, 7);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(375, 59);
            this.bunifuCustomLabel1.TabIndex = 74;
            this.bunifuCustomLabel1.Text = "Unidad de Medida";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(34, 112);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(324, 12);
            this.bunifuProgressBar1.TabIndex = 73;
            this.bunifuProgressBar1.Value = 0;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(29, 86);
            this.bunifuCustomLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(321, 25);
            this.bunifuCustomLabel13.TabIndex = 72;
            this.bunifuCustomLabel13.Text = "Informacion de la Unidad de Medida";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.descriptiontxt);
            this.panel2.Controls.Add(this.codetxt);
            this.panel2.Controls.Add(this.bunifuCustomLabel15);
            this.panel2.Controls.Add(this.measuretxt);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 476);
            this.panel2.TabIndex = 71;
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.BackColor = System.Drawing.Color.Gainsboro;
            this.descriptiontxt.BorderColor = System.Drawing.Color.Gainsboro;
            this.descriptiontxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontxt.Location = new System.Drawing.Point(556, 238);
            this.descriptiontxt.Margin = new System.Windows.Forms.Padding(4);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(242, 86);
            this.descriptiontxt.TabIndex = 21;
            // 
            // codetxt
            // 
            this.codetxt.AccessibleName = "";
            this.codetxt.BackColor = System.Drawing.Color.Gainsboro;
            this.codetxt.BorderColor = System.Drawing.Color.Gainsboro;
            this.codetxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.Location = new System.Drawing.Point(556, 82);
            this.codetxt.Margin = new System.Windows.Forms.Padding(4);
            this.codetxt.Multiline = true;
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(194, 34);
            this.codetxt.TabIndex = 20;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(300, 85);
            this.bunifuCustomLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(69, 23);
            this.bunifuCustomLabel15.TabIndex = 19;
            this.bunifuCustomLabel15.Text = "Codigo:";
            // 
            // measuretxt
            // 
            this.measuretxt.AccessibleName = "";
            this.measuretxt.BackColor = System.Drawing.Color.Gainsboro;
            this.measuretxt.BorderColor = System.Drawing.Color.Gainsboro;
            this.measuretxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measuretxt.Location = new System.Drawing.Point(556, 157);
            this.measuretxt.Margin = new System.Windows.Forms.Padding(4);
            this.measuretxt.Multiline = true;
            this.measuretxt.Name = "measuretxt";
            this.measuretxt.Size = new System.Drawing.Size(194, 34);
            this.measuretxt.TabIndex = 8;
            this.measuretxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.measuretxt_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(300, 157);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(133, 23);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Tipo de Medida:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(300, 241);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(102, 23);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Descripcion:";
            // 
            // ttmessage
            // 
            this.ttmessage.AutoPopDelay = 5000;
            this.ttmessage.InitialDelay = 200;
            this.ttmessage.IsBalloon = true;
            this.ttmessage.ReshowDelay = 100;
            this.ttmessage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttmessage.ToolTipTitle = "Select";
            // 
            // Measure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.codegried);
            this.Controls.Add(this.closepb);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Measure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measure";
            this.Load += new System.EventHandler(this.Measure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codegried)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView codegried;
        private System.Windows.Forms.PictureBox closepb;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 editbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 savebtn;
        private Bunifu.Framework.UI.BunifuThinButton2 newbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.Panel panel2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox descriptiontxt;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox codetxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox measuretxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ToolTip ttmessage;
    }
}