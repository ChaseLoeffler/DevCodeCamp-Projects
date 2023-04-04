using System.Diagnostics.CodeAnalysis;

namespace Loops_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            string hi = "Hello!";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{hi}");
            }

            // Task 2

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }


            // Task 3

            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine(i);
            }

            //Task 4
            Console.WriteLine("Number of times you want the loop to run?");
            string input = Console.ReadLine();

            int inputint = Convert.ToInt32(input);

            for (int i = 0; i < inputint; i++)
            {
                Console.WriteLine("devCodeCamp");
            }

            // Task 5
            string[] letters = { "P", "a", "c", "k", "e", "r", "s" };
            foreach(string letter in letters)
            {
                Console.WriteLine(letter);
            }

            //Task 6
            for(int i = 0; i < 101; i++)
            {
                if (i % 3==0)
                {
                    Console.WriteLine("fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    continue;
                }
                if (i % 3==0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                    continue;
                }
                Console.WriteLine(i);
            }
            //Task 7
            int num = 0;

            while (num < 5)
            {
                Console.WriteLine("Hello");
                num++;
            }

            //Task 8

            string myUsername = "ChaseL";
            string myPassword = "Chase123";

            int numOfAttempts = 0;

            while(numOfAttempts < 3)
            {
                Console.WriteLine("Login attempts:" + numOfAttempts);

                Console.WriteLine("Username:");
                string usernameInput = Console.ReadLine();
                Console.WriteLine("Password:");
                string passwordInput = Console.ReadLine();

                if (usernameInput == myUsername && passwordInput == myPassword)
                {
                    Console.WriteLine("User Validated");
                    break;
                }
                else if (usernameInput == myUsername && passwordInput != myPassword)
                {
                    Console.WriteLine("Password Incorrect");
                }
                else if (usernameInput != myUsername && passwordInput == myPassword)
                {
                    Console.WriteLine("Username Incorrect");
                }
                else
                {
                    Console.WriteLine("No user found");
                }
                numOfAttempts++;

            }

















        }
    }
}