using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{
    /// <summary>
    /// Projet  :   Loups-garoups
    /// Fichier :   Program.cs
    /// Date    :   21.05.2024
    /// Auteurs :   Maksym Ptytsia, Oscar Calvo
    /// </summary>
    internal static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoupGarou());
        }
    }
}
