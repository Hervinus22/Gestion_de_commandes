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
    public partial class Ucparam : UserControl
    {
        public Ucparam()
        {
            InitializeComponent();
            M.chargementTableau(dgv_user, "select * from tLogin", "");
        }
        Classes.ClsGlossiaire M = new Classes.ClsGlossiaire();

        private void txtRechercheuser_TextChanged(object sender, EventArgs e)
        {
            dgv_user.DataSource = M.recherche_Infromation("TLOGIN","username","pass","id",txtRechercheuser.Text);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {if(txtPass.Text == "" || txtusername.Text == "" || txtid.Text == "" ){
                MessageBox.Show("Tout les champs sont requis svp!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                Classes.ClsGlossiaire.Getinstance().EXEC_UNIVERSELLE("Sp_Login", "'" + int.Parse(txtid.Text) + "','" + txtusername.Text + "','" + txtPass.Text + "'", "Enregistrement Reussi");
                M.chargementTableau(dgv_user, "select * from tLogin", "");
                txtPass.Text = "";
                txtusername.Text = "";
                txtid.Text = "";
            }
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classes.ClsGlossiaire.Getinstance().backup(txtbd.Text, txtdisk.Text);
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dgv_user.CurrentRow.Cells[0].Value.ToString();
            txtusername.Text = dgv_user.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = dgv_user.CurrentRow.Cells[2].Value.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            M.Supprimer("Tlogin", "id", int.Parse(label6.Text));
        }
    }
}
