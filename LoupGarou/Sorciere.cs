using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    /// <summary>
    /// Projet  :   Loups-garoups
    /// Fichier :   Sorciere.cs
    /// Date    :   21.05.2024
    /// Auteurs :   Maksym Ptytsia, Oscar Calvo
    /// </summary>
    public class Sorciere : Villageois
    {
        private bool _potionTuer;
        private bool _potionSoin;

        public Sorciere(string nom) : base(nom)
        {
            _potionTuer = true;
            _potionSoin = true;
        }


        /// <summary>
        /// Cette fonction permet a la sorcière d'utiliser ses potions
        /// </summary>
        /// <param name="potion"></param>
        /// <param name="cibleIndex"></param>
        /// <param name="Village"></param>
        public void UtiliserPotions(int potion, int cibleIndex, BindingList<Villageois> Village)
        {
            if (potion == 0 && _potionTuer)
            {
                _potionTuer = false;
                Villageois Cible = Village[cibleIndex];
                Cible.Death();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"    _______\r\n    `.___,'\r\n     (___)\r\n     <   >\r\n      ) (\r\n     /`-.\\\r\n    /     \\\r\n   / _    _\\\r\n  :,' `-.' `:\r\n  |         |\r\n  :         ;\r\n   \\       /\r\n    `.___.' \r\n{Cible.nom} est tué par la sorciére");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (potion == 1 && _potionSoin)
            {
                _potionSoin = false;
                Villageois Cible = Village[cibleIndex];
                Cible.EstVivant=true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"    _______\r\n    `.___,'\r\n     (___)\r\n     <   >\r\n      ) (\r\n     /`-.\\\r\n    /     \\\r\n   / _    _\\\r\n  :,' `-.' `:\r\n  |         |\r\n  :         ;\r\n   \\       /\r\n    `.___.' \r\n{Cible.nom} est sauvé par la sorciére");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("   ▄▄▄▄▄   ████▄ █▄▄▄▄ ▄█▄    ▄█ ▄███▄   █▄▄▄▄ ▄███▄          ▄   ▄███▄       ▄████  ██   ▄█    ▄▄▄▄▀     █▄▄▄▄ ▄█ ▄███▄      ▄   \r\n  █     ▀▄ █   █ █  ▄▀ █▀ ▀▄  ██ █▀   ▀  █  ▄▀ █▀   ▀          █  █▀   ▀      █▀   ▀ █ █  ██ ▀▀▀ █        █  ▄▀ ██ █▀   ▀      █  \r\n▄  ▀▀▀▀▄   █   █ █▀▀▌  █   ▀  ██ ██▄▄    █▀▀▌  ██▄▄        ██   █ ██▄▄        █▀▀    █▄▄█ ██     █        █▀▀▌  ██ ██▄▄    ██   █ \r\n ▀▄▄▄▄▀    ▀████ █  █  █▄  ▄▀ ▐█ █▄   ▄▀ █  █  █▄   ▄▀     █ █  █ █▄   ▄▀     █      █  █ ▐█    █         █  █  ▐█ █▄   ▄▀ █ █  █ \r\n                   █   ▀███▀   ▐ ▀███▀     █   ▀███▀       █  █ █ ▀███▀        █        █  ▐   ▀            █    ▐ ▀███▀   █  █ █ \r\n                  ▀                       ▀                █   ██               ▀      █                   ▀               █   ██ \r\n                                                                                      ▀                                           \r\n\r\n");
            }
        }

        /// <summary>
        /// Utilise la potion de mort
        /// </summary>
        public bool PotionTuer
        {
            set { _potionTuer = value; }
            get { return _potionTuer; }
        }

        /// <summary>
        /// Utilise la potion de soin
        /// </summary>
        public bool PotionSoin
        {
            set { _potionSoin = value; }
            get { return _potionSoin; }
        }
    }
}
