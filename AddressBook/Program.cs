using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            AddressBookSys records = new AddressBookSys(); // Creating a object of AddressBookSys class
            Console.WriteLine("1. Add a new Record of your choice");
            int ch = Convert.ToInt32(Console.ReadLine()); // Storing User Choice
            
            records.AddRecords(); // Calling AddRecords method of AddressBookSys class 
            records.PrintRecords(); // Calling PrintRecords method of AddressBookSys class 
            Console.ReadLine();

        }
    }
}
