using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer2._0
{
    class Program
    {
        
             static void Main(string[] args)
        {
            Greeting();
            Game game = new Game();
            game.PlayGame();
            AddHighScore(game.Player.PlayerHealth);
            DisplayHighScore();
        }
        static void Greeting()
        {
            Console.WriteLine("HALT!! Who dares approach the dungeon?");
            Console.WriteLine("Look for <<>> to advance past story");
            Console.WriteLine("So warrior, you think you have what it takes to make it through the dungeon\n And defeat the Undead? If so... you are stronger than I was before I tried and failed. My name is Harold and I will guide you as much as I can, I have faith in you, warrior. What are your attacks? .....You don't know!? You must have been hit with a memory spell earlier.\n\nWell from the looks of it you have a sword. <Swords are strong but they only hit 70% of the time. <<You can accsess your sword attack by pressing 1.>>\n\nDo feel that? It's magic... You must be part warlock! \n<Magic is really useful, it never misses it's target, but being half warlock \nyour spells won't be as effective. <<You can use magic by pressing 2.>> \n\nIt looks like you are a smart enough warrior to bring some healing potions, they seem pretty standard so they'll heal you 10 points. You only have 10 right now.<<use potions to get 10 health back by \npressing 3>> \n\nYou can dodge attacks but if you do that you lose a turn.\n<<You can dodge by pressing 4.>>");
            Console.WriteLine("\n\nWell, warrior, let's get started.");
            Console.WriteLine("<<Press enter to start the game>>");
            Console.ReadLine();
            Console.WriteLine("<<You enter the dungeon and you are imediatley attacked by one of the undead soldiers, time to make your move>>");
            Console.ReadLine();
        }
        static void AddHighScore(int playerScore)
        {
            Console.WriteLine("Your Name: ");
            string playerName = Console.ReadLine();

            //Create connection to database
            TylerEntities db = new TylerEntities();

            //New HighScore Object must create new instance of an Object
            HighScore newHighScore = new HighScore();
            //populate the object
            newHighScore.Date = DateTime.Now;
            newHighScore.Game = "Dragon Slayer2";
            newHighScore.PlayerName = playerName;
            newHighScore.Score = playerScore;

            //add it to the database
            db.HighScores.Add(newHighScore);
            //now it's set up but not in the database yet
            //Nothing happens until you save
            db.SaveChanges();


        }
        static void DisplayHighScore()
        {
            //clear the console
            Console.Clear();
            //Write the High Score Text
            
            Console.WriteLine("============================= DRAGON SLAYER HIGH SCORE =============================");
            
            //create a new connection to the database
            TylerEntities db = new TylerEntities();

            //get the HS list
            List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "Dragon Slayer2").OrderByDescending(x => x.Score).Take(10).ToList();
            
            foreach (HighScore highScore in highScoreList)
            {
                Console.WriteLine("{0}, {1} - {2}", highScoreList.IndexOf(highScore) + 1, highScore.PlayerName, highScore.Score);
            }
            

        }
    }
}
