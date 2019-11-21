using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterMind
{

    class Program
    {
        static void Main(string[] args)
        
        {
            var rand = new Random();
            int answerTwo;
            var userList = new List<int>(4);
            var computerList = new List<int>(4);
            //int randomNumbers = new int();

            //Console.WriteLine("4 random integers generated");
            for (int i = 0; i <= 3; i++)
                Console.WriteLine("{0,8:N0}", rand.Next(1, 6));
                computerList.Add(rand.Next(4));

            Console.WriteLine("Guess a four digit number with digits between 1 and 6.");
            answerTwo = Convert.ToInt32(Console.ReadLine());

            for (int ctr = 0; ctr <= 4; ctr++)
                userList.Add(answerTwo);

            {

                if (userList[0] == computerList[0])
                {
                    Console.Write("+");
                }
                else if (userList[0] == computerList[1])
                {
                    Console.Write("-");
                }
                else if (userList[0] != computerList[0])
                {
                    Console.WriteLine(" ");
                }
                else if (userList[0] != computerList[1])
                {
                    Console.WriteLine(" ");
                }
            }
        }

    }
}
