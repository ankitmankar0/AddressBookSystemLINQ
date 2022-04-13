using System;

namespace AddressBookLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System Using LINQ ");

            // UC 1 Create a new table
            AddressBookTable addressBookTable = new AddressBookTable();

            // UC3
           // addressBookTable.GetAllContacts();

            // UC4
            //addressBookTable.EditExistingContact("Ankit", "Mankar", "PhoneNumber", "8888888888");

            // UC5
            addressBookTable.DeleteContact("Vishal", "Singh");
        }
    }
}
