namespace SisfacoDeskApp.Presentation_Layer.Alerts
{
    partial class Control_Dialog
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.messagelbl = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.closepb = new System.Windows.Forms.PictureBox();
            this.confirmpasstxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // messagelbl
            // 
            this.messagelbl.AutoSize = true;
            this.messagelbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagelbl.ForeColor = System.Drawing.Color.White;
            this.messagelbl.Location = new System.Drawing.Point(111, 62);
            this.messagelbl.Name = "messagelbl";
            this.messagelbl.Size = new System.Drawing.Size(164, 23);
            this.messagelbl.TabIndex = 18;
            this.messagelbl.Text = "Ingresar Contraseña";
            // 
            // okbtn
            // 
            this.okbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.okbtn.ForeColor = System.Drawing.Color.White;
            this.okbtn.Location = new System.Drawing.Point(130, 199);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(130, 35);
            this.okbtn.TabIndex = 16;
            this.okbtn.Text = "Ok";
            this.okbtn.UseVisualStyleBackColor = false;
            // 
            // closepb
            // 
            this.closepb.Image = global::SisfacoDeskApp.Properties.Resources.cerrar;
            this.closepb.Location = new System.Drawing.Point(356, 12);
            this.closepb.Name = "closepb";
            this.closepb.Size = new System.Drawing.Size(25, 40);
            this.closepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepb.TabIndex = 15;
            this.closepb.TabStop = false;
            this.closepb.Click += new System.EventHandler(this.closepb_Click);
            // 
            // confirmpasstxt
            // 
            this.confirmpasstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.confirmpasstxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasstxt.ForeColor = System.Drawing.Color.White;
            this.confirmpasstxt.Location = new System.Drawing.Point(92, 124);
            this.confirmpasstxt.Multiline = true;
            this.confirmpasstxt.Name = "confirmpasstxt";
            this.confirmpasstxt.PasswordChar = '*';
            this.confirmpasstxt.Size = new System.Drawing.Size(194, 34);
            this.confirmpasstxt.TabIndex = 62;
            // 
            // Control_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.confirmpasstxt);
            this.Controls.Add(this.messagelbl);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.closepb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Control_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control_Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label messagelbl;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.PictureBox closepb;
        private System.Windows.Forms.TextBox confirmpasstxt;
    }
}