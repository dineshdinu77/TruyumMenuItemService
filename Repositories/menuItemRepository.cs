using MenuItemsService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemsService.Repositories
{
    public class menuItemRepository : IRepository<MenuItem>
    {
        static List<MenuItem> menuItems;
        static menuItemRepository()
        {
            menuItems = new List<MenuItem>() {
            new MenuItem(){Id=1,Active=true,category="Icecream",DateOflaunch=DateTime.Parse("30-12-2019"),FreeDelivery=true,Name="Buter Scortch ",Price=100},
            new MenuItem(){Id=2,Active=true,category="Main Course",DateOflaunch=DateTime.Parse("13-11-2020"),FreeDelivery=true,Name="veg pulav",Price=200},
            new MenuItem(){Id=3,Active=false,category="Starters",DateOflaunch=DateTime.Parse("15-07-2020"),FreeDelivery=true,Name="Tandori chicken",Price=200},
            new MenuItem(){Id=4,Active=true,category="Main Course",DateOflaunch=DateTime.Parse("10-10-2020"),FreeDelivery=false,Name="Noodles",Price=300},
            new MenuItem(){Id=5,Active=false,category="snacks",DateOflaunch=DateTime.Parse("17-01-2022"),FreeDelivery=true,Name="Pizza",Price=400}


            };

        }
        public void Add(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

       

        public  IEnumerable<MenuItem> Get()
        {
            return  menuItems;
        }

        public MenuItem GetById(int id)
        {
            var menuitem = menuItems.FirstOrDefault(m => m.Id == id);
            return menuitem;
        }

       
    }
}
