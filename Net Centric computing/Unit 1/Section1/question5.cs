//5.Create a class named BankAccount with the following properties:
//•	accountNumber(string)
//•	balance(double)
//•	ownerName(string)
//•	Define a constructor that takes the accountNumber and ownerName as   arguments and initializes the corresponding properties. Set the initial balance to 0.
//•	Create a new BankAccount object using the constructor with appropriate arguments and print the details (account number, owner name, and balance) to the console.
using System;
namespace Section1
{
    class BankAccount
    {
        private string accountNumber;
        private double balance;
        private string ownerName;

        public BankAccount(string number,string name)
        {
            this.accountNumber = number;
            this.ownerName = name;
            this.balance = 0.0D;
        }

        public void displayDetails()
        {
            Console.WriteLine("Details of account are as follow: ");
            Console.WriteLine($"AccountNumber: {this.accountNumber}");
            Console.WriteLine($"OwnerName: {this.ownerName}");
            Console.WriteLine($"Balance: {this.balance}");
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            string name, number;
            Console.Write("Enter the name of the account holder: ");
            name = Console.ReadLine();
            Console.Write("Enter the account number: ");
            number = Console.ReadLine();

            BankAccount saving = new BankAccount(number, name);
            saving.displayDetails();
            Console.ReadKey();
        }

    }

}
