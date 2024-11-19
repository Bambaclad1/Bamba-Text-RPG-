namespace Bamba_RPG_rev2
{
    internal class data
    {
        internal static int level = 0;
        internal static int EXP = 0;
        internal static int age = 16;
        internal static int Hunger = 6;
        internal static float Money = 5.00f;
        internal static int hp = 20;
        internal static int Strength = 1;
        internal static int Intelligence = 1;
        internal static int Defense = 1;
        internal static string playerStatus = "Normal";

        internal static string Enemy1Name = "null";
        internal static int Enemy1HP = 5;
        internal static int Enemy1Strength = 1;
        internal static int Enemy1Defense = 1;
        internal static int Enemy1Speed = 0;
        internal static float MoneyDrop = 0;
        internal static int EXPDrop = 0;

        internal static bool Level1 = false;
        internal static bool Level2 = false;
        internal static bool Level3 = false;
        internal static bool Level4 = false;
        internal static bool Level5 = false;
        internal static bool Level6 = false;
        internal static bool Level7 = false;
        internal static bool Level8 = false;
        internal static bool Level9 = false;
        internal static bool Level10 = false;

        /* Player Statusses:
         * Normal
         * Energised + 5 strength
         * Sad + 5 hp
         * Focused + 5 strength || + 5 intelligence
         * Anxious + 5 defense
         * Angry + 5 strength || + 5 speed || - 10 defense

         * Bored
         * Silly
         * Confused
         */
        internal static int confidence = 0;
        internal static string username = "Player";
        //look, i asked chatgpt for the yes and no words
        internal static string noWords = "nuh uh, no, nah, nope, negative, not at all, absolutely not, certainly not, definitely not, surely not, by no means, never, no way, not really, not likely, unlikely, not a chance, no siree, no thanks, no way Jose, not in a million years, not on your life, nope, nada, nay, not on your nelly, no siree Bob, no can do, not for all the tea in China, no go, no dice, not on your watch, not on your tintype, not for love or money, not by a long shot, not in a month of Sundays, not on your sweet life, not in your wildest dreams, not in a blue moon, not in this lifetime, not if I can help it, not if I know it, not in this day and age, not for all the gold in Fort Knox, not for all the tea in China, not for all the money in the world, not on your tintype, not on your life, not on your nelly, not on your sweet life, not on your watch, not on your wildest dreams, not really, not likely, unlikely, absolutely not, certainly not, definitely not, surely not, not a chance, no siree, no thanks, no way Jose, not in a million years, not for love or money, no can do, not in this day and age, not if I can help it, not if I know it, not in this lifetime, not for all the gold in Fort Knox, not for all the tea in China, not for all the money in the world, not in a blue moon, not in this day and age, not if I can help it, not if I know it, not in this lifetime, not for all the gold in Fort Knox, not for all the tea in China, not for all the money in the world, no go, no dice, not on your watch, not on your tintype, not for love or money, not by a long shot, not in a month of Sundays, not if I know it, not for all the money in the world, not for all the gold in Fort Knox, not for all the tea in China, not in this day and age, not if I can help it, not in this lifetime, not really, not likely, unlikely, absolutely not, certainly not, definitely not, surely not, not a chance, no siree, no thanks, no way Jose, not in a million years, not for love or money, no can do, not in a blue moon, not in this day and age, not for all the gold in Fort Knox, not for all the tea in China, not for all the money in the world, not on your tintype, not on your life, not on your nelly, not on your sweet life, not on your watch, not on your wildest dreams, not really, not likely, unlikely, not at all, absolutely not, certainly not, definitely not, surely not, by no means, never, no way, not really, not likely, unlikely, not a chance, no siree, no thanks, no way Jose, not in a million years, not for love or money, nope, nada, nay, not on your nelly, no siree Bob, no thanks, no way Jose, not in a million years, not for love or money, nope, nada, nay, not on your nelly, no siree Bob, not in a month of Sundays, not if I can help it, not if I know it, not in a blue moon, not in this day and age, not for all the gold in Fort Knox, not for all the tea in China, not for all the money in the world, not on your tintype, not on your life, not on your nelly, not on your sweet life, not on your watch, not on your wildest dreams, not really, not likely, unlikely, absolutely not, certainly not, definitely not, surely not, not a chance, no siree, no thanks, no way Jose, not in a million years, not for love or money, no can do, not in this day and age, not if I can help it, not if I know it, not in this lifetime, not for all the gold in Fort Knox, not for all the tea in China, not for all the money in the world, not in a blue moon, not in this day and age, not if I can help it, not if I know it, not in this lifetime, not for all the gold in Fort Knox, not for all the tea in China, not for all the money in the world, no go, no dice, not on your watch, not on your tintype, not for love or money, not by a long shot, not in a month of Sundays, not if I know it, not for all the money in the world, not for all the gold in Fort Knox, not for all the tea in China, not in this day and age, not if I can help it, not in this lifetime, not really, not likely, unlikely, absolutely not, certainly not, definitely not, surely not, not a chance, no siree, no thanks, no way Jose, not in a million years, not for love or money, no can do, not in a blue moon, not in this day and age, not for all the gold in Fort Knox, not for all the tea in China, not for all the money in the world, not on your tintype, not on your life, not on your nelly, not on your sweet life, not on your watch, not on your wildest dreams, not really, not likely, unlikely, not at all, absolutely not, certainly not, definitely not, surely not, by no means, never, no way, not really, not likely, unlikely, not a chance, no siree, no thanks";
        internal static string yesWords = "yuh uh, yuuuhh, yurr, yup, yoohoo, yesss, yes!, yuuh, motherfucking yes, yes, yeah, yep, absolutely, certainly, indeed, positively, definitely, surely, of course, without a doubt, unquestionably, naturally, for sure, undoubtedly, absolutely, most certainly, sure thing, no doubt, sure, definitely, affirmative, for sure, sure enough, absolutely right, absolutely sure, true, precisely, undoubtedly, indubitably, without question, gladly, willingly, gladly, gladly so, gladly yes, by all means, by all odds, for certain, for a fact, for real, forsootbt, wih, no ifs, ands, or buts, exactly, precisely, positively, unquestionably, without a douthout fail, yea, yup, certainly, definitely, of course, by all means, naturally, surely, absolutely, for sure, indeed, undoubtedly, unquestionably, affirmative, without a doubt, most certainly, true, very well, as you say, amen, roger, fine, all right, right on, agreed, okay, sure thing, you bet, no problem, alrighty then, for sure, yeah buddy, you got it, absolutely right, right you are, sure as shooting, damn right, damn straight, you said it, amen to that, can do, for sure, sure thing, you betcha, you got it, no problem, that's correct, absolutely, precisely, indeed, affirmative, alright, agreed, roger, exactly, naturally, of course, positively, true, very well, yup, okay, sure, fine, right, by all means, absolutely, for sure, undoubtedly, without a doubt, unquestionably, certainly, definitely, indubitably, without reservation, without question, no doubt, for a fact, as you say, so be it, so it is, so say we all, good, agreed, you said it, that's right, correct, absolutely right, amen, right on, all right, alrighty then, for sure, no problem, you bet, sure thing, yep, yeah buddy, sure, affirmative, indeed, absolutely, you got it, can do, okay, agreed, fine, right, naturally, precisely, positively, true, very well, sure as shooting, damn right, damn straight, you said it, amen to that, that's correct, absolutely right, right you are, you know it, absolutely, for sure, undoubtedly, unquestionably, certainly, definitely, indubitably, without question, no doubt, for a fact, as you say, so be it, so it is, so say we all, good, alright, agreed, you said it, that's right, correct, absolutely right, amen, right on, all right, alrighty then, for sure, no problem, you bet, sure thing, yep, yeah buddy, sure, affirmative, indeed, absolutely, you got it, can do, okay, agreed, fine, right, naturally, precisely, positively, true, very well, sure as shooting, damn right, damn straight, you said it, amen to that, that's correct, absolutely right, right you are, you know it";
        internal static Boolean ID = false;
        internal static Boolean Taser = false;

        internal static void hungerCheck()
        {
            if (data.Hunger < 0)
            {
                data.Hunger = 0;
            }
            return;
        }
    }
}
