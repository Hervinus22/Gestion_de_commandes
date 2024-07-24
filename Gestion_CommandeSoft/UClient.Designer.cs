namespace Gestion_CommandeSoft
{
    partial class UClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRechercheE = new Guna.UI.WinForms.GunaTextBox();
            this.Dgv_client = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_client)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 70);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvel Client";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
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
            this.label9.Location = new System.Drawing.Point(641, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 21);
            this.label9.TabIndex = 69;
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
            this.txtRechercheE.Location = new System.Drawing.Point(742, 47);
            this.txtRechercheE.Name = "txtRechercheE";
            this.txtRechercheE.PasswordChar = '\0';
            this.txtRechercheE.Radius = 15;
            this.txtRechercheE.Size = new System.Drawing.Size(284, 30);
            this.txtRechercheE.TabIndex = 68;
            this.txtRechercheE.TextChanged += new System.EventHandler(this.txtRechercheE_TextChanged);
            // 
            // Dgv_client
            // 
            this.Dgv_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_client.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_client.Location = new System.Drawing.Point(0, 19);
            this.Dgv_client.Name = "Dgv_client";
            this.Dgv_client.Size = new System.Drawing.Size(1012, 541);
            this.Dgv_client.TabIndex = 71;
            this.Dgv_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_client_CellContentClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgv_client);
            this.groupBox2.Location = new System.Drawing.Point(3, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 560);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            // 
            // refresh
            // 
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(446, 59);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(38, 27);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 81;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(423, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 82;
            this.label1.Text = "Actualiser";
            // 
            // UClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRechercheE);
            this.Name = "UClient";
            this.Size = new System.Drawing.Size(1034, 646);
            this.Load += new System.EventHandler(this.UClient_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_client)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        public System.Windows.Forms.DataGridView Dgv_client;
        private System.Windows.Forms.PictureBox refresh;
        internal System.Windows.Forms.Label label1;
    }
}
