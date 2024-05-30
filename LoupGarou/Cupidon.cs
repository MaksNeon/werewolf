using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    /**
     * @file Cupidon.cs
     * @brief Définition de la classe Cupidon pour le jeu Loups-garous.
     * @date 21.05.2024
     * @authors Maksym Ptytsia, Oscar Calvo
     */

    /**
     * @class Cupidon
     * @brief Représente le personnage de Cupidon dans le jeu.
     */
    public class Cupidon : Villageois
    {
        public List<Villageois> Amoureux = new List<Villageois>();

        /**
         * @brief Constructeur de la classe Cupidon.
         * @param nom Le nom de Cupidon.
         */
        public Cupidon(string nom) : base(nom)
        {
        }

        /**
         * @brief Fonction qui permet de désigner les amoureux.
         * @param VillageVivant La liste des villageois vivants.
         * @param index1 L'index du premier amoureux dans la liste des villageois vivants.
         * @param index2 L'index du deuxième amoureux dans la liste des villageois vivants.
         * @return La liste des deux villageois désignés comme amoureux.
         */
        public List<Villageois> DesignerAmoureux(BindingList<Villageois> VillageVivant, int index1, int index2)
        {
            Villageois Amoureux1 = VillageVivant[index1];
            Villageois Amoureux2 = VillageVivant[index2];
            Amoureux.Add(Amoureux1);
            Amoureux.Add(Amoureux2);
            return Amoureux;
        }
    }
}
