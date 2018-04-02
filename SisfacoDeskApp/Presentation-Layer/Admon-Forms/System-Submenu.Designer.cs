namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    partial class System_Submenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.backupbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.maitenancebtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maitenancebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Respaldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mantenimiento";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = global::SisfacoDeskApp.Properties.Resources.back;
            this.backbtn.Location = new System.Drawing.Point(797, 17);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(30, 32);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 82;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // backupbtn
            // 
            this.backupbtn.BackColor = System.Drawing.Color.Transparent;
            this.backupbtn.Image = global::SisfacoDeskApp.Properties.Resources.backup;
            this.backupbtn.ImageActive = null;
            this.backupbtn.Location = new System.Drawing.Point(455, 265);
            this.backupbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(46, 54);
            this.backupbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backupbtn.TabIndex = 20;
            this.backupbtn.TabStop = false;
            this.backupbtn.Zoom = 10;
            // 
            // maitenancebtn
            // 
            this.maitenancebtn.BackColor = System.Drawing.Color.Transparent;
            this.maitenancebtn.Image = global::SisfacoDeskApp.Properties.Resources.maintenance;
            this.maitenancebtn.ImageActive = null;
            this.maitenancebtn.Location = new System.Drawing.Point(281, 265);
            this.maitenancebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maitenancebtn.Name = "maitenancebtn";
            this.maitenancebtn.Size = new System.Drawing.Size(46, 54);
            this.maitenancebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maitenancebtn.TabIndex = 18;
            this.maitenancebtn.TabStop = false;
            this.maitenancebtn.Zoom = 10;
            // 
            // System_Submenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(844, 585);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backupbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maitenancebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "System_Submenu";
            this.Text = "System_Submenu";
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maitenancebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton backupbtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton maitenancebtn;
        private System.Windows.Forms.PictureBox backbtn;
    }
}