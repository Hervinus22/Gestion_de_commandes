namespace Gestion_CommandeSoft
{
    partial class UCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCommande));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRechercheE = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgvcommande = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvcommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 70);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle commande";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(658, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 73;
            this.label9.Text = "Recherche";
            // 
            // txtRechercheE
            // 
            this.txtRechercheE.BackColor = System.Drawing.Color.Transparent;
            this.txtRechercheE.BaseColor = System.Drawing.Color.White;
            this.txtRechercheE.BorderColor = System.Drawing.Color.Silver;
            this.txtRechercheE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRechercheE.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRechercheE.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRechercheE.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRechercheE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRechercheE.Location = new System.Drawing.Point(759, 49);
            this.txtRechercheE.Name = "txtRechercheE";
            this.txtRechercheE.PasswordChar = '\0';
            this.txtRechercheE.Radius = 15;
            this.txtRechercheE.Size = new System.Drawing.Size(249, 27);
            this.txtRechercheE.TabIndex = 72;
            this.txtRechercheE.TextChanged += new System.EventHandler(this.txtRechercheE_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgvcommande);
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 560);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            // 
            // Dgvcommande
            // 
            this.Dgvcommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvcommande.BackgroundColor = System.Drawing.Color.White;
            this.Dgvcommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvcommande.Location = new System.Drawing.Point(3, 12);
            this.Dgvcommande.Name = "Dgvcommande";
            this.Dgvcommande.Size = new System.Drawing.Size(1003, 554);
            this.Dgvcommande.TabIndex = 71;
            this.Dgvcommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvcommande_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(480, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 84;
            this.label1.Text = "Actualiser";
            // 
            // refresh
            // 
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(503, 49);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(38, 27);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 83;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // UCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRechercheE);
            this.Name = "UCommande";
            this.Size = new System.Drawing.Size(1022, 642);
            this.Load += new System.EventHandler(this.UCommande_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvcommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtRechercheE;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView Dgvcommande;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox refresh;
    }
}
