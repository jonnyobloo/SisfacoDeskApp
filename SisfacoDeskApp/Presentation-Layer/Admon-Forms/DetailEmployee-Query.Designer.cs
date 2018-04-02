namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    partial class DetailEmployee_Query
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailEmployee_Query));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sendbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.closepb = new System.Windows.Forms.PictureBox();
            this.registrylbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.querygrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querygrid)).BeginInit();
            this.SuspendLayout();
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
            this.sendbtn.Location = new System.Drawing.Point(486, 656);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(5);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(150, 50);
            this.sendbtn.TabIndex = 64;
            this.sendbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.Image = global::SisfacoDeskApp.Properties.Resources.search;
            this.searchbtn.ImageActive = null;
            this.searchbtn.Location = new System.Drawing.Point(666, 53);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(32, 34);
            this.searchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchbtn.TabIndex = 63;
            this.searchbtn.TabStop = false;
            this.searchbtn.Zoom = 10;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
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
            this.searchtxt.Location = new System.Drawing.Point(363, 53);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(296, 34);
            this.searchtxt.TabIndex = 62;
            this.searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchtxt.OnValueChanged += new System.EventHandler(this.searchtxt_OnValueChanged);
            this.searchtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchtxt_KeyPress);
            // 
            // closepb
            // 
            this.closepb.Image = global::SisfacoDeskApp.Properties.Resources.black_close;
            this.closepb.Location = new System.Drawing.Point(1061, 13);
            this.closepb.Name = "closepb";
            this.closepb.Size = new System.Drawing.Size(35, 55);
            this.closepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepb.TabIndex = 61;
            this.closepb.TabStop = false;
            this.closepb.Click += new System.EventHandler(this.closepb_Click);
            // 
            // registrylbl
            // 
            this.registrylbl.AutoSize = true;
            this.registrylbl.BackColor = System.Drawing.Color.Transparent;
            this.registrylbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrylbl.Location = new System.Drawing.Point(643, 612);
            this.registrylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrylbl.Name = "registrylbl";
            this.registrylbl.Size = new System.Drawing.Size(49, 23);
            this.registrylbl.TabIndex = 60;
            this.registrylbl.Text = "label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 612);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "Total de Registros:";
            // 
            // querygrid
            // 
            this.querygrid.AllowUserToAddRows = false;
            this.querygrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.querygrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.querygrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.querygrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.querygrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.querygrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.querygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.querygrid.DoubleBuffered = true;
            this.querygrid.EnableHeadersVisualStyles = false;
            this.querygrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.querygrid.HeaderForeColor = System.Drawing.Color.White;
            this.querygrid.Location = new System.Drawing.Point(29, 134);
            this.querygrid.Name = "querygrid";
            this.querygrid.ReadOnly = true;
            this.querygrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.querygrid.RowTemplate.Height = 24;
            this.querygrid.Size = new System.Drawing.Size(1044, 420);
            this.querygrid.TabIndex = 58;
            this.querygrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.querygrid_CellClick);
            // 
            // DetailEmployee_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.closepb);
            this.Controls.Add(this.registrylbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.querygrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailEmployee_Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailEmployee_Query";
            this.Load += new System.EventHandler(this.DetailEmployee_Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querygrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 sendbtn;
        private Bunifu.Framework.UI.BunifuImageButton searchbtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchtxt;
        private System.Windows.Forms.PictureBox closepb;
        private System.Windows.Forms.Label registrylbl;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid querygrid;
    }
}