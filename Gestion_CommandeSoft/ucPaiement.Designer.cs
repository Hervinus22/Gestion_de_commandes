namespace Gestion_CommandeSoft
{
    partial class ucPaiement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPaiement));
            this.label7 = new System.Windows.Forms.Label();
            this.txtRechercheP = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dgvPaiement = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaiement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(626, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 345;
            this.label7.Text = "Recherche";
            // 
            // txtRechercheP
            // 
            this.txtRechercheP.BackColor = System.Drawing.Color.Transparent;
            this.txtRechercheP.BaseColor = System.Drawing.Color.White;
            this.txtRechercheP.BorderColor = System.Drawing.Color.Silver;
            this.txtRechercheP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRechercheP.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRechercheP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRechercheP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRechercheP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRechercheP.Location = new System.Drawing.Point(727, 43);
            this.txtRechercheP.Name = "txtRechercheP";
            this.txtRechercheP.PasswordChar = '\0';
            this.txtRechercheP.Radius = 15;
            this.txtRechercheP.Size = new System.Drawing.Size(265, 30);
            this.txtRechercheP.TabIndex = 344;
            this.txtRechercheP.TextChanged += new System.EventHandler(this.txtRechercheP_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox3);
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 70);
            this.groupBox5.TabIndex = 343;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nouveau Paiement";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(183, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            // 
            // dgvPaiement
            // 
            this.dgvPaiement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaiement.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaiement.Location = new System.Drawing.Point(3, 79);
            this.dgvPaiement.Name = "dgvPaiement";
            this.dgvPaiement.Size = new System.Drawing.Size(989, 572);
            this.dgvPaiement.TabIndex = 342;
            this.dgvPaiement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaiement_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(515, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 347;
            this.label1.Text = "Actualiser";
            // 
            // refresh
            // 
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(538, 43);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(38, 27);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 346;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(299, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 348;
            this.label2.Text = "Total Montant Payer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(365, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 23);
            this.label3.TabIndex = 349;
            this.label3.Text = "0";
            // 
            // ucPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRechercheP);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dgvPaiement);
            this.Name = "ucPaiement";
            this.Size = new System.Drawing.Size(1004, 651);
            this.Load += new System.EventHandler(this.ucPaiement_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaiement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtRechercheP;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.DataGridView dgvPaiement;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox refresh;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
    }
}
