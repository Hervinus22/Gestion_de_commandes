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
    public partial class frmPaiement : Form
    {
        public frmPaiement()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
         
        try
            {
                if (txtmontant.Text == "" || txtDate.Text == "" || cmbcommande.SelectedIndex==-1)
                {
                    MessageBox.Show("tout les champs sont requis svp!!");
                }
                else
                {
                    M.EXEC_UNIVERSELLE("sp_paiement", "'" +lblId.Text + "','"+ Convert.ToDecimal(txtmontant.Text.Trim()) + "','"+ txtDate.Value.ToString("yyyy-MM-dd") + "','"+ cmboArticle.SelectedItem +"','"+ cmbClient.SelectedItem +"','"+cmbcommande.SelectedItem+"'", "Enregistrement reussi");
    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }
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
                    M.Supprimer("Tpaiement", "id", int.Parse(lblId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void frmPaiement_Load(object sender, EventArgs e)
        {
            M.chargementCombo(cmbClient, "select noms from tclient");
            M.chargementCombo(cmboArticle, "select Designation from tArticle");
            M.chargementCombo(cmbcommande, "select quantite from tcommande");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "")
                {
                    MessageBox.Show("Veuiller indiquer le code svp!!","Message");
                }
                else
                {
                    Rapport.Recupaiement rpt = new Rapport.Recupaiement();
                    rpt.DataSource = Classes.ClsGlossiaire.Getinstance().get_Report_X("v_paiement", "idp", int.Parse(lblId.Text));
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

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ///guna2DateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
