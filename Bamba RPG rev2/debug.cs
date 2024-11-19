using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamba_RPG_rev2
{
    internal class debug
    {

        internal static void Debug()
        {
            gameInventory mijnInventory = new gameInventory();
            GameSetup mijnGame = new GameSetup();
            Chapter0 c0 = new Chapter0();
            Program p = new Program();
            Store store = new Store();
            Russianroulette russianroulette = new Russianroulette();
            BattleSystem battlesystem = new BattleSystem();
            var reader = new Mp3FileReader("mariokart.mp3");
            var waveOut = new WaveOutEvent();
            waveOut.Stop();
            while (true)
            {
                Console.WriteLine("Welcome to the Debug Menu.");
                Console.ReadLine();

                Console.WriteLine(@"
                1 - p.title();
                2 - mijnGame.CharacterSetup();
                3 - mijnGame.GetAge();
                4 - mijnInventory.tutorialInventory();
                5 - c0.Title();
                6 - c0.map1();
                7 - store.cafeteriaStore();
                8 - mijnInventory.inventory();
                9 - c0.halls();
                10 - c0.cafeteria();
                11 - c0.outsidesSchool();
                12 - russian roulette (Mini-Game) 
                13 - c0.map2(); 
                14 - battlesystem.BattleSystemv1();
                15 - p.creditsTrial();
 ");
              
                Console.WriteLine("You know the drill.");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        p.title();
                        return;
                    case "2":
                        mijnGame.CharacterSetup();
                        return;
                    case "3":
                        mijnGame.GetAge();
                        return;
                    case "4":
                        mijnInventory.tutorialInventory();
                        return;
                    case "5":
                        c0.Title();
                        return;
                    case "6":
                        c0.map1();
                        return;
                    case "7":
                        store.cafeteriaStore();
                        return;
                    case "8":
                        mijnInventory.inventory();
                        return;
                    case "9":
                        c0.halls();
                        return;
                    case "10":
                        c0.cafeteria();
                        return;
                    case "11":
                        c0.outsidesSchool();
                        return;
                    case "12":
                        russianroulette.PlayerSetup();
                        return;
                    case "13":
                        c0.map2();
                        return;
                    case "14":
                        battlesystem.BattleSystemv1();
                        return;
                    case "15":
                        p.creditsTrial();
                        return;
                }
            }

        }
    }
}
