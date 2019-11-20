using System;
using System.Linq;

namespace MasterMind
{

    class Program
    {
        static void Main(string[] args)
        
        {
            var rand = new Random();
            int answerTwo;
            //int randomNumber;
            //int[] userArray;
            //int[] computerArray;

            //Console.WriteLine("1 random integer generated");
            for (int ctr = 0; ctr <= 1; ctr++)
                Console.WriteLine("{0,8:N0}", rand.Next(1, 6));

            for (int ctr = 0; ctr <= 2; ctr++)
            {
                int[] computerArray = new int[2];
            }

            Console.WriteLine("Guess a two digit number with digits between 1 and 6.");
            answerTwo = Convert.ToInt32(Console.ReadLine());
            for (int ctr = 0; ctr <= 2; ctr++)
            {
                int[] userArray = new int[2];

                if (userArray[0] == computerArray[0])
                {
                    Console.Write("+");
                }
                else if (userArray[0] == computerArray[1])
                {
                    Console.Write("-");
                }
                else if (userArray[0] != computerArray[0])
                {
                    Console.WriteLine("Nope!");
                }
                else if (userArray[0] != computerArray[1])
                {
                    Console.WriteLine("Nope!");
                }
            }
        }

    }
}
