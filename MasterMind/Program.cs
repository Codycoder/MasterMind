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
            int Turn = new int();

            Console.WriteLine("Welcome to MasterMind! In this game you try to guess a 4 digit number.");
            Console.WriteLine("You have ten tries. Press any key to continue"); 
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i <= 3; i++)

            {
                // capture this random number for WriteLine-ing AND computerList.Add!
                randomNumber = rand.Next(1, 6);     
                Console.Write("{0,8:N0}", randomNumber);
                computerList.Add(randomNumber);
            }

            Console.WriteLine();
            Console.WriteLine("The computer is ready! Press any key to continue.");

            // Printing numbers to test list population/function
            //foreach (var item in computerList)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
            Console.Clear();


            bool correctAnswer = false;
            Turn = 0;
            do
            {

                for (int i = 0; i <= 3; i++)
                {

                    Console.WriteLine("Guess a digit");
                    string userInput = Console.ReadLine();
                    userList.Add(Convert.ToInt32(userInput));
                }

                Console.ReadKey();

                // printing numbers to test list population
                foreach (var item in userList)
                {
                    Console.WriteLine(item);
                }

                Console.ReadKey();

                {
                    if (userList[0] == computerList[0])
                    {
                        Console.WriteLine("YESSSS");
                        break;
                    }

                    else

                    {
                        Console.WriteLine("Nope, try again!");
                    }
                    //correctAnswer = true;
                    //Console.WriteLine("YOU WON!");
                    //break;


                }


            } while (Turn <= 10 && correctAnswer == false);
        }
    }
}


    
