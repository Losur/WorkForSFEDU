using System;
using System.Diagnostics;
using System.IO;

namespace Lab_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while(timer.Elapsed.TotalSeconds < 0.04)
            {
                CustomLogger logger = CustomLogger.Instance;
                First first = new First();
                Second second = new Second();
                if(first.logger == second.logger && logger == second.logger)
                {
                    logger.WriteInfo("They are the same");
                }
                Random random = new Random();
                var type = random.Next(0, 2);
                switch(type)
                {
                    case 0:
                        first.writeLog("First called" + timer.Elapsed.TotalSeconds.ToString() + "\n");
                        break;

                    default:
                        second.writeLog("Second called" + timer.Elapsed.TotalSeconds.ToString() + "\n");
                        break;
                }
            }
            timer.Stop();
        }
    }
}