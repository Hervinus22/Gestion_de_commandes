namespace Gestion_CommandeSoft.Boxers
{
    partial class FrmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClient));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTel1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTel2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(499, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 32);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(267, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Add or Update an exising Clients*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Noms*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(306, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telephone1*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(306, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telephone2*";
            // 
            // txtNom
            // 
            this.txtNom.BorderRadius = 18;
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.ForeColor = System.Drawing.Color.Black;
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Location = new System.Drawing.Point(8, 104);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PlaceholderText = "";
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(243, 36);
            this.txtNom.TabIndex = 7;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BorderRadius = 18;
            this.txtAdresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.DefaultText = "";
            this.txtAdresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdresse.ForeColor = System.Drawing.Color.Black;
            this.txtAdresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdresse.Location = new System.Drawing.Point(10, 166);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.PlaceholderText = "";
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.Size = new System.Drawing.Size(243, 36);
            this.txtAdresse.TabIndex = 8;
            // 
            // txtTel1
            // 
            this.txtTel1.BorderRadius = 18;
            this.txtTel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel1.DefaultText = "";
            this.txtTel1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTel1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTel1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTel1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTel1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTel1.ForeColor = System.Drawing.Color.Black;
            this.txtTel1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTel1.Location = new System.Drawing.Point(297, 104);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.PasswordChar = '\0';
            this.txtTel1.PlaceholderText = "";
            this.txtTel1.SelectedText = "";
            this.txtTel1.Size = new System.Drawing.Size(213, 36);
            this.txtTel1.TabIndex = 9;
            // 
            // txtTel2
            // 
            this.txtTel2.BorderRadius = 18;
            this.txtTel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel2.DefaultText = "";
            this.txtTel2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTel2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTel2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTel2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTel2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTel2.ForeColor = System.Drawing.Color.Black;
            this.txtTel2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTel2.Location = new System.Drawing.Point(297, 166);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.PasswordChar = '\0';
            this.txtTel2.PlaceholderText = "";
            this.txtTel2.SelectedText = "";
            this.txtTel2.Size = new System.Drawing.Size(213, 36);
            this.txtTel2.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblId.Location = new System.Drawing.Point(256, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 11;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.BorderRadius = 23;
            this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2Button1.FillColor = System.Drawing.Color.White;
            this.Guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.Guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("Guna2Button1.Image")));
            this.Guna2Button1.Location = new System.Drawing.Point(120, 228);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.Size = new System.Drawing.Size(145, 45);
            this.Guna2Button1.TabIndex = 38;
            this.Guna2Button1.Text = "Enregistrer";
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 23;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(285, 228);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(145, 45);
            this.guna2Button2.TabIndex = 39;
            this.guna2Button2.Text = "Supprimer";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 307);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.Guna2Button1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClient";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2Button guna2Button2;
        public Guna.UI2.WinForms.Guna2TextBox txtNom;
        public Guna.UI2.WinForms.Guna2TextBox txtAdresse;
        public Guna.UI2.WinForms.Guna2TextBox txtTel1;
        public Guna.UI2.WinForms.Guna2TextBox txtTel2;
        public System.Windows.Forms.Label lblId;
    }
}