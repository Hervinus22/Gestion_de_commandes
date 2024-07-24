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
    public partial class UClient : UserControl
    {
        public UClient()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        private void UClient_Load(object sender, EventArgs e)
        {
            M.chargementTableau(Dgv_client,"Select * from tclient","");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Boxers.FrmClient cl = new Boxers.FrmClient();
            cl.ShowDialog();
        }

        private void txtRechercheE_TextChanged(object sender, EventArgs e)
        {
            Dgv_client.DataSource = M.recherche_Infromation("tclient", "noms", "adresse", "telephone1", txtRechercheE.Text);

        }

        private void Dgv_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_client_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Boxers.FrmClient c = new Boxers.FrmClient();
            c.lblId.Text = Dgv_client.CurrentRow.Cells[0].Value.ToString();
            c.txtNom.Text = Dgv_client.CurrentRow.Cells[1].Value.ToString();
            c.txtAdresse.Text = Dgv_client.CurrentRow.Cells[2].Value.ToString();
            c.txtTel1.Text = Dgv_client.CurrentRow.Cells[3].Value.ToString();
            c.txtTel2.Text = Dgv_client.CurrentRow.Cells[4].Value.ToString();
            c.ShowDialog();
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            M.chargementTableau(Dgv_client, "Select * from tclient", "");
        }
    }
}
