using Figgle;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamba_RPG_rev2
{
    internal class Store
    {
        
        public void cafeteriaStore()
        {
            gameInventory inv = new gameInventory();

            var reader = new Mp3FileReader("shop.mp3");
            var waveOut = new WaveOutEvent();
            waveOut.Init(reader);
            waveOut.Play();

            Console.Clear();
            Console.WriteLine(FiggleFonts.Ogre.Render("Store"));
            Console.WriteLine("Welcome to the cafeteria store!");
            Console.ReadLine();
            Console.WriteLine($"Rick: Goodmorning, {data.username}, you came here to grab a bite?");
            Console.ReadLine();
            bool input1bool = true;
            while (input1bool)
            {
                Console.WriteLine($"You currently have {data.Money} euros!");
                Console.WriteLine("A, 2.50$ - Pancake");
                Console.WriteLine("B, 0.50$ - Banana");
                Console.WriteLine("C, 3.50$ - Chicken Nuggets");

                string input1 = Console.ReadLine();
                switch (input1.ToLower())
                {
                    case "A":
                        if (2.50 < data.Money)
                        {
                            Console.WriteLine("Purchased!");
                            Console.WriteLine($"Rick: Here are your pancakes, {data.username}, enjoy them!");
                            Console.ReadLine();
                            Console.WriteLine("You consumed the pancake! Defintely was a good one!");
                            Console.WriteLine("Hunger decreased!");
                            data.Hunger = data.Hunger - 3;
                            data.hungerCheck();
                            input1bool = false;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money..");
                        }
                        break;
                    case "B":
                        if (0.50 < data.Money)
                        {
                            Console.WriteLine("Purchased!");
                            Console.WriteLine($"Rick: Here is your banana, {data.username}, enjoy it!");
                            Console.ReadLine();
                            Console.WriteLine("You consumed the banana! A good energy boost!");
                            Console.WriteLine("Hunger significantly decreased!");
                            data.Hunger = data.Hunger - 1;
                            data.hungerCheck();
                            input1bool = false;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money..");
                        }
                        break;
                    case "C":
                        if (3.50 < data.Money)
                        {
                            Console.WriteLine("Purchased!");
                            Console.WriteLine($"Rick: Here are your chicken nuggets, {data.username}, enjoy them!");
                            Console.ReadLine();
                            Console.WriteLine("You consumed the chicken nuggets! That's a hood classic!");
                            Console.WriteLine("Hunger majorly decreased!");
                            data.Hunger = data.Hunger - 5;
                            data.hungerCheck();
                            input1bool = false;
                        }
                        else
                        {
                            Console.WriteLine("Not enough money..");
                        }
                        break;
                    case "/inventory":
                        inv.inventory();
                        break;
                }
            }
            Console.ReadLine();
            Console.WriteLine("After getting something from the cafeteria, you feel refreshed!");
            Console.ReadLine();
            Console.WriteLine($"Rick: Tell mom that i said hi");
            Console.WriteLine($"{data.username}: Will do!");
            waveOut.Stop();
        }
    }
}
