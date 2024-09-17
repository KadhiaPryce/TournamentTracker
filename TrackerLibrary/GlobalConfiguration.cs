using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfiguration
    {
        public static List<I_Database_Connection> Connections { get; private set; } = new List<I_Database_Connection>();

        public static void InitialiseConnections(bool database, bool textFiles)
        {
            if (database)
            {   
                // TODO - Create the SQL Connection
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create the Text Connection

                TextConnection text = new TextConnection();
                Connections.Add(text);
            }

        }


    }
}
