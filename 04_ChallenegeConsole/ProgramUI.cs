using _04_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ChallenegeConsole
{

    class ProgramUI
    {
        OutingRepository outingrepo = new OutingRepository();

        public void Run()
        {
            outingrepo.SeedList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool choice = true;
            while (choice)
            {
                Console.Clear();
                Console.WriteLine("1.Display All outings \n" +
                    "2.Add a new Outing\n" +
                    "3.See The cost for All outings this year\n" +
                    "4.Display Outing Costs By Type\n");

                string userchoice = Console.ReadLine();

                switch (userchoice)
                {
                    case "1":
                        DisplayAllOutings();
                        break;
                    case "2":
                        AddNewOuting();
                        break;
                    case "3":
                        SeeCostByType();
                        break;
                    case "4":
                        SeeOverallCost();
                        break;
                    default:
                        choice = false;
                        break;
                }

            }

        }
        private void DisplayAllOutings()
        {
            List<OutingInfo> outing = outingrepo.SeeAllOutings();

            foreach (OutingInfo outter in outing)
            {
                Console.WriteLine($"{outter.EventType} {outter.Date}, Cost of Event: {outter.TotalCostForTheEvent}, Number of People: {outter.NumberOfPeopleAttended} {outter.TotalCostPerPersonForEvent}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        private void AddNewOuting()
        {
            OutingInfo outing = new OutingInfo();

            Console.WriteLine("What type of outing would you like to add?\n" +
                "1.Golf outting?\n" +
                "2.Bowling\n" +
                "3.Amusement Park\n" +
                "4.Concert");
            int eventTypeEnum = int.Parse(Console.ReadLine());
            outing.EventType = (EventType)eventTypeEnum;

            Console.WriteLine("What was the date of the event?(01/01/2019)");
            outing.Date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("How many people attended?");
            outing.NumberOfPeopleAttended = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the total cost breakdown per person? (must be a decimal)");
            outing.TotalCostPerPersonForEvent = decimal.Parse(Console.ReadLine());

            outing.TotalCostForTheEvent = outing.TotalCostPerPersonForEvent * outing.NumberOfPeopleAttended;

            outingrepo.AddTolist(outing);

        }

        private void SeeCostByType()
        {
            Console.WriteLine("What event type would you like to see the overall cost for?\n" +
                "1.Golf outting?\n" +
                "2.Bowling\n" +
                "3.Amusement Park\n" +
                "4.Concert");
            int response = int.Parse(Console.ReadLine());

            decimal totalcost = outingrepo.GetTotalCostOfEventsWithType((EventType)response);

            Console.WriteLine(totalcost);
            Console.ReadKey();
        }

        private void SeeOverallCost()
        {

            decimal totalcost = outingrepo.GetTotalCostOfAllEvents();
            Console.WriteLine(totalcost);
            Console.ReadKey();

        }


    }
}
