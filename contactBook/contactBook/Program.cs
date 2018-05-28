/*
This program simulates a contact book. Users may:
1) Enter a new contact
2) Search for a new contact
3) Remove a contact
4) Edit a contact


PROGRESS:
- enter & save new contact

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace contactBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            Console.WriteLine("Hello! Welcome to the Address Book!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Please choose an option from below:(Only option 1 currently works)");
            Console.WriteLine("1. Create Contact");
            Console.WriteLine("2. Search for Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");

            userChoice = Int32.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    CreateContact();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                default:
                    break;
            }

        }

        public static void CreateContact()
        {
            string Name;
            long PhoneNum;
            string Address;
            

            //FileStream f = new FileStream("ContactBook.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter f = new StreamWriter("ContactBool.txt");

            Console.WriteLine("Please enter your name, phone number, and address: ");
            Name = Console.ReadLine();
            PhoneNum = Int64.Parse(Console.ReadLine());
            Address = Console.ReadLine();
            //8,503,681,062
            f.WriteLine(Name);
            f.WriteLine(PhoneNum);
            f.WriteLine(Address);
            f.WriteLine("");
        }
    }
}
