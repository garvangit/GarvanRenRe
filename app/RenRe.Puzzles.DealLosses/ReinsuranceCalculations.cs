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
    public class ReinsuranceCalculations
    {
        /// <summary>
        /// Calculates the reinsurance company's loss for each event
        /// </summary>
        /// <param name="Event"></param>
        /// <param name="DealList"></param>
        /// <returns></returns>
        public static List<DealLossResult> CalculateLossForEvent(int[] Event, List<Deal> DealList)
        {
            List<DealLossResult> DealLossResultList = new List<DealLossResult>();
            try
            {
                bool matchPeril = false;
                bool matchRegion = false;
                int dealLoss = 0;
                //for each event iterate through all the deals and match the deal to event based on the peril and region IDs 
                foreach (Deal deal in DealList)
                {
                    if (deal.ListOfPerils.Contains(Event[1])) //Attempt to match peril
                    { matchPeril = true; }

                    if (matchPeril)
                    {
                        if (deal.ListOfRegions.Contains(Event[2])) //Attempt to match region
                        {
                            matchRegion = true;
                        }
                    }

                    if (matchPeril && matchRegion) //If periland region both match retrieve the loss value
                    {
                        dealLoss = CalculateEventDealLoss(Event[3], deal.Limit_retention);
                        DealLossResult dlr = new DealLossResult();
                        dlr.EventId = Event[0];
                        dlr.DealId = deal.ID;
                        dlr.DealLoss = dealLoss;

                        DealLossResultList.Add(dlr); //Add the details of the loss with the event and deal ID to the list
                        matchPeril = false;
                        matchRegion = false;
                        dealLoss = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return DealLossResultList;
        }

        /// <summary>
        /// Calculates the loss for a particular event based on the deal that is affected by that event
        /// </summary>
        /// <param name="EventLoss"></param>
        /// <param name="Limit_retention"></param>
        /// <returns></returns>
        public static int CalculateEventDealLoss(int EventLoss, string Limit_retention)
        {
            int dealLimit = 0;
            try
            {
                //Not sure if this is entirely correct but took the approach of calculating the loss
                //using the following logic.
                //If Event loss is > Deal limit, then the loss = Deal Limit
                //If Event loss is < Deal limit, then the loss = Deal Limit - Event loss
                dealLimit = GetDealLimitFromLimit_Retention(Limit_retention);
                if (EventLoss >= dealLimit)
                {
                    return dealLimit;
                }
                else
                {
                    return dealLimit - EventLoss;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dealLimit;
        }

        /// <summary>
        /// Parse the deal limit from the limit in excess of client retention value
        /// </summary>
        /// <param name="limit_retention"></param>
        /// <returns></returns>
        public static int GetDealLimitFromLimit_Retention(string limit_retention)
        {
            string limit = "0";

            try
            {
                if (limit_retention.Contains('x'))
                {
                    int indexOfX = 0;
                    indexOfX = limit_retention.IndexOf('x');
                    if (indexOfX > 0)
                    {
                        int result;
                        string limitTemp = limit_retention.Substring(0, indexOfX);
                        if (int.TryParse(limitTemp, out result))
                        {
                            limit = limitTemp;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return int.Parse(limit);
        }
    }
}
