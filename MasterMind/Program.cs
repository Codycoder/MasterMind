using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterMind
{
    public class Program
    {
        static void Main(string[] args)
        {

            var rand = new Random();
            //int userInput = new int();
            var userList = new List<int>(4);
            var computerList = new List<int>(4);
            int randomNumber = new int();

            Console.WriteLine("Welcome to MasterMind! In this game you try to guess a 4 digit number the computer has generated. " +
                "You have ten tries. Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i <= 3; i++)

            {
                randomNumber = rand.Next(1, 6);     // capture this random number for WriteLine-ing AND computerList.Add!
                Console.Write("{0,8:N0}", randomNumber);
                computerList.Add(randomNumber);
            }

            Console.WriteLine();
            Console.WriteLine("The computer is ready! Press any key to continue.");

            foreach (var item in computerList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i <= 3; i++)
            {
            Console.WriteLine("Guess a digit");
            string userInput = Console.ReadLine();
            userList.Add(Convert.ToInt32(userInput));
            }
            


            //string guess = Console.ReadLine();
            //int guessNumber = Convert.ToInt32(guess);

            //for (int i = 0; i <= 3; i++)
            //{

            //    userList.Add(userInput);
            //}

            Console.ReadKey();
            
            foreach (var item in userList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            foreach (var item in userList)
                //for (int i = 0; i <= 3; i++)

            {
                if (userList[0] == computerList[0] || userList[1] == computerList[1] || userList[2] == computerList[2] || userList[3] == computerList[3])
                {
                    Console.Write("+");
                }
                else if (userList.Contains(computerList[0]))
                {
                    Console.Write("-");
                }
            }

            //foreach (var item in userInput)
            //    Console.WriteLine(item);
           
            //if (userList[0] == computerList[0])
            //{
            //    Console.WriteLine("+");
            //}

            //else if (userList[1] == computerList[1])
            //{
            //    Console.WriteLine("+");
            //}

            //else if (userList[2] == computerList[2])
            //{
            //    Console.WriteLine("+");
            //}

            //else if (userList[3] == computerList[3])
            //{
            //    Console.WriteLine("+");
            //}

            //else
            //{
            //    Console.WriteLine("-");
            //}
        }
    }
}


    
