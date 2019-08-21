using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRpg
{
    class Game
    {
        //player stats
        string playerName = ""; // allows for player name to be stored for later
        int PlayerHealth = 100; // for player health
        int Playerdamage = 10;
        int playermaxHealth = 100;
        int playerHealing = 25;

        public void Start()
        {
            Welcome(); // runs code in welcome
            bool alive = true; // bool allows for it to be set true or false
            int monsterRemaining = 5; //alows you to set number of monsters that show up

            while (alive && monsterRemaining > 0) // fight until you die
            {
                Console.WriteLine("There are " + monsterRemaining + " monsters remaining."); // shows player how many monsters are remaining
                alive = Encounter(20, 20); // First one is monster health second sets damage
                monsterRemaining--; // subtracts one from monster remaing
            }





            Console.ReadKey(); // waits for key to move on to next line
        }
        void Welcome() // code that is run when welcom () is run
        {
            Console.WriteLine("What is Your name?"); // shows what is your name
            playerName = Console.ReadLine(); // allows player to put in there name and have it stored using the string typed earlier
            Console.WriteLine("Welcome " + playerName + "."); // shows playername because i put in the
        }

        bool Encounter(int monsterHealth, int monsterDamage) // Code for encounter is here so it can be started with Encounter in the () in the start you can changed monster damage
        {
            //Monster encounter!


            Console.WriteLine(""); // creates a space inbetween lines
            Console.WriteLine("There is a monser in front of you"); // displayes this text

            string action = ""; //allows response to be stored as action
            bool survived = true; //allows game to know if you are alive
            while (PlayerHealth > 0 && monsterHealth > 0) // moved so player can pick action in same fight and prevents you from typing nothing
            {
                Console.WriteLine("What will you do? (fight/flee/heal)"); //displayes this text
                action = Console.ReadLine(); // stores user input as the string typed earlier


                if (action == "fight") // does this if player types in fight
                {
                    survived = Fight(ref monsterHealth, ref monsterDamage);
                    if (!survived)// ! means the value needs to be false for this to happen
                    {
                        return false;
                    }
                }

                else if (action == "flee") // does this if player types in flee
                {
                    survived = Flee();
                        if (survived)
                    {
                        return true;
                    }
                }
                else if (action == "heal")
                {
                    survived = Heal(ref monsterHealth, ref monsterDamage);
                }
            } return true;
        }
        bool Fight(ref int monsterHealth, ref int monsterDamage)
        {
            //Monster attack
            Console.WriteLine("The monster attacks! " + playerName + " takes " + monsterDamage + " damage!");
            PlayerHealth = PlayerHealth - monsterDamage; // takes away damge monster does to player
            Console.WriteLine(playerName + " has " + PlayerHealth + " health remaining."); // tell player how much health they have
            if (PlayerHealth <= 0) //runs code if player health is bellow 0
            {
                Console.WriteLine(playerName + " was defeated");
                return false; // Return leaves monster encounter code and sets alive to false
            }
            //Player attack

            Console.WriteLine(playerName + " attacks! The monster takes " + Playerdamage + "."); // only shows if the code in if is not run
            monsterHealth = monsterHealth - Playerdamage; // takes away player damage from monster health
            Console.WriteLine("The monster has " + monsterHealth + " HP left."); // tells playr how much health the monster has left
            if (monsterHealth <= 0)
            {
                Console.WriteLine("The monster has been defeated"); //tells the player they won
                return true; //  exits the loop code

            }
            return true;
        }
        bool Flee()
        {
            //Esccape
            Console.WriteLine("Got away safely..."); // shows got away safely
            return true; // allows flee to work

        }
        bool Heal(ref int monsterHealth, ref int monsterDamage)
        {
            //Monster attack
            Console.WriteLine("The monster attacks! " + playerName + " takes " + monsterDamage + " damage!");
            PlayerHealth = PlayerHealth - monsterDamage; // takes away damge monster does to player
            Console.WriteLine(playerName + " has " + PlayerHealth + " health remaining."); // tell player how much health they have
            if (PlayerHealth <= 0) //runs code if player health is bellow 0
            {
                Console.WriteLine(playerName + " was defeated");
                return false; // Return leaves monster encounter code and sets alive to false
            }
            //Player Heal

            Console.WriteLine(playerName + " Heals " + playerHealing + " using random magic."); // message that lets player know they healed
            PlayerHealth = PlayerHealth + playerHealing;
            Console.WriteLine("You have " + PlayerHealth + "left");
            return true;
        }




    }


}

