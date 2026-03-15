using System;
namespace Mobile_Directory
{
    class BankAccount
    {
        private string accountNo;
        private double balance;
        private string nameOfAccountHolder;
        private string CNIC;
        private string phoneNo;
        private string email;
        private string address;
        private double initialDeposit;
        public BankAccount(string accountNo,double balance)
        {
            this.accountNo = accountNo;
            this.balance = balance;
        }
        public BankAccount()
        {
            accountNo = "Unknown";
            balance = 0.0;
        }
        public BankAccount(BankAccount copy)
        {
            this.accountNo = copy.accountNo;
            this.balance = copy.balance;
        }
        public void MainInterface()
        {
            Console.Clear();
            Console.WriteLine("==== Bank Account Managment System =====");
            Console.WriteLine("1.Add New Account");
            Console.WriteLine("2.Display Account Details");
            Console.WriteLine("3.Deposit Amount to Account");
            Console.WriteLine("4.Withdraw Amount From Account");
            Console.WriteLine("5.Exit From the System");
            Console.WriteLine();
            bool flag = false;
            do
            {
                Console.Write("Enter Your Choice:");
                if(int.TryParse(Console.ReadLine(),out int choice))
                {
                    if (choice >= 1 && choice <= 5)
                    {
                        flag = true;
                        switch (choice)
                        {
                            case 2:
                                Display();
                                break;
                            case 3:
                                Deposit();
                                break;
                            case 4:
                                Withdraw();
                                break;
                            case 5:
                                return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice!!!");
                        Console.WriteLine("Try again with a valid choice...");
                    }
                }
                else
                {
                    Console.WriteLine("The choice you entered is not an integer!!!");
                }
            } while (flag == false);
        }
        public void Display()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("  Bank Account Details");
            Console.WriteLine($"Account No :{accountNo}");
            Console.WriteLine($"Balance In Account:{balance}");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.Write("Press any key to return to Main Interface...");
            Console.ReadKey();
            MainInterface();
        }
        public void Deposit()
        {
            Console.WriteLine("--------------------------");
            Console.Write("Enter the amount of Money you want to deposit in your account:");
            double entry = double.Parse(Console.ReadLine());
            balance = balance + entry;
            Console.WriteLine("Money successfully deposited to the account...");
            Console.WriteLine();
            Console.Write("Press any key to return to Main Interface...");
            Console.ReadKey();
            MainInterface();
        }
        public void Withdraw()
        {
            Console.WriteLine("--------------------------");
            Console.Write("Enter the amount of money you want to withdraw from the account:");
            double removal = double.Parse(Console.ReadLine());
            if(removal<=balance)
            {
                balance = balance - removal;
                Console.WriteLine("Money successfully withdrawn from the account:");
            }
            else
            {
                Console.WriteLine("Insufficient balance in your account!!!");
                Console.WriteLine("You cant deduct this amount from the account");
            }
            Console.WriteLine();
            Console.Write("Press any key to return to Main Interface...");
            Console.ReadKey();
            MainInterface();
    }
}
}
