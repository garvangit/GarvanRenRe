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
    public class DataUnitTests
    {
        //Test the total event are = 4
        [TestMethod]
        public void TestData_CheckCorrectCount()
        {
            int[][] EventData = Data.Events;
            int TotalNumerOfEvents = EventData.Length;
            Assert.AreEqual(TotalNumerOfEvents, 4);
        }

        //Test event 1,peril ID is between 1 and 3
        [TestMethod]
        public void TestData_Event1PerilValueIsBetween1And3()
        {
            int[][] EventData = Data.Events;
            int Peril = EventData[0][1]; //Event 1 Peril
            Assert.IsTrue((Peril >= 1 && Peril <= 3), "Peril ID for event 1 is not between 1 and 3 ");
        }

        //Test event 1 region ID is between 1 and 3
        [TestMethod]
        public void TestData_Event1RegionValueIsBetween1And3()
        {
            int[][] EventData = Data.Events;
            int Region = EventData[0][2]; //Event 1 Region
            Assert.IsTrue((Region >= 1 && Region <= 3), "Region ID for event 1 is not between 1 and 3 ");
        }

        //Test event 1 loss = 1000
        [TestMethod]
        public void TestData_Event1LossValueIs1000()
        {
            int[][] EventData = Data.Events;
            int Loss = EventData[0][3]; //Event 1 Loss
            Assert.AreEqual<int>(1000, Loss);
        }

        //Test event 2 peril is between 1 and 3
        [TestMethod]
        public void TestData_Event2PerilValueIsBetween1And3()
        {
            int[][] EventData = Data.Events;
            int Peril = EventData[1][1]; //Event 2 Peril
            Assert.IsTrue((Peril >= 1 && Peril <= 3), "Peril ID for event 2 is not between 1 and 3 ");
        }

        //Test event 2 region ID is between 1 and 3
        [TestMethod]
        public void TestData_Event2RegionValueIsBetween1And3()
        {
            int[][] EventData = Data.Events;
            int Region = EventData[1][2]; //Event 2 Region
            Assert.IsTrue((Region >= 1 && Region <= 3), "Region ID for event 2 is not between 1 and 3 ");
        }

        //Test event 2 loss is 500
        [TestMethod]
        public void TestData_Event2LossValueIs500()
        {
            int[][] EventData = Data.Events;
            int Loss = EventData[1][3]; //Event 2 Loss
            Assert.AreEqual<int>(500, Loss);
        }

        //Test event 3 perilID is between 1 and 3
        [TestMethod]
        public void TestData_Event3PerilValueIsBetween1And3()
        {
            int[][] EventData = Data.Events;
            int Peril = EventData[2][1]; //Event 3 Peril
            Assert.IsTrue((Peril >= 1 && Peril <= 3), "Peril ID for event 3 is not between 1 and 3 ");
        }

        //Test event 3 region ID is between 1 and 3
        [TestMethod]
        public void TestData_Event3RegionValueIsBetween1And3()
        {
            int[][] EventData = Data.Events;
            int Region = EventData[2][2]; //Event 3 Region
            Assert.IsTrue((Region >= 1 && Region <= 3), "Region ID for event 3 is not between 1 and 3 ");
        }

        //Test even 3 loss = 750
        [TestMethod]
        public void TestData_Event3LossValueIs750()
        {
            int[][] EventData = Data.Events;
            int Loss = EventData[2][3]; //Event 3 Loss
            Assert.AreEqual<int>(750, Loss);
        }

        //Test event 4 peril IDs is between 1 and 3
        [TestMethod]
        public void TestData_Event4PerilValueIsBetween1And3()
        {
            int[][] EventData = Data.Events;
            int Peril = EventData[3][1]; //Event 4 Peril
            Assert.IsTrue((Peril >= 1 && Peril <= 3), "Peril ID for event 4 is not between 1 and 3 ");
        }

        //Test event 4 region ID is between 1 and 3
        [TestMethod]
        public void TestData_Event4RegionValueIsBetween1And3()
        {
            int[][] EventData = Data.Events;
            int Region = EventData[3][2]; //Event 3 Region
            Assert.IsTrue((Region >= 1 && Region <= 3), "Region ID for event 4 is not between 1 and 3 ");
        }

        //Test event 4 loss = 2000
        [TestMethod]
        public void TestData_Event4LossValueIs2000()
        {
            int[][] EventData = Data.Events;
            int Loss = EventData[3][3]; //Event 4 Loss
            Assert.AreEqual<int>(2000, Loss);
        }
    }
}
