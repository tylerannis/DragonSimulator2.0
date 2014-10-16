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
            
        }
    }
}
