using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller userIO = new Controller();
            Question_Bank qB = new Question_Bank();

            int choice;

            while (true)
            {
                Console.WriteLine("\n\n\n1.Play Trivia!");
                Console.WriteLine("2.Display Trivia Questions and Answers");
                Console.WriteLine("3.Add a Trivia Question");
                Console.WriteLine("4.Quit the App");

                Console.WriteLine("Please Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                    break;

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        userIO.Play();
                        break;
                    case 2:
                        qB.ShowQuestions();
                        break;
                    case 3:
                        userIO.UserInputAdd();
                        break;
                    default:
                        Console.WriteLine("Not a correct option number.");
                        break;
                }
            }

            userIO.Exit();

            Console.ReadLine();
        }

        
    }
}
