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
using System.Threading.Tasks;
using RenRe.Puzzles.DealLosses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DealLossesUnitTests
{
    [TestClass]
    public class CalculateLossForEventUnitTests
    {
        //Test Event 1 matches a single deal
        [TestMethod]
        public void TestCalculateLossForEvent1_MatchOneDeal()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 1, 2, 1, 1000 }; //event1
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            Assert.AreEqual<int>(reInsureanceLossResultList.Count, 1);
        }

        //Test event 1 has ID = 1
        [TestMethod]
        public void TestCalculateLossForEvent1_ReturnsEventID1()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 1, 2, 1, 1000 }; //event1
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(1, dlr.EventId);
        }

        //Test event 1 matches deal 1
        [TestMethod]
        public void TestCalculateLossForEvent1_MatchsDeal1ID()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 1, 2, 1, 1000 }; //event1
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(1, dlr.DealId);
        }

        //Test event 1 returns loss of 500
        [TestMethod]
        public void TestCalculateLossForEvent1_ReturnsLoss500()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 1, 2, 1, 1000 }; //event1
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(500, dlr.DealLoss);
        }

        // Test Event 2 matches a single deal
        [TestMethod]
        public void TestCalculateLossForEvent2_MatchOneDeal()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 2, 3, 2, 500 }; //event2
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            Assert.AreEqual<int>(reInsureanceLossResultList.Count, 1);
        }

        //Test event 2 has event id = 2
        [TestMethod]
        public void TestCalculateLossForEvent2_ReturnsEventID2()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 2, 3, 2, 500 }; //event2
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(2, dlr.EventId);
        }

        //Test event 2 matches deal 3
        [TestMethod]
        public void TestCalculateLossForEvent2_MatchsDeal3ID()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 2, 3, 2, 500 }; //event2
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(3, dlr.DealId);
        }

        //Test event 2 returns a loss of 250
        [TestMethod]
        public void TestCalculateLossForEvent2_ReturnsLoss250()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 2, 3, 2, 500 }; //event2
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(250, dlr.DealLoss);
        }

        //Test event 3 matches a single deal
        [TestMethod]
        public void TestCalculateLossForEvent3_MatchOneDeal()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 3, 3, 3, 750 }; //event3
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            Assert.AreEqual<int>(reInsureanceLossResultList.Count, 1);
        }

        //Test event 3 has ID = 3
        [TestMethod]
        public void TestCalculateLossForEvent3_ReturnsEventID3()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 3, 3, 3, 750 }; //event3
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(3, dlr.EventId);
        }

        //Test event 3 matches deal 3
        [TestMethod]
        public void TestCalculateLossForEvent3_MatchsDeal3ID()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 3, 3, 3, 750 }; //event3
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(3, dlr.DealId);
        }

        //Test event 3 returns a loss of 250
        [TestMethod]
        public void TestCalculateLossForEvent3_ReturnsLoss250()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 3, 3, 3, 750 }; //event3
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            DealLossResult dlr = reInsureanceLossResultList.FirstOrDefault();
            Assert.AreEqual<int>(250, dlr.DealLoss);
        }

        //Test event 4 matches 2 deals
        [TestMethod]
        public void TestCalculateLossForEvent4_Match2Deals()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 4, 1, 3, 2000 }; //event4
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            Assert.AreEqual<int>(reInsureanceLossResultList.Count, 2);
        }

        //Test event 4 has an ID = 4
        [TestMethod]
        public void TestCalculateLossForEvent4_ReturnsEventID4()
        {
            bool EventIDIs4 = true;
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 4, 1, 3, 2000 }; //event4
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            foreach (DealLossResult dlr in reInsureanceLossResultList)
            {
                if (dlr.EventId != 4)
                { EventIDIs4 = false; }
            }
            Assert.IsTrue(EventIDIs4, "Event ID is not 4"); 
        }

        //Test event 4 matches deal 2
        [TestMethod]
        public void TestCalculateLossForEvent4_MatchsDeal2()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 4, 1, 3, 2000 }; //event4
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            IEnumerable<DealLossResult> reInsureanceLossResultListWithDeal2 = reInsureanceLossResultList.Where(d => d.DealId == 2);
            Assert.IsTrue(reInsureanceLossResultListWithDeal2.ToList().Count > 0, "Event 4 does not match with deal 2");
        }

        //Test event 4 matches deal 3
        [TestMethod]
        public void TestCalculateLossForEvent4_MatchsDeal3()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 4, 1, 3, 2000 }; //event4
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            IEnumerable<DealLossResult> reInsureanceLossResultListWithDeal3 = reInsureanceLossResultList.Where(d => d.DealId == 3);
            Assert.IsTrue(reInsureanceLossResultListWithDeal3.ToList().Count > 0, "Event 4 does not match with deal 3");
        }

        //Test deal 2 returns loss of 1000 for event 4
        [TestMethod]
        public void TestCalculateLossForEvent4_MatchDeal2ReturnsLoss1000()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 4, 1, 3, 2000 }; //event4
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            IEnumerable<DealLossResult> reInsureanceLossResultListWithDeal2 = reInsureanceLossResultList.Where(d => d.DealId == 2);
            DealLossResult dlr = reInsureanceLossResultListWithDeal2.ToList().FirstOrDefault();
            Assert.AreEqual<int>(1000, dlr.DealLoss);
        }

        //Test deal 3 returns a loss of 250 for event 4 
        [TestMethod]
        public void TestCalculateLossForEvent4_MatchDeal3ReturnsLoss250()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 4, 1, 3, 2000 }; //event4
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            IEnumerable<DealLossResult> reInsureanceLossResultListWithDeal3 = reInsureanceLossResultList.Where(d => d.DealId == 3);
            DealLossResult dlr = reInsureanceLossResultListWithDeal3.ToList().FirstOrDefault();
            Assert.AreEqual<int>(250, dlr.DealLoss);
        }

        //Test an event not covered by a deal, does not match a deal
        [TestMethod]
        public void TestCalculateLossForNewEventWithNewRegionAndPeril_NoDealIsmatched()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int[] Event = new[] { 5, 4, 4, 2000 }; //event5
            List<DealLossResult> reInsureanceLossResultList = ReinsuranceCalculations.CalculateLossForEvent(Event, ListofDeals);
            Assert.AreEqual<int>(0, reInsureanceLossResultList.Count);
        }

    }
}
