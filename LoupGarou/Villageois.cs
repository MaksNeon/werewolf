using System;
using System.Collections.Generic;
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
        /// <param name="nom"></param>
        public Villageois(string nom)
        {
            this._nom = nom;
            this._Etat = true;
            this._Veille = false;
        }
        /// <summary>
        /// Methode pour se tuer
        /// </summary>
        public void Death()
        {
            this.EstVivant = false;
        }

        public string nom
        {
            get { return _nom; }
        }
        public bool EstVivant
        {
            get { return this._Etat; }
            set { this._Etat = value; }
        }
        public bool EstVeillés
        {
            get { return this._Veille; }
            set { this._Veille = value; }
        }
        public int Id
        {
            get { return _id; }
        }
        /// <summary>
        /// Je crée un random qui va etre utilisé pour trouver l'index, pour crée le random j'utilise la taille de la liste donner en entré
        /// Je crée un objet villageoissorti qui va etre la sorti de la fonction, je lui donne la valeur de l'bjet de la liste villageois avec l'index du random.
        /// et je return le villageoissorti defini avant
        /// </summary>
        /// <param name="villageois">C'est une liste qui permets d'avoir la liste des joueur encore en vie c'est une liste de l'objet Villageois</param>
        /// <returns>villageoissorti</returns>
        public Villageois Voter(List<Villageois> villageois)
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
