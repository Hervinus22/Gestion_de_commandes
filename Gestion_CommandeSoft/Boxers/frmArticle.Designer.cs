namespace Gestion_CommandeSoft.Boxers
{
    partial class frmArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticle));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_categorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(555, 5);
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
            this.panel1.Size = new System.Drawing.Size(582, 32);
            this.panel1.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Add or update  Articles *";
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
            this.guna2Button2.Location = new System.Drawing.Point(328, 210);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(145, 45);
            this.guna2Button2.TabIndex = 53;
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
            this.Guna2Button1.Location = new System.Drawing.Point(117, 210);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.Size = new System.Drawing.Size(145, 45);
            this.Guna2Button1.TabIndex = 52;
            this.Guna2Button1.Text = "Enregistrer";
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // cmb_categorie
            // 
            this.cmb_categorie.BackColor = System.Drawing.Color.Transparent;
            this.cmb_categorie.BorderColor = System.Drawing.Color.Black;
            this.cmb_categorie.BorderRadius = 20;
            this.cmb_categorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categorie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_categorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_categorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_categorie.ForeColor = System.Drawing.Color.Black;
            this.cmb_categorie.ItemHeight = 30;
            this.cmb_categorie.Location = new System.Drawing.Point(361, 92);
            this.cmb_categorie.Name = "cmb_categorie";
            this.cmb_categorie.Size = new System.Drawing.Size(218, 36);
            this.cmb_categorie.TabIndex = 51;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblId.Location = new System.Drawing.Point(289, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 50;
            // 
            // txtPu
            // 
            this.txtPu.BorderRadius = 18;
            this.txtPu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPu.DefaultText = "";
            this.txtPu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPu.ForeColor = System.Drawing.Color.Black;
            this.txtPu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPu.Location = new System.Drawing.Point(16, 154);
            this.txtPu.Name = "txtPu";
            this.txtPu.PasswordChar = '\0';
            this.txtPu.PlaceholderText = "00,00$";
            this.txtPu.SelectedText = "";
            this.txtPu.Size = new System.Drawing.Size(225, 36);
            this.txtPu.TabIndex = 47;
            // 
            // txtdes
            // 
            this.txtdes.BorderRadius = 18;
            this.txtdes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdes.DefaultText = "";
            this.txtdes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdes.ForeColor = System.Drawing.Color.Black;
            this.txtdes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdes.Location = new System.Drawing.Point(16, 92);
            this.txtdes.Name = "txtdes";
            this.txtdes.PasswordChar = '\0';
            this.txtdes.PlaceholderText = "";
            this.txtdes.SelectedText = "";
            this.txtdes.Size = new System.Drawing.Size(243, 36);
            this.txtdes.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Prix_unitaire*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(367, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Categorie*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Designation*";
            // 
            // frmArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.Guna2Button1);
            this.Controls.Add(this.cmb_categorie);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPu);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticle";
            this.Load += new System.EventHandler(this.frmArticle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label12;
        internal Guna.UI2.WinForms.Guna2Button guna2Button2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox cmb_categorie;
        public Guna.UI2.WinForms.Guna2TextBox txtPu;
        public Guna.UI2.WinForms.Guna2TextBox txtdes;
        public System.Windows.Forms.Label lblId;
    }
}