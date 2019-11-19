using System;
using System.Linq;

namespace MasterMind
{

    class Program
    {
        static void Main(string[] args)
        
        {
            var rand = new Random();
            int answerOne;

            //Console.WriteLine("1 random integer generated");
            for (int ctr = 0; ctr <= 0; ctr++)
            Console.Write("{0,8:N0}", rand.Next(1, 6));
            

            Console.WriteLine("Choose a number between 1 and 6.");
            int answerTwo = Convert.ToInt32(Console.ReadLine());

            if (answerTwo = answerOne)
            {
                Console.WriteLine("Looks like you nailed it!");
            }

            else
            {
                Console.WriteLine("Guess again!");
            }


            //bool higher = (rand = answerTwo);

            //bool lower = (answerOne < answerTwo);

            //bool same = (answerOne == answerTwo);

            //if (higher)
            //{
            //    Console.WriteLine(answerOne + " is higher");
            //}
            //if (lower)
            //{
            //    Console.WriteLine(answerOne + " is lower!");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers are even, I guess!");
            //}












            //Console.WriteLine("Welcome to the Guessing Game! You are guessing a " +
            //             "4 digit number with digits no lower than 1 and no higher than 6. You have ten tries. " +
            //             "Press any key to continue.");

            //Console.ReadKey();

            //Console.WriteLine("Type a 4 digit number, with no digit lower than 1 or higher than 6.");
            //string guess = Console.ReadLine();

            //Convert.ToInt32(guess);





            //var rand = new Random();

            //int Min = 1;
            //int Max = 6;
            //Random randNum = new Random();
            //int[] First = Enumerable
            //    .Repeat(1, 6)
            //    .Select(i => randNum.Next(Min, Max))
            //    .ToArray();

            //if (First[0] =)
            //{

            //}



            //int[] numberString = new int[4];
            //numberString[0] = 3;
            //numberString[1] = 6;
            //numberString[2] = 2;
            //numberString[3] = 1;



        }

    }
}
