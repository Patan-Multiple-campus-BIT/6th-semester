//8.For a password management system, you could build a PasswordManager class using an indexer to store usernames as keys and their corresponding passwords as values. The indexer would act like a dictionary, enabling users to retrieve or update password entries by username
using System;
namespace section4.Properties
{
    class PasswordManager
    {
        private int size, i;
        private string[] username;
        private string[] password;
        public PasswordManager(int size)
        {
            this.size = size;
            this.username = new string[size];
            this.password = new string[size];
            Console.WriteLine($"Password Manger have been created sucessfully and can store {this.size} different username along with their password");
        }
        public object this[string username]
        {
            get
            {
                for(i = 0; i < this.size; i++)
                {
                    if (this.username[i] == username.ToUpper())
                        return this.password[i];
                }
                return null;
            }
            set
            {
                for(i = 0; i < this.size; i++)
                {
                    if (this.username[i] == username.ToUpper())
                    {
                        this.password[i] =(string)value;
                        Console.WriteLine($"Pasword for the username {username} has been updated sucessfully.");
                        break;
                    }
                    else if(string.IsNullOrEmpty(this.username[i]))
                    {
                        this.username[i] = username.ToUpper();
                        this.password[i] = (string)value;
                        Console.WriteLine($"Pasword for the username {username} has been set sucessfully ");
                        break;
                    }
                }
                if(i == size)
                    Console.WriteLine($"Password for the {username} cann't be added or updated.");
            }
        }
    }
    internal class question8
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int size;
            string decision, username, pass;
            Console.Write("Enter the size of the password manager you want: ");
            size = Convert.ToInt32(Console.ReadLine());

            PasswordManager mymanager = new PasswordManager(size);
            do
            {
                Console.WriteLine();
                Console.Write("What do you want to do Add/Update/Retrive password or exit? ");
                decision = Console.ReadLine().ToUpper();

                if (decision == "ADD")
                {
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
                    do
                    {
                        Console.Write($"Enter the password for the username {username}: ");
                        pass = Console.ReadLine();
                        if (string.IsNullOrEmpty(pass))
                            Console.WriteLine("Password cann't be empty or null.\n");

                    } while (string.IsNullOrEmpty(pass));
                    mymanager[username] = pass;
                }
                else if (decision == "UPDATE")
                {
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
                    do
                    {
                        Console.Write($"Enter the new password for the username {username}: ");
                        pass = Console.ReadLine();
                        if (string.IsNullOrEmpty(pass))
                            Console.WriteLine("Password cann't be empty or null.\n");

                    } while (string.IsNullOrEmpty(pass));
                    mymanager[username] = pass;
                }
                else if(decision == "RETRIVE")
                {
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
                    pass = (string)mymanager[username];
                    Console.WriteLine($"Password for the username {username} is {pass}");
                }
               

            } while (decision == "ADD" || decision == "UPDATE" || decision == "RETRIVE");
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
