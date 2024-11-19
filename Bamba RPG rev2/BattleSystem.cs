using Figgle;
using NAudio.MediaFoundation;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamba_RPG_rev2
{
    internal class BattleSystem
    {
        data data = new data();
        static Mp3FileReader reader = new Mp3FileReader("battletheme.mp3");
        static WaveOutEvent waveOut = new WaveOutEvent();
        public void BattleSystemv1()
        {
            Console.Clear();
            waveOut.Init(reader);
            waveOut.Play();
            Console.WriteLine(FiggleFonts.Ogre.Render("Battle Start!"));
            Console.WriteLine($"Enemy {data.Enemy1Name} approached you!");

            while (data.Enemy1HP > 0 && data.hp > 0)
            {
                GiveStatus();
                BattleSystemv1Menu();
                BattleSystemv1EnemyTurn();
            }

            waveOut.Stop();
            if (data.Enemy1HP <= 0)
            {
                BattleSystemv1Victory();
                // add victory sound
            }
            else if (data.hp <= 0)
            {
                BattleSystemv1Loss();
            }
        }


        public void GiveStatus()
        {
            Console.WriteLine($"{data.username} has {data.hp} HP!");
            Console.WriteLine($"{data.Enemy1Name} has {data.Enemy1HP} HP!");
            Console.ReadLine();
            Console.Clear();
        }

        public void BattleSystemv1Menu()
        {
            while (true)
            {
                Console.WriteLine("What do you do?");
                Console.WriteLine(" 1 - Fight");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        BattleSystemv1Fight();
                        break;
                }
                Console.Clear();
                break;
            }
        }

        public void BattleSystemv1Fight()
        {
            bool punch = false;
            bool kick = false;
            bool taser = false;
            int attackDamage = data.Strength;

            Random random = new Random();
            while (true) {
                Console.Clear();
                Console.WriteLine("What do you do?");
                Console.WriteLine($@"1 - Punch (Punches the enemy.Can hit a fatal spot.)");
                Console.WriteLine($@"2 - Kick  (Kicks the enemy. Can give STUN.)");
                if (data.Taser == true)
                {
                    Console.WriteLine($@"Taser - Taser (Tases the enemy.)");
                }
                
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        punch = true;

                    break;
                    case "2":
                        kick = true;
                        break;
                    case "Taser":
                        if (data.Taser)
                        {
                            taser = true;
                        }
                        break;
                }
                break;
            }
            Console.Clear();

            if (punch)
            {
                attackDamage = attackDamage + 2;
                Console.WriteLine("You packed him a punch!");
            }

            if (kick)
            {
                attackDamage = attackDamage + 2;
                Console.WriteLine("You kicked him!");
            }
            if (taser)
            {
                attackDamage = attackDamage + 3;
                Console.WriteLine("You tased him!");
            }
            int effectiveness = random.Next(1, 6);

            switch (effectiveness)
            {
                case 1:
                    Console.WriteLine("Got a decent hit!");
                    break;
                case 2:
                    Console.WriteLine("Got a decent hit!");
                    break;
                case 3:
                    Console.WriteLine("Got a decent hit!");
                    break;
                case 4:
                    Console.WriteLine("A lucky hit! It was very effective!!");
                    attackDamage = attackDamage * 2;
                    break;
                case 5:
                    Console.WriteLine("That was not very effective!");
                    attackDamage = attackDamage / 2;
                    break;
            }
            data.Enemy1HP = data.Enemy1HP - attackDamage;
            Console.WriteLine($"You did {attackDamage} damage!");
            Console.ReadLine();
        }

        public void BattleSystemv1EnemyTurn()
        {
            Random random = new Random();

            Console.Clear();
            Console.WriteLine($"Now its {data.Enemy1Name}'s turn!");
            int effectiveness = random.Next(1, 6);
            int resistance = data.Defense / 2;
            int foeDamage = data.Enemy1Strength - resistance;
            switch (effectiveness)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("You got hit!");
                    break;
                case 4:
                    Console.WriteLine("Your foe got a lucky hit! It was very effective!");
                    foeDamage *= 2;
                    break;
                case 5:
                    Console.WriteLine("He did not hit you well! It was not that effective...");
                    foeDamage /= 2;
                    break;
            }
            data.hp -= foeDamage;
            Console.WriteLine($"You lost {foeDamage} HP!");
            Console.ReadLine();
        }

        public void BattleSystemv1Victory()
        {
            Console.WriteLine("");
            Console.WriteLine("You won!");
            Console.WriteLine($"Got {data.MoneyDrop} euros and {data.EXPDrop} xp!");
            data.Money = data.Money + data.MoneyDrop;
            data.EXP = data.EXP + data.EXPDrop;
            BattleSystemv1LevelUp();
            Console.ReadLine();

        }
        public void BattleSystemv1Loss()
        {
            Console.WriteLine("");
            Console.WriteLine("You lost..");
            Console.WriteLine($"Try again?");
            Console.ReadLine();

        }

        public void BattleSystemv1LevelUp()
        {
            if (!data.Level1 && data.EXP >= 5)
            {
                Console.WriteLine("You reached level 1!");
                data.level = 1;
                BattleSystemv1ChooseBuff();
            }
        }

        public void BattleSystemv1ChooseBuff()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What to level up?");
            Console.WriteLine("1 - HP + 3");
            Console.WriteLine("2 - Strength + 3");
            Console.WriteLine("3 - Defense + 3");
            string choiceString = Console.ReadLine();
            Int32.TryParse(choiceString, out int choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("HP Increased with 3!");
                    data.hp = data.hp + 3;
                    break;
                case 2:
                    Console.WriteLine("Strength increased with 3!");
                    data.Strength = data.Strength + 3;
                    break;
                case 3:
                    Console.WriteLine("Defense increased with 3!");
                    data.Defense = data.Defense + 3;
                    break;
            }
        }
    }
}
