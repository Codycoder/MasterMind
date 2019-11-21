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
            int randomNumber = new int();

            Console.WriteLine("Welcome to MasterMind! Try to guess a 4 digit number. You have ten tries. " +
                "Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine("4 random integers generated");
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.Write("{0,8:N0}", rand.Next(1, 6));
            //    computerList.Add(rand.Next(4));
            //}

            //for (int i = 0; i <= 3; i++)

            //{
            //    randomNumber = rand.Next(1, 6);     // capture this random number for WriteLine-ing AND computerList.Add!
            //    Console.Write("{0,8:N0}", randomNumber);
            //    computerList.Add(randomNumber);
            //}

            randomNumber = rand.Next(1, 6);     // capture this random number for WriteLine-ing AND computerList.Add!
            Console.Write("{0,8:N0}", randomNumber);


            Console.WriteLine();
            Console.WriteLine("The computer is ready! Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Guess a four digit number with digits between 1 and 6.");
            //answerTwo = Convert.ToInt32(Console.ReadLine());

            //for (int ctr = 0; ctr <= 3; ctr++)
            //{
            //    userList.Add(answerTwo);
            //}

            answerTwo = Convert.ToInt32(Console.ReadLine());

            if (answerTwo == randomNumber)
            {
                Console.WriteLine("+");
            }

            else
            {
                Console.WriteLine("-");
            }

            //if (userList[1] == computerList[1])
            //{
            //    Console.WriteLine("+");
            //}

            //if (userList[2] == computerList[2])
            //{
            //    Console.WriteLine("+");
            //}

            //if (userList[3] == computerList[3])
            //{
            //    Console.WriteLine("+");
            //}






        }
    }
}


    
