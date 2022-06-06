namespace uiprogect.UserControls
{
    partial class sikayet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aciklama = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bildir_but = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aciklama
            // 
            this.aciklama.BackColor = System.Drawing.Color.Transparent;
            this.aciklama.BaseColor = System.Drawing.Color.White;
            this.aciklama.BorderColor = System.Drawing.Color.Silver;
            this.aciklama.BorderSize = 3;
            this.aciklama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aciklama.FocusedBaseColor = System.Drawing.Color.White;
            this.aciklama.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.aciklama.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.aciklama.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.aciklama.Location = new System.Drawing.Point(42, 78);
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Padding = new System.Windows.Forms.Padding(5);
            this.aciklama.PasswordChar = '\0';
            this.aciklama.Radius = 6;
            this.aciklama.SelectedText = "";
            this.aciklama.Size = new System.Drawing.Size(816, 291);
            this.aciklama.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(17)))), ((int)(((byte)(94)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(125, 23);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(163, 35);
            this.label7.TabIndex = 80;
            this.label7.Text = "Şikayetiniz : ";
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.BackColor = System.Drawing.Color.Transparent;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(17)))), ((int)(((byte)(94)))));
            this.lblHata.Location = new System.Drawing.Point(38, 448);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 25);
            this.lblHata.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uiprogect.Properties.Resources.puzzled_50px;
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // Bildir_but
            // 
            this.Bildir_but.AutoRoundedCorners = true;
            this.Bildir_but.BorderRadius = 29;
            this.Bildir_but.CheckedState.Parent = this.Bildir_but;
            this.Bildir_but.CustomImages.Parent = this.Bildir_but;
            this.Bildir_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(17)))), ((int)(((byte)(94)))));
            this.Bildir_but.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Bildir_but.ForeColor = System.Drawing.Color.White;
            this.Bildir_but.HoverState.Parent = this.Bildir_but;
            this.Bildir_but.Image = global::uiprogect.Properties.Resources.send_20px;
            this.Bildir_but.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Bildir_but.Location = new System.Drawing.Point(711, 448);
            this.Bildir_but.Name = "Bildir_but";
            this.Bildir_but.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.Bildir_but.ShadowDecoration.Parent = this.Bildir_but;
            this.Bildir_but.Size = new System.Drawing.Size(147, 60);
            this.Bildir_but.TabIndex = 81;
            this.Bildir_but.Text = "Bildir";
            this.Bildir_but.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Bildir_but.Click += new System.EventHandler(this.Bildir_but_Click);
            // 
            // sikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.Bildir_but);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aciklama);
            this.Name = "sikayet";
            this.Size = new System.Drawing.Size(900, 572);
            this.Load += new System.EventHandler(this.sikayet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox aciklama;
        private Guna.UI2.WinForms.Guna2Button Bildir_but;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
