using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{
    /// <summary>
    /// Projet  :   Loups-garoups
    /// Fichier :   MaitreDuJeux.cs
    /// Date    :   21.05.2024
    /// Auteurs :   Maksym Ptytsia, Oscar Calvo
    /// </summary>
    public class MaitreDuJeux
    {
        public BindingList<Villageois> Village = new BindingList<Villageois>();
        private List<Villageois> ListLoup = new List<Villageois>();
        private List<Villageois> NonListLoup = new List<Villageois>();
        private List<Villageois> ListCupidon = new List<Villageois>();
        private List<Villageois> VillageMort = new List<Villageois>();
        private List<Villageois> ListSorcière = new List<Villageois>();
        public List<string> username = new List<string>();
        private bool loupgauchkboxTour = false;
        public Random random = new Random();
        public bool GameEnd = false;

        public MaitreDuJeux()
        {

        }

        /// <summary>
        /// Démarre le jeu en appelant JouerTour.
        /// </summary>
        public void StartGame()
        {
            JouerTour();
        }

        public BindingList<Villageois> GetVillage
        {
            get { return Village; }
        }

        public bool LoupgauchkboxTour
        {
            set => loupgauchkboxTour = value;
        }

        /// <summary>
        /// Supprime les villageois morts de la liste Village.
        /// </summary>
        void DeleteVillageoisMort()
        {
            foreach (Villageois villageoisMort in VillageMort)
            {
                Village.Remove(villageoisMort);
            }
        }

        /// <summary>
        /// Boucle principale du jeu où chaque tour est joué jusqu'à la fin du jeu.
        /// </summary>
        void JouerTour()
        {
            TourInit();
            int nbTour = 0;
            while (!GameEnd)
            {
                loupgauchkboxTour = false;
                if (Village.Count < 4)
                {
                    if (NonListLoup.Count > ListLoup.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\r\n __     ___ _ _                                                         \r\n \\ \\   / (_) | | __ _  __ _  ___    __ _    __ _  __ _  __ _ _ __   ___ \r\n  \\ \\ / /| | | |/ _` |/ _` |/ _ \\  / _` |  / _` |/ _` |/ _` | '_ \\ / _ \\\r\n   \\ V / | | | | (_| | (_| |  __/ | (_| | | (_| | (_| | (_| | | | |  __/\r\n    \\_/  |_|_|_|\\__,_|\\__, |\\___|  \\__,_|  \\__, |\\__,_|\\__, |_| |_|\\___|\r\n                      |___/                |___/       |___/            \r\n");
                    }
                    else if (NonListLoup.Count < ListLoup.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\r\n▄▄▌  ▄▄▄ ..▄▄ ·     ▄▄▌        ▄• ▄▌ ▄▄▄·.▄▄ ·      ▄▄ •  ▄▄▄·  ▄▄ •  ▐ ▄ ▄▄▄ . ▐ ▄ ▄▄▄▄▄\r\n██•  ▀▄.▀·▐█ ▀.     ██•  ▪     █▪██▌▐█ ▄█▐█ ▀.     ▐█ ▀ ▪▐█ ▀█ ▐█ ▀ ▪•█▌▐█▀▄.▀·•█▌▐█•██  \r\n██▪  ▐▀▀▪▄▄▀▀▀█▄    ██▪   ▄█▀▄ █▌▐█▌ ██▀·▄▀▀▀█▄    ▄█ ▀█▄▄█▀▀█ ▄█ ▀█▄▐█▐▐▌▐▀▀▪▄▐█▐▐▌ ▐█.▪\r\n▐█▌▐▌▐█▄▄▌▐█▄▪▐█    ▐█▌▐▌▐█▌.▐▌▐█▄█▌▐█▪·•▐█▄▪▐█    ▐█▄▪▐█▐█ ▪▐▌▐█▄▪▐███▐█▌▐█▄▄▌██▐█▌ ▐█▌·\r\n.▀▀▀  ▀▀▀  ▀▀▀▀     .▀▀▀  ▀█▄▀▪ ▀▀▀ .▀    ▀▀▀▀     ·▀▀▀▀  ▀  ▀ ·▀▀▀▀ ▀▀ █▪ ▀▀▀ ▀▀ █▪ ▀▀▀ \r\n");
                    }
                    GameEnd = true;
                }

                if (GameEnd)
                {

                }
                else
                {
                    while (!loupgauchkboxTour)
                    {
                        Application.DoEvents();
                    }
                    nbTour++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (nbTour)
                    {
                        case 1:
                            Console.WriteLine("\r\n\r\n       __    ______    __    __  .______          __  \r\n      |  |  /  __  \\  |  |  |  | |   _  \\        /_ | \r\n      |  | |  |  |  | |  |  |  | |  |_)  |        | | \r\n.--.  |  | |  |  |  | |  |  |  | |      /         | | \r\n|  `--'  | |  `--'  | |  `--'  | |  |\\  \\----.    | | \r\n \\______/   \\______/   \\______/  | _| `._____|    |_| \r\n                                                      \r\n\r\n");
                            break;
                        case 2:
                            Console.WriteLine("\r\n\r\n       __    ______    __    __  .______          ___   \r\n      |  |  /  __  \\  |  |  |  | |   _  \\        |__ \\  \r\n      |  | |  |  |  | |  |  |  | |  |_)  |          ) | \r\n.--.  |  | |  |  |  | |  |  |  | |      /          / /  \r\n|  `--'  | |  `--'  | |  `--'  | |  |\\  \\----.    / /_  \r\n \\______/   \\______/   \\______/  | _| `._____|   |____| \r\n                                                        \r\n\r\n");
                            break;
                        case 3:
                            Console.WriteLine("\r\n\r\n       __    ______    __    __  .______          ____   \r\n      |  |  /  __  \\  |  |  |  | |   _  \\        |___ \\  \r\n      |  | |  |  |  | |  |  |  | |  |_)  |         __) | \r\n.--.  |  | |  |  |  | |  |  |  | |      /         |__ <  \r\n|  `--'  | |  `--'  | |  `--'  | |  |\\  \\----.    ___) | \r\n \\______/   \\______/   \\______/  | _| `._____|   |____/  \r\n                                                         \r\n\r\n");
                            break;
                        case 4:
                            Console.WriteLine("\r\n\r\n       __    ______    __    __  .______          _  _    \r\n      |  |  /  __  \\  |  |  |  | |   _  \\        | || |   \r\n      |  | |  |  |  | |  |  |  | |  |_)  |       | || |_  \r\n.--.  |  | |  |  |  | |  |  |  | |      /        |__   _| \r\n|  `--'  | |  `--'  | |  `--'  | |  |\\  \\----.      | |   \r\n \\______/   \\______/   \\______/  | _| `._____|      |_|   \r\n                                                          \r\n\r\n");
                            break;
                        case 5:
                            Console.WriteLine("\r\n\r\n       __    ______    __    __  .______          _____  \r\n      |  |  /  __  \\  |  |  |  | |   _  \\        | ____| \r\n      |  | |  |  |  | |  |  |  | |  |_)  |       | |__   \r\n.--.  |  | |  |  |  | |  |  |  | |      /        |___ \\  \r\n|  `--'  | |  `--'  | |  `--'  | |  |\\  \\----.    ___) | \r\n \\______/   \\______/   \\______/  | _| `._____|   |____/  \r\n                                                         \r\n\r\n");
                            break;
                        case 6:
                            Console.WriteLine("\r\n\r\n       __    ______    __    __  .______            __   \r\n      |  |  /  __  \\  |  |  |  | |   _  \\          / /   \r\n      |  | |  |  |  | |  |  |  | |  |_)  |        / /_   \r\n.--.  |  | |  |  |  | |  |  |  | |      /        | '_ \\  \r\n|  `--'  | |  `--'  | |  `--'  | |  |\\  \\----.   | (_) | \r\n \\______/   \\______/   \\______/  | _| `._____|    \\___/  \r\n                                                         \r\n\r\n");
                            break;
                        case 7:
                            Console.WriteLine("\r\n\r\n       __    ______    __    __  .______          ______  \r\n      |  |  /  __  \\  |  |  |  | |   _  \\        |____  | \r\n      |  | |  |  |  | |  |  |  | |  |_)  |           / /  \r\n.--.  |  | |  |  |  | |  |  |  | |      /           / /   \r\n|  `--'  | |  `--'  | |  `--'  | |  |\\  \\----.     / /    \r\n \\______/   \\______/   \\______/  | _| `._____|    /_/     \r\n                                                          \r\n\r\n");
                            break;

                    }
                    TourNormal();
                    DeleteVillageoisMort();
                }
            }
        }

        /// <summary>
        /// Exécute le tour de la sorcière, lui permettant d'utiliser des potions sur une cible.
        /// </summary>
        void TourSorciere(int cible)
        {
            foreach (Sorciere sorciere in ListSorcière)
            {
                WakeUp(sorciere);
                sorciere.UtiliserPotions(random.Next(0, 2), cible, Village);
            }
        }

        /// <summary>
        /// Exécute le tour des loups-garous, où ils sélectionnent une cible à tuer.
        /// </summary>
        int TourLoups()
        {
            int cible = random.Next(0, Village.Count);
            foreach (Lg loup in ListLoup)
            {
                WakeUp(loup);
                loup.Manger(ListLoup, Village, cible);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   ▄▄▄▄▀ ████▄   ▄   █▄▄▄▄     ██▄   ▄███▄     ▄▄▄▄▄       █    ████▄   ▄   █ ▄▄    ▄▄▄▄▄   \r\n▀▀▀ █    █   █    █  █  ▄▀     █  █  █▀   ▀   █     ▀▄     █    █   █    █  █   █  █     ▀▄ \r\n    █    █   █ █   █ █▀▀▌      █   █ ██▄▄   ▄  ▀▀▀▀▄       █    █   █ █   █ █▀▀▀ ▄  ▀▀▀▀▄   \r\n   █     ▀████ █   █ █  █      █  █  █▄   ▄▀ ▀▄▄▄▄▀        ███▄ ▀████ █   █ █     ▀▄▄▄▄▀    \r\n  ▀            █▄ ▄█   █       ███▀  ▀███▀                     ▀      █▄ ▄█  █              \r\n                ▀▀▀   ▀                                                ▀▀▀    ▀             \r\n                                                                                            \r\n\r\n");
            Console.WriteLine("                              __\r\n                            .d$$b\r\n                          .' TO$;\\\r\n                         /  : TP._;\r\n                        / _.;  :Tb|\r\n                       /   /   ;j$j\r\n                   _.-\"       d$$$$\r\n                 .' ..       d$$$$;\r\n                /  /P'      d$$$$P. |\\\r\n               /   \"      .d$$$P' |\\^\"l\r\n             .'           `T$P^\"\"\"\"\"  :\r\n         ._.'      _.'                ;\r\n      `-.-\".-'-' ._.       _.-\"    .-\"\r\n    `.-\" _____  ._              .-\"\r\n   -(.g$$$$$$$b.              .'\r\n     \"\"^^T$$$P^)            .(:\r\n       _/  -\"  /.'         /:/;\r\n    ._.'-'`-'  \")/         /;/;\r\n `-.-\"..--\"\"   \" /         /  ;\r\n.-\" ..--\"\"        -'          :\r\n..--\"\"--.-\"         (\\      .-(\\\r\n  ..--\"\"              `-\\(\\/;`\r\n    _.                      :\r\n                            ;`-\r\n                           :\\\r\n                           ;");
            Console.ForegroundColor = ConsoleColor.White;
            return cible;
        }

        /// <summary>
        /// Exécute les actions de la journée où les villageois votent pour éliminer un joueur.
        /// </summary>
        void TourJour()
        {
            if (!GameEnd)
            {
                WakeUpAll();
                foreach (Villageois villageois in Village)
                {
                    if (!villageois.EstVivant)
                    {
                        villageois.Death();
                        VillageMort.Add(villageois);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"                            ,--.\r\n                           {{    }}\r\n                           K,   }}\r\n                          /  ~Y`\r\n                     ,   /   /\r\n                    {{_'-K.__/\r\n                      `/-.__L._\r\n                      /  ' /`\\_}}\r\n                     /  ' /\r\n             ____   /  ' /\r\n      ,-'~~~~    ~~/  ' /_\r\n    ,'             ``~~~  ',\r\n   (                        Y\r\n  {{                         I\r\n {{      -                    `,\r\n |       ',                   )\r\n |        |   ,..__      __. Y\r\n |    .,_./  Y ' / ^Y   J   )|\r\n \\           |' /   |   |   ||\r\n  \\          L_/    . _ (_,.'(\r\n   \\,   ,      ^^\"\"' / |      )\r\n     \\_  \\          /,L]     /\r\n       '-_~-,       ` `   ./`\r\n          `'{{_            )\r\n              ^^\\..___,.--`\r\n\r\n\r\n{villageois.nom} est mort");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                List<Villageois> VillageoisVoter = new List<Villageois>();
                foreach (Villageois villageois in Village)
                {
                    VillageoisVoter.Add(villageois.Voter(Village));
                }
                foreach (Villageois villageoisSelectionner in VillageoisVoter)
                {
                    if (villageoisSelectionner is null)
                    {
                        //Console.WriteLine("");
                    }
                    else
                    {
                        TuerVillageois(VillageoisVoter[random.Next(0, VillageoisVoter.Count)]);
                    }
                }
            }

        }

        /// <summary>
        /// Tue un villageois et le déplace dans la liste des villageois morts.
        /// </summary>
        void TuerVillageois(Villageois villageois)
        {
            if (villageois == null)
            {
                //Console.WriteLine($"le villageois {villageois.ToString()} est null");
            }
            else if (villageois != null)
            {
                villageois.Death();
                VillageMort.Add(villageois);
            }

        }

        /// <summary>
        /// Exécute un tour normal, composé des actions des loups-garous, des sorcières et des actions de la journée.
        /// </summary>
        void TourNormal()
        {
            Application.DoEvents();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  _                  _ _ _                        _                _            _   \r\n | |                (_) | |                      ( )              | |          | |  \r\n | |     ___  __   ___| | | __ _  __ _  ___   ___|/  ___ _ __   __| | ___  _ __| |_ \r\n | |    / _ \\ \\ \\ / / | | |/ _` |/ _` |/ _ \\ / __|  / _ \\ '_ \\ / _` |/ _ \\| '__| __|\r\n | |___|  __/  \\ V /| | | | (_| | (_| |  __/ \\__ \\ |  __/ | | | (_| | (_) | |  | |_ \r\n |______\\___|   \\_/ |_|_|_|\\__,_|\\__, |\\___| |___/  \\___|_| |_|\\__,_|\\___/|_|   \\__|\r\n                                  __/ |                                             \r\n                                 |___/                                              \r\n\r\n");
            Console.ForegroundColor = ConsoleColor.White;
            EndormirAll();
            Thread.Sleep(1000);
            int cible = TourLoups();
            EndormirAll();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   ▄▄▄▄▀ ████▄   ▄   █▄▄▄▄     ██▄   ▄███▄       █    ██          ▄▄▄▄▄   ████▄ █▄▄▄▄ ▄█▄    ▄█ ▄███▄   █▄▄▄▄ ▄███▄   \r\n▀▀▀ █    █   █    █  █  ▄▀     █  █  █▀   ▀      █    █ █        █     ▀▄ █   █ █  ▄▀ █▀ ▀▄  ██ █▀   ▀  █  ▄▀ █▀   ▀  \r\n    █    █   █ █   █ █▀▀▌      █   █ ██▄▄        █    █▄▄█     ▄  ▀▀▀▀▄   █   █ █▀▀▌  █   ▀  ██ ██▄▄    █▀▀▌  ██▄▄    \r\n   █     ▀████ █   █ █  █      █  █  █▄   ▄▀     ███▄ █  █      ▀▄▄▄▄▀    ▀████ █  █  █▄  ▄▀ ▐█ █▄   ▄▀ █  █  █▄   ▄▀ \r\n  ▀            █▄ ▄█   █       ███▀  ▀███▀           ▀   █                        █   ▀███▀   ▐ ▀███▀     █   ▀███▀   \r\n                ▀▀▀   ▀                                 █                        ▀                       ▀            \r\n                                                       ▀                                                              \r\n\r\n");
            Console.ForegroundColor= ConsoleColor.White;
            TourSorciere(cible);
            Thread.Sleep(1000);
            EndormirAll();
            TourJour();
        }

        /// <summary>
        /// Exécute le tour initial où Cupidon agit.
        /// </summary>
        void TourInit()
        {
            EndormirAll();
            TourCupidon();
        }

        /// <summary>
        /// Exécute le tour de Cupidon, où il désigne les amoureux.
        /// </summary>
        void TourCupidon()
        {
            foreach (Cupidon cupidon in ListCupidon)
            {
                cupidon.EstVeillés = true;
                cupidon.DesignerAmoureux(Village, random.Next(4, 5), random.Next(8, 9));
                cupidon.EstVeillés = false;
                WakeUp(cupidon.Amoureux[0]);
                WakeUp(cupidon.Amoureux[1]);
                Sleep(cupidon.Amoureux[0]);
                Sleep(cupidon.Amoureux[1]);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("     ***********                  ***********\r\n  *****************            *****************\r\n*********************        *********************\r\n***********************      ***********************\r\n************************    ************************\r\n*************************  *************************\r\n **************************************************\r\n  ************************************************\r\n    ********************************************\r\n      ****************************************\r\n         **********************************\r\n           ******************************\r\n              ************************\r\n                ********************\r\n                   **************\r\n                     **********\r\n                       ******\r\n                         **\r\n             Cupidon designe les amoureux");
            Console.ForegroundColor = ConsoleColor.White;

        }

        /// <summary>
        /// Endort un villageois en définissant son état de veille à false.
        /// </summary>
        void Sleep(Villageois villageois)
        {
            villageois.EstVeillés = false;
        }

        /// <summary>
        /// Réveille tous les villageois en définissant leur état de veille à true.
        /// </summary>
        void WakeUpAll()
        {
            foreach (Villageois villageois in Village)
            {
                villageois.EstVeillés = true;
            }
        }

        /// <summary>
        /// Réveille un villageois en définissant son état de veille à true.
        /// </summary>
        void WakeUp(Villageois villageois)
        {
            villageois.EstVeillés = true;
        }

        /// <summary>
        /// Endort tous les villageois en définissant leur état de veille à false.
        /// </summary>
        void EndormirAll()
        {
            foreach (Villageois villageois in Village)
            {
                villageois.EstVeillés = false;
            }
        }

        /// <summary>
        /// Crée le village avec des rôles attribués aux joueurs à partir de la liste des noms d'utilisateur.
        /// </summary>
        /// <param name="Username">Liste des noms d'utilisateur.</param>
        public void CréeVillage(List<string> Username)
        {
            Village.Clear();
            for (int i = 0; i < 14; i++)
            {
                if (i <= 6)
                {
                    Villageois villageoisLG = new Lg(Username[i++]);
                    Village.Add(villageoisLG);
                    ListLoup.Add(villageoisLG);
                }
                else if (i <= 8)
                {
                    Villageois villageoisSorciere = new Sorciere(Username[i]);
                    Village.Add(villageoisSorciere);
                    NonListLoup.Add(villageoisSorciere);
                    ListSorcière.Add(villageoisSorciere);
                }
                else if (i <= 10)
                {
                    Villageois villageoisCupidon = new Cupidon(Username[i]);
                    Village.Add(villageoisCupidon);
                    ListCupidon.Add(villageoisCupidon);
                    NonListLoup.Add(villageoisCupidon);
                }
                else
                {
                    Villageois villageois = new Villageois(Username[i]);
                    Village.Add(villageois);
                    NonListLoup.Add(villageois);
                }
            }
        }
    }
}