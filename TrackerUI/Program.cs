﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialise the database connection
            TrackerLibrary.GlobalConfiguration.InitialiseConnections(true, true);
            Application.Run(new CreatePrizeForm());            
           
           
            //Application.Run(new TournamentDashboardForm());
        }
    }
}
