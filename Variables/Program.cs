using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int score, enemyValue, lives, enemies, i;
            string name, gamerTag, studioName, gameTitle, endMessage;
            float health, shield, scoreMult, enemyDamage;

            //initializing values
            studioName = "Benedict Games";
            gameTitle = "NO GAME QUEST";
            enemies = 10;
            enemyValue = 100;
            enemyDamage = 28.7f;

            name = "Matthieu Benedict";
            gamerTag = "Twitchton";
            lives = 3;
            health = 100.0f;
            shield = 100.0f;
            score = 0;
            scoreMult = 1.0f;
            i = 0;


            //Printing to console
            Console.WriteLine("----------------");
            Console.WriteLine(gameTitle + ":"); 
            Console.WriteLine("----------------");
            Console.WriteLine("By: " + studioName);
            Console.WriteLine();

            Console.WriteLine("GamerTag:\t\t" + gamerTag);
            Console.WriteLine("Name:\t\t\t" + name);
            Console.WriteLine("Score:\t\t\t" + score);
            Console.WriteLine("Score Multiplier:\t" + scoreMult);
            Console.WriteLine("Shield:\t\t\t" + shield);
            Console.WriteLine("Health:\t\t\t" + health);
            Console.WriteLine("Lives:\t\t\t" + lives);
            Console.WriteLine();

            //Simulate gameplay
            endMessage = "You Win!";

            while (enemies>0 && lives>0)
            {
                i++;

                //taking damage
                if (shield >= 0.0f)
                {
                    shield -= enemyDamage;
                }
                else
                {
                    health -= enemyDamage; 
                }

                Console.WriteLine("You took Damage!");

                //killing enemy
                enemies--;
                score += (int)(enemyValue * scoreMult);
                scoreMult += 0.5f;

                Console.WriteLine("You killed an Enemy!");

                //checking health
                if (health<=0.0f)
                {
                    lives--;
                    health = 100.0f;
                    shield = 100.0f;
                    scoreMult = 1.0f;

                    Console.WriteLine("You lost one life.");
                }

                //checking lives
                if (lives <= 0)
                {
                    score = 0;
                    endMessage = "You Lose :(";
                    Console.WriteLine("You DIED.\n");
                    break;

                }

                //picking up shield kit
                if (i%3 == 0)
                {
                    shield += 50.0f;
                    Console.WriteLine("You picked up a SHIELD KIT!");
                }

                //picking up health kit
                if (i%7 == 0)
                {
                    health += 33.3f;
                    if (health > 100.0f)
                    {
                        health = 100.0f;
                    }
                    Console.WriteLine("You picked up a HEALTH KIT!");
                }

                //event log
                

            }

            //Printing Final message
            Console.WriteLine("\n----------------");
            Console.WriteLine(gameTitle + ":");
            Console.WriteLine("----------------");
            Console.WriteLine("By: " + studioName);
            Console.WriteLine();

            Console.WriteLine("GamerTag:\t\t" + gamerTag);
            Console.WriteLine("Name:\t\t\t" + name);
            Console.WriteLine("Score:\t\t\t" + score);
            Console.WriteLine("Score Multiplier:\t" + scoreMult);
            Console.WriteLine("Shield:\t\t\t" + shield);
            Console.WriteLine("Health:\t\t\t" + health);
            Console.WriteLine("Lives:\t\t\t" + lives);
            Console.WriteLine();
            Console.WriteLine(endMessage);
            Console.WriteLine();

            Console.WriteLine("Press any Key to exit.");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }
}
