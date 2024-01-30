using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Game
{
    internal class Program
    {
       

        public static Nullable<TimeSpan> reactiontime;
        public static bool repeat;
        static void Main(string[] args)
        {
            difficulty();
        }
        private static void difficulty()
        {
            Console.Clear();
            Console.WriteLine("Reaction Time Game\n");
            Console.WriteLine("Difficulty options:\n " +
                              "1000ms..Easy.....[1]\n " +
                              "500ms...Medium...[2]\n " +
                              "250ms...Hard.....[3]\n " +
                              "125ms...Extreme..[4]");
          
            try
            {
                repeat = false;
                while (!repeat)
                {
                    Console.CursorVisible = false;
                   
                    reactiontime = null;
                    while (reactiontime == null)
                    {
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1: reactiontime = TimeSpan.FromMilliseconds(1000); break;
                            case ConsoleKey.D2: reactiontime = TimeSpan.FromMilliseconds(500); break;
                            case ConsoleKey.D3: reactiontime = TimeSpan.FromMilliseconds(250); break;
                            case ConsoleKey.D4: reactiontime = TimeSpan.FromMilliseconds(125); break;
                        }
                    }

                    Console.Clear();
                    TimeSpan signal = TimeSpan.FromMilliseconds(Random.Shared.Next(2000, 5000));
                    Console.WriteLine("wait");
                    Stopwatch stopwatch = new();
                    stopwatch.Restart();
                    bool isTooFast = false;

                    while (stopwatch.Elapsed < signal && isTooFast == false)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            Console.Clear() ;
                            isTooFast = true;
                            Console.WriteLine("too Fast!\n");
                            restart();
                        }
                    }

                    bool isTooSlow = false;
                    bool isValid = false;
                    TimeSpan reactionTimeFinal = default;
                    stopwatch.Restart();

                    if (isTooFast == false)
                    {
                        Console.Clear();
                        stopwatch.Restart();
                        Console.WriteLine("Click");
                    }

                    while (isTooFast == false && stopwatch.Elapsed < reactiontime)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            stopwatch.Stop();
                            reactionTimeFinal = stopwatch.Elapsed;
                            Console.Clear();
                            isTooFast = false;
                            isTooSlow = false;
                            isValid = true;

                            double millisecond = reactionTimeFinal.TotalMilliseconds;
                            int roundedmilliseconds = (int)Math.Round(millisecond);

                            Console.WriteLine("Nice!\n");
                            Console.WriteLine("Reactiontime: " + roundedmilliseconds + " Milliseconds" + "\n");
                            restart();
                        }
                        else if (stopwatch.Elapsed > reactiontime && isValid == false)
                        {
                            Console.Clear();
                            isTooSlow = true;
                        }
                    }

                    if (isTooSlow == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Too Slow!\n");
                        restart();
                    }
                }
            }

            catch
            {
                Console.Clear();
                Console.WriteLine("ERROR");
                Stopgame();
            }

        }

        private static void restart()
        {
            Console.WriteLine("-------------------\nRestart? yes -> 1\n \t no --> 2\n-------------------");
            reactiontime = null;

            string retry = "yes";

            do
            {
                switch (Console.ReadKey(true).Key)

                {
                    case ConsoleKey.D1:
                        
                        difficulty();
                        break;
                    case ConsoleKey.D2:
                        
                        Stopgame();
                        break;
                    case ConsoleKey Spacebar:
                        retry = "no";
                        Console.Clear();
                        restart();
                        break;
                }
            }
            while (retry != "yes");
        }

        private static void Stopgame()
        {
            Console.Clear();
            repeat = true;
        }
    }
}
