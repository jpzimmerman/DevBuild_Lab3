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
        enum OddOrEven { Neither, odd, even }

        static void Main(string[] args)
        {
            OddOrEven _OddOrEvenPref = OddOrEven.Neither;
            OddOrEven _OddOrEvenEval = OddOrEven.Neither;
            ushort userNumber = ushort.MaxValue; //since the app is looking for a number between 1 and 100, let's set this to Max Value so that we don't lose program flow prematurely
            string userName, _OddOrEvenResponse;
            bool parseSuccessful = false;

            Console.Write("***********************************************************\n" +
                           "*            Dev.Build(2.0) Number Analyzer               *\n" +
                           "***********************************************************\n\n");


            Console.Write("Let's start with your name. What's your name? ");
            userName = Console.ReadLine();
            switch (userName.ToLower())
            {
                //if user does what arcade-goers were known to do to the scorebord in Pac-Man or Space Invaders,
                //let's reward their creativity
                case "ass":
                case "aaa":
                    {
                        Console.WriteLine("Wow, you're a legend around the arcade! Anyway, let's continue.");
                        break;
                    }
                default: Console.Write("Hello, {0}. ", userName);  break;

            }

            Console.Write("Do you prefer odd numbers or even numbers? (type \"odd\" or \"even\")");
            _OddOrEvenResponse = Console.ReadLine();
            Enum.TryParse<OddOrEven>(_OddOrEvenResponse, out _OddOrEvenPref);


            while (true)
            {
                while (!parseSuccessful || (userNumber < 0 || userNumber > 100))
                {
                    Console.WriteLine("Please pick a number between 1 and 100.");
                    parseSuccessful = ushort.TryParse(Console.ReadLine(), out userNumber);
                }
                Console.WriteLine("Thanks, {0}. Okay, let's do a little analysis.\n\n" + "******************************", userName);
                //Console.Write(userNumber > 60 ? (userNumber + " and ") : "");
                if (userNumber % 2 == 0)
                {
                    _OddOrEvenEval = OddOrEven.even;
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
                    _OddOrEvenEval = OddOrEven.odd;
                    Console.WriteLine("{0} and Odd", userNumber);
                }
                userNumber = ushort.MaxValue;
                string linesUpWithPreferred = (_OddOrEvenEval == _OddOrEvenPref) ? "is :) " : "isn't :( ";
                Console.WriteLine("And it " + linesUpWithPreferred + "your preferred kind of number.\n" + "******************************\n");
            }
            //Thread.Sleep(3000);
        }
    }
}
