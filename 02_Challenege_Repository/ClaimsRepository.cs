using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenege_Repository
{
    public class ClaimsRepository
    {
        ClaimsContent claimlib = new ClaimsContent();
        Queue<ClaimsContent> _claimrepo = new Queue<ClaimsContent>();


        public void SeedQueue()
        {
            ClaimsContent claim1 = new ClaimsContent(1, ClaimType.Car, "Car Accident on 465", 400.00m, DateTime.Parse("4/25/18"), DateTime.Parse("4/27/18"));
            ClaimsContent claim2 = new ClaimsContent(2, ClaimType.Home, "House fire in kitchen", 4000.00m, DateTime.Parse("4/11/18"), DateTime.Parse("4/12/18"));
            ClaimsContent claim3 = new ClaimsContent(3, ClaimType.Theft, "Stolen PAncakes", 4.00m, DateTime.Parse("4/27/18"), DateTime.Parse("6/01/18"));

            AddToQueue(claim1);
            AddToQueue(claim2);
            AddToQueue(claim3);
        }

        public Queue<ClaimsContent> SeeAllClaims()
        {
            return _claimrepo;
        }

        public void AddToQueue(ClaimsContent claims)
        {

            _claimrepo.Enqueue(claims);  
        }

        public ClaimsContent SeeNextClaim()
        {
            return _claimrepo.Peek();

        }

        public void DeleteCurrentClaim()
        {
             _claimrepo.Dequeue();
        
        }

    }


}

