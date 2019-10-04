using _01_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenege_Console
{
    public class ProgramUI
    {
        MenuRepository _menurepo = new MenuRepository();

        public void Run()
        {
            _menurepo.SeedList();
            RunMenu();

        }

        public void RunMenu()
        {
            bool choice = true;
            while (choice)
            {
                Console.WriteLine("Enter the number for the action you would like\n+" +
                    "1.)See all Meals\n+" +
                    "2.)Find Meal by number\n" +
                    "3.)Create a new Meal\n+" +
                    "4.)Remove Meal From Menu\n+" +
                    "");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        DisplayMenuList();
                        break;
                    case "2":
                        FindMealByMealNumber();
                        break;
                    case "3":
                        MakeNewMenuItem();
                        break;
                    case "4":
                        RemoveMenuItem();
                        break;
                    default:
                        choice = false;
                        break;
                }
            }
        }
        private void DisplayMenuList()
        {
            List<Menu> UImenu = _menurepo.GetMenuList();
            foreach (Menu item in UImenu)
            {
                Console.WriteLine($"{item.MealNumber} {item.MealName} {item.Ingredients} {item.Price}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void FindMealByMealNumber()
        {
            Console.WriteLine("Please enter meal number");
            string numberInput = Console.ReadLine();
            int orderNumber = int.Parse(numberInput);

            Menu UIMenu = _menurepo.GetMenuListByNumber(orderNumber);

            if(orderNumber!=UIMenu.MealNumber)
            {
                Console.WriteLine("That meal does not exist. Meal numbers are 1-4");
            }
            else
            {
                Console.WriteLine($"Meal Number:{ UIMenu.MealNumber}\n"+
                    $"Meal Name: {UIMenu.MealName} \n" +
                    $"Ingredients:{UIMenu.Ingredients} \n"+
                    $"Price: {UIMenu.Price}");
            }
            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();

        }

        private void MakeNewMenuItem()
        {
            Menu item = new Menu();

            Console.WriteLine("Create new Order Number");
            item.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the name of your Order");
            item.MealName = Console.ReadLine();

            Console.WriteLine("What ingredients are in this order");
            item.Ingredients = Console.ReadLine();

            Console.WriteLine("How much will the order cost?");
            item.Price = decimal.Parse(Console.ReadLine());

            _menurepo.AddToMenuList(item);

        }

        private void RemoveMenuItem()
        {
            Menu item = new Menu();

            Console.WriteLine("What order would you like to remove");
            //string userInput = Console.ReadLine();
            int userInputs = int.Parse(Console.ReadLine());

            _menurepo.RemoveMenuItemsFromList(userInputs);
            
            if (userInputs==item.MealNumber)
            {
                Console.WriteLine("The bad boy is deleted");
            }
            else
            { Console.WriteLine("Cannot Delete an order that does not exsist");

            }
        }
    }
}

