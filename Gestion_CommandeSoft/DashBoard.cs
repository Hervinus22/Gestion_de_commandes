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
    public partial class DashBoard : UserControl
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        void chargeChatExpedition()
        {
            try
            {
                chartcommande.Series["Series1"].XValueMember = "Designations";
                chartcommande.Series["Series1"].YValueMembers = "Nombre";
                chartcommande.DataSource =Classes.ClsGlossiaire.Getinstance().ChargerTable("v_StatCommande");
                chartcommande.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void chargeChatPayement()
        {
            try
            {
                chartpayement.Series["SPaiement"].XValueMember = "MontantP";
                chartpayement.Series["SPaiement"].YValueMembers = "Nombre";
                chartpayement.DataSource = Classes.ClsGlossiaire.Getinstance().ChargerTable("V_StatPayement");
                chartpayement.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void chargeChatCategorie()
        {
            try
            {
                chartCategorie.Series["Scategorie"].XValueMember = "designation";
                chartCategorie.Series["Scategorie"].YValueMembers = "Nombre";
                chartCategorie.DataSource = Classes.ClsGlossiaire.Getinstance().ChargerTable("V_StatCategorie");
                chartCategorie.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void chargeChatlivraison()
        {
            try
            {
                chartLivraison.Series["SLivraison"].XValueMember = "qt";
                chartLivraison.Series["SLivraison"].YValueMembers = "nombre";
               
                chartLivraison.DataSource = Classes.ClsGlossiaire.Getinstance().ChargerTable("StatLivraison");
                chartLivraison.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            chargeChatlivraison();
            chargeChatExpedition();
            chargeChatPayement();
            chargeChatCategorie();
        }
    }
}
