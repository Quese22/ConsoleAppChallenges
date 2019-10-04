using _02_Challenege_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChallenegeConsole
{
    public class ProgramUI
    {
        ClaimsRepository _claimrepo = new ClaimsRepository();


        public void Run()
        {
            _claimrepo.SeedQueue();
            RunMenu();
        }

        private void RunMenu()
        { bool choice = true;
            while (choice)
            {
                Console.WriteLine("1.)See All Claims \n" +
                    "2.)Take Care of Next Claim \n" +
                    "3.)Enter a New Claim \n" +
                    "4.)Delete Claims");
                string userchoice = Console.ReadLine();

                switch (userchoice)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2.":
                        ViewNextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
                        break;
                    case "4":
                        DeleteClaim();
                        break;
                    default:
                        choice = false;
                        break;
                }
            }
        }

        private void ViewAllClaims()
        {
            Queue<ClaimsContent> claims = _claimrepo.SeeAllClaims();

            foreach (ClaimsContent claim in claims)
            {
                Console.WriteLine($"{claim.ClaimId} {claim.ClaimType} {claim.Description}{claim.ClaimAmount} {claim.DateOfIncident} {claim.DateOfClaim}");

            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
        }

        private void ViewNextClaim()
        {
            ClaimsContent claim = _claimrepo.SeeNextClaim();
            Console.WriteLine(claim.ClaimId + "\t", claim.ClaimType + "\t", claim.Description + "\t", claim.ClaimAmount + "\t", claim.DateOfIncident + "\t", claim.DateOfClaim + "\t", claim.IsValid);
            Console.WriteLine("Would you like to handle this claim?(y/n)");
            string input = Console.ReadLine();
            if (input != "y")
            {
                _claimrepo.DeleteCurrentClaim();
            }
            else Console.WriteLine("Press Enter to return to the main menu");
            Console.Clear();
            RunMenu();


        }

        private void CreateNewClaim()
        {
            ClaimsContent claims = new ClaimsContent();

            Console.WriteLine("What is the new claim ID?");
            claims.ClaimId = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Claim type?\n" +
            "1.)Car\n" +
            "2.)Home\n" +
            "3.)Theft");

            int claimtypenum = int.Parse(Console.ReadLine());
            claims.ClaimType = (ClaimType)claimtypenum;

            Console.WriteLine("Please desrcribe your claim");
            claims.Description = Console.ReadLine();

            Console.WriteLine("How much is the claim worth?");
            claims.ClaimAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Date of the Incdent?");
            claims.DateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What date did was the claim filed?");
            claims.DateOfClaim = DateTime.Parse(Console.ReadLine());


            _claimrepo.AddToQueue(claims);

        }

        private void DeleteClaim()
        {
            ClaimsContent claim = _claimrepo.SeeNextClaim();


            Console.WriteLine("Delete this claim");
            claim.ClaimId = int.Parse(Console.ReadLine());


            _claimrepo.DeleteCurrentClaim();

        }
    }






}
