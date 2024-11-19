namespace Bamba_RPG_rev2
{
    internal class GameSetup
    {
        public void Title()
        {
            // This method is only supposed to run once.
            Console.Write("W");
            System.Threading.Thread.Sleep(50);
            Console.Write("e");
            System.Threading.Thread.Sleep(50);
            Console.Write("l");
            System.Threading.Thread.Sleep(50);
            Console.Write("c");
            System.Threading.Thread.Sleep(50);
            Console.Write("o");
            System.Threading.Thread.Sleep(50);
            Console.Write("m");
            System.Threading.Thread.Sleep(50);
            Console.Write("e");
            System.Threading.Thread.Sleep(50);
            Console.Write(" ");
            System.Threading.Thread.Sleep(50);
            Console.Write("t");
            System.Threading.Thread.Sleep(50);
            Console.Write("o");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(300);
        }

        public void loadAnimation()
        {
            Console.Write("Downloading ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("|");
                Thread.Sleep(200);
                Console.Write("\b");

                Console.Write("/");
                Thread.Sleep(200);
                Console.Write("\b");

                Console.Write("-");
                Thread.Sleep(200);
                Console.Write("\b");

                Console.Write("\\");
                Thread.Sleep(200);
                Console.Write("\b");
            }

        }
        public void GetAge()
        {
            int aAge;

            Console.Clear();
            Console.WriteLine("Username setup passed!");
            Console.WriteLine("wget https://github.com/Bambaclad1/test-website/raw/main/getAge.txt.");
            loadAnimation();
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("How old are you, " + data.username + " ?");
                string input = Console.ReadLine();

                int.TryParse(input, out aAge);

                if (aAge > 11 && aAge < 31)
                {
                    Console.WriteLine("Success!");
                    data.age = aAge;
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid. Age must be from 12 to 30. You are going to high school dude..");
                    Console.ReadLine();
                }
            }
        }
        public void CharacterSetup()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Character Setup Program Version 3.1b");
                Console.WriteLine("");
                Console.Write("A good game would let you pick a good name, go ahead and type one!");
                Console.WriteLine("");
                data.username = Console.ReadLine();
                System.Threading.Thread.Sleep(200);
                Console.Clear();
                System.Threading.Thread.Sleep(100);
                Console.WriteLine(data.username + ", that sure is one unique name.");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Question is, do you like the name? (Y/N)");
                string answer1 = Console.ReadLine();

                string[] yesWordsArray = data.yesWords.Split(',');

                if (yesWordsArray.Any(word => answer1.ToLower().Contains(word.Trim())))
                {
                    Console.WriteLine("Great! You seem to like the name.");
                    Console.ReadLine();
                    return;
                }
                else if (answer1.Contains('y') || answer1.Contains('Y'))
                {
                    Console.WriteLine("Great! You seem to like the name.");
                    return;
                }
                else
                {
                    Console.WriteLine("Oh, it seems you're not a fan of the name... Well, change your name till it suits your likings!");
                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();

                }
            }

        }
    }
}
