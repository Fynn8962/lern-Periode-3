using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Game
{
    internal class Program
    {

        public static bool repeat;
        static void Main(string[] args)
        {

            Console.WriteLine("Reaction Time Game\n");
            Console.WriteLine("Difficulty options:\n Easy.....[1]\n Medium...[2]\n Hard.....[3]\n Extreme..[4]");
            difficulty();
        }
        private static void difficulty()
        {
            try
            {
                 repeat = false;
                while (!repeat) 
                {
                    Console.CursorVisible = false;

                    // Nullable<timeSpan> sagt, das die Timespan auch Null sein darf. Kurzschreibweise ist Timespan?
                    Nullable<TimeSpan> reactiontime = null;
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
                    TimeSpan Signal = TimeSpan.FromMilliseconds(Random.Shared.Next(2000, 5000));
                    Console.WriteLine("wait");
                    Stopwatch stopwatch = new();
                    stopwatch.Restart();
                    bool tooFast = false;
                    while (stopwatch.Elapsed < Signal && tooFast == false)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {

                            tooFastFunktion();

                        }
                    }

                    Console.Clear();
                    stopwatch.Restart();
                    Console.WriteLine("Click");
                    bool tooSlow = true;
                    TimeSpan reactionTimeFinal = default;
                    
                    while (tooFast == false && stopwatch.Elapsed < reactiontime)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar && tooSlow)
                        {
                            tooSlow = false;
                            reactionTimeFinal = stopwatch.Elapsed;

                        }

                    }
                    double millisecond = reactionTimeFinal.TotalMilliseconds;
                    int roundedmilliseconds = (int)Math.Round(millisecond);
                    Console.WriteLine("Reactiontime: " + roundedmilliseconds + " Milliseconds" + "\n");
                    Console.WriteLine("Restart? [y: 1|n: 2]");


                    switch (Console.ReadKey(true).Key)

                    {
                        case ConsoleKey.D1:
                            repeat = false;
                            break;
                        case ConsoleKey.D2:
                            Stopgame();
                            break;
                    }

                    if (tooSlow == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Too Slow!\n");
                        Console.WriteLine("Restart? [y: 1|n: 2]");

                       
                        switch (Console.ReadKey(true).Key)

                        {
                            case ConsoleKey.D1: repeat = false;
                                break; 
                            case ConsoleKey.D2: Stopgame(); 
                                break;
                        }



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
            
            
        }
        private static void Stopgame()
        {
            Console.Clear();
            repeat = true;
            
            
            
        }
        


    }
}
