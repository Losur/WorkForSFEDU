using System.IO;
using System;
using System.Diagnostics;

public class Logger
{
    private Logger()
    { }

    private static Logger instance = null;

    public static Logger Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    private const string FILENAME = "log.txt";

    public void WriteInfo(string info)
    {
        using(StreamWriter sw = new StreamWriter("D:\\" + FILENAME, true))
        {
            sw.WriteLine(info);
        }
    }
}

public class FirstWriter
{
    public readonly Logger logger = Logger.Instance;

    public void writeLog(string information)
    {
        logger.WriteInfo(information);
    }
}

public class SecondWriter
{
    public readonly Logger logger = Logger.Instance;

    public void writeLog(string information)
    {
        logger.WriteInfo(information);
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while(timer.Elapsed.TotalSeconds < 0.04)
        {
            Logger logger = Logger.Instance;

            FirstWriter first = new FirstWriter();
            SecondWriter second = new SecondWriter();
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