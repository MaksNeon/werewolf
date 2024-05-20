using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Villageois
    {
        private string _nom;
        private bool _Etat;
        private bool _Veille;
        private int _id;

        /// <summary>
        /// Constructeur d'un villageois
        /// </summary>
        /// <param name="nom">Nom du villageois</param>
        public Villageois(string nom)
        {
            this._nom = nom;
            this._Etat = true;
            this._Veille = false;
        }

        /// <summary>
        /// Méthode pour se tuer
        /// </summary>
        public void Death()
        {
            this.EstVivant = false;
        }

        /// <summary>
        /// Propriété pour obtenir le nom du villageois
        /// </summary>
        public string nom
        {
            get { return _nom; }
        }

        /// <summary>
        /// Propriété pour vérifier si le villageois est vivant
        /// </summary>
        public bool EstVivant
        {
            get { return this._Etat; }
            set { this._Etat = value; }
        }

        /// <summary>
        /// Propriété pour vérifier si le villageois est réveillé
        /// </summary>
        public bool EstVeillés
        {
            get { return this._Veille; }
            set { this._Veille = value; }
        }

        /// <summary>
        /// Propriété pour obtenir l'identifiant du villageois
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Le villageois vote pour éliminer un autre villageois au hasard.
        /// Je crée un random qui va être utilisé pour trouver l'index, pour créer le random j'utilise la taille de la liste donnée en entrée.
        /// Je crée un objet villageoisSorti qui va être la sortie de la fonction, je lui donne la valeur de l'objet de la liste villageois avec l'index du random.
        /// et je retourne le villageoisSorti défini avant.
        /// </summary>
        /// <param name="villageois">C'est une liste qui permet d'avoir la liste des joueurs encore en vie, c'est une liste de l'objet Villageois.</param>
        /// <returns>Le villageois choisi au hasard pour être éliminé, ou null si le villageois n'est pas vivant ou si la liste est vide.</returns>
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