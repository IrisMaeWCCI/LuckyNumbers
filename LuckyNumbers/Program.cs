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
            //Create an array in which I know the length

            int[] GuessingNumberArray = new int[6];
           
           
            //loop thru n input user guessed #s

            //Console.WriteLine("Lucky Number: {0},\nLucky Number: {1},\nLucky Number: {2},\nLucky Number: {3},\nLucky Number: {4},\nLucky Number: {5},\nLucky Number: {6}", GuessingNumberArray[0], GuessingNumberArray[1], GuessingNumberArray[2], GuessingNumberArray[3], GuessingNumberArray[4], GuessingNumberArray[5], GuessingNumberArray[6]);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Enter a number please");
                int userNumber = int.Parse(Console.ReadLine());
                while (userNumber < startNumber || userNumber > endNumber)
                {
                    Console.WriteLine("Please enter a valid number");
                    userNumber = int.Parse(Console.ReadLine());
                }

                GuessingNumberArray[i] = userNumber;
            }
            //Throwing in my Random
            Random random = new Random();
            int[] LuckyNumbers = new int [6];
            //my first loop
            for (int i = 0; i<=5; i++)
            {
                LuckyNumbers[i] = random.Next(startNumber, endNumber+1);

            }
            //my second nested loop
            foreach (int number in LuckyNumbers)
            {
                Console.WriteLine("Lucky Number : " + number);
            }
            int jackpot = 500;
            Console.WriteLine("The jackpot is $" +jackpot+ "!");
            int guessedCorrectly = 0;
            for(int i = 0; i<5; i++)
            {
                for (int j=0; j<5; j++)
                {
                    if (LuckyNumbers[i] == GuessingNumberArray[j])
                    {
                        guessedCorrectly += 1;

                    }
                }
            }
            //jackpot and if statement
            Console.WriteLine("You have guessed: "+guessedCorrectly+" correctly");

            if (guessedCorrectly == 0)
            {
                Console.WriteLine("Sorry, you don't win any of the jackpot!");
            }
            else if (guessedCorrectly > 0 && guessedCorrectly <= 3)
            {
                Console.WriteLine("You will receive $" + jackpot/2);
            }
            else
            {
                Console.WriteLine("You will receive $"+ jackpot);
            }
        }
    }
}
