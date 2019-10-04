using System;
using System.Collections.Generic;
using _04_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Challenge_Tests
{
    [TestClass]
    public class OutingRepositoryTests
    {
        [TestMethod]
        public void CreateNewOuting_AddToOutings_CountShouldBeTheSame()
        {
            OutingRepository outingrepo = new OutingRepository();

            List<OutingInfo> outing = outingrepo.SeeAllOutings();

            OutingInfo outing5 = new OutingInfo(EventType.Golf, 34, DateTime.Now, 90.09m, 104144.04m);

            outingrepo.AddTolist(outing5);

            int expected = 1;
            int actual = outing.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalCostOfAllEvents_ValidEventCost_ShouldReturnCorrectSum()
        {
            OutingRepository outingRepo = new OutingRepository();

            outingRepo.SeedList();

            decimal expected = 1739900m;
            decimal actual = outingRepo.GetTotalCostOfAllEvents();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalCostByType_ShouldReturnCorrectSum()
        {
            OutingRepository outingrepo = new OutingRepository();
          

            OutingInfo outing5 = new OutingInfo(EventType.Golf, 34, DateTime.Now, 90.09m, 1043.04m);

            outingrepo.AddTolist(outing5);

            decimal expected = 35463.36m;
            decimal actual = outingrepo.GetTotalCostOfEventsWithType(EventType.Golf);


            Assert.AreEqual(expected, actual);
          



        }
    }

}
