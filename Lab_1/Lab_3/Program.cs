using System;

namespace Lab_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var first = new FirstBankAccountHandler();
            var second = new SecondBankAccountHandler();
            var third = new ThirdBankAccountHandler();

            first.SetNext(second).SetNext(third);

            Client.ClientSimulator(first);
            Console.WriteLine("Subchain");
            Client.ClientSimulator(second);
        }
    }
}