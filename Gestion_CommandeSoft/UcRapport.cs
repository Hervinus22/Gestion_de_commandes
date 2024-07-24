using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Gestion_CommandeSoft.Rapport;
namespace Gestion_CommandeSoft
{
    public partial class UcRapport : UserControl
    {
        public UcRapport()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Rapport.liste_client rpt = new Rapport.liste_client();
                rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_S("V_CLIENT","CODE DESC");
                using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                {
                    printTool.ShowPreviewDialog();
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
                Rapport.liste_paiements rpt = new Rapport.liste_paiements();
                rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_S("V_paiement", "idp desc");
                using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                {
                    printTool.ShowPreviewDialog();
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
                if (txtdate11.Text == null)
                {
                    MessageBox.Show("VEUILLEZ Indiquer la date valide svp!!", "MESSAGE");

                }
                else
                {

                    listeCommande_journalier rpt = new listeCommande_journalier();
                    rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_Trier("V_LISTE_COMMANDE", "datecommande",Convert.ToDateTime(txtdate11.Value.ToString("yyyy-MM-dd")), Convert.ToDateTime(txtdate2.Value.ToString("yyyy-MM-dd")));
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

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdate11.Text == null) {
                    MessageBox.Show("VEUILLEZ Indiquer la date valide svp !!","MESSAGE");

                    }
                else
                {
                    Liste_Paiement_journalier1 rpt = new Liste_Paiement_journalier1();
                    rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_Trier("V_Paiement", "Datep", Convert.ToDateTime(txtdate11.Value.ToString("yyyy-MM-dd")), Convert.ToDateTime(txtdate2.Value.ToString("yyyy-MM-dd")));
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

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Rapport.Liste_de_commande rpt = new Rapport.Liste_de_commande();
                rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_S("V_LISTE_COMMANDE", "idc");
                using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                {
                    printTool.ShowPreviewDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

