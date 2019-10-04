using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge_Repository
{
    public enum EventType { Golf=1, Bowling, AmusementPark, Concert }
    public class OutingInfo
    {

        public OutingInfo()
        {

        }
        public EventType EventType { get; set; }
        public int NumberOfPeopleAttended { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalCostPerPersonForEvent { get; set; }
        public decimal TotalCostForTheEvent { get; set; }
   
        public OutingInfo(EventType eventType,int numberOfPeopleAttended,DateTime date,decimal totalCostPerPersonForEvent,decimal totalCostForTheEvent)
        {
            EventType = eventType;
            NumberOfPeopleAttended = numberOfPeopleAttended;
            Date = date;
            TotalCostPerPersonForEvent = totalCostPerPersonForEvent;
            TotalCostForTheEvent = (numberOfPeopleAttended * totalCostForTheEvent);
        }

        
       
    }
}
