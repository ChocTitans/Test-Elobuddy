using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        public static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.Hero != Champion.Jhin) return;
            Chat.Print("Hello Jhin");
            Menus.CreateMenu();
            Game.OnTick += OnTick;
        }

        public static void OnTick(EventArgs args)
        {
            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo)) ComboExecute();
        }
    }
}
