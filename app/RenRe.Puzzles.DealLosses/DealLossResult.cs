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
    /// DealLossResult class stores the results of deals and its associated loss for a particular event
    /// </summary>
    public class DealLossResult
    {
        private int eventId;
        private int dealId;
        private int dealLoss;

        public int EventId
        {
            get
            {
                return eventId;
            }
            set
            {
                eventId = value;
            }
        }

        public int DealId
        {
            get
            {
                return dealId;
            }
            set
            {
                dealId = value;
            }
        }

        public int DealLoss
        {
            get
            {
                return dealLoss;
            }
            set
            {
                dealLoss = value;
            }
        }
    }
}
