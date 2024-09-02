using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfiguration
    {
        public static List<I_Database_Connection> Connections { get; private set; }

        public static void InitialiseConnections(bool database, bool TextFiles)
        {
            if (database)
            {   
                // TODO - Create the SQL Connection
            }

            if (TextFiles)
            {
                // TODO - Create the Text Connection
            }

        }


    }
}
