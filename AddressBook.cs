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


        public AddressBook(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.addressBook = new Contact[1];
            Contact contact = new Contact() { FirstName = firstName, LastName = lastName, Address = address, City = city, State = state, Zip = zip, PhoneNumber = phoneNumber, Email = email };
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
