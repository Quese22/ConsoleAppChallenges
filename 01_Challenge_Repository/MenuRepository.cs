using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class MenuRepository
    {
        List<Menu> _menuList = new List<Menu>();

        public void AddToMenuList(Menu items)
        {
            _menuList.Add(items);
        }

        public void RemoveMenuItemsFromList(int mealNumber)
        {
            foreach (Menu item in _menuList)
            {
                if (item.MealNumber == mealNumber)
                {
                    _menuList.Remove(item);
                        break;

                }
            }
            
        }

        public List<Menu> GetMenuList()
        {
            return _menuList;
        }

        public Menu GetMenuListByNumber(int mealnumber)
        {
            foreach (Menu item in _menuList)
            {
                if (item.MealNumber == mealnumber)
                {
                    return item;

                }
            }
                return null;
     
        }
        public void SeedList()
        {
            Menu fooditem = new Menu(1, "Impossible burger", "Vegan Burger", "setan,nuts,tofu,burger condiments", 15.50m);
            Menu fooditem2 = new Menu(2, "Chickenless chicken sandwhich", "Vegan Chicken sandwhich", "soy protein, quiona,wheat", 16.75m);
            Menu fooditem3 = new Menu(3, "Pulled Jackfruit", "Vegan pulled pork", "jackfruit,lawrys,BBQ sauce", 20.18m);
            Menu fooditem4 = new Menu(4, "Burger", "traditional American burger", "burger condiments,coleslaw,egg,onion rings", 17.45m);

            AddToMenuList(fooditem);
            AddToMenuList(fooditem2);
            AddToMenuList(fooditem3);
            AddToMenuList(fooditem4);



        }



    }
}
