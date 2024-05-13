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
    public partial class LoupGarou : Form
    {
        public List<Villageois> village = new List<Villageois>();
        public MaitreDuJeux maitreDuJeux = new MaitreDuJeux();

        //private List<Villageois> _village;
        public LoupGarou()
        {
            InitializeComponent();
            //this._village = village;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Villageois n in _village)
            //{
            //Console.WriteLine(n.nom);
            //    MessageBox.Show(n.nom);
            //}
        }


        private void label1_Click(object sender, EventArgs e)
        {

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
                listViewUsername.Items.Add(txboxNomAdd.Text);
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

        //ICI negro
        private void btnListVillageois_Click(object sender, EventArgs e)
        {
            FormListVillage formListVillage = new FormListVillage(maitreDuJeux.Village);
            formListVillage.ShowDialog();
        }
    }
}
