using System;

namespace Mobile_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("25-NTU-CS-FL-1187",256.947);
            account.MainInterface();
            Console.WriteLine("-------------------------");
        }
    }
}
