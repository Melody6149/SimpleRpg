using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRpg
{
    class Game
    {
        public void Start()
        {
            String playerName = ""; //
            int PlayerHealth = 100; // for player healt
            Console.WriteLine("What is Your name?"); // shows what is your name
            playerName = Console.ReadLine(); // allows player to put in there name and have it stored using the string typed earlier
            Console.WriteLine("Welcome " + playerName + "."); // shows playername because i put in the
            

            //Monster encounter!
            int monsterDamage = 13; // Sets monster's damage
            Console.WriteLine("");
            Console.WriteLine("There is a monser in front of you"); // displayes this text

            string action = ""; //allows response to be stored as action
            Console.WriteLine("What will you do? (fight/flee)"); //displayes this text
            action = Console.ReadLine(); // stores user input as the string typed earlier

            if (action == "fight") // does this if player types in fight
            {
                //Monster attack
                Console.WriteLine("the monster attacks! " + playerName + "takes " + monsterDamage + " damage!");
                PlayerHealth = PlayerHealth - monsterDamage;
                Console.WriteLine(playerName + " has " + PlayerHealth + " health remaining.");
                //Player attack
                Console.WriteLine(playerName + " attacks! The monster is defeated!");
            }
            else if (action == "flee") // does this if player types in flee
            {
                //Esccape
                Console.WriteLine("Got away safely..."); // shows got away safely
            }

            Console.ReadKey(); // waits for key to move on to next line
        }
       
    }
}
