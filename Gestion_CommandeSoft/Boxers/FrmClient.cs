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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }
        public void refreshfields()
        {
            txtTel2.Text = "";
            txtTel1.Text = "";
            txtNom.Text = "";
            txtAdresse.Text = "";
          
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmClient_Load(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            
          
            try
            {

                if (txtNom.Text == "" || txtAdresse.Text == "" || txtTel1.Text == "" )
                {

                    MessageBox.Show("Tout les champs sont requis svp", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    M.EXEC_UNIVERSELLE("SpClient", "'" + lblId.Text + "','" + txtNom.Text + "','" + txtAdresse.Text + "','" + txtTel1.Text + "','" + txtTel2.Text + "'","Enregistrement reussi");
                    refreshfields();
                                   
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
                    M.Supprimer("Tclient", "id", int.Parse(lblId.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        }
    
    }

