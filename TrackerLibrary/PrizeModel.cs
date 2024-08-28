using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The place number of the winning/losing team.
        /// </summary>
        
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The place name associated with each place number.
        /// </summary>
        /// <example> Place Number 1: Champion / Winner / Runner Up</example>

        public string PlaceName { get; set; }

        /// <summary>
        /// The prize money award to the winning person or team. 
        /// </summary>

        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The prize percentage award to the winning person or team. 
        /// If price amount is 0.
        /// </summary>

        public double PrizePercentage { get; set; }

    }
}
