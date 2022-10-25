using System;

namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Use Case #1: Create a contact in Address Book");
            Console.WriteLine("Use Case #2: Add a new contact in Address Book");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddressBook addressBookOne = new AddressBook("John", "Doe", "House-100", "Texas", "Florida", "111111", "9876543210", "john@google.com");
                    addressBookOne.Display();
                    break;
                case 2:
                    AddressBook addressBookTwo = new AddressBook();
                    addressBookTwo.AddContact();
                    addressBookTwo.Display();
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }


        }
    }
}