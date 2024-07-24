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
    public partial class UCommande : UserControl
    {
        public UCommande()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        private void Dgv_commande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCommande_Load(object sender, EventArgs e)
        {
            M.chargementTableau(Dgvcommande, "select * from tcommande", "");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Boxers.frmCommande cl = new Boxers.frmCommande();
            cl.ShowDialog();
        }

        private void txtRechercheE_TextChanged(object sender, EventArgs e)
        {
            Dgvcommande.DataSource = M.recherche_Infromation("tCommande", "Refclient", "Refarticle", "datecommande", txtRechercheE.Text);

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            M.chargementTableau(Dgvcommande, "Select * from tcommande", "");
        }

        private void Dgvcommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Boxers.frmCommande co = new Boxers.frmCommande();
                co.lblId.Text = Dgvcommande.CurrentRow.Cells[0].Value.ToString();
                co.cmb_Article.SelectedItem = Dgvcommande.CurrentRow.Cells[1].Value.ToString();
                co.cmb_client.SelectedItem = Dgvcommande.CurrentRow.Cells[2].Value.ToString();
                co.cmbStatus.SelectedItem = Dgvcommande.CurrentRow.Cells[3].Value.ToString();
                co.txtQuantite.Text= Dgvcommande.CurrentRow.Cells[4].Value.ToString();
                co.ShowDialog();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
           
            
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            M.chargementTableau(Dgvcommande, "Select * from tcommande", "");
        }
    }
}
