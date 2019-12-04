using Microsoft.Xna.Framework;
using System;
using System.Threading.Tasks;
using WTactics.Enums;
using WTactics.Models;
using WTactics.Services.Interfaces;

namespace WTactics.Services
{
    public class MenuService : IMenuService
    {
        public Task<Menu> GenerateNewMenuAsync()
        {
            var menu = new Menu();
            foreach (var @enum in Enum.GetNames(typeof(MenuOption)))
            {
                var menuItem = new MenuItem(Enum.Parse<MenuOption>(@enum), Vector2.One);
                menu.MenuItems.Add(menuItem);
            }
            foreach (var item in menu.MenuItems)
                Console.WriteLine(item.Menu);
            return Task.FromResult(menu);
        }
    }
}
