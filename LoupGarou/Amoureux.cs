using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    /// <summary>
    /// Projet  :   Loups-garoups
    /// Fichier :   Amoureux.cs
    /// Date    :   21.05.2024
    /// Auteurs :   Maksym Ptytsia, Oscar Calvo
    /// </summary>
    public class Amoureux : Villageois
    {
        private Villageois _other;
        //Je laisse vide car je pense qu'il ne faut pas de getter ou de setter mais uniquement des fonction car les amoureux vont rien afire dautre a par donner le role de l'autre
        public Amoureux(string nom) : base(nom)
        {
            
        }

        public Villageois Other
        {
            set { _other = value; }
            get { return _other; }
        }

        /// <summary>
        /// Fonction qui permet de tuer son partenaire.
        /// </summary>
        public void tuerOther()
        {
            _other.Death();
        }
    }
}
