namespace SisfacoDeskApp.Presentation_Layer.Buy_Forms
{
    partial class PurchaseOrder_Query
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.registrylbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.querygrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.showpursachecheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.marriedlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.searchbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.querygrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // registrylbl
            // 
            this.registrylbl.AutoSize = true;
            this.registrylbl.BackColor = System.Drawing.Color.Transparent;
            this.registrylbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrylbl.Location = new System.Drawing.Point(655, 643);
            this.registrylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrylbl.Name = "registrylbl";
            this.registrylbl.Size = new System.Drawing.Size(49, 23);
            this.registrylbl.TabIndex = 84;
            this.registrylbl.Text = "label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 643);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 83;
            this.label4.Text = "Total de Registros:";
            // 
            // searchtxt
            // 
            this.searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchtxt.HintForeColor = System.Drawing.Color.Gray;
            this.searchtxt.HintText = "Buscar por expresion";
            this.searchtxt.isPassword = false;
            this.searchtxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.searchtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.searchtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.searchtxt.LineThickness = 3;
            this.searchtxt.Location = new System.Drawing.Point(386, 120);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(296, 34);
            this.searchtxt.TabIndex = 82;
            this.searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchtxt.OnValueChanged += new System.EventHandler(this.searchtxt_OnValueChanged);
            this.searchtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchtxt_KeyPress);
            // 
            // querygrid
            // 
            this.querygrid.AllowUserToAddRows = false;
            this.querygrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.querygrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.querygrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.querygrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.querygrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.querygrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.querygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.querygrid.DoubleBuffered = true;
            this.querygrid.EnableHeadersVisualStyles = false;
            this.querygrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.querygrid.HeaderForeColor = System.Drawing.Color.White;
            this.querygrid.Location = new System.Drawing.Point(52, 201);
            this.querygrid.Name = "querygrid";
            this.querygrid.ReadOnly = true;
            this.querygrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.querygrid.RowTemplate.Height = 24;
            this.querygrid.Size = new System.Drawing.Size(1044, 384);
            this.querygrid.TabIndex = 81;
            this.querygrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.querygrid_CellClick);
            // 
            // showpursachecheckbox
            // 
            this.showpursachecheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.showpursachecheckbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.showpursachecheckbox.Checked = true;
            this.showpursachecheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.showpursachecheckbox.ForeColor = System.Drawing.Color.White;
            this.showpursachecheckbox.Location = new System.Drawing.Point(229, 632);
            this.showpursachecheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showpursachecheckbox.Name = "showpursachecheckbox";
            this.showpursachecheckbox.Size = new System.Drawing.Size(20, 20);
            this.showpursachecheckbox.TabIndex = 114;
            this.showpursachecheckbox.OnChange += new System.EventHandler(this.showpursachecheckbox_OnChange);
            // 
            // marriedlbl
            // 
            this.marriedlbl.AutoSize = true;
            this.marriedlbl.BackColor = System.Drawing.Color.Transparent;
            this.marriedlbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marriedlbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.marriedlbl.Location = new System.Drawing.Point(171, 655);
            this.marriedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.marriedlbl.Name = "marriedlbl";
            this.marriedlbl.Size = new System.Drawing.Size(135, 23);
            this.marriedlbl.TabIndex = 113;
            this.marriedlbl.Text = "Mostrar Compra";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.Image = global::SisfacoDeskApp.Properties.Resources.search;
            this.searchbtn.ImageActive = null;
            this.searchbtn.Location = new System.Drawing.Point(689, 120);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(32, 34);
            this.searchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchbtn.TabIndex = 85;
            this.searchbtn.TabStop = false;
            this.searchbtn.Zoom = 10;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = global::SisfacoDeskApp.Properties.Resources.back;
            this.backbtn.Location = new System.Drawing.Point(1056, 19);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(40, 40);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 136;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 20.8F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(378, 19);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(329, 47);
            this.bunifuCustomLabel1.TabIndex = 137;
            this.bunifuCustomLabel1.Text = "Compras Realizadas";
            // 
            // PurchaseOrder_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.showpursachecheckbox);
            this.Controls.Add(this.marriedlbl);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.registrylbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.querygrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrder_Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder_Query";
            this.Load += new System.EventHandler(this.PurchaseOrder_Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.querygrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton searchbtn;
        private System.Windows.Forms.Label registrylbl;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchtxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid querygrid;
        public Bunifu.Framework.UI.BunifuCheckbox showpursachecheckbox;
        private Bunifu.Framework.UI.BunifuCustomLabel marriedlbl;
        private System.Windows.Forms.PictureBox backbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}