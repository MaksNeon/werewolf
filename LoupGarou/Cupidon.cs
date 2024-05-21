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
    /// Fichier :   Cupidon.cs
    /// Date    :   21.05.2024
    /// Auteurs :   Maksym Ptytsia, Oscar Calvo
    /// </summary>
    public class Cupidon : Villageois
    {
        public List<Villageois> Amoureux = new List<Villageois>();
        //Cupidon na pas de getter ou setter car il va definir avec une fonction les amoureux
        public Cupidon(string nom) : base(nom)
        {

        }


        /// <summary>
        /// Fonction Qui permet de designer les amoureux
        /// </summary>
        /// <param name="VillageVivant"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <returns></returns>
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
