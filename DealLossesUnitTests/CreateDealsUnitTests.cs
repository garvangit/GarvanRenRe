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
using RenRe.Puzzles.DealLosses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DealLossesUnitTests
{
    [TestClass]
    public class CreateDealsUnitTests
    {
        //Test there a 3 deals
        [TestMethod]
        public void TestCreateDeals_CheckCorrectCount()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            int TotalNumerOfDeals = ListofDeals.Count;
            Assert.AreEqual(TotalNumerOfDeals, 3);
        }

        //Test ID for deal 1 is not 0 
        [TestMethod]
        public void TestCreateDeals_Deal1IDIsNotZero()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal1 = ListofDeals[0];
                int Deal1ID = Deal1.ID;
                Assert.AreNotEqual<int>(0, Deal1ID);
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test the region ID for deal 1 is not greather than 3
        [TestMethod]
        public void TestCreateDeals_Deal1ListOfRegionsValuesIsNotGreaterThan3()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal1 = ListofDeals[0];
                List<int> Deal1Regions = Deal1.ListOfRegions;
                int MaxDeal1Region = Deal1Regions.Max();
                Assert.IsTrue(MaxDeal1Region <= 3, "Region for Deal is greater than 3");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 1 region is not less than 1
        [TestMethod]
        public void TestCreateDeals_Deal1ListOfRegionsValuesIsNotlessThan1()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal1 = ListofDeals[0];
                List<int> Deal1Regions = Deal1.ListOfRegions;
                int MinDeal1Region = Deal1Regions.Min();
                Assert.IsTrue(MinDeal1Region >= 1, "Region for Deal is less than 1");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 1 Peril ID is not > 3
        [TestMethod]
        public void TestCreateDeals_Deal1ListOfPerilsValuesIsNotGreaterThan3()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal1 = ListofDeals[0];
                List<int> Deal1Perils = Deal1.ListOfPerils;
                int MaxDeal1Perils = Deal1Perils.Max();
                Assert.IsTrue(MaxDeal1Perils <= 3, "Peril for Deal is greater than 3");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 1 Peril IDs is not < 1
        [TestMethod]
        public void TestCreateDeals_Deal1ListOfPerilsValuesIsNotLessThan1()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal1 = ListofDeals[0];
                List<int> Deal1Perils = Deal1.ListOfPerils;
                int MinDeal1Perils = Deal1Perils.Min();
                Assert.IsTrue(MinDeal1Perils >= 1, "Peril for Deal is less than 1");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 1 limit and retention value is not null
        [TestMethod]
        public void TestCreateDeals_Deal1Limit_retentionIsNotNull()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal1 = ListofDeals[0];
                string Limit_retention = Deal1.Limit_retention;
                Assert.IsNotNull(Limit_retention);
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 2 ID is not zero
        [TestMethod]
        public void TestCreateDeals_Deal2IDIsNotZero()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal2 = ListofDeals[1];
                int Deal2ID = Deal2.ID;
                Assert.AreNotEqual<int>(0, Deal2ID);
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 2, regions ID is not > 3
        [TestMethod]
        public void TestCreateDeals_Deal2ListOfRegionsValuesIsNotGreaterThan3()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal2 = ListofDeals[1];
                List<int> Deal2Regions = Deal2.ListOfRegions;
                int MaxDeal2Region = Deal2Regions.Max();
                Assert.IsTrue(MaxDeal2Region <= 3, "Region for Deal is greater than 3");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 2, region IDs are not < 1
        [TestMethod]
        public void TestCreateDeals_Deal2ListOfRegionsValuesIsNotlessThan1()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal2 = ListofDeals[1];
                List<int> Deal2Regions = Deal2.ListOfRegions;
                int MinDeal2Region = Deal2Regions.Min();
                Assert.IsTrue(MinDeal2Region >= 1, "Region for Deal is less than 1");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 2 peril IDs is not > 3
        [TestMethod]
        public void TestCreateDeals_Deal2ListOfPerilsValuesIsNotGreaterThan3()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal2 = ListofDeals[1];
                List<int> Deal2Perils = Deal2.ListOfPerils;
                int MaxDeal2Perils = Deal2Perils.Max();
                Assert.IsTrue(MaxDeal2Perils <= 3, "Peril for Deal is greater than 3");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 2 perils IDs are not < 1
        [TestMethod]
        public void TestCreateDeals_Deal2ListOfPerilsValuesIsNotLessThan1()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal2 = ListofDeals[1];
                List<int> Deal2Perils = Deal2.ListOfPerils;
                int MinDeal2Perils = Deal2Perils.Min();
                Assert.IsTrue(MinDeal2Perils >= 1, "Peril for Deal is less than 1");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 2 limit and retention values are not null
        [TestMethod]
        public void TestCreateDeals_Deal2Limit_retentionIsNotNull()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal2 = ListofDeals[1];
                string Limit_retention = Deal2.Limit_retention;
                Assert.IsNotNull(Limit_retention);
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 3 ID is not zero
        [TestMethod]
        public void TestCreateDeals_Deal3IDIsNotZero()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal3 = ListofDeals[2];
                int Deal3ID = Deal3.ID;
                Assert.AreNotEqual<int>(0, Deal3ID);
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 3 regions IDs are not > 3
        [TestMethod]
        public void TestCreateDeals_Deal3ListOfRegionsValuesIsNotGreaterThan3()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal3 = ListofDeals[2];
                List<int> Deal3Regions = Deal3.ListOfRegions;
                int MaxDeal3Region = Deal3Regions.Max();
                Assert.IsTrue(MaxDeal3Region <= 3, "Region for Deal is greater than 3");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 3 regions IDs are not less than 1
        [TestMethod]
        public void TestCreateDeals_Deal3ListOfRegionsValuesIsNotlessThan1()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal3 = ListofDeals[2];
                List<int> Deal3Regions = Deal3.ListOfRegions;
                int MinDeal3Region = Deal3Regions.Min();
                Assert.IsTrue(MinDeal3Region >= 1, "Region for Deal is less than 1");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 3 perils IDs are not > 3
        [TestMethod]
        public void TestCreateDeals_Deal3ListOfPerilsValuesIsNotGreaterThan3()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal3 = ListofDeals[2];
                List<int> Deal3Perils = Deal3.ListOfPerils;
                int MaxDeal3Perils = Deal3Perils.Max();
                Assert.IsTrue(MaxDeal3Perils <= 3, "Peril for Deal is greater than 3");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 3 perils IDs are not < 1
        [TestMethod]
        public void TestCreateDeals_Deal3ListOfPerilsValuesIsNotLessThan1()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal3 = ListofDeals[2];
                List<int> Deal3Perils = Deal3.ListOfPerils;
                int MinDeal3Perils = Deal3Perils.Min();
                Assert.IsTrue(MinDeal3Perils >= 1, "Peril for Deal is less than 1");
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }

        //Test deal 3 limit and retention is not null
        [TestMethod]
        public void TestCreateDeals_Deal3Limit_retentionIsNotNull()
        {
            List<Deal> ListofDeals = Deal.CreateDeals();
            if (ListofDeals.Count > 0)
            {
                Deal Deal3 = ListofDeals[2];
                string Limit_retention = Deal3.Limit_retention;
                Assert.IsNotNull(Limit_retention);
            }
            else
            {
                Assert.Fail("CreateDeals returns empty list");
            }
        }


    }
}
