using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterMind
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool correctAnswer = false;
            do
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

                Console.ReadKey();

                foreach (var item in userList)
                {
                    Console.WriteLine(item);
                }

                Console.ReadKey();

                foreach (var item in userList)

                {
                    if ()
                    {
                        Console.WriteLine("+");
                    }

                    else 
                   
                    {
                        Console.WriteLine("Nope, try again!");
                    }
                    //correctAnswer = true;
                    //Console.WriteLine("YOU WON!");
                    //break;


                }

            } while (correctAnswer == false);

            {

            }

        }
    }
}


    
