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
    /**
     * @file Form1.cs
     * @brief Implémentation de l'interface utilisateur pour le jeu Loups-garous
     * @date 21.05.2024
     * @authors Maksym Ptytsia, Oscar Calvo
     */

    /**
     * @class LoupGarou
     * @brief Classe principale de la fenêtre du jeu Loups-garous.
     */
    public partial class LoupGarou : Form
    {
        /**
         * @brief Pour enlever les flash blanc des WinForms basiques.
         * @return Les paramètres de création de la fenêtre.
         */
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

        /**
         * @brief Constructeur de la classe LoupGarou.
         */
        public LoupGarou()
        {
            InitializeComponent();
            // Pour enlever les flash blanc des WinForms basiques
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
            Thread.Sleep(200);
            lblYourRole.Text = "Vous: Maitre du jeux";
            timerRefreshList.Start();
            panelAdd.Hide();
        }

        /**
         * @brief Obtient la liste des villageois.
         * @return La liste des villageois.
         */
        public List<Villageois> Village
        {
            get
            {
                return village;
            }
        }

        /**
         * @brief Gestionnaire de l'événement clic pour ajouter un joueur.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
        private void btnAjouterJoueur_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
        }

        /**
         * @brief Gestionnaire de l'événement clic pour ajouter un nom de joueur.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
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

        /**
         * @brief Gestionnaire de l'événement clic pour démarrer le jeu.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
        private void btnStart_Click(object sender, EventArgs e)
        {
            maitreDuJeux.CréeVillage(maitreDuJeux.username);
            if (maitreDuJeux.Village.Count > 14)
            {
                // Actions à effectuer si plus de 14 joueurs
            }
            else
            {
                timerRefreshList.Stop();
                maitreDuJeux.StartGame();
            }
            btnStart.Enabled = false;
        }

        /**
         * @brief Gestionnaire de l'événement pour la sélection des éléments dans listViewVillage.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
        private void listViewVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code à exécuter lors de la sélection d'un élément
        }

        /**
         * @brief Gestionnaire de l'événement Tick pour le rafraîchissement de la liste.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
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

        /**
         * @brief Gestionnaire de l'événement pour la sélection des éléments dans listViewUsername.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
        private void listViewUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code à exécuter lors de la sélection d'un élément
        }

        /**
         * @brief Gestionnaire de l'événement clic pour afficher la liste des villageois.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
        private void btnListVillageois_Click(object sender, EventArgs e)
        {
            FormListVillage formListVillage = new FormListVillage(maitreDuJeux.Village);
            formListVillage.ShowDialog();
        }

        /**
         * @brief Gestionnaire de l'événement clic pour ajouter plusieurs joueurs.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
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

        /**
         * @brief Gestionnaire de l'événement clic pour minimiser la fenêtre.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /**
         * @brief Gestionnaire de l'événement clic pour fermer l'application.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * @brief Gestionnaire de l'événement clic pour une case à cocher personnalisée.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         */
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            // Code à exécuter lors du clic sur la case à cocher
        }

        /**
         * @brief Gestionnaire de l'événement clic pour le label HTML personnalisé.
         * @param sender L'objet source de l'événement.
         * @param e Les données de l'événement.
         * @note Active le tour du Loupgauchkbox.
         */
        private async void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            maitreDuJeux.LoupgauchkboxTour = true;
        }
    }
}
