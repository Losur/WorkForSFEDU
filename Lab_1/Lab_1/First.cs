﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class First
    {
        public readonly CustomLogger logger = CustomLogger.Instance;

        public void writeLog(string information)
        {
            logger.WriteInfo(information);
        }
    }
}