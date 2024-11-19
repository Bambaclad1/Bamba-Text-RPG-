using Figgle;
using NAudio.Wave;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;

namespace Bamba_RPG_rev2
{
    internal class Program
    {
        static Mp3FileReader reader = new Mp3FileReader("mariokart.mp3");
        static WaveOutEvent waveOut = new WaveOutEvent();
        static bool TrialVersion = true;
        static void Main(string[] args)
        {
            BattleSystem battlesystem = new BattleSystem();
            gameInventory mijnInventory = new gameInventory();
            GameSetup mijnGame = new GameSetup();
            Chapter0 c0 = new Chapter0();
            Program p = new Program();
            Store store = new Store();

            mijnGame.Title();


            waveOut.Init(reader);
            waveOut.Play();

            p.title();

            mijnGame.CharacterSetup();
            mijnGame.GetAge();
            waveOut.Stop();

            mijnInventory.tutorialInventory();
            c0.Title();
            c0.map1();

            if (TrialVersion)
            {
                p.creditsTrial();
            }


        }

        public void title()
        {
            Console.WriteLine(FiggleFonts.Ogre.Render("Bamba's Text Rpg! - Git Update Final"));
            Console.WriteLine("A RPG game for your commandline with love and care by bamba!");
            Console.WriteLine("\nPress Enter to continue...");
            string input = Console.ReadLine();
            if (input == ":3")
            {
                waveOut.Pause();
                Console.WriteLine("Played the wildcard.");
                while (true)
                {
                    debug.Debug();
                }

            }
        }

        public void creditsTrial()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing...");
            Console.WriteLine(FiggleFonts.Ogre.Render("Bamba's Text Rpg!"));
            Console.WriteLine($@"
            ____________________________________________________________________________________________________________
            |I really hope that you enjoyed this game. This is my first text RPG game i made.                          |
            |To dissapoint you, this is just the demo. I might make more chapters too, and                             |
            |i would like to tell you that i put my dedication and creativity in this project.                         |
            |                                                                                                          |
            |This is the end of chapter zero, just the prologe. This has been inspired by Persona and Final Fantasy.   |
            |Please shout some suggestions for my game and bugs at my github or discord. It's really much appriciated. |
            |Take care!                                                                                                |
            ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
                            Bamba's Text RPG made by");
            Console.WriteLine(FiggleFonts.Ogre.Render("Raman Cooperation"));
            Console.WriteLine("also known as: Bambaisbanned, bambito, bambaclad1");
            Console.ReadLine();








        }
    }
}
