using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer2._0
{
    class Enemy
    {
        //prpoerties
        public string Skeleton { get; set; }
        public int SkeHP { get; set; }
        public bool IsAlive
        {
            get
            {
                return SkeHP > 0;
            }
        }

        //Constructor
        public Enemy(string name, int hp)
        {
            this.Skeleton = name;
            this.SkeHP = hp;

        }
        //methods
        public int DoAttack()
        {
            Random hit = new Random();
            int damage = 0;
            if (hit.Next(0, 101) < 81)
            {
                //make a rng for Skeleton attack strength
                damage = hit.Next(5, 16);


            }
            else
            {
                damage = 0;
                Console.WriteLine();
                Console.WriteLine("That was close better not let it get you");
                Console.WriteLine();
            }
            return damage;

        }
        public void TakeDamage(int damage)
        {

            if (SkeHP > 0)
            {


                SkeHP -= damage;
                Console.WriteLine();
                Console.WriteLine("You did " + damage);
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("YOU DID IT!");
                Console.WriteLine();
            }
        }
    }
}
