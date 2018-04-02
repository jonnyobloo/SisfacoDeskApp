namespace SisfacoDeskApp.Presentation_Layer.Admon_Forms
{
    partial class Employee_Submenu
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
            this.detailemployeebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.employeebtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailemployeebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Asignar Cargos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Empleados";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.Image = global::SisfacoDeskApp.Properties.Resources.back;
            this.backbtn.Location = new System.Drawing.Point(1059, 29);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(40, 40);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 41;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // detailemployeebtn
            // 
            this.detailemployeebtn.BackColor = System.Drawing.Color.Transparent;
            this.detailemployeebtn.Image = global::SisfacoDeskApp.Properties.Resources.employeeposition;
            this.detailemployeebtn.ImageActive = null;
            this.detailemployeebtn.Location = new System.Drawing.Point(665, 318);
            this.detailemployeebtn.Name = "detailemployeebtn";
            this.detailemployeebtn.Size = new System.Drawing.Size(62, 67);
            this.detailemployeebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detailemployeebtn.TabIndex = 22;
            this.detailemployeebtn.TabStop = false;
            this.detailemployeebtn.Zoom = 10;
            this.detailemployeebtn.Click += new System.EventHandler(this.detailemployeebtn_Click);
            // 
            // employeebtn
            // 
            this.employeebtn.BackColor = System.Drawing.Color.Transparent;
            this.employeebtn.Image = global::SisfacoDeskApp.Properties.Resources.employee;
            this.employeebtn.ImageActive = null;
            this.employeebtn.Location = new System.Drawing.Point(433, 318);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(62, 67);
            this.employeebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeebtn.TabIndex = 20;
            this.employeebtn.TabStop = false;
            this.employeebtn.Zoom = 10;
            this.employeebtn.Click += new System.EventHandler(this.employeebtn_Click);
            // 
            // Employee_Submenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detailemployeebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Submenu";
            this.Text = "Employee_Submenu";
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailemployeebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton detailemployeebtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton employeebtn;
        private System.Windows.Forms.PictureBox backbtn;
    }
}