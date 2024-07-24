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
    public partial class frmCategorie : Form
    {
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        public frmCategorie()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDes.Text.Trim() == "")
                {
                    MessageBox.Show("Tous les chamos sont requis svp !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    Classes.ClsGlossiaire.Getinstance().EXEC_UNIVERSELLE("sp_Categorie", "'" + lblId.Text + "','" + txtDes.Text + "'", "Enregistrement Reussi");
                    // M.chargementTableau(dgv_user, "select * from tLogin", "");
                    lblId.Text = "";
                    txtDes.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    Classes.ClsGlossiaire.Getinstance().Supprimer("Tcategorie", "id", int.Parse(lblId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}