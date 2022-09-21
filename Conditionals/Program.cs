using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weapons = { "Pistol", "Shotgun", "Spreader", "Lazer", "Sniper", "Bfg (Big friendly giant)" };
            int health = 100;
            string[] healthStatus = { "Imminent Danger", "Badly Hurt", "Hurt", "Healthy", "Perfect Health" };
            string[] variables = { "Pistol", "Shotgun", "Spreader", "Lazer", "Sniper", "Bfg (Big friendly giant)", health.ToString()};

            void ChangeWeapon(int weaponPickedUp)
            {
                for (int i = 0; i < weapons.Count(); i++)
                {
                    if (i == weaponPickedUp)
                    {
                        Console.WriteLine("Player has picked up a " + char.ToLower(weapons[i][0]) + weapons[i].Substring(1) + ".");
                    }
                }
            }

            void TakeDamage(int damage)
            {
                int oldHp = health;
                int newHp = health -= damage;
                if (health <= 0)
                {
                    health = 0;
                    Console.WriteLine("Player died. " + damage + " damage was taken when their health was " + oldHp + ".");
                }
                else
                {
                    Console.WriteLine("Player's health is now " + newHp + ". Their health was " + oldHp + " and " + damage + " damage was taken.");
                }
            }

            void Heal(int hp)
            {
                int oldHp = health;
                if (health == 100)
                {
                    Console.WriteLine("Player didn't heal because health is already full.");
                    return;
                }
                health += hp;
                if (health > 100)
                {
                    health = 100;
                }
                Console.WriteLine("Player's health has healed. Their health increased from " + oldHp + " to " + health + ".");
            }

            void ShowHUD()
            {
                string hudSTRING;
                hudSTRING = "";
                for (int i = 0; i < variables.Count(); i++)
                {
                    if (i == 6)
                    {
                        if (Int32.Parse(variables[i]) == 100)
                        {
                            hudSTRING += " | " + healthStatus[4];
                            //Console.WriteLine(healthStatus[4]);
                        }
                        else if (Int32.Parse(variables[i]) > 74)
                        {
                            hudSTRING += " | " + healthStatus[3];
                            //Console.WriteLine(healthStatus[3]);
                        }
                        else if (Int32.Parse(variables[i]) > 49)
                        {
                            hudSTRING += " | " + healthStatus[2];
                            //Console.WriteLine(healthStatus[2]);
                        }
                        else if (Int32.Parse(variables[i]) > 9)
                        {
                            hudSTRING += " | " + healthStatus[1];
                            //Console.WriteLine(healthStatus[1]);
                        }
                       else
                        {
                            hudSTRING += " | " + healthStatus[0];
                            //Console.WriteLine(healthStatus[0]);
                        }
                    }
                    else if (i == 0)
                    {
                        hudSTRING += variables[i];
                    }
                    else
                    {
                        hudSTRING += " | " + variables[i];
                    }
                }
                Console.WriteLine(hudSTRING);
            }

            ChangeWeapon(2);
            TakeDamage(20);
            Heal(10);
            ShowHUD();
            Console.ReadKey(false);
        }
    }
}