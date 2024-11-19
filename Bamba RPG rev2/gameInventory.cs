using Figgle;
using NAudio.Wave;

namespace Bamba_RPG_rev2
{
    internal class gameInventory
    {
        string text = @"   _____ _        _               ____   __   __  __                _    _ 
  / ____| |      | |             / __ \ / _| |  \/  |              | |  (_)
 | (___ | |_ __ _| |_ ___  ___  | |  | | |_  | \  / | ___ _ __ __ _| | ___ 
  \___ \| __/ _` | __/ _ \/ __| | |  | |  _| | |\/| |/ _ \ '__/ _` | |/ / |
  ____) | || (_| | ||  __/\__ \ | |__| | |   | |  | |  __/ | | (_| |   <| |
 |_____/ \__\__,_|\__\___||___/  \____/|_|   |_|  |_|\___|_|  \__,_|_|\_\_|
                  |_   _|  | |  / ____|            | |                     
                    | |  __| | | |     __ _ _ __ __| |                     
                    | | / _` | | |    / _` | '__/ _` |                     
                   _| || (_| | | |___| (_| | | | (_| |                     
                  |_____\__,_|  \_____\__,_|_|  \__,_|                     
                                                                           
                                                                           ";
        string text1 = @"                                                                                                     
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    
                            .....                               .... ...:::::.....                  
            . .............::::::::::::::::::::::::::::::::::::::::::::::::::::::..                 
          .:-+:::::::::::::::::::::::::::::::::::::::::::::::::::::-----------::::..                
          .:-:::-::-:::::::::::::::::::::::::::::::-------------:::-------+%%#-::::..               
          .::::::::::::::-::::::::::::::::::::::::::------------:::-----=*#%%*--:::.                
          .::::::::::::::::-::::::::::::::::::::::::-:.....=%@#--::----+#%#=---:::..                
          .**=-:::::::::::-:::::::::::::::::::::::::-.    .-%@%=--::-=#%*-----::::.                 
           *%%%%%*=-:::::::::::::::::::::::::::::::-.     .+%@#--:::::::::::::::::.                 
          .*%%%%%%%#::::::::::::::::::::::::::::::::.    ..%%%---::::::::::::::::-..                
          .*%%%%%%%+:::::::::-:::::::::::::::-----::.   .:%%:---:-::::::::::::::::-..               
           *%%%-::::::::::::::::::::::::::::#%%%%=::.   ...:-::::-:::::::::::::::::::.              
          .:::::::::::::::::::::::::::::::::#%%%+::-...:-::::----::::::::::::::::::=--.             
          .::::::::::::::::::::::::::::::::::--::::::::::::......-::::::::::::::::+#%*:.            
          .::::::::::::::::::::::::::::::::::::::::::::...      ..:::::::::::::::::###=:.           
          .:::::::::::::::::::::::::::::::::::::::::...           ::::::::::::::::::::-+.           
          ..:.:%+::::::::::::::::::::::::::::--::::..             ::::::::::::::::-+*#%%:           
              ..........::::::::::::::::::::::--::..              ::::::::::::-+#%%%%#%%:           
                       ..:::::::::::::....:..:...                 .::::::::-#%%%%%%%%%%%:           
                        ............                               .:-:::::#%%%%%%%%%%*:.           
                                                                    .:--=*%%%%%%%%#+:.              
                                                                     .*%%%%%%%#+..                  
                                                                      .*%%#=..                      
                                                                                                    
                                                                                                    
                                                                                                    
                                                                                                    "; 

        public void inventory()
        {

            while (true)
            {
                var reader2 = new Mp3FileReader("open.mp3");
                var waveOut = new WaveOutEvent();
                waveOut.Init(reader2);
                waveOut.Play();
                Console.Clear();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(FiggleFonts.Ogre.Render("Inventory"));
                Console.WriteLine("Player: " + data.username + " Level: " + data.level + " EXP: " + data.EXP +  " HP: " + data.hp + " Money: " + data.Money + "$");
                Console.WriteLine("Hunger: " + data.Hunger + " Status: " + data.playerStatus);
                Console.WriteLine("Strength: " + data.Strength + " Defense : " + data.Strength + " Intelligence: " + data.Intelligence + " Confidence: " + data.confidence);
                Console.WriteLine("Inventory:");

                if (data.ID == true)
                {
                    Console.WriteLine("ID-Card");
                }
                if (data.Taser == true)
                {
                    Console.WriteLine("Taser");
                }

                Console.WriteLine("");
                Console.WriteLine("To use a item, write it's name.");
                Console.WriteLine("\nOtherwise, type Exit to exit...");
                string input = Console.ReadLine();
                var reader3 = new Mp3FileReader("close.mp3");
                var waveOut1 = new WaveOutEvent();
                waveOut1.Init(reader3);
                waveOut1.Play();
                switch (input.ToLower())
                {
                    case "exit":
                        Console.Clear();
                        return;
                    case "id-card":
                        ID();
                        break;
                    case "taser":
                        Taser();
                        break;
                }
            }

        }
        public void tutorialInventory()
        {

            Console.Clear();
            var url = "https://github.com/Bambaclad1/bamba_data/raw/main/youtube_em90nk7nZQo_audio.mp3";
            using (var mf = new MediaFoundationReader(url))
            using (var wo = new WasapiOut())
            {
                wo.Init(mf);
                wo.Play();
                while (wo.PlaybackState == PlaybackState.Playing)
                {
                    Console.WriteLine("Got access to inventory!");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            while (true)
            {
                Console.WriteLine("Now you got your inventory, This is your inventory tutorial.");
                Console.WriteLine("For now, you have nothing! Except for money. You can always open it at choicemenus typing /inventory");
                Console.WriteLine("Hunger is measured from 0 to 10 with 10 being really hungry and 0 being not hungry.");
                Console.WriteLine("Open it now by typing /inventory. Try it!");
                string input = Console.ReadLine();

                if (input == "/inventory")
                {
                    inventory();
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        public void ID()
        {
            Console.Clear();
            Console.WriteLine(text);
            Console.WriteLine("This Identifaction card may only be held by its owner. Any abuse will be registered to the System.");
            Console.WriteLine("This is a card which is used to identify yourself, not having this card while being outside results in a cash penalty.");
            Console.WriteLine();
            Console.WriteLine("Legal Name: " + data.username);
            Console.WriteLine("Legal Age: " + data.age);
            Console.WriteLine("Gender: M");
            Console.WriteLine("Born in: Meraki");
            Console.WriteLine("Expiration Date: 15 October 2028");
            Console.WriteLine();
            Console.ReadLine();
        }

        public void Taser()
        {
            Console.Clear();
            Console.WriteLine(text1);
            Console.WriteLine(@"
                                UNAUTHORIZED PRODUCT, NO WEAPONS PERMIT DETECTED!
                                UNAUTHORIZED USER, CANNOT AUTHENTICATE USER!

                                ERROR 404: CANNOT CONNECT SYSTEM
                                Please dial the Police Support Line (0900-8844)");
            Console.ReadLine();
        }
    }
}
