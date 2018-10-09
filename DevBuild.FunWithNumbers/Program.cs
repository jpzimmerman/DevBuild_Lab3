using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevBuild.FunWithNumbers
{
    class Program
    {


        static void Main(string[] args)
        {
            ushort userNumber = 1000;
            string userName;
            bool parseSuccessful = false;

            Console.Write("***********************************************************\n" +
                           "*            Dev.Build(2.0) Number Analyzer              *\n" +
                           "**********************************************************\n\n");


            Console.Write("Let's start with your name. What's your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("Hello, {0}. Please pick a number between 1 and 100: ", userName);

            while (true)
            {
                while (!parseSuccessful || (userNumber < 0 || userNumber > 100))
                {
                    Console.WriteLine("Please pick a number between 1 and 100.");
                    parseSuccessful = ushort.TryParse(Console.ReadLine(), out userNumber);
                }
                Console.WriteLine("Thanks, {0}. Okay, let's do a little analysis.", userName);
                //Console.Write(userNumber > 60 ? (userNumber + " and ") : "");
                if (userNumber % 2 == 0)
                {
                    if (userNumber >= 2 && userNumber <= 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (userNumber >= 26 & userNumber <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (userNumber > 60)
                    {
                        Console.WriteLine("{0} and Even", userNumber);
                    }
                }
                else
                {
                    Console.WriteLine("{0} and Odd", userNumber);
                }
                userNumber = ushort.MaxValue;
            }
            //Thread.Sleep(3000);
        }
    }
}
