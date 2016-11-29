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
    public class CalculateEventDealLossUnitTests
    {
        //Test if event loss is greater than deal limit the company loss is the deal limit 
        [TestMethod]
        public void TestCalculateEventDealLoss_EventLossGreaterThanDealLimit_LossEqualsDealLimit()
        {
            int EventDealLoss = ReinsuranceCalculations.CalculateEventDealLoss(1000, "999x500");
            Assert.AreEqual(EventDealLoss, 999);
        }

        //Test if event loss equals deal limit the company loss is the deal limit 
        [TestMethod]
        public void TestCalculateEventDealLoss_EventLossEqualsDealLimit_LossEqualsDealLimit()
        {
            int EventDealLoss = ReinsuranceCalculations.CalculateEventDealLoss(1000, "1000x500");
            Assert.AreEqual(EventDealLoss, 1000);
        }

        //Test if event loss is less than the deal limit the company loss is the deal limit - event loss
        [TestMethod]
        public void TestCalculateEventDealLoss_EventLossLessThanDealLimit_LossEquals1()
        {
            int EventDealLoss = ReinsuranceCalculations.CalculateEventDealLoss(1000, "1001x500");
            Assert.AreEqual(EventDealLoss, 1);
        }

    }
}
