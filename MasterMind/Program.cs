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
            var userList = new List<int>();
            var computerList = new List<int>();
            int randomNumbers = new int();

            //Console.WriteLine("4 random integers generated");
            for (int ctr = 0; ctr <= 4; ctr++)
                randomNumbers = rand.Next(1, 6);
                Console.WriteLine("{0,8:N0}", randomNumbers);
                computerList.Add(randomNumbers);

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
