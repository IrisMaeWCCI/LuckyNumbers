using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {   //Start and End Number which create my range
            Console.WriteLine("Good day! Please provide me with a starting number");
            int startNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("And provide me with a ending number");
            int endNumber = int.Parse(Console.ReadLine());
            //User's Guess Numbers
            Console.WriteLine(" Please provide me with your guess number 1");
            int guessNumber1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine(" Please provide me with your guess number 2");
            int guessNumber2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Please provide me with your guess number 3");
            int guessNumber3 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Please provide me with your guess number 4");
            int guessNumber4 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Please provide me with your guess number 5");
            int guessNumber5 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Please provide me with your guess number 6");
            int guessNumber6 = int.Parse(Console.ReadLine());

            //Array 
            int[] GuessingNumberArray = { guessNumber1, guessNumber2, guessNumber3, guessNumber4, guessNumber5, guessNumber6 };

            int userEnters = int.Parse(Console.ReadLine());
            // while (userEnters == 2|| userEnters == 7 || userEnters == 9|| userEnters == 11 || userEnters == 13 || userEnters == 17)
            // Console.WriteLine("You've guessed a lucky number!");
            Random random = new Random();
             if (userEnters <= startNumber || endNumber >= userEnters)
            {
                do
                {
                     Console.WriteLine("Lucky Number: "+ GuessingNumberArray);
                    //Let's pretend the code for the game is her

                    Console.WriteLine("Great game!!");
                    Console.WriteLine("Do you want to play again? YES/NO");
                    userEnters = int.Parse(Console.ReadLine());
                }
                while (userEnters > startNumber || endNumber < userEnters);
            }
            int jackpot = 123456789;
            Console.WriteLine("The jackpot amount is 123,456,789");
            string tryAgain; 
            do
            {
                Console.WriteLine("Welcome to my game!");
                //Let's pretend the code for the game is here
                Console.WriteLine("Great game!!");
                Console.WriteLine("Do you want to play again? YES/NO");
                tryAgain = Console.ReadLine();
            }
            while (tryAgain == "YES");

        }
    }
}
