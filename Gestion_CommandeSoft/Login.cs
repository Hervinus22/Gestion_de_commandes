using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_CommandeSoft
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        { 
               
            if(IDENTIFIANT.Text=="" || PASSWORD.Text == "")
            {
                MessageBox.Show("Tous les champs sont requis svp!!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Classes.ClsGlossiaire.Getinstance().testLogin(IDENTIFIANT.Text, PASSWORD.Text);
            }
           
        }
    }
}
