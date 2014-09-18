using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer2._0
{
        public enum AttackTypes
        {
            Sword = 1,
            Magic,
            Heal,
            No

        }
    class Player
    {
    

            public int PlayerHealth { get; set; }
            public bool IsALive1
            {
                get
                {
                    return PlayerHealth > 0;
                }
            }

            // Constructor
            public Player(int health)
            {
                this.PlayerHealth = health;

            }
            //methods
            public int DoAttack()
            {
                ChooseAttack();
                Random hit = new Random();
                int damage = 0;


                if (ChooseAttack() == AttackTypes.Sword)
                {


                    if (hit.Next(0, 101) >= 95)
                    {
                        damage = hit.Next(15, 41);

                        Console.WriteLine("You attacked with your sword and did " + damage + " damage.");

                    }
                    else
                    {

                        Console.WriteLine("You missed, way to go.....");

                    }
                    return damage;
                }
                else if (ChooseAttack() == AttackTypes.Magic)
                {
                    damage = hit.Next(10, 26);
                    Console.WriteLine("You attacked with magic and did " + damage + " damage.");
                    return damage;

                }
                else if (ChooseAttack() == AttackTypes.Heal)
                {

                    Console.WriteLine("You healed yourself.");
                    PlayerHealth += hit.Next(10, 16);
                    return damage;
                }
                else if (ChooseAttack() == AttackTypes.No)
                {

                    Console.WriteLine("Ah, ah, ah you didn't attack");
                    return damage;
                }
                return damage;

            }
            private AttackTypes ChooseAttack()
            {
                Console.WriteLine();
                Console.WriteLine("<<Select an attack>>");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "1")
                {
                    return AttackTypes.Sword;

                }
                else if (input == "2")
                {
                    return AttackTypes.Magic;
                }
                else if (input == "3")
                {
                    return AttackTypes.Heal;
                }
                else
                {
                    return AttackTypes.No;
                }
            }
            public void TakeDamage(int damage)
            {
                PlayerHealth -= damage;
                Console.WriteLine("You took " + damage + " damage.");
                if (PlayerHealth <= 0)
                {
                    Console.WriteLine("YOU DIED");

                }
            }
        }
            
    }

