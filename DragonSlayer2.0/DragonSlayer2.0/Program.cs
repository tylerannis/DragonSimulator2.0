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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
 _____ _       _____   _____________ 
/  ___| |     / _ \ \ / /  ___| ___ \
\ `--.| |    / /_\ \ V /| |__ | |_/ /
 `--. \ |    |  _  |\ / |  __||    / 
/\__/ / |____| | | || | | |___| |\ \ 
\____/\_____/\_| |_/\_/ \____/\_| \_|
                                     
                                                                                                                          
");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HALT!! Who dares approach the dungeon?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Look for <<>> to advance past story");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" <<You can accsess your sword attack by pressing 1.>> \n<<You can use magic by pressing 2.>> \n<<use potions to get 10 health back by pressing 3>>");
            Console.WriteLine("\n\nWell, warrior, let's get started.");
            Console.WriteLine("<<Press enter to start the game>>");
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
