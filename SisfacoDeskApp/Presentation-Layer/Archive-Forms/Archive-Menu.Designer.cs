namespace SisfacoDeskApp.Presentation_Layer.Home_Forms
{
    partial class Archive_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.excelbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.wordbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.calculatorbtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.excelbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "    Word   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "   Excel  ";
            // 
            // excelbtn
            // 
            this.excelbtn.BackColor = System.Drawing.Color.Transparent;
            this.excelbtn.Image = global::SisfacoDeskApp.Properties.Resources.excel;
            this.excelbtn.ImageActive = null;
            this.excelbtn.Location = new System.Drawing.Point(724, 283);
            this.excelbtn.Name = "excelbtn";
            this.excelbtn.Size = new System.Drawing.Size(100, 100);
            this.excelbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.excelbtn.TabIndex = 4;
            this.excelbtn.TabStop = false;
            this.excelbtn.Zoom = 10;
            this.excelbtn.Click += new System.EventHandler(this.excelbtn_Click);
            // 
            // wordbtn
            // 
            this.wordbtn.BackColor = System.Drawing.Color.Transparent;
            this.wordbtn.Image = global::SisfacoDeskApp.Properties.Resources.word;
            this.wordbtn.ImageActive = null;
            this.wordbtn.Location = new System.Drawing.Point(342, 283);
            this.wordbtn.Name = "wordbtn";
            this.wordbtn.Size = new System.Drawing.Size(100, 100);
            this.wordbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wordbtn.TabIndex = 2;
            this.wordbtn.TabStop = false;
            this.wordbtn.Zoom = 10;
            this.wordbtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // calculatorbtn
            // 
            this.calculatorbtn.BackColor = System.Drawing.Color.Transparent;
            this.calculatorbtn.Image = global::SisfacoDeskApp.Properties.Resources.calculator;
            this.calculatorbtn.ImageActive = null;
            this.calculatorbtn.Location = new System.Drawing.Point(545, 283);
            this.calculatorbtn.Name = "calculatorbtn";
            this.calculatorbtn.Size = new System.Drawing.Size(100, 100);
            this.calculatorbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calculatorbtn.TabIndex = 0;
            this.calculatorbtn.TabStop = false;
            this.calculatorbtn.Zoom = 10;
            this.calculatorbtn.Click += new System.EventHandler(this.calculatorbtn_Click);
            // 
            // Archive_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1125, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.excelbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculatorbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Archive_Menu";
            this.Text = "Archive_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.excelbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton calculatorbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton wordbtn;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton excelbtn;
    }
}