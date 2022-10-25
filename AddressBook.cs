using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {

        private Contact[] addressBook;

        public AddressBook()
        {
            this.addressBook = new Contact[1];
        }

        public AddressBook(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.addressBook = new Contact[1];
            Contact contact = new Contact() { FirstName = firstName, LastName = lastName, Address = address, City = city, State = state, Zip = zip, PhoneNumber = phoneNumber, Email = email };
            addressBook[0] = contact;
        }

        public void AddContact()
        {
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter second name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter zip: ");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();

            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.Zip = zip;
            contact.PhoneNumber = phoneNumber;
            contact.Email = email;

            addressBook[0] = contact;
        }

        public void Display()
        {
            foreach (Contact contact in addressBook)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("First name: " + contact.FirstName);
                Console.WriteLine("Last name: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Zip: " + contact.Zip);
                Console.WriteLine("Phone number: " + contact.PhoneNumber);
                Console.WriteLine("Email: " + contact.Email);
                Console.WriteLine("-----------------------------");
            }
        }

    }
}
