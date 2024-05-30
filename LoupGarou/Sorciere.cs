using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    /**
     * @file Sorciere.cs
     * @brief Définition de la classe Sorciere pour le jeu Loups-garous.
     * @date 21.05.2024
     * @authors Maksym Ptytsia, Oscar Calvo
     */

    /**
     * @class Sorciere
     * @brief Représente le personnage de Sorcière dans le jeu.
     */
    public class Sorciere : Villageois
    {
        private bool _potionTuer;
        private bool _potionSoin;

        /**
         * @brief Constructeur de la classe Sorciere.
         * @param nom Le nom de la sorcière.
         */
        public Sorciere(string nom) : base(nom)
        {
            _potionTuer = true;
            _potionSoin = true;
        }

        /**
         * @brief Cette fonction permet à la sorcière d'utiliser ses potions.
         * @param potion Indique le type de potion à utiliser (0 pour tuer, 1 pour soigner).
         * @param cibleIndex L'index de la cible dans la liste des villageois.
         * @param Village La liste des villageois.
         */
        public void UtiliserPotions(int potion, int cibleIndex, BindingList<Villageois> Village)
        {
            if (potion == 0 && _potionTuer)
            {
                _potionTuer = false;
                Villageois Cible = Village[cibleIndex];
                Cible.Death();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"    _______\r\n    `.___,'\r\n     (___)\r\n     <   >\r\n      ) (\r\n     /`-.\\\r\n    /     \\\r\n   / _    _\\\r\n  :,' `-.' `:\r\n  |         |\r\n  :         ;\r\n   \\       /\r\n    `.___.' \r\n{Cible.nom} est tué par la sorcière");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (potion == 1 && _potionSoin)
            {
                _potionSoin = false;
                Villageois Cible = Village[cibleIndex];
                Cible.EstVivant = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"    _______\r\n    `.___,'\r\n     (___)\r\n     <   >\r\n      ) (\r\n     /`-.\\\r\n    /     \\\r\n   / _    _\\\r\n  :,' `-.' `:\r\n  |         |\r\n  :         ;\r\n   \\       /\r\n    `.___.' \r\n{Cible.nom} est sauvé par la sorcière");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("   ▄▄▄▄▄   ████▄ █▄▄▄▄ ▄█▄    ▄█ ▄███▄   █▄▄▄▄ ▄███▄          ▄   ▄███▄       ▄████  ██   ▄█    ▄▄▄▄▀     █▄▄▄▄ ▄█ ▄███▄      ▄   \r\n  █     ▀▄ █   █ █  ▄▀ █▀ ▀▄  ██ █▀   ▀  █  ▄▀ █▀   ▀          █  █▀   ▀      █▀   ▀ █ █  ██ ▀▀▀ █        █  ▄▀ ██ █▀   ▀      █  \r\n▄  ▀▀▀▀▄   █   █ █▀▀▌  █   ▀  ██ ██▄▄    █▀▀▌  ██▄▄        ██   █ ██▄▄        █▀▀    █▄▄█ ██     █        █▀▀▌  ██ ██▄▄    ██   █ \r\n ▀▄▄▄▄▀    ▀████ █  █  █▄  ▄▀ ▐█ █▄   ▄▀ █  █  █▄   ▄▀     █ █  █ █▄   ▄▀     █      █  █ ▐█    █         █  █  ▐█ █▄   ▄▀ █ █  █ \r\n                   █   ▀███▀   ▐ ▀███▀     █   ▀███▀       █  █ █ ▀███▀        █        █  ▐   ▀            █    ▐ ▀███▀   █  █ █ \r\n                  ▀                       ▀                █   ██               ▀      █                   ▀               █   ██ \r\n                                                                                      ▀                                           \r\n\r\n");
            }
        }

        /**
         * @brief Utilise la potion de mort.
         * @return true si la potion de mort est disponible, false sinon.
         */
        public bool PotionTuer
        {
            set { _potionTuer = value; }
            get { return _potionTuer; }
        }

        /**
         * @brief Utilise la potion de soin.
         * @return true si la potion de soin est disponible, false sinon.
         */
        public bool PotionSoin
        {
            set { _potionSoin = value; }
            get { return _potionSoin; }
        }
    }
}
