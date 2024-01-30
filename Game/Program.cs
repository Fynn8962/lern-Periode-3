using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Game
{
    internal class Program
    {
        // Nullable<timeSpan> sagt, das die Timespan auch Null sein darf. Kurzschreibweise ist Timespan?

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
                    Console.CursorVisible = false;
                    TimeSpan Signal = TimeSpan.FromMilliseconds(Random.Shared.Next(2000, 5000));
                    Console.WriteLine("wait");
                    Stopwatch stopwatch = new();
                    stopwatch.Restart();
                    bool tooFast = false;
                    while (stopwatch.Elapsed < Signal && tooFast == false)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            Console.Clear() ;
                            tooFast = true;
                            Console.WriteLine("too Fast!\n");
                            restart();
                           
                        }
                    }

                    bool tooSlow = false;
                    TimeSpan reactionTimeFinal = default;
                    stopwatch.Restart();
                    bool hit = false;
                    if (tooFast == false)
                    {
                        Console.Clear();
                        stopwatch.Restart();
                        Console.WriteLine("Click");
                        
                    }

                    while (tooFast == false && stopwatch.Elapsed < reactiontime)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            stopwatch.Stop();
                            reactionTimeFinal = stopwatch.Elapsed;
                            Console.Clear();
                            tooFast = false;
                            tooSlow = false;
                            hit = true;
                            double millisecond = reactionTimeFinal.TotalMilliseconds;
                            int roundedmilliseconds = (int)Math.Round(millisecond);
                            Console.WriteLine("Nice!\n");
                            Console.WriteLine("Reactiontime: " + roundedmilliseconds + " Milliseconds" + "\n");
                            restart();
                        }
                        else if (stopwatch.Elapsed > reactiontime && hit == false)
                        {
                            Console.Clear();
                            tooSlow = true;
                           
                            
                        }
                        
                    }
                   
                    

                    if (tooSlow == true)
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
            }

        }

        private static void tooFastFunktion()
        {

            
            Console.Clear();
            Console.WriteLine("too Fast!");
            repeat = true;





        }
        private static void Stopgame()
        {
            Console.Clear();
            repeat = true;



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

    }
}
