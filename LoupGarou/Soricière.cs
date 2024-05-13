using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    /// <summary>
    /// Classe pour la sorcière
    /// Calvo Oscar
    /// </summary>
    public class Sorciere : Villageois
    {
        private bool _potionTuer;
        private bool _potionSoin;

        public Sorciere(string nom) : base(nom)
        {
            _potionTuer = true;
            _potionSoin = true;
        }


        /// <summary>
        /// Cette fonction permet a la sorcière d'utiliser ses potions
        /// </summary>
        /// <param name="potion"></param>
        /// <param name="cibleIndex"></param>
        /// <param name="Village"></param>
        public void UtiliserPotions(int potion, int cibleIndex, BindingList<Villageois> Village)
        {
            if (potion==1&&_potionTuer)
            {
                _potionTuer = false;
                Villageois Cible = Village[cibleIndex];
                Cible.Death();
            }
            else if (potion==2&&_potionSoin)
            {
                _potionSoin = false;
                Villageois Cible = Village[cibleIndex];
                Cible.EstVivant=true;
            }
            else
            {

            }
        }


        public bool PotionTuer
        {
            set { _potionTuer = value; }
            get { return _potionTuer; }
        }

        public bool PotionSoin
        {
            set { _potionSoin = value; }
            get { return _potionSoin; }
        }
    }
}
