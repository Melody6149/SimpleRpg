using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRpg
{
    class Game
    {
        String playerName = ""; // allows for player name to be stored for later
        int PlayerHealth = 100; // for player healt

        public void Start()
        {
            Welcome(); // runs code in welcome
            bool alive = true; // bool allows for it to be set true or false
            int monsterRemaining = 5; //alows you to set number of monsters that show up

            while (alive && monsterRemaining > 0) // fight until you die
            {
                Console.WriteLine("There are " + monsterRemaining + " monsters remaining.");
                alive = Encounter(5); // sets damage
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

        bool Encounter(int monsterDamage) // Code for encounter is here so it can be started with Encounter in the () in the start you can changed monster damage
        {
            //Monster encounter!
            
            Console.WriteLine(""); // creates a space inbetween lines
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
                if (PlayerHealth<= 0 ) //runs code if player health is bellow 0
                {
                    Console.WriteLine(playerName + " was defeated");
                    return false; // Return leaves monster encounter code and sets alive to false
                }
                //Player attack
                Console.WriteLine(playerName + " attacks! The monster is defeated!"); // only shows if the code in if is not run
            }
            else if (action == "flee") // does this if player types in flee
            {
                //Esccape
                Console.WriteLine("Got away safely..."); // shows got away safely
            }
            return true;
        }
        
       
    }
}
