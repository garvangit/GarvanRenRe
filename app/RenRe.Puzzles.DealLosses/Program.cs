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
    public class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                List<Deal> ListofDeals = Deal.CreateDeals();
                int[][] EventData = Data.Events;

                //Iterate through allthe events and retreive the Deal and its associated loss to Reinsurance company
                for (int i = 0; i < EventData.Length; i++)
                {
                    List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(EventData[i], ListofDeals);

                    if (reInsureanceLossResultList.Count == 0)
                    {
                        Console.WriteLine("No deals are affected by these events");
                    }

                    if (reInsureanceLossResultList.Count == 1)
                    {
                        DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
                        Console.WriteLine("Event id = {0}, only affects deal {1} and the reinsurance company's loss is {2}", dlr.EventId, dlr.DealId, dlr.DealLoss);
                    }
                    if (reInsureanceLossResultList.Count > 1)
                    {
                        foreach (DealLossResult dlr in reInsureanceLossResultList)
                        {
                            Console.WriteLine("Event id = {0}, affects deal {1} and the reinsurance company's loss is {2}", dlr.EventId, dlr.DealId, dlr.DealLoss);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

      
    }
}
