namespace Gestion_CommandeSoft.Boxers
{
    partial class frmPaiement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaiement));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.cmbClient = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmboArticle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcommande = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(520, 5);
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
            this.panel1.Size = new System.Drawing.Size(547, 32);
            this.panel1.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(353, 38);
            this.label12.TabIndex = 2;
            this.label12.Text = "Add or Update Existing Payment(Paiement) *\r\n\r\n";
            // 
            // txtDate
            // 
            this.txtDate.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(12, 171);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(207, 21);
            this.txtDate.TabIndex = 82;
            this.txtDate.Value = new System.DateTime(2023, 9, 22, 12, 36, 14, 0);
            this.txtDate.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            // 
            // cmbClient
            // 
            this.cmbClient.BackColor = System.Drawing.Color.Transparent;
            this.cmbClient.BorderColor = System.Drawing.Color.Black;
            this.cmbClient.BorderRadius = 20;
            this.cmbClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClient.ForeColor = System.Drawing.Color.Black;
            this.cmbClient.ItemHeight = 30;
            this.cmbClient.Location = new System.Drawing.Point(289, 156);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(258, 36);
            this.cmbClient.TabIndex = 81;
            // 
            // cmboArticle
            // 
            this.cmboArticle.BackColor = System.Drawing.Color.Transparent;
            this.cmboArticle.BorderColor = System.Drawing.Color.Black;
            this.cmboArticle.BorderRadius = 20;
            this.cmboArticle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboArticle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboArticle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmboArticle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmboArticle.ForeColor = System.Drawing.Color.Black;
            this.cmboArticle.ItemHeight = 30;
            this.cmboArticle.Location = new System.Drawing.Point(290, 93);
            this.cmboArticle.Name = "cmboArticle";
            this.cmboArticle.Size = new System.Drawing.Size(258, 36);
            this.cmboArticle.TabIndex = 80;
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
            this.guna2Button2.Location = new System.Drawing.Point(290, 273);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(130, 45);
            this.guna2Button2.TabIndex = 79;
            this.guna2Button2.Text = "Supprimer";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.Guna2Button1.Location = new System.Drawing.Point(115, 273);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.Size = new System.Drawing.Size(145, 45);
            this.Guna2Button1.TabIndex = 78;
            this.Guna2Button1.Text = "Enregistrer";
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblId.Location = new System.Drawing.Point(236, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(15, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Date paiement*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(298, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Client*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Montant*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(298, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 84;
            this.label5.Text = "Articles*";
            // 
            // txtmontant
            // 
            this.txtmontant.BorderRadius = 18;
            this.txtmontant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmontant.DefaultText = "";
            this.txtmontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmontant.ForeColor = System.Drawing.Color.Black;
            this.txtmontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontant.Location = new System.Drawing.Point(12, 93);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.PasswordChar = '\0';
            this.txtmontant.PlaceholderText = "00,00$";
            this.txtmontant.SelectedText = "";
            this.txtmontant.Size = new System.Drawing.Size(207, 36);
            this.txtmontant.TabIndex = 85;
            // 
            // Button6
            // 
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Button6.ForeColor = System.Drawing.Color.Navy;
            this.Button6.Image = ((System.Drawing.Image)(resources.GetObject("Button6.Image")));
            this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button6.Location = new System.Drawing.Point(100, 324);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(356, 42);
            this.Button6.TabIndex = 333;
            this.Button6.Text = "ImprimeBon d\'entree caisse";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(286, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 334;
            this.label3.Text = "RefCommande*";
            // 
            // cmbcommande
            // 
            this.cmbcommande.BackColor = System.Drawing.Color.Transparent;
            this.cmbcommande.BorderColor = System.Drawing.Color.Black;
            this.cmbcommande.BorderRadius = 20;
            this.cmbcommande.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcommande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcommande.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcommande.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcommande.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcommande.ForeColor = System.Drawing.Color.Black;
            this.cmbcommande.ItemHeight = 30;
            this.cmbcommande.Location = new System.Drawing.Point(290, 218);
            this.cmbcommande.Name = "cmbcommande";
            this.cmbcommande.Size = new System.Drawing.Size(251, 36);
            this.cmbcommande.TabIndex = 335;
            // 
            // frmPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 378);
            this.Controls.Add(this.cmbcommande);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.cmboArticle);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.Guna2Button1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaiement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaiement";
            this.Load += new System.EventHandler(this.frmPaiement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label12;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbClient;
        internal Guna.UI2.WinForms.Guna2ComboBox cmboArticle;
        internal Guna.UI2.WinForms.Guna2Button guna2Button2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox txtmontant;
        private System.Windows.Forms.Button Button6;
        public System.Windows.Forms.DateTimePicker txtDate;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbcommande;
    }
}