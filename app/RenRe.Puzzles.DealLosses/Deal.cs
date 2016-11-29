//*********************************************************
//
// Garvan Gallagher 
// Technical test for Renaissance Reinsurance 
//
//*********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenRe.Puzzles.DealLosses
{
    /// <summary>
    /// Deal stores the data for a particular deal.
    /// </summary>
    public class Deal
    {
        private int id;
        private List<int> listOfRegions;
        private List<int> listOfPerils;
        private string limit_retention;
         
        public int ID

        {
            get
            {
                return id;
            }
          set
            {
                id = value;
            }
        }

        public List<int> ListOfRegions

        {
            get
            {
                return listOfRegions;
            }
            set
            {
                listOfRegions = value;
            }
        }

        public List<int> ListOfPerils

        {
            get
            {
                return listOfPerils;
            }
            set
            {
                listOfPerils = value;
            }
        }

        public string Limit_retention

        {
            get
            {
                return limit_retention;
            }
            set
            {
                limit_retention = value;
            }
        }

        /// <summary>
        /// Create a list of Deals with the relevant information such as peril, region,limit and retention value for each deal. 
        /// </summary>
        /// <returns>A list of Deals</returns>
        public static List<Deal> CreateDeals()
        {
            return new List<Deal>
                          {
                        new DealLosses.Deal
                        {
                         ID = 1,
                         ListOfPerils = new List<int> { 2 },  //Earthquake
                         ListOfRegions = new List<int> { 1 }, //California
                         Limit_retention = "500x100"
                        },
                        new DealLosses.Deal
                        {
                         ID = 2,
                         ListOfPerils = new List<int> { 1 }, //Hurricane
                         ListOfRegions = new List<int> { 3 }, //Florida
                         Limit_retention = "3000x1000"
                        },
                        new DealLosses.Deal
                        {
                         ID = 3,
                         ListOfPerils = new List<int> { 1, 3 }, //Hurricane, Flood
                         ListOfRegions = new List<int> { 3, 2 }, //Florida, Louisana
                         Limit_retention = "250x250"
                        }
            };
        }
    }
}
