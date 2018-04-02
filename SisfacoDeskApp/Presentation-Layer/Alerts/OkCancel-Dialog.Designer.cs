namespace SisfacoDeskApp.Presentation_Layer.Alerts
{
    partial class OkCancel_Dialog
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
            this.okbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.messagelbl = new System.Windows.Forms.Label();
            this.alertpb = new System.Windows.Forms.PictureBox();
            this.closepb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alertpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // okbtn
            // 
            this.okbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okbtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.okbtn.ForeColor = System.Drawing.Color.White;
            this.okbtn.Location = new System.Drawing.Point(26, 133);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(130, 35);
            this.okbtn.TabIndex = 12;
            this.okbtn.Text = "Ok";
            this.okbtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(190, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // messagelbl
            // 
            this.messagelbl.AutoSize = true;
            this.messagelbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagelbl.ForeColor = System.Drawing.Color.White;
            this.messagelbl.Location = new System.Drawing.Point(46, 72);
            this.messagelbl.Name = "messagelbl";
            this.messagelbl.Size = new System.Drawing.Size(259, 23);
            this.messagelbl.TabIndex = 14;
            this.messagelbl.Text = "Seguro quieres salir del Sistema?";
            // 
            // alertpb
            // 
            this.alertpb.Image = global::SisfacoDeskApp.Properties.Resources.advertencia;
            this.alertpb.Location = new System.Drawing.Point(1, 3);
            this.alertpb.Name = "alertpb";
            this.alertpb.Size = new System.Drawing.Size(50, 50);
            this.alertpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertpb.TabIndex = 15;
            this.alertpb.TabStop = false;
            // 
            // closepb
            // 
            this.closepb.Image = global::SisfacoDeskApp.Properties.Resources.cerrar;
            this.closepb.Location = new System.Drawing.Point(312, 3);
            this.closepb.Name = "closepb";
            this.closepb.Size = new System.Drawing.Size(25, 40);
            this.closepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closepb.TabIndex = 11;
            this.closepb.TabStop = false;
            this.closepb.Click += new System.EventHandler(this.closepb_Click);
            // 
            // OkCancel_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.alertpb);
            this.Controls.Add(this.messagelbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.closepb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OkCancel_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OkCancel_Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.alertpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closepb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox closepb;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label messagelbl;
        private System.Windows.Forms.PictureBox alertpb;
    }
}