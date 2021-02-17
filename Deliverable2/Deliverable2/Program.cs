//Author: Kenneth Stempowski
/* To create a program that has a very basic conversation with a bot
 * and terminates upon saying "bye" to the bot. Only hello, sup,
 * hello there, and bye are suitable inputs.*/

using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define the strings/variables for possible inputs
            string userInput;
            string userInput2;
            string hi = "hello";
            string goodBye = "bye";
            string whatsUp = "sup";
            string kenobi = "hello there";

            Console.WriteLine("Start a coversation");
            do //This will create a loop
            {
                
                userInput = Console.ReadLine().ToLower(); //Convert the input to lower case

                if (userInput == hi) //Start an if-else block
                {
                    Console.WriteLine("Hi good to see you \n");
                    Console.WriteLine("Start a conversation");
                }
                else if (userInput == whatsUp)
                {
                    Console.WriteLine("I am good \n");
                    Console.WriteLine("Start a conversation");
                }
                else if (userInput == kenobi)
                {
                    Console.WriteLine("General Kenobi \n");
                    Console.WriteLine("Start a conversation");
                }
                else if (userInput == goodBye)
                {
                    Console.WriteLine("Good bye!");
                    break; //Terminate the loop
                }
                if (userInput != goodBye) //Start a new if-else block
                {
                    userInput2 = Console.ReadLine().ToLower(); //Convert input to lower case
                        if (userInput2 == userInput)
                        {
                            Console.WriteLine("I'm sorry, but you already said that \n");
                            Console.WriteLine("Start a conversation");
                        }
                        else if (userInput2 == goodBye)
                        {
                            Console.WriteLine("Good bye!");
                        break;
                        }
                }
            }
            while (userInput != goodBye);
        }
    }
}
