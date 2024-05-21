using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    /// <summary>
    /// Projet  :   Loups-garoups
    /// Fichier :   Lg.cs
    /// Date    :   21.05.2024
    /// Auteurs :   Maksym Ptytsia, Oscar Calvo
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
        /// Choix automatique de la cible
        /// </summary>
        public void Manger(List<Villageois> listeLoup, BindingList<Villageois> villageVivant, int cible)
        {
            // Vérifier si l'index cible est valide
            if (cible >= 0 && cible < villageVivant.Count)
            {
                bool manger = false;
                int tauxmangable = 0;
                Villageois victime = villageVivant[cible];
                while (!manger)
                {
                    foreach (Lg loups in listeLoup)
                    {
                        if (victime.GetType().ToString() != loups.GetSimpleType())
                        {
                            tauxmangable++;
                        }
                    }
                    if (tauxmangable > 0)
                    {
                        victime.Death();
                        manger = true;
                    }
                }
            }
        }
    }
}
