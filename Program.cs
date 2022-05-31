using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number");
            var userInput=int.Parse(Console.ReadLine());

            if (userInput<favNumber)
            {
                Console.WriteLine("too low");
            }else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorite school subject");
            string favSubject=Console.ReadLine();
            switch (favSubject.ToLower())
            {
                case ("nuclear physics"):
                    Console.WriteLine("mine too");
                    break;
                case ("rocket science"):
                    Console.WriteLine("You are smart");
                    break;
                case ("home economics"):
                    Console.WriteLine("What are you cooking for supper?");
                    break;
                case ("molecular physics"):
                    Console.WriteLine("can you explain what's in my sunscreen");
                    break;
                case ("gym"):
                    Console.WriteLine("can you open this jar for me?");
                    break;
                default:
                    Console.WriteLine("Well I guess you like English");
                    break ;

            }
        }
    }
}
