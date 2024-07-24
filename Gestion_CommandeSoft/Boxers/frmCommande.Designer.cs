namespace Gestion_CommandeSoft.Boxers
{
    partial class frmCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommande));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_client = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_Article = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datecommande = new System.Windows.Forms.DateTimePicker();
            this.datelivraison = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantite = new Guna.UI2.WinForms.Guna2TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbUnite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(898, 5);
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
            this.panel1.Size = new System.Drawing.Size(938, 32);
            this.panel1.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(369, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Add or Update an Existing Order(commande)*";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblId.Location = new System.Drawing.Point(217, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 64;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(291, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Date_commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Article*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(291, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Date livrison*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Client*";
            // 
            // cmb_client
            // 
            this.cmb_client.BackColor = System.Drawing.Color.Transparent;
            this.cmb_client.BorderColor = System.Drawing.Color.Black;
            this.cmb_client.BorderRadius = 20;
            this.cmb_client.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_client.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_client.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_client.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_client.ForeColor = System.Drawing.Color.Black;
            this.cmb_client.ItemHeight = 30;
            this.cmb_client.Location = new System.Drawing.Point(0, 88);
            this.cmb_client.Name = "cmb_client";
            this.cmb_client.Size = new System.Drawing.Size(200, 36);
            this.cmb_client.TabIndex = 68;
            // 
            // cmb_Article
            // 
            this.cmb_Article.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Article.BorderColor = System.Drawing.Color.Black;
            this.cmb_Article.BorderRadius = 20;
            this.cmb_Article.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Article.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Article.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Article.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Article.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Article.ForeColor = System.Drawing.Color.Black;
            this.cmb_Article.ItemHeight = 30;
            this.cmb_Article.Location = new System.Drawing.Point(0, 150);
            this.cmb_Article.Name = "cmb_Article";
            this.cmb_Article.Size = new System.Drawing.Size(200, 36);
            this.cmb_Article.TabIndex = 69;
            // 
            // datecommande
            // 
            this.datecommande.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecommande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datecommande.Location = new System.Drawing.Point(295, 111);
            this.datecommande.Name = "datecommande";
            this.datecommande.Size = new System.Drawing.Size(159, 20);
            this.datecommande.TabIndex = 70;
            // 
            // datelivraison
            // 
            this.datelivraison.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelivraison.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datelivraison.Location = new System.Drawing.Point(295, 173);
            this.datelivraison.Name = "datelivraison";
            this.datelivraison.Size = new System.Drawing.Size(159, 20);
            this.datelivraison.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 334;
            this.label5.Text = "Status commande ";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.Black;
            this.cmbStatus.BorderRadius = 20;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Non soldé",
            "Soldé"});
            this.cmbStatus.Location = new System.Drawing.Point(0, 223);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(190, 36);
            this.cmbStatus.TabIndex = 335;
            // 
            // Button6
            // 
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Button6.ForeColor = System.Drawing.Color.Navy;
            this.Button6.Image = ((System.Drawing.Image)(resources.GetObject("Button6.Image")));
            this.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button6.Location = new System.Drawing.Point(60, 167);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(356, 42);
            this.Button6.TabIndex = 332;
            this.Button6.Text = "Imprimer Fiche de suivie commande";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
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
            this.guna2Button2.Location = new System.Drawing.Point(250, 373);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(145, 45);
            this.guna2Button2.TabIndex = 67;
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
            this.Guna2Button1.Location = new System.Drawing.Point(55, 373);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.Size = new System.Drawing.Size(145, 45);
            this.Guna2Button1.TabIndex = 66;
            this.Guna2Button1.Text = "Enregistrer";
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(60, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 42);
            this.button1.TabIndex = 336;
            this.button1.Text = "Imprimer Facture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(291, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 338;
            this.label7.Text = "Quantité";
            // 
            // txtQuantite
            // 
            this.txtQuantite.BorderRadius = 15;
            this.txtQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantite.DefaultText = "";
            this.txtQuantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantite.ForeColor = System.Drawing.Color.Black;
            this.txtQuantite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantite.Location = new System.Drawing.Point(295, 223);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.PasswordChar = '\0';
            this.txtQuantite.PlaceholderText = "";
            this.txtQuantite.SelectedText = "";
            this.txtQuantite.Size = new System.Drawing.Size(157, 36);
            this.txtQuantite.TabIndex = 339;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(60, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(356, 42);
            this.button2.TabIndex = 340;
            this.button2.Text = "Imprimer Facture Proformat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Button6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 311);
            this.groupBox1.TabIndex = 341;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTION";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(60, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(356, 42);
            this.button3.TabIndex = 341;
            this.button3.Text = "Imprimer Bon de Livraison";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(460, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 332);
            this.panel2.TabIndex = 342;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(291, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 344;
            this.label8.Text = "Unite";
            // 
            // CmbUnite
            // 
            this.CmbUnite.BackColor = System.Drawing.Color.Transparent;
            this.CmbUnite.BorderColor = System.Drawing.Color.Black;
            this.CmbUnite.BorderRadius = 20;
            this.CmbUnite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbUnite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnite.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbUnite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbUnite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbUnite.ForeColor = System.Drawing.Color.Black;
            this.CmbUnite.ItemHeight = 30;
            this.CmbUnite.Items.AddRange(new object[] {
            "Pièce"});
            this.CmbUnite.Location = new System.Drawing.Point(295, 290);
            this.CmbUnite.Name = "CmbUnite";
            this.CmbUnite.Size = new System.Drawing.Size(165, 36);
            this.CmbUnite.TabIndex = 345;
            // 
            // frmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 430);
            this.Controls.Add(this.CmbUnite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datelivraison);
            this.Controls.Add(this.datecommande);
            this.Controls.Add(this.cmb_Article);
            this.Controls.Add(this.cmb_client);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.Guna2Button1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCommande_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label12;
        internal Guna.UI2.WinForms.Guna2Button guna2Button2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal Guna.UI2.WinForms.Guna2ComboBox cmb_client;
        internal Guna.UI2.WinForms.Guna2ComboBox cmb_Article;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Label label5;
        internal Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker datecommande;
        public System.Windows.Forms.DateTimePicker datelivraison;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox txtQuantite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        internal Guna.UI2.WinForms.Guna2ComboBox CmbUnite;
        public System.Windows.Forms.Label lblId;
    }
}