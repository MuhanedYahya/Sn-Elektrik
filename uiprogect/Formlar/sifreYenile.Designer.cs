namespace uiprogect.Formlar
{
    partial class sifreYenile
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblgiren = new System.Windows.Forms.Label();
            this.resetle = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHata = new System.Windows.Forms.Label();
            this.numara = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseB = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tc
            // 
            this.tc.AsciiOnly = true;
            this.tc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tc.ForeColor = System.Drawing.Color.Black;
            this.tc.Location = new System.Drawing.Point(231, 171);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(190, 19);
            this.tc.TabIndex = 0;
            this.tc.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(183, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 28);
            this.label3.TabIndex = 51;
            this.label3.Text = "TC-Kimlik numaranız :";
            // 
            // lblgiren
            // 
            this.lblgiren.AutoSize = true;
            this.lblgiren.BackColor = System.Drawing.Color.Transparent;
            this.lblgiren.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblgiren.ForeColor = System.Drawing.Color.Black;
            this.lblgiren.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblgiren.Location = new System.Drawing.Point(139, 215);
            this.lblgiren.Name = "lblgiren";
            this.lblgiren.Size = new System.Drawing.Size(0, 28);
            this.lblgiren.TabIndex = 57;
            // 
            // resetle
            // 
            this.resetle.AutoRoundedCorners = true;
            this.resetle.BorderRadius = 21;
            this.resetle.CheckedState.Parent = this.resetle;
            this.resetle.CustomImages.Parent = this.resetle;
            this.resetle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(17)))), ((int)(((byte)(94)))));
            this.resetle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.resetle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(175)))), ((int)(((byte)(201)))));
            this.resetle.HoverState.Parent = this.resetle;
            this.resetle.Location = new System.Drawing.Point(377, 451);
            this.resetle.Name = "resetle";
            this.resetle.ShadowDecoration.Parent = this.resetle;
            this.resetle.Size = new System.Drawing.Size(180, 45);
            this.resetle.TabIndex = 61;
            this.resetle.Text = "Resetle";
            this.resetle.Click += new System.EventHandler(this.resetle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(17)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "- Bu şifrenizi diğer tüm aboneliklerinizde kullanmak zorundasınız.";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(17)))), ((int)(((byte)(94)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 543);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(17)))), ((int)(((byte)(94)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(600, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 543);
            this.panel2.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(226, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 66;
            this.label1.Text = "yeni şifreniz :";
            // 
            // sifre
            // 
            this.sifre.BorderColor = System.Drawing.Color.Black;
            this.sifre.BorderRadius = 6;
            this.sifre.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.sifre.DefaultText = "";
            this.sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifre.DisabledState.Parent = this.sifre;
            this.sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifre.FocusedState.Parent = this.sifre;
            this.sifre.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F);
            this.sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifre.HoverState.Parent = this.sifre;
            this.sifre.Location = new System.Drawing.Point(188, 342);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '\0';
            this.sifre.PlaceholderText = "";
            this.sifre.SelectedText = "";
            this.sifre.ShadowDecoration.Parent = this.sifre;
            this.sifre.Size = new System.Drawing.Size(225, 41);
            this.sifre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.sifre.TabIndex = 30;
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.UseWaitCursor = true;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblHata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(17)))), ((int)(((byte)(94)))));
            this.lblHata.Location = new System.Drawing.Point(83, 514);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 20);
            this.lblHata.TabIndex = 94;
            // 
            // numara
            // 
            this.numara.AsciiOnly = true;
            this.numara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numara.Location = new System.Drawing.Point(265, 256);
            this.numara.Mask = "0000";
            this.numara.Name = "numara";
            this.numara.Size = new System.Drawing.Size(190, 19);
            this.numara.TabIndex = 10;
            this.numara.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uiprogect.Properties.Resources.key_2_60px;
            this.pictureBox1.Location = new System.Drawing.Point(16, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 67);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // CloseB
            // 
            this.CloseB.BackColor = System.Drawing.Color.Transparent;
            this.CloseB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseB.CheckedState.Parent = this.CloseB;
            this.CloseB.CustomImages.Parent = this.CloseB;
            this.CloseB.FillColor = System.Drawing.Color.Transparent;
            this.CloseB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseB.ForeColor = System.Drawing.Color.White;
            this.CloseB.HoverState.Parent = this.CloseB;
            this.CloseB.Image = global::uiprogect.Properties.Resources.close_25;
            this.CloseB.ImageSize = new System.Drawing.Size(30, 30);
            this.CloseB.Location = new System.Drawing.Point(550, 12);
            this.CloseB.Name = "CloseB";
            this.CloseB.ShadowDecoration.Parent = this.CloseB;
            this.CloseB.Size = new System.Drawing.Size(44, 32);
            this.CloseB.TabIndex = 60;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // sifreYenile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numara);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetle);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.lblgiren);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sifreYenile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sifreYenile";
            this.Load += new System.EventHandler(this.sifreYenile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblgiren;
        private Guna.UI2.WinForms.Guna2Button CloseB;
        private Guna.UI2.WinForms.Guna2Button resetle;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox sifre;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.MaskedTextBox numara;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}