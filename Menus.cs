using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EloBuddy;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    internal class Menus
    {
        public static Menu FirstMenu;
        public static Menu ComboMenu;
        public static Menu DrawingsMenu;

        public static void CreateMenu()
        {
            FirstMenu = MainMenu.AddMenu(Player.Instance.ChampionName, Player.Instance.ChampionName.ToLower() + "Template");
            ComboMenu = FirstMenu.AddSubMenu("Titans EX");
            DrawingsMenu = FirstMenu.AddSubMenu("Drawings Ex");

            //TEST COMBO
            ComboMenu.AddGroupLabel("Combo Settings");
            ComboMenu.Add("Q", new CheckBox("Use Q"));
            ComboMenu.Add("W", new CheckBox("Use W"));
            ComboMenu.Add("E", new CheckBox("Use E"));
            ComboMenu.Add("R", new CheckBox("Use R"));

            //Drawings
            DrawingsMenu.AddGroupLabel("Drawings Settings");
            DrawingsMenu.Add("Q", new CheckBox("Draw Q"));
            DrawingsMenu.Add("W", new CheckBox("Draw W"));
            DrawingsMenu.Add("E", new CheckBox("Draw E"));
            DrawingsMenu.Add("R", new CheckBox("Draw R"));



        }
    }
}
