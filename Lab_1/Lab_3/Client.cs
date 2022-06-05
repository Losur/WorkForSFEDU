using System;
using System.Collections.Generic;

namespace Lab_3
{
    internal class Client
    {
        public static void ClientSimulator(AccountsHandler handler)
        {
            foreach(var money in new List<int> { 9, 19, 32, 10000 })
            {
                Console.WriteLine($"Client: How can I paid?  *" + money);

                var result = handler.Handle(money);

                if(result != null)
                {
                    Console.WriteLine($"By your {result} wallet\n\n");
                }
                else
                {
                    Console.WriteLine($"You don't have enough money to paid by this request :(\n\n");
                }
            }
        }
    }
}