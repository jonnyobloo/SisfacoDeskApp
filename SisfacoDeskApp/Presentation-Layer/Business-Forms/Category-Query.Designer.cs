namespace SisfacoDeskApp.Presentation_Layer.Business_Forms
{
    partial class Category_Query
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Query));
            this.registrylbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.querygrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sendbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.closepb = new System.Windows.Forms.PictureBox();
            this.searchbtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.querygrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // registrylbl
            // 
            this.registrylbl.AutoSize = true;
            this.registrylbl.BackColor = System.Drawing.Color.Transparent;
            this.registrylbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrylbl.Location = new System.Drawing.Point(641, 514);
            this.registrylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrylbl.Name = "registrylbl";
            this.registrylbl.Size = new System.Drawing.Size(49, 23);
            this.registrylbl.TabIndex = 77;
            this.registrylbl.Text = "label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 514);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 76;
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
            this.searchtxt.Location = new System.Drawing.Point(366, 56);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(296, 34);
            this.searchtxt.TabIndex = 75;
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
            this.querygrid.Location = new System.Drawing.Point(32, 137);
            this.querygrid.Name = "querygrid";
            this.querygrid.ReadOnly = true;
            this.querygrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.querygrid.RowTemplate.Height = 24;
            this.querygrid.Size = new System.Drawing.Size(1044, 351);
            this.querygrid.TabIndex = 74;
            this.querygrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.querygrid_CellClick);
            // 
            // sendbtn
            // 
            this.sendbtn.ActiveBorderThickness = 1;
            this.sendbtn.ActiveCornerRadius = 20;
            this.sendbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.sendbtn.ActiveForecolor = System.Drawing.Color.White;
            this.sendbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.sendbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.sendbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendbtn.BackgroundImage")));
            this.sendbtn.ButtonText = "Aceptar";
            this.sendbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.ForeColor = System.Drawing.Color.White;
            this.sendbtn.IdleBorderThickness = 1;
            this.sendbtn.IdleCornerRadius = 20;
            this.sendbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.sendbtn.IdleForecolor = System.Drawing.Color.White;
            this.sendbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.sendbtn.Location = new System.Drawing.Point(472, 567);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(5);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(150, 50);
            this.sendbtn.TabIndex = 80;
            this.sendbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // closepb
            // 
            this.closepb.Image = global::SisfacoDeskApp.Properties.Resources.black_close;
            this.closepb.Location = new System.Drawing.Point(1058, 14);
            this.closepb.Name = "closepb";
            this.closepb.Size = new System.Drawing.Size(35, 55);
            this.closepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepb.TabIndex = 79;
            this.closepb.TabStop = false;
            this.closepb.Click += new System.EventHandler(this.closepb_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.Image = global::SisfacoDeskApp.Properties.Resources.search;
            this.searchbtn.ImageActive = null;
            this.searchbtn.Location = new System.Drawing.Point(669, 56);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(32, 34);
            this.searchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchbtn.TabIndex = 78;
            this.searchbtn.TabStop = false;
            this.searchbtn.Zoom = 10;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Category_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 630);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.closepb);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.registrylbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.querygrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category_Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category_Query";
            this.Load += new System.EventHandler(this.Category_Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.querygrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 sendbtn;
        private System.Windows.Forms.PictureBox closepb;
        private Bunifu.Framework.UI.BunifuImageButton searchbtn;
        private System.Windows.Forms.Label registrylbl;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchtxt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid querygrid;
    }
}