using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class CustomLogger
    {
        private CustomLogger()
        { }

        private static CustomLogger instance = null;

        public static CustomLogger Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CustomLogger();
                }
                return instance;
            }
        }

        private const string FILENAME = "log.txt";

        public void WriteInfo(string info)
        {
            using(StreamWriter sw = new StreamWriter("C:\\" + FILENAME, true))
            {
                sw.WriteLine(info);
            }
        }
    }
}