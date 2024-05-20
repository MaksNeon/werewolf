using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{    /// <summary>
     /// Classe pour les loup garous
     /// Calvo Oscar
     /// </summary>
    public class Lg : Villageois
    {
        // pas de getter ou setter car elle peuvent juste voir les autre loup avec une fonction ou tuer avec une fonction
        public Lg(string nom) : base(nom)
        {

        }

        public string GetSimpleType()
        {
            string type = this.GetType().ToString().Replace("LoupGarou.", "");
            return type;
        }

        /// <summary>
        /// Cette fonction serais appeler à chaque tour de nuit et vu qu'on se base sur un jeux en singleplayer alors ça sera le joueur qui va prendre la decision de qui manger ou ne pas manger
        /// </summary>
        public void Manger(List<Villageois> ListLoup, BindingList<Villageois> VillageVivant, int cible)
        {
            // Vérifier si l'index cible est valide
            if (cible >= 0 && cible < VillageVivant.Count)
            {
                bool manger = false;
                int tauxmangable = 0;
                Villageois Vicitme = VillageVivant[cible];
                while (!manger)
                {
                    foreach (Lg loups in ListLoup)
                    {
                        if (Vicitme.GetType().ToString() != loups.GetSimpleType())
                        {
                            tauxmangable++;
                        }
                    }
                    if (tauxmangable > 0)
                    {
                        Vicitme.Death();
                        manger = true;
                    }
                }
            }


        }
    }
}
