using Figgle;
using NAudio.Wave;

namespace Bamba_RPG_rev2
{
    internal class Chapter0
    {
        // make a username character limit - greetings to axeone
        gameInventory inv = new gameInventory();
        Store store = new Store();
        data data = new data();
        BattleSystem battleSystem = new BattleSystem();
        public void Title()
        {
            Console.WriteLine("This game uses ASCII art. Please open this program in a modern terminal application, or maximalize the window for the best experience.");
            Console.ReadLine();
            Console.Clear();
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.Write("C");
            System.Threading.Thread.Sleep(50);
            Console.Write("h");
            System.Threading.Thread.Sleep(50);
            Console.Write("a");
            System.Threading.Thread.Sleep(50);
            Console.Write("p");
            System.Threading.Thread.Sleep(50);
            Console.Write("t");
            System.Threading.Thread.Sleep(50);
            Console.Write("e");
            System.Threading.Thread.Sleep(50);
            Console.Write("r");
            System.Threading.Thread.Sleep(50);
            Console.Write(" ");
            System.Threading.Thread.Sleep(50);
            Console.Write("0");
            System.Threading.Thread.Sleep(50);
            Console.Write(" ");
            System.Threading.Thread.Sleep(50);
            Console.Write("S");
            System.Threading.Thread.Sleep(50);
            Console.Write("t");
            System.Threading.Thread.Sleep(50);
            Console.Write("a");
            System.Threading.Thread.Sleep(50);
            Console.Write("r");
            System.Threading.Thread.Sleep(50);
            Console.WriteLine("t");
            System.Threading.Thread.Sleep(2000);
            return;
        }
        public void map1()
        {
            Console.Clear();
            Console.WriteLine("Mom: " + data.username + " ?");
            Console.ReadLine();
            Console.WriteLine("Mom: ?");
            Console.ReadLine();
            Console.WriteLine("Mom: " + data.username + "!");
            Console.ReadLine();
            Console.WriteLine("Mom:" + " WAKE UP! ");
            Console.ReadLine();
            Console.WriteLine(data.username + ": ...");
            Console.ReadLine();
            Console.WriteLine(data.username + ": yeahyeah im up..");
            Console.ReadLine();
            Console.Clear();
            bool input1bool = true;
            while (input1bool)
            {

                Console.WriteLine("Waking up, what do you do?");
                Console.WriteLine("A, to check the time, B to stand up");
                string input1 = Console.ReadLine();
                Console.Clear();
                switch (input1.ToLower())
                {
                    case "a":
                        Console.WriteLine("Hovering to your phone, seeing the time is 6:40.");
                        Console.ReadLine();
                        break;
                    case "b":
                        Console.Clear();
                        input1bool = false;
                        break;
                    case "/inventory":
                        inv.inventory();
                        break;
                }
            }
            bool input2bool = true;
            while (input2bool)
            {
                Console.WriteLine("You stood up, washed your face, brushed your teeth,");
                Console.WriteLine("What do you eat?");
                Console.WriteLine("A - slap a sandwich with cheese.");
                Console.WriteLine("B - slap a sandwich with chicken.");
                Console.WriteLine("C - A good grilled toast.");
                string input2 = Console.ReadLine();
                Console.Clear();
                switch (input2.ToLower())
                {
                    case "a":
                        Console.WriteLine(data.username + ": 'That was a nice sandwich.'");
                        Console.WriteLine("Hunger satisfied!");
                        data.Hunger = 5;
                        input2bool = false;
                        break;
                    case "b":
                        Console.WriteLine(data.username + ": 'That was a nice sandwich.'");
                        Console.WriteLine("Hunger satisfied!");
                        data.Hunger = 5;
                        input2bool = false;
                        break;
                    case "c":
                        Console.WriteLine(data.username + ": 'mmm.. nothing goes wrong against a nice sandwich.'");
                        Console.WriteLine("Hunger largly satisfied!");
                        data.Hunger = 3;
                        input2bool = false;
                        break;
                    case "/inventory":
                        inv.inventory();
                        break;
                }
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Mom: Hey, {data.username}? You should not forget your ID-Card!");
            Console.WriteLine("Mom: I forgot to tell you yesterday that it was sent to our postmail!");
            Console.ReadLine();
            data.ID = true;
            var reader2 = new Mp3FileReader("got item.mp3");
            var waveOut = new WaveOutEvent();
            waveOut.Init(reader2);
            waveOut.Play();
            Console.WriteLine("ID-Card got!");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("Mom: Don't lose it again!");
            Console.ReadLine();
            Console.WriteLine($"{data.username}: Thanks mom!");
            Console.ReadLine();
            Console.WriteLine("Mom: Now hurry up to school!");
            Console.ReadLine();
            Console.WriteLine($"{data.username}: Yeahyeah...");
            Console.WriteLine("You left home.");
            var reader3 = new Mp3FileReader("doorclose.mp3");
            var waveOut1 = new WaveOutEvent();
            waveOut1.Init(reader3);
            waveOut1.Play();
            System.Threading.Thread.Sleep(3500);
            Console.Clear();
            bool input4bool = true;
            while (input4bool)
            {
                Console.WriteLine("You are now on a train on your way to school. The time is 7:10.");
                Console.WriteLine("Out of boredom, what are you gonna do on the train?");
                Console.WriteLine("A, look at random people in the train and stare away when they see you");
                Console.WriteLine("B, Stare outside");

                string input4 = Console.ReadLine();
                Console.Clear();
                switch (input4.ToLower())
                {
                    case "a":
                        Console.WriteLine("You felt silly after looking at random people looking back fast.");
                        Console.WriteLine("You felt silly.");
                        data.playerStatus = "Silly";
                        input4bool = false;
                        break;
                    case "b":
                        Console.WriteLine("You stared outside.");
                        Console.WriteLine("You felt focused.");
                        data.playerStatus = "Focused";
                        input4bool = false;
                        break;
                    case "/inventory":
                        inv.inventory();
                        break;
                }

            }
            System.Threading.Thread.Sleep(2000);
            Console.ReadLine();
            Console.WriteLine("Annoucer: Station Meraki Centre, now arriving at Station Merkai Centre. You may switch to the public transport bus to travel around.");
            Console.WriteLine("(I got to get off as this station, and just a 5 minute walk.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Walking to school, the memories were flooding back.");
            Console.ReadLine();
            Console.WriteLine("The group of bullies is still there, better avoid em.");
            Console.ReadLine();
            Console.WriteLine("The warm air from the door floodes inside your body, it felt welcoming yet eerie...");
            Console.ReadLine();
            bool input5bool = true;
            while (input5bool)
            {
                Console.WriteLine("There are 20 minutes left, what would you do now? You are located in the school halls.");
                Console.WriteLine("What would you do?");
                Console.WriteLine("A, Eat something at the school cafeteria");
                Console.WriteLine("B, Scroll through tiktok on your phone");
                Console.WriteLine("C, Go on the computers");



                string input5 = Console.ReadLine();
                Console.Clear();
                switch (input5.ToLower())
                {
                    case "a":
                        store.cafeteriaStore();
                        input5bool = false;
                        break;
                    case "b":
                        Console.WriteLine("You scrolled thorugh tiktok on your phone.");
                        Console.WriteLine("felt like a waste of time ngl.");
                        input5bool = false;
                        break;
                    case "c":
                        Console.WriteLine("You went on the computers.");
                        Console.WriteLine("By searching random topics on wikipedia, you gained more information.");
                        Console.WriteLine("You felt more educated.");
                        Console.WriteLine("Intelligence + 1!");
                        data.Intelligence = data.Intelligence + 1;
                        input5bool = false;
                        break;
                    case "/inventory":
                        inv.inventory();
                        break;
                }
            }
            Console.ReadLine();
            Console.Clear();
            bool input6bool = true;
            while (input6bool)
            {
                Console.WriteLine("Looks like its 8:15, you have some time left to roam around the buildings");
                Console.WriteLine("What would you do?");
                Console.WriteLine("A, Go through the cafeteria");
                Console.WriteLine("B, Go around in the halls");
                Console.WriteLine("C, Go outside");



                string input6 = Console.ReadLine();
                Console.Clear();
                switch (input6.ToLower())
                {
                    case "a":
                        cafeteria();
                        input6bool = false;
                        break;
                    case "b":
                        halls();
                        input6bool = false;
                        break;
                    case "c":
                        outsidesSchool();
                        input6bool = false;
                        break;
                    case "/inventory":
                        inv.inventory();
                        break;
                }
            }

        }
        // make all 3 options notify player about recent event, something rpg like
        
        // There was a massive earthquake yesterday night, and rumors about the statistics that the violence of people has dramatically been increased!
        // DUring walking to a class, the player will find a small glass capsule hanging and grabs it.
        // Eventually, he dropped it, making his body shrink into the ground and turning into a dark blue environment, like he turned upside down
        // but his vision is corrected.
        
        
        public void cafeteria()
        {
            Console.WriteLine("You went to the cafeteria");
            Console.ReadLine();
            Console.WriteLine("There are a few small groups of people, some who play a cards game, some who are on their phones,");
            Console.WriteLine("But that is kind of it.");
            Console.ReadLine();
            Console.WriteLine($"Rick: Hey, {data.username}! Come grab a coffee and talk to me! It's on the house!");
            Console.ReadLine();
            Console.WriteLine("You decided to walk to Rick.");
            Console.ReadLine();
            Console.WriteLine($"Rick: So, {data.username}, enjoying the coffee? (y/n)");

            string answer1 = Console.ReadLine();

            string[] yesWordsArray = data.yesWords.Split(',');
            if (yesWordsArray.Any(word => answer1.ToLower().Contains(word.Trim())))
            {
                Console.WriteLine("Rick: Hey, its nice to have another coffee lover around here!");
                Console.ReadLine();
                return;
            }
            else if (answer1.Contains('y'))
            {
                Console.WriteLine("Rick: Hey, its nice to have another coffee lover around here!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Rick: Oh, i thought coffee was your thing, oh well...");
                Console.ReadLine();
            }
            Console.ReadLine();
            Console.WriteLine($"Rick: Anyways, i called you here to tell you something.");
            Console.ReadLine();
            Console.WriteLine("Rick: Yesterday, there has been a earthquake.");
            Console.ReadLine();
            Console.WriteLine("Rick: The vibe of everyone.. feels different.");
            Console.ReadLine();
            Console.WriteLine("Rick: Anyways, i have something for you. I feel worried about you, be careful with it.");
            Console.ReadLine();
            var reader2 = new Mp3FileReader("got item.mp3");
            var waveOut = new WaveOutEvent();
            waveOut.Init(reader2);
            waveOut.Play();
            Console.WriteLine("Taser got!");
            data.Taser = true;
            Console.WriteLine();
            System.Threading.Thread.Sleep(3000);
            Console.ReadLine();
            Console.WriteLine("Rick: I only want you to use this for emergencys.");
            Console.ReadLine();
            Console.WriteLine("Rick: Oh, its 8:30 already! Go head to your class!");
            map2();
        }

        public void halls()
        {
            Console.WriteLine($"Walking through the school halls, you saw your classmate sitting on the bench.");
            Console.ReadLine();
            Console.WriteLine($"Auri: Wait {data.username}! Did you hear about the earthquake from last night causing people to act...different?");
            Console.ReadLine();
            Console.WriteLine($"{data.username}: Earthquake..? No, i didn't.");
            Console.ReadLine();
            Console.WriteLine($"Auri: Well, the news reporters said that they were acting more violent for some reason...");
            Console.ReadLine();
            Console.WriteLine($"{data.username}: That sounds... horrible.");
            Console.ReadLine();
            Console.WriteLine($"Auri: It is! Well, just be careful now!");
            Console.ReadLine();
            Console.WriteLine($"{data.username}: I will! Thank you!");
            Console.ReadLine();
            map2();
        }

        public void outsidesSchool()
        {
            Console.WriteLine("You got a notification on your phone.");
            Console.ReadLine();
            Console.WriteLine("It is a notification from Instagram, which shows a populair feed.");
            Console.ReadLine();
            Console.WriteLine(@"""Just in! Earthquake from yesterday may be cause for violence in people?""");
            Console.ReadLine();
            Console.WriteLine("(Earthquake...?)");
            Console.ReadLine();
            Console.WriteLine("(Eh, whatever.. there won't be anything happening here..");
            Console.ReadLine();
            map2();
        }

        public void map2()
        {
            Console.WriteLine("You walked through the halls to your class.");
            Console.ReadLine();
            Console.WriteLine("Theres a amulet in your arm, its tilting.");
            Console.ReadLine();
            Console.WriteLine("And suddenly..");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It drops.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It's falling in slowmotion.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It falls in a puddle.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It's like the world just hit a buffer pause.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Everything is turning dark blue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(".");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("..");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("It's the same place you were at, although be it a dark blue dimension like.");
            Console.ReadLine();
            Console.WriteLine("It reminds you of the dark hour of Persona 3, but that is something else");
            Console.ReadLine();
            Console.WriteLine("Looking around you, questioning what is happening and probably panicking, a person who is hidden under a mask runs to you");
            Console.ReadLine();

            data.Enemy1Name = "Masked Man";
            data.MoneyDrop = 5;
            data.Enemy1HP = 10;
            data.Enemy1Defense = 1;
            data.Enemy1Speed = 0;
            data.Enemy1Strength = 2;
            data.EXPDrop = 5;

            battleSystem.BattleSystemv1();

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Jeez.. why did that man approach me.. What even is this place..?");
            Console.ReadLine();
            Console.WriteLine("He did hurt me but i managed to win.. i hope...");
            Console.ReadLine();
            Console.WriteLine("You collapse on the ground.");
            Console.WriteLine(FiggleFonts.Ogre.Render("Chapter 0 end."));
            Console.ReadLine();

        }

    }
}












