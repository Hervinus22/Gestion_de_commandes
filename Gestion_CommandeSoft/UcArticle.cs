using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_CommandeSoft
{
    public partial class UcArticle : UserControl
    {
        public UcArticle()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        private void UcArticle_Load(object sender, EventArgs e)
        {
            M.chargementTableau(Dgv_article, "Select * from tArticle", "");
            M.chargementTableau(dgvcategorie, "Select * from tcategorie", "");
            M.chargementLabel(label2, "select count(designation) from tarticle");
            M.chargementLabel(label5, "select count(*) from tcategorie");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Boxers.frmArticle a = new Boxers.frmArticle();
            a.Show();
        }

        private void DgvCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            M.chargementTableau(dgvcategorie, "Select * from tcategorie", "");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Boxers.frmCategorie ca = new Boxers.frmCategorie();
            ca.ShowDialog();
        }

        private void Dgv_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvcategorie_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Boxers.frmCategorie c = new Boxers.frmCategorie();
            c.lblId.Text = dgvcategorie.CurrentRow.Cells[0].Value.ToString();
            c.txtDes.Text = dgvcategorie.CurrentRow.Cells[1].Value.ToString();
            c.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void txtRechercheP_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
            Dgv_article.DataSource=M.recherche_Infromation("tArticle", "Designation", "pu", "quantite", txtRechercheArt.Text);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
           
        }

        private void refresh_Click(object sender, EventArgs e)
        {
             
            M.chargementTableau(dgvcategorie, "Select * from tcategorie", "");
            M.chargementTableau(Dgv_article, "Select * from tArticle", "");
            M.chargementLabel(label5, "select count(*) from tcategorie");
            M.chargementLabel(label2, "select count(designation) from tarticle");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            M.chargementLabel(label2, "select count(designation) from tarticle");
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_article_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boxers.frmArticle a = new Boxers.frmArticle();
            a.lblId.Text = Dgv_article.CurrentRow.Cells[0].Value.ToString();
            a.txtdes.Text = Dgv_article.CurrentRow.Cells[1].Value.ToString();
            a.txtPu.Text = Dgv_article.CurrentRow.Cells[2].Value.ToString();                  
            a.cmb_categorie.SelectedText = Dgv_article.CurrentRow.Cells[3].Value.ToString();
              
           // M.chargementLabel(label3, "select stock from tarticle where stock='" + Dgv_article.CurrentRow.Cells[4].Value.ToString() + "'");
            a.ShowDialog();
        }

        private void dgvPaiement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
