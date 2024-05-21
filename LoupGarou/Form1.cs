using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoupGarou
{
    /// <summary>
    /// Projet  :   Loups-garoups
    /// Fichier :   Form1.cs
    /// Date    :   21.05.2024
    /// Auteurs :   Maksym Ptytsia, Oscar Calvo
    /// </summary>
    public partial class LoupGarou : Form
    {
        /// <summary>
        /// Pour enlever les flash blanc des winform basic quand meme on fait pas le travail a moitier
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        public List<Villageois> village = new List<Villageois>();
        public MaitreDuJeux maitreDuJeux = new MaitreDuJeux();

        public LoupGarou()
        {
            InitializeComponent();
            // Pour enlever les flash blanc des winform basic quand meme on fait pas le travail a moitier
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
            Thread.Sleep(200);
            lblYourRole.Text = "Vous: Maitre du jeux";
            timerRefreshList.Start();
            panelAdd.Hide();

        }


        public List<Villageois> Village
        {
            get
            {
                return village;
            }
        }


        private void btnAjouterJoueur_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txboxNomAdd.Text))
            {
                maitreDuJeux.username.Add(txboxNomAdd.Text);
                panelAdd.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez saisir le nom du joueur.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            maitreDuJeux.CréeVillage(maitreDuJeux.username);
            if (maitreDuJeux.Village.Count > 14)
            {

            }
            else
            {
                timerRefreshList.Stop();
                maitreDuJeux.StartGame();
            }
            btnStart.Enabled = false;

        }

        private void listViewVillage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerRefreshList_Tick_1(object sender, EventArgs e)
        {
            if (maitreDuJeux.username.Count < 15)
            {
                btnStart.Enabled = false;
            }
            else
            {
                btnStart.Enabled = true;
            }
        }

        private void listViewUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnListVillageois_Click(object sender, EventArgs e)
        {
            FormListVillage formListVillage = new FormListVillage(maitreDuJeux.Village);
            formListVillage.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txboxNomAdd.Text))
            {
                for (int i = 0; i < 15; i++)
                {
                    maitreDuJeux.username.Add(txboxNomAdd.Text);
                }
                panelAdd.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez saisir le nom du joueur.");
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Gestionnaire de l'événement clic pour le label
        /// </summary>
        /// <param name="sender">L'objet source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private async void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            // Active le tour du Loupgauchkbox
            maitreDuJeux.LoupgauchkboxTour = true;
        }
    }
}
