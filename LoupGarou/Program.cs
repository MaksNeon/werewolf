using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{

    internal static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Villageois mateo = new Villageois("Mateo");
            //Villageois Ismael = new Villageois("Ismael");
            //Lg dario = new Lg("Dario");

            //village.Add(mateo);
            //village.Add(dario);
            //village.Add(Ismael);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoupGarou());
        }
    }
}
