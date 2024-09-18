using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SQLConnector : I_Database_Connection
    {
        //TODO - Makes the CreatePrize method actually save to do the database.
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"> The prize information.</param>
        /// <returns>The prize information, inclusinf the unique identifier.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.ID = 1;
            return model;

           // throw new NotImplementedException();
        }
    }
}
