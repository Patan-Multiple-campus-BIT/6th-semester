//7.Encapsulation and Validation:
//Create a class named Employee with the following fields:
//•	firstName(string)
//•	lastName(string)
//•	salary(double)
//a) Modify the class by converting these fields into properties. Each property should have a getter and a setter. Implement validation logic in the setters:
//- `firstName` and `lastName` should only accept non-empty strings. Throw an `ArgumentException` with an appropriate message if an empty string is provided.
//- `salary` should only accept positive values. Throw an `ArgumentOutOfRangeException` with an informative message if a non-positive value is provided.
//b) Create a new Employee object and try setting invalid values for each property. Observe the exceptions thrown by the validation logic.

using System;
namespace Section2
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private double salary;

        public string FirstName
        {
            get => firstName;
            set {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        this.firstName = value;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("FirstName cann't be empty");
                    Console.WriteLine("Setting the first name to admin");
                    this.firstName = "Admin";
                    Console.WriteLine();
                }
            }
        }
        public string LastName
        {
            get => lastName;
            set {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        this.lastName = value;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("LastName cann't be empty");
                    Console.WriteLine("Setting the last name to admin");
                    this.lastName = "Admin";
                    Console.WriteLine();
                }
            }
        }
        public double Salary
        {
            get => salary;
            set
            {
                try
                {
                    if (value < 0.0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        this.salary = value;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Salary cann't be a negative number.");
                    Console.WriteLine("Setting the salary to 0");
                    this.salary = 0.0;
                    Console.WriteLine();
                }
            }
        }
        public void GiveDetails()
        {
            Console.WriteLine();
            Console.WriteLine("The details of employee is as follow: ");
            Console.WriteLine($"The name of the employee is: {this.firstName} {this.lastName}");
            Console.WriteLine($"The salary of the employee is: ${this.salary}");
            return;
        }

    }
    internal class question7
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            double salary = 0.0;
            bool iserror = true;
            Employee employee1 = new Employee();
            Console.Write("Enter the firstname of the employee: ");
            employee1.FirstName = Console.ReadLine();
            Console.Write("Enter the lastname of the employee: ");
            employee1.LastName= Console.ReadLine();
            while (iserror)
            {
                Console.Write("Enter the salary of the employee: ");
                try
                {
                    employee1.Salary = Convert.ToDouble(Console.ReadLine());
                    iserror = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("salary must be a numeric value");
                }

            }
            employee1.GiveDetails();
            Console.ReadKey();
            return;
        }

    }
}
