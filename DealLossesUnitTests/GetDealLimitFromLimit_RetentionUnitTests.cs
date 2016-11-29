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
    public class GetDealLimitFromLimit_RetentionUnitTests
    {
        //Test if there is no limit value it returns zero
        [TestMethod]
        public void TestGetDealLimitFromLimit_Retention_NoLimit_Return0()
        {
            int LimitValue = ReinsuranceCalculations.GetDealLimitFromLimit_Retention("x200");
            Assert.AreEqual(LimitValue, 0);
        }

        //Test the correct limit value is parsed from the value
        [TestMethod]
        public void TestGetDealLimitFromLimit_Retention_ReturnLimitValue100()
        {
            int LimitValue = ReinsuranceCalculations.GetDealLimitFromLimit_Retention("100x200");
            Assert.AreEqual(LimitValue, 100);
        }

        //Test the correct limit vlaue is parsed from the value if there is no retention value
        [TestMethod]
        public void TestGetDealLimitFromLimit_Retention_NoRetention_ReturnLimit100()
        {
            int LimitValue = ReinsuranceCalculations.GetDealLimitFromLimit_Retention("100x");
            Assert.AreEqual(LimitValue, 100);
        }

        //Test if there is no 'x', the limit value returns zero
        [TestMethod]
        public void TestGetDealLimitFromLimit_Retention_Nox_Return0()
        {
            int LimitValue = ReinsuranceCalculations.GetDealLimitFromLimit_Retention("100");
            Assert.AreEqual(LimitValue, 0);
        }

        //Test if the limit is not numeric then return a value of zero
        [TestMethod]
        public void TestGetDealLimitFromLimit_Retention_LimitvalueNoAnInteger_Return0()
        {
            int LimitValue = ReinsuranceCalculations.GetDealLimitFromLimit_Retention("ABCx100");
            Assert.AreEqual(LimitValue, 0);
        }
    }
}
