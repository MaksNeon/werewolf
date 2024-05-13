using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{    /// <summary>
     /// Classe pour Cupidon
     /// Calvo Oscar
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
        public List<Villageois> DesignerAmoureux(List<Villageois> VillageVivant, int index1, int index2)
        {
            Villageois Amoureux1 = VillageVivant[index1];
            Villageois Amoureux2 = VillageVivant[index2];
            Amoureux.Add(Amoureux1);
            Amoureux.Add(Amoureux2);
            return Amoureux;
        }


        //public void VoterAmoureux(List<Villageois> villageois)
        //{
        //    if (EstVivant && villageois.Count > 0)
        //    {
        //        Random rdm = new Random();
        //        int indexRdm1 = rdm.Next(villageois.Count);
        //        int indexRdm2 = rdm.Next(villageois.Count);
        //        Villageois villageois1 = villageois[indexRdm1];
        //        Villageois villageois2 = villageois[indexRdm2];
        //        Amoureux amoureux = villageois1;
        //    }
        //}
    }
}
