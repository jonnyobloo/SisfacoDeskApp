namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    partial class maintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maintenance));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cancelbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.savebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.newbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(297, 38);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(238, 45);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Mantenimiento";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = global::SisfacoDeskApp.Properties.Resources.back;
            this.backbtn.Location = new System.Drawing.Point(793, 21);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(30, 32);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 91;
            this.backbtn.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 120);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(174, 20);
            this.bunifuCustomLabel2.TabIndex = 92;
            this.bunifuCustomLabel2.Text = "Datos de mantenimiento";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(42, 144);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(177, 10);
            this.bunifuProgressBar1.TabIndex = 93;
            this.bunifuProgressBar1.Value = 0;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.LightGray;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(42, 170);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(765, 306);
            this.bunifuCustomDataGrid1.TabIndex = 99;
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
            this.cancelbtn.Location = new System.Drawing.Point(676, 512);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(112, 41);
            this.cancelbtn.TabIndex = 103;
            this.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.editbtn.Location = new System.Drawing.Point(472, 512);
            this.editbtn.Margin = new System.Windows.Forms.Padding(4);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(112, 41);
            this.editbtn.TabIndex = 102;
            this.editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.savebtn.ButtonText = "Ingresar";
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.IdleBorderThickness = 1;
            this.savebtn.IdleCornerRadius = 20;
            this.savebtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.savebtn.IdleForecolor = System.Drawing.Color.White;
            this.savebtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.savebtn.Location = new System.Drawing.Point(263, 512);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(112, 41);
            this.savebtn.TabIndex = 101;
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.newbtn.Location = new System.Drawing.Point(49, 512);
            this.newbtn.Margin = new System.Windows.Forms.Padding(4);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(112, 41);
            this.newbtn.TabIndex = 100;
            this.newbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(844, 585);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "maintenance";
            this.Text = "maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox backbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 editbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 savebtn;
        private Bunifu.Framework.UI.BunifuThinButton2 newbtn;
    }
}