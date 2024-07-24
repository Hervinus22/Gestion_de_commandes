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
    public partial class frmArticle : Form
    {
        public frmArticle()
        {
            InitializeComponent();
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmArticle_Load(object sender, EventArgs e)
        {
       
           Classes.ClsGlossiaire.Getinstance().chargementComboBox(cmb_categorie, "designation", "tcategorie");

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
            this.Close();

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtdes.Text == "" || txtPu.Text == ""||cmb_categorie.SelectedIndex==-1)
                {
                    MessageBox.Show("tout les champs sont requis svp!!");
                }
                else
                {
                    M.EXEC_UNIVERSELLE("sp_Article", "'" + lblId.Text + "','" + txtdes.Text + "','" + Convert.ToDecimal(txtPu.Text.Trim())+ "','" + cmb_categorie.Text + "'", "Enregistrement reussi");

                }
            }
            catch (Exception ex)
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
                    M.Supprimer("Tarticle", "id", int.Parse(lblId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
        }
    }
    }

