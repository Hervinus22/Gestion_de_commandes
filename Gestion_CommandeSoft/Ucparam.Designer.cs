namespace Gestion_CommandeSoft
{
    partial class Ucparam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ucparam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.USE = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.txtRechercheuser = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbd = new System.Windows.Forms.TextBox();
            this.txtdisk = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.USE.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 32);
            this.panel1.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Parametres*";
            // 
            // USE
            // 
            this.USE.Controls.Add(this.tabPage1);
            this.USE.Controls.Add(this.tabPage2);
            this.USE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USE.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USE.Location = new System.Drawing.Point(0, 32);
            this.USE.Name = "USE";
            this.USE.SelectedIndex = 0;
            this.USE.Size = new System.Drawing.Size(1056, 511);
            this.USE.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.grbUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UTILISATEURS";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(410, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 352;
            this.label7.Text = "Gestion Utilisateurs*";
            // 
            // grbUser
            // 
            this.grbUser.BackColor = System.Drawing.Color.Transparent;
            this.grbUser.Controls.Add(this.txtusername);
            this.grbUser.Controls.Add(this.txtPass);
            this.grbUser.Controls.Add(this.txtid);
            this.grbUser.Controls.Add(this.guna2Button2);
            this.grbUser.Controls.Add(this.Guna2Button1);
            this.grbUser.Controls.Add(this.label4);
            this.grbUser.Controls.Add(this.dgv_user);
            this.grbUser.Controls.Add(this.txtRechercheuser);
            this.grbUser.Controls.Add(this.label6);
            this.grbUser.Controls.Add(this.label2);
            this.grbUser.Controls.Add(this.label3);
            this.grbUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUser.Location = new System.Drawing.Point(145, 106);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(732, 318);
            this.grbUser.TabIndex = 351;
            this.grbUser.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.BorderColor = System.Drawing.Color.Navy;
            this.txtusername.BorderRadius = 18;
            this.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Location = new System.Drawing.Point(23, 122);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderText = "";
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(245, 36);
            this.txtusername.TabIndex = 351;
            // 
            // txtPass
            // 
            this.txtPass.BorderColor = System.Drawing.Color.Navy;
            this.txtPass.BorderRadius = 18;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Location = new System.Drawing.Point(23, 183);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(245, 36);
            this.txtPass.TabIndex = 350;
            // 
            // txtid
            // 
            this.txtid.BorderColor = System.Drawing.Color.Navy;
            this.txtid.BorderRadius = 18;
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Location = new System.Drawing.Point(107, 49);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "";
            this.txtid.SelectedText = "";
            this.txtid.Size = new System.Drawing.Size(75, 36);
            this.txtid.TabIndex = 349;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
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
            this.guna2Button2.Location = new System.Drawing.Point(219, 250);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(145, 45);
            this.guna2Button2.TabIndex = 348;
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
            this.Guna2Button1.Location = new System.Drawing.Point(32, 250);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.Size = new System.Drawing.Size(145, 45);
            this.Guna2Button1.TabIndex = 347;
            this.Guna2Button1.Text = "Enregistrer";
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(404, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 344;
            this.label4.Text = "Recherche";
            // 
            // dgv_user
            // 
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.GridColor = System.Drawing.Color.White;
            this.dgv_user.Location = new System.Drawing.Point(373, 49);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(353, 263);
            this.dgv_user.TabIndex = 338;
            this.dgv_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellContentClick);
            // 
            // txtRechercheuser
            // 
            this.txtRechercheuser.BackColor = System.Drawing.Color.Transparent;
            this.txtRechercheuser.BaseColor = System.Drawing.Color.White;
            this.txtRechercheuser.BorderColor = System.Drawing.Color.Silver;
            this.txtRechercheuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRechercheuser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRechercheuser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRechercheuser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRechercheuser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRechercheuser.Location = new System.Drawing.Point(519, 15);
            this.txtRechercheuser.Name = "txtRechercheuser";
            this.txtRechercheuser.PasswordChar = '\0';
            this.txtRechercheuser.Radius = 15;
            this.txtRechercheuser.Size = new System.Drawing.Size(207, 31);
            this.txtRechercheuser.TabIndex = 343;
            this.txtRechercheuser.TextChanged += new System.EventHandler(this.txtRechercheuser_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(123, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 346;
            this.label6.Text = "id*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(99, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 336;
            this.label2.Text = "Username*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(99, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 337;
            this.label3.Text = "Password*";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SAUVEGARDES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtbd);
            this.groupBox1.Controls.Add(this.txtdisk);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(172, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 324);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sauvegarde backup";
            // 
            // txtbd
            // 
            this.txtbd.Enabled = false;
            this.txtbd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbd.ForeColor = System.Drawing.Color.Navy;
            this.txtbd.Location = new System.Drawing.Point(170, 99);
            this.txtbd.Name = "txtbd";
            this.txtbd.Size = new System.Drawing.Size(396, 27);
            this.txtbd.TabIndex = 44;
            this.txtbd.Text = "GestionCommande_Soft";
            this.txtbd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdisk
            // 
            this.txtdisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdisk.FormattingEnabled = true;
            this.txtdisk.Items.AddRange(new object[] {
            "C:\\",
            "D:\\",
            "E:\\",
            "F:\\",
            "G:\\"});
            this.txtdisk.Location = new System.Drawing.Point(193, 180);
            this.txtdisk.Name = "txtdisk";
            this.txtdisk.Size = new System.Drawing.Size(357, 27);
            this.txtdisk.TabIndex = 46;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(234, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(282, 40);
            this.button4.TabIndex = 42;
            this.button4.Text = "Sauvegardes";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(246, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Selection le disk de sauvegarde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(218, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Indication de la Base de données";
            // 
            // Ucparam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.USE);
            this.Controls.Add(this.panel1);
            this.Name = "Ucparam";
            this.Size = new System.Drawing.Size(1056, 543);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.USE.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl USE;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_user;
        private Guna.UI.WinForms.GunaTextBox txtRechercheuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal Guna.UI2.WinForms.Guna2Button guna2Button2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbd;
        private System.Windows.Forms.ComboBox txtdisk;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
    }
}
