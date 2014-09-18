using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer2._0
{
    class Game
    {
        //properties
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }
        //Constructor
        public Game()
        {
            this.Player = new Player(250);
            this.Enemy = new Enemy("Skeletor", 300);
        }
        //methods
        public void DisplayCombatInfo()
        {
            Console.WriteLine("Your Health: " + Player.PlayerHealth);
            Console.WriteLine();
            Console.WriteLine("Enemy Health: " + Enemy.SkeHP);
        }
        public void PlayGame()
        {
            while (this.Player.IsALive1 && this.Enemy.IsAlive)
            {
                DisplayCombatInfo();
                this.Enemy.TakeDamage(this.Player.DoAttack());
                this.Player.TakeDamage(this.Enemy.DoAttack());
            }

            if (this.Player.IsALive1)
            {
                Console.WriteLine("YOU WIN");
            }
            else
            {
                Console.WriteLine("YOU LOST AND DIED");
            }
            Console.ReadKey();
        }
    }
}
