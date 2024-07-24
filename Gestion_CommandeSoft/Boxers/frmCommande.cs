using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_CommandeSoft.Boxers
{
    public partial class frmCommande : Form
    {
        public frmCommande()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Article.SelectedIndex == -1 || cmb_client.SelectedIndex == -1 || datecommande.Text == null || datelivraison.Text == null || cmbStatus.SelectedIndex == -1 || txtQuantite.Text == "" || CmbUnite.SelectedIndex==-1)
                {
                    MessageBox.Show("tout les champs sont requis svp!!");
                }
                else
                {
                    M.EXEC_UNIVERSELLE("sp_commande", "'" + lblId.Text + "','" + cmb_client.Text + "','" + cmb_Article.Text + "','" + datecommande.Value.ToString("yyyy-MM-dd") + "','" + datelivraison.Value.ToString("yyyy-MM-dd") + "','"+ cmbStatus.SelectedItem +"','"+int.Parse(txtQuantite.Text)+"','"+CmbUnite.SelectedItem+"'", "Enregistrement reussi");
              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

        }

        private void frmCommande_Load(object sender, EventArgs e)
        {
            Classes.ClsGlossiaire.Getinstance().chargementComboBox(cmb_client, "Noms", "tClient");
            Classes.ClsGlossiaire.Getinstance().chargementComboBox(cmb_Article, "designation", "tArticle");
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("il y'a un champ requis svp!!");
                }
                else
                {
                    M.Supprimer("Tcommande", "id", int.Parse(lblId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Veuillez Entrer d'abord le code Svp!!", "Message");
                }
                else
                {

                    Rapport.Suivie_Commande rpt = new Rapport.Suivie_Commande();
                    rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_X("V_Suivie_commande", "idcommande", int.Parse(lblId.Text));
                    using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblId.Text == "")
                {
                    MessageBox.Show("Veuillez Entrer d'abord le code Svp!!", "Message");
                }
                else
                {
                    Rapport.Factures rpt = new Rapport.Factures();
                    rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_X("V_FACTURE", "idfact", int.Parse(lblId.Text));
                    using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                    {
                        printTool.ShowPreviewDialog();
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Veuillez Entrer d'abord le code  Svp!!","Message");
                }
                else
                {
                    Rapport.Facture_Proformat rpt = new Rapport.Facture_Proformat();
                    rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_X("V_facture_proformat","idf", int.Parse(lblId.Text));
                    using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                    {
                        printTool.ShowPreviewDialog();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Veuillez Entrer d'abord le code Svp!!", "Message");
                }
                else
                {
                    Rapport.Bon_de_livraison rpt = new Rapport.Bon_de_livraison();
                    rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_X("v_bonlivraison", "idc", int.Parse(lblId.Text));
                    using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                    {
                        printTool.ShowPreviewDialog();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
  
    
