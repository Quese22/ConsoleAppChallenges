using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge_Repository
{
    public class OutingRepository
    {
        List<OutingInfo> _outingList = new List<OutingInfo>();
        public void AddTolist(OutingInfo outing)
        {
            _outingList.Add(outing);

        }

        public List<OutingInfo> SeeAllOutings()
        {
            return _outingList;
        }


        public void SeedList()
        {
            OutingInfo outing1 = new OutingInfo(EventType.Golf, 100, DateTime.Parse("01/01/2019"), 56.20m, 5260.00m);
            OutingInfo outing2 = new OutingInfo(EventType.AmusementPark, 100, DateTime.Parse("02/02/2019"), 25.05m, 2505.00m);
            OutingInfo outing3 = new OutingInfo(EventType.Bowling, 100, DateTime.Parse("03/01/2019"), 10.00m, 1000m);
            OutingInfo outing4 = new OutingInfo(EventType.Concert, 100, DateTime.Parse("08/15/2019"), 86.34m, 8634.00m);

            AddTolist(outing1);
            AddTolist(outing2);
            AddTolist(outing3);
            AddTolist(outing4);
        }

        public decimal GetTotalCostOfEventsWithType(EventType eventType)
        {
            decimal totalcost = 0;

            foreach(OutingInfo outing in _outingList)
            {
                if (eventType == outing.EventType)
                {
                    totalcost = totalcost + outing.TotalCostForTheEvent;
                }
            }
            return totalcost;
        }

        public decimal GetTotalCostOfAllEvents()
        {
            decimal totalcost = 0;

            foreach (OutingInfo outing in _outingList)
            {
                totalcost = totalcost + outing.TotalCostForTheEvent;
            }
            return totalcost;

        }
    }

}
