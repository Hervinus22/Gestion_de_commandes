namespace Gestion_CommandeSoft
{
    partial class UcArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcArticle));
            this.label9 = new System.Windows.Forms.Label();
            this.txtRechercheArt = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvcategorie = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Dgv_article = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategorie)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_article)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(299, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 68;
            this.label9.Text = "Recherche";
            // 
            // txtRechercheArt
            // 
            this.txtRechercheArt.BackColor = System.Drawing.Color.Transparent;
            this.txtRechercheArt.BaseColor = System.Drawing.Color.White;
            this.txtRechercheArt.BorderColor = System.Drawing.Color.Silver;
            this.txtRechercheArt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRechercheArt.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRechercheArt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRechercheArt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRechercheArt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRechercheArt.Location = new System.Drawing.Point(416, 41);
            this.txtRechercheArt.Name = "txtRechercheArt";
            this.txtRechercheArt.PasswordChar = '\0';
            this.txtRechercheArt.Radius = 15;
            this.txtRechercheArt.Size = new System.Drawing.Size(263, 26);
            this.txtRechercheArt.TabIndex = 67;
            this.txtRechercheArt.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 64);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvel Article";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvcategorie);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(685, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 354);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste categorie";
            // 
            // dgvcategorie
            // 
            this.dgvcategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcategorie.BackgroundColor = System.Drawing.Color.White;
            this.dgvcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategorie.Location = new System.Drawing.Point(6, 19);
            this.dgvcategorie.Name = "dgvcategorie";
            this.dgvcategorie.Size = new System.Drawing.Size(291, 327);
            this.dgvcategorie.TabIndex = 72;
            this.dgvcategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcategorie_CellContentClick_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(842, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 64);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajouter categorie";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Dgv_article);
            this.groupBox4.Location = new System.Drawing.Point(3, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(682, 571);
            this.groupBox4.TabIndex = 73;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Dgv_article
            // 
            this.Dgv_article.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_article.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_article.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_article.Location = new System.Drawing.Point(0, 19);
            this.Dgv_article.Name = "Dgv_article";
            this.Dgv_article.Size = new System.Drawing.Size(677, 546);
            this.Dgv_article.TabIndex = 71;
            this.Dgv_article.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_article_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(807, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "Total article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(843, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(844, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(767, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 21);
            this.label6.TabIndex = 78;
            this.label6.Text = "Total Categorie Article";
            // 
            // refresh
            // 
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(691, 23);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(47, 39);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 80;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // UcArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRechercheArt);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcArticle";
            this.Size = new System.Drawing.Size(995, 642);
            this.Load += new System.EventHandler(this.UcArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategorie)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_article)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtRechercheArt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox refresh;
        public System.Windows.Forms.DataGridView dgvcategorie;
        public System.Windows.Forms.DataGridView Dgv_article;
    }
}
