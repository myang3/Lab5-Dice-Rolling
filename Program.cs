using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static string play;
        static int sides;

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
            play = Console.ReadLine();

            do
            {
                Console.WriteLine("\nHow many sides do you want the dice to have?");
                bool result = int.TryParse(Console.ReadLine(), out sides);

                if (sides > 20 || sides < 4)
                {
                    Console.Write("Where do you get dice like that? How about something between 4 and 20?\n");

                }

                else
                {


                    Random rnd = new Random();
                    int dice1 = rnd.Next(1, sides + 1);
                    int dice2 = rnd.Next(1, sides + 1);

                    Console.WriteLine("\nDice 1: " + dice1 + "\nDice 2: " + dice2);
                    
                    rollChecker(dice1, dice2);

                    continueOrQuit();

                }

                //Console.ReadLine();
            }
            while (play.ToLower() == "y" || play.ToLower() == "yes");

        }

        private static void continueOrQuit()
        {
            Console.WriteLine("\nWould you like to roll again? (y/n)");
            play = Console.ReadLine();
        }

        public static void rollChecker(int dice1, int dice2)
        {
            if (dice1 + dice2 == 2)
            {
                Console.WriteLine("Snake eyes, thats unlucky.");
            }
            else if (dice1 + dice2 == 12)

            {
                Console.WriteLine("Box cars all the way!");
            }
            else
            { Console.WriteLine(""); }


        }
    }
}

/*
       Random dice1 = new Random();
       //for(int i =0;i<10;i++)     
       Console.WriteLine("Dice 1:  " + dice1.Next(4,21));

       Random dice2 = new Random();
       //for (int i = 0; i < 10; i++)
       Console.WriteLine("Dice 2:  " + dice2.Next(4, 21));

    Random rnd = new Random();
                int month = rnd.Next(1, 13); // creates a number between 1 and 12
                int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
                int card = rnd.Next(52);
                Console.WriteLine(month + "\n" + dice);

     private static int getInteger(String question)
        {
            Console.WriteLine(question);
            while (question == "0")
            {
                Console.WriteLine("You have entered invalid data. Please enter a whole number. ");
                Console.Read();
            }
            int answer = Console.Read();
            return answer;
        }
       */
