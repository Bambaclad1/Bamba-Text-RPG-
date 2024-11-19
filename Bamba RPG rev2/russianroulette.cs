using NAudio.Wave;
using System;

namespace Bamba_RPG_rev2
{
    internal class Russianroulette
    {
        static Mp3FileReader reader = new Mp3FileReader("toby_fox_hearthache.mp3");
        static WaveOutEvent waveOut = new WaveOutEvent();
        private int numPlayers;
        private int currentPlayerIndex;
        private bool[] chambers;

        public Russianroulette()
        {
            numPlayers = 0;
            currentPlayerIndex = 0;
        }

        public void PlayerSetup()
        {
            Console.Clear();
            waveOut.Init(reader);
            waveOut.Play();

            while (true)
            {
                Console.WriteLine("How many players will play Russian Roulette? (Max 6.)");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numPlayers) && numPlayers > 0 && numPlayers <= 6)
                {
                    Console.WriteLine($"{numPlayers} players will play Russian Roulette.");
                    chambers = new bool[6]; // Initialize chambers array
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Game();
        }

        public void Game()
        {
            Random rand = new Random();

            for (int i = 0; i < chambers.Length; i++)
            {
                chambers[i] = false;
            }

            int bulletIndex = rand.Next(6);
            chambers[bulletIndex] = true;

            while (true)
            {
                Console.WriteLine($"Player {currentPlayerIndex + 1}, press Enter to pull the trigger...");
                Console.ReadLine();

                if (chambers[currentPlayerIndex])
                {
                    Console.WriteLine($"Player {currentPlayerIndex + 1} is dead!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Player {currentPlayerIndex + 1} survived!");
                    currentPlayerIndex = (currentPlayerIndex + 1) % numPlayers;
                }

            }
            waveOut.Stop();
        }

    }
}
