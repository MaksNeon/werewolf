using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    /**
     * @file Lg.cs
     * @brief Définition de la classe Lg pour le jeu Loups-garous.
     * @date 21.05.2024
     * @authors Maksym Ptytsia, Oscar Calvo
     */

    /**
     * @class Lg
     * @brief Représente un loup-garou dans le jeu.
     */
    public class Lg : Villageois
    {
        /**
         * @brief Constructeur de la classe Lg.
         * @param nom Le nom du loup-garou.
         */
        public Lg(string nom) : base(nom)
        {
        }

        /**
         * @brief Obtient le type simple de l'objet.
         * @return Le type simple de l'objet sous forme de chaîne de caractères.
         */
        public string GetSimpleType()
        {
            string type = this.GetType().ToString().Replace("LoupGarou.", "");
            return type;
        }

        /**
         * @brief Choix automatique de la cible à manger.
         * @param listeLoup La liste des loups-garous.
         * @param villageVivant La liste des villageois vivants.
         * @param cible L'index de la cible dans la liste des villageois vivants.
         */
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
