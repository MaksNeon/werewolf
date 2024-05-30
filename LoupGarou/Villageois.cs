using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    /**
     * @file Villageois.cs
     * @brief Définition de la classe Villageois pour le jeu Loups-garous.
     * @date 21.05.2024
     * @authors Maksym Ptytsia, Oscar Calvo
     */

    /**
     * @class Villageois
     * @brief Représente un villageois dans le jeu.
     */
    public class Villageois
    {
        private string _nom;
        private bool _Etat;
        private bool _Veille;
        private int _id;

        /**
         * @brief Constructeur de la classe Villageois.
         * @param nom Le nom du villageois.
         */
        public Villageois(string nom)
        {
            this._nom = nom;
            this._Etat = true;
            this._Veille = false;
        }

        /**
         * @brief Méthode pour se tuer.
         */
        public void Death()
        {
            this.EstVivant = false;
        }

        /**
         * @brief Propriété pour obtenir le nom du villageois.
         * @return Le nom du villageois.
         */
        public string nom
        {
            get { return _nom; }
        }

        /**
         * @brief Propriété pour vérifier si le villageois est vivant.
         * @return true si le villageois est vivant, false sinon.
         */
        public bool EstVivant
        {
            get { return this._Etat; }
            set { this._Etat = value; }
        }

        /**
         * @brief Propriété pour vérifier si le villageois est réveillé.
         * @return true si le villageois est réveillé, false sinon.
         */
        public bool EstVeillés
        {
            get { return this._Veille; }
            set { this._Veille = value; }
        }

        /**
         * @brief Propriété pour obtenir l'identifiant du villageois.
         * @return L'identifiant du villageois.
         */
        public int Id
        {
            get { return _id; }
        }

        /**
         * @brief Le villageois vote pour éliminer un autre villageois au hasard.
         * @param villageois C'est une liste qui permet d'avoir la liste des joueurs encore en vie, c'est une liste de l'objet Villageois.
         * @return Le villageois choisi au hasard pour être éliminé, ou null si le villageois n'est pas vivant ou si la liste est vide.
         */
        public Villageois Voter(BindingList<Villageois> villageois)
        {
            if (EstVivant && villageois.Count > 0)
            {
                Random rdm = new Random();
                int indexRdm = rdm.Next(villageois.Count);
                Villageois villageoissorti = villageois[indexRdm];
                return villageoissorti;
            }
            return null;
        }
    }
}
