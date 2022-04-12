using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            Console.ReadLine();

            //Created object to call contacts menthod
            CreateContacts createContacts = new CreateContacts();
            createContacts.Contacts();
        }
    }
}
