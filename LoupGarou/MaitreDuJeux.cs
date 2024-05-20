using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{
    public class MaitreDuJeux
    {
        public BindingList<Villageois> Village = new BindingList<Villageois>();
        private List<Villageois> ListLoup = new List<Villageois>();
        private List<Villageois> NonListLoup = new List<Villageois>();
        private List<Villageois> ListCupidon = new List<Villageois>();
        private List<Villageois> VillageMort = new List<Villageois>();
        private List<Villageois> ListSorcière = new List<Villageois>();
        public List<string> username = new List<string>();

        public Random random = new Random();
        public bool GameEnd = false;
        public MaitreDuJeux()
        {
            
        }

        public void StartGame()
        {
            JouerTour();
        }

        public BindingList<Villageois> GetVillage
        {
            get { return Village; }
        }

        void ListAllVillageois()
        {
            foreach (Villageois villageois in Village)
            {
                Console.WriteLine(villageois.ToString());
            }
        }

        void DeleteVillageoisMort()
        {
            foreach (Villageois villageoisMort in VillageMort)
            {
                Village.Remove(villageoisMort);
            }
        }

        void JouerTour()
        {
            TourInit();
            int nbTour = 0;
            while (!GameEnd)
            {
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
                    Thread.Sleep(1000);
                    nbTour++;
                    Console.WriteLine($"Jour {nbTour}");
                    TourNormal();
                    DeleteVillageoisMort();
                    ListAllVillageois();
                }
            }
        }

        void TourSorciere(int cible)
        {
            foreach (Sorciere sorciere in ListSorcière)
            {
                WakeUp(sorciere);
                sorciere.UtiliserPotions(random.Next(1, 2), cible, Village);
            }
        }

        int TourLoups()
        {
            int cible = random.Next(0, Village.Count);
            foreach (Lg loup in ListLoup)
            {
                WakeUp(loup);
                loup.Manger(ListLoup, Village, cible);
            }
            return cible;
        }

        void TourJour()
        {
            if (!GameEnd) { 
            WakeUpAll();
            foreach (Villageois villageois in Village)
            {
                if (!villageois.EstVivant)
                {
                    villageois.Death();
                    VillageMort.Add(villageois);
                    AnonnceVillage($"{villageois.nom} est mort");
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
                    Console.WriteLine("");
                }
                else
                {
                    TuerVillageois(VillageoisVoter[random.Next(0, VillageoisVoter.Count)]);
                }
            }
            }

        }

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

        void AnonnceVillage(string Annonce)
        {
            Console.WriteLine(Annonce);
        }

        void TourNormal()
        {
            EndormirAll();
            int cible = TourLoups();
            EndormirAll();
            TourSorciere(cible);
            EndormirAll();
            TourJour();
        }

        void TourInit()
        {
            EndormirAll();
            TourCupidon();
        }

        void TourCupidon()
        {
            foreach (Cupidon cupidon in ListCupidon)
            {
                cupidon.EstVeillés = true;
                cupidon.DesignerAmoureux(Village, random.Next(0, 7), random.Next(7, 13));
                cupidon.EstVeillés = false;
                WakeUp(cupidon.Amoureux[0]);
                WakeUp(cupidon.Amoureux[1]);
                Sleep(cupidon.Amoureux[0]);
                Sleep(cupidon.Amoureux[1]);

            }

        }

        void Sleep(Villageois villageois)
        {
            villageois.EstVeillés = false;
        }

        void WakeUpAll()
        {
            foreach (Villageois villageois in Village)
            {
                villageois.EstVeillés = true;
            }
        }

        void WakeUp(Villageois villageois)
        {
            villageois.EstVeillés = true;
        }

        void EndormirAll()
        {
            foreach (Villageois villageois in Village)
            {
                villageois.EstVeillés = false;
            }
        }

        public void CréeVillage(List<string> Username)
        {
            Village.Clear();
            for (int i = 0; i < 14; i++)
            {
                if (i <= 3)
                {
                    Villageois villageoisLG = new Lg(Username[i++]);
                    Village.Add(villageoisLG);
                    ListLoup.Add(villageoisLG);
                }
                else if (i <= 4)
                {
                    Villageois villageoisSorciere = new Sorciere(Username[i]);
                    Village.Add(villageoisSorciere);
                    NonListLoup.Add(villageoisSorciere);
                    ListSorcière.Add(villageoisSorciere);
                }
                else if (i <= 5)
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
            foreach (Villageois villageois in Village)
            {
                Console.WriteLine(villageois.nom);
            }
        }
    }
}
