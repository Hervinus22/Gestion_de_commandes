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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            switchClic(new DashBoard(), btnHome);
        }
        public void switchClic(Control uc, Button btn)
        {
            //move indicator
            SidePanel.Height = btn.Height;
            SidePanel.Top = btn.Top;
            //change control
            pan1.Controls.Clear();
            uc.Dock = pan1.Dock;
            pan1.Controls.Add(uc);

        }
        int panelwidth = 0;
        bool isCollapsed;
        private void Form1_Load(object sender, EventArgs e)
        {
            panelwidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void pan1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           switchClic(new UClient(), button1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switchClic(new UcRapport(), button8);
        }

        private void pan2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switchClic(new UcArticle(), button2);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            switchClic(new DashBoard(), btnHome);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switchClic(new UCommande(), button4);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if
                  (MessageBox.Show("Voulez vous vraiment quitter l'application ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    this.Show();
                }

            }
            catch (Exception)
            {

                throw;
            }

        
    }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switchClic(new Ucparam(), button10);
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= panelwidth)
                {

                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();

                }
                else
                    panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {

                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switchClic(new ucPaiement(), button7);
        }
    }
    }

