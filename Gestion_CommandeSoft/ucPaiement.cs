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
    public partial class ucPaiement : UserControl
    {
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
     
        public ucPaiement()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Boxers.frmPaiement p = new Boxers.frmPaiement();
            p.ShowDialog();
        }

        private void txtRechercheP_TextChanged(object sender, EventArgs e)
        {
            dgvPaiement.DataSource = M.recherche_Infromation("Tpaiement", "DatePaiement", "RefClient", "Refarticle", txtRechercheP.Text);

        }

        private void dgvPaiement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boxers.frmPaiement P = new Boxers.frmPaiement();
            P.lblId.Text = dgvPaiement.CurrentRow.Cells[0].Value.ToString();
            P.txtmontant.Text = dgvPaiement.CurrentRow.Cells[2].Value.ToString();
            P.txtDate.Text = dgvPaiement.CurrentRow.Cells[3].Value.ToString();
            P.cmboArticle.SelectedItem = dgvPaiement.CurrentRow.Cells[4].Value.ToString();
            P.cmbClient.SelectedItem = dgvPaiement.CurrentRow.Cells[5].Value.ToString();
            P.cmbcommande.SelectedItem = dgvPaiement.CurrentRow.Cells[6].Value.ToString();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            
            M.chargementTableau(dgvPaiement, "Select * from tpaiement", "");
            M.chargementLabel(label3, "select sum(Montant) from tpaiement");
        }

        private void ucPaiement_Load(object sender, EventArgs e)
        {
            M.chargementTableau(dgvPaiement, "Select * from tpaiement", "");
            M.chargementLabel(label3, "select sum(Montant) from tpaiement");
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            M.chargementTableau(dgvPaiement, "Select * from tpaiement", "");
        }
    }
}
