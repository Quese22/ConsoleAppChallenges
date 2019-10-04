using System;
using System.Collections.Generic;
using _02_Challenege_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenege_Tests
{
    [TestClass]
    public class ChallengeRepositoryTests
    {
 
        [TestMethod]
        public void CreateNewClaim_AddToClaim_CountShouldBeTheSame()
        {
            ////AAA///
            ClaimsContent claims = new ClaimsContent();
            ClaimsRepository _claimrepo = new ClaimsRepository();
            Queue<ClaimsContent> queue = _claimrepo.SeeAllClaims();


            ///AA///
            ClaimsContent claim1 = new ClaimsContent(20, ClaimType.Home, "whole house burned down", 308987.34m, DateTime.Parse("03/01/2019"), DateTime.Parse("03/28/2019"));

            claim1.ClaimType = ClaimType.Home;
            ClaimType expected = ClaimType.Home;

            //A//

            Assert.AreEqual(expected, claim1.ClaimType);
            Assert.AreEqual(20, claim1.ClaimId);
            Assert.AreEqual("whole house burned down", claim1.Description);
            Assert.AreEqual(308987.34m, claim1.ClaimAmount);
            Assert.AreEqual(DateTime.Parse("03/01/2019"), claim1.DateOfIncident);
            Assert.AreEqual(DateTime.Parse("03/28/2019"), claim1.DateOfClaim);

            _claimrepo.AddToQueue(claim1);

            int expected1 = 1;
            int actual = queue.Count;

            Assert.AreEqual(expected1, actual);
        }

        [TestMethod]
        public void DisplayAllClaims()
        {
            ////AAA////
            ClaimsRepository _claimrepo = new ClaimsRepository();

            ClaimsContent claim1 = new ClaimsContent(20, ClaimType.Home, "whole house burned down", 308987.34m, DateTime.Parse("03/01/2019"), DateTime.Parse("03/28/2019"));

            ///AA///
            _claimrepo.AddToQueue(claim1);

            Queue<ClaimsContent> actual = _claimrepo.SeeAllClaims();
            ClaimsContent peekQueue = actual.Peek();


            //A//
            Assert.AreEqual(ClaimType.Home, peekQueue.ClaimType);

        }

        [TestMethod]
        public void RemoveFromQueue()
        { 
            ClaimsRepository _claimrepo = new ClaimsRepository();
            Queue<ClaimsContent> queue = new Queue<ClaimsContent>();

            ClaimsContent claim1 = new ClaimsContent(20, ClaimType.Home, "whole house burned down", 308987.34m, DateTime.Parse("03/01/2019"), DateTime.Parse("03/28/2019"));

            _claimrepo.AddToQueue(claim1);

            int expected = 0;

            _claimrepo.DeleteCurrentClaim();

            int actual = queue.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
