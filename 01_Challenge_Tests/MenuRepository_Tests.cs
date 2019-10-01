using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _01_Challenge_Repository;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateNewMenuItem()
        {
            Menu menu = new Menu();

            menu.MealNumber = 5;
            int expected = 5;

            Assert.AreEqual(expected,menu.MealNumber);

            Menu menu1 = new Menu(5, "The Dog", "Vegan Sausage Dog", "tofu,setan", 10.78m);

            Assert.AreEqual(expected, menu1.MealNumber);
            Assert.AreEqual("The Dog", menu1.MealName);
            Assert.AreEqual("Vegan Sausage Dog", menu1.Description);
            Assert.AreEqual("tofu,setan", menu1.Ingredients);
            Assert.AreEqual(10.78m, menu1.Price);
            
        }
        [TestMethod]
        public void AddToList_AddNewMenuItem_MenuCountShouldBeCorrect()
        {
            //AAA//

            MenuRepository menuRepo = new MenuRepository();
            List<Menu> items = menuRepo.GetMenuList();

            Menu item1 = new Menu(8, "Portabellawhich", "Porteblla Muchroom Sandwhich", "Portabella Mushroom,sandwhich condiments,", 9.70m);
            Menu item2 = new Menu(9, "AB&J", "Classic twist on PB&J using almod butter", "Almond Butter and grape Peserves", 6.50m);
            Menu item3 = new Menu(10, "Pad thai", "Classic Pad thai", "noodles,quiona,curry,tofu", 13.28m);

            //AA//
            int expected = 3;

            menuRepo.AddToMenuList(item1);
            menuRepo.AddToMenuList(item2);
            menuRepo.AddToMenuList(item3);

            int actual = items.Count;

            //A//
            Assert.AreEqual(expected,actual);


        }
        [TestMethod]
        public void RemoveFromList_DeleteNewMenuItem_MenuCountShouldBeCorrect()
        {
            //AAA//
            MenuRepository menuRepo = new MenuRepository();
            List<Menu> items = menuRepo.GetMenuList();

            Menu item1 = new Menu(8, "Portabellawhich", "Porteblla Muchroom Sandwhich", "Portabella Mushroom,sandwhich condiments,", 9.70m);
            Menu item2 = new Menu(9, "AB&J", "Classic twist on PB&J using almod butter", "Almond Butter and grape Peserves", 6.50m);
            Menu item3 = new Menu(10, "Pad thai", "Classic Pad thai", "noodles,quiona,curry,tofu", 13.28m);


            menuRepo.AddToMenuList(item1);
            menuRepo.AddToMenuList(item2);
            menuRepo.AddToMenuList(item3);

            //AA//

            int expected = 1;

            menuRepo.RemoveMenuItemsFromList(9);
            menuRepo.RemoveMenuItemsFromList(10);

            int actual = items.Count;

            //A//
            Assert.AreEqual(expected, actual);

            
        }
        [TestMethod]
        public void GetMenuItemByMealNumber_GetItemByValidIn_MenuItemsShouldBeTheSame()
        {
            //AAA//
            Menu item = new Menu();
            MenuRepository menuRepo = new MenuRepository();
            
            Menu item1 = new Menu(8, "Portabellawhich", "Porteblla Muchroom Sandwhich", "Portabella Mushroom,sandwhich condiments,", 9.70m);
            Menu item2 = new Menu(9, "AB&J", "Classic twist on PB&J using almod butter", "Almond Butter and grape Peserves", 6.50m);
            Menu item3 = new Menu(10, "Pad thai", "Classic Pad thai", "noodles,quiona,curry,tofu", 13.28m);

            //AA//
            menuRepo.AddToMenuList(item1);

            Menu actual = menuRepo.GetMenuListByNumber(8);




        }
    }

}
