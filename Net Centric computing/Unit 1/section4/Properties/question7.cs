//7.Imagine developing an e-commerce application. You could create a ShoppingCart class with an indexer to manage the list of items added by a user. This indexer would allow accessing and modifying individual items in the cart based on their position (index).
using System;
namespace section4.Properties
{
    class ShoppingCart
    {
        private string[] cart;
        private int size;

        public ShoppingCart(int size)
        {
            this.size = size;
            cart = new string[size];
            Console.WriteLine($"You have the shopping cart with capacity of {size} items");
        }
        public object this[int index]
        {
            get
            {
                index--;
                if(index >=size)
                {
                    Console.WriteLine($"Your cart size is only of {this.size} items. So you don't have {index + 1} position in your cart");
                    return null;
                }
                else
                {
                    if (string.IsNullOrEmpty(cart[index]))
                    {
                        return null;
                    }
                    else
                    {
                        return cart[index];
                    }
                }

            }
            set
            {
                index--;
                if (index < 0 || index > size)
                {
                    Console.WriteLine($"You have the cart size of {this.size} only.So cann't add item at position {index + 1}");
                    //cart[index] = null;
                }
                else
                {
                    cart[index] = (string)value;
                    Console.WriteLine($"Item {(string)value} has been sucessfully inserted into the cart at position {index + 1}");
                }
            }
        }
    }
    internal class question7
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            int size,index;
            string itemname, decision;
            Console.Write("What size of cart do you want? ");
            size = Convert.ToInt32(Console.ReadLine());
            ShoppingCart mycart = new ShoppingCart(size);
            do
            {
                Console.WriteLine("\n");
                Console.Write("What do you want to do now? Add/Retrive/Exit? ");
                decision = Console.ReadLine().ToUpper();
                if (decision == "ADD")
                {
                    Console.Write("Enter the name of the items that you want to add into the cart: ");
                    itemname = Console.ReadLine();
                    Console.Write($"Enter the index(position) that you want to keep the item {itemname} into the cart: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    mycart[index] = itemname;
        
                }
                else if (decision == "RETRIVE")
                {
                    Console.Write("Enter the postion of the cart whose item you want to see: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    itemname = (string)mycart[index];
                    if (string.IsNullOrEmpty(itemname))
                        Console.WriteLine($"You have no item at postion {index} in your cart");
                    else
                        Console.WriteLine($"You have {itemname} at position {index} in your cart");

                }
            } while (decision == "ADD" || decision == "RETRIVE");
            Console.WriteLine("Happy Shopping");
            Console.ReadKey();
        }
    }
}
