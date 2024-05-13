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
            lblYourRole.Text ="Vous: Maitre du jeux";
            timerRefreshList.Start();
            panelAdd.Hide();

        }

        public void BindDataToListView()
        {
            // Effacez les éléments existants du ListView
            listViewVillage.Items.Clear();

            // Parcourez la liste Village de MaitreDuJeux et ajoutez chaque élément à ListView
            foreach (Villageois villageois in maitreDuJeux.GetVillage)
            {
                // Créez un nouvel élément de ListView avec le nom du villageois
                ListViewItem item = new ListViewItem(villageois.nom);

                // Ajoutez l'élément à ListView
                listViewVillage.Items.Add(item);
            }

            // Optionnel : Ajustez la mise en forme de ListView si nécessaire
            // Par exemple, vous pouvez ajuster les colonnes, les en-têtes, etc.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Villageois n in _village)
            //{
                //Console.WriteLine(n.nom);
            //    MessageBox.Show(n.nom);
            //}
        }

        private void timerRefreshList_Tick(object sender, EventArgs e)
        {
            BindDataToListView();
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
            maitreDuJeux.username.Add(txboxNomAdd.Text);
            panelAdd.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            maitreDuJeux.CréeVillage(maitreDuJeux.username);
            if (maitreDuJeux.Village.Count>14)
            {

            }
            else
            {
                timerRefreshList.Stop();
                maitreDuJeux.StartGame();
            }
            
        }

        private void listViewVillage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerRefreshList_Tick_1(object sender, EventArgs e)
        {
            if (maitreDuJeux.username.Count<15)
            {
                btnStart.Enabled = false;
            }
            else
            {
                btnStart.Enabled = true;
            }
            listViewVillage.Items.Clear();

            foreach (Villageois nom in maitreDuJeux.Village)
            {
                listViewVillage.Items.Add(nom.nom);
            }
        }
    }
}
