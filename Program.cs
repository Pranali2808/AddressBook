﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Address Book Program on Master ");
            AddNweContact AD = new AddNweContact();                    // Creating a Object of Main Class     
            while (true)                                // Checking a Choice with Switch Statement
            {
                Console.WriteLine("1. Adding Contact \n2. Show All Contact \n3. Edit  \n4. Exit");
                Console.WriteLine("Enter a Your Choice :");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        CreateContact ContactDetails = AD.GetContactInput();
                        AD.addContact(ContactDetails);

                        Console.WriteLine("Contact Added Successfully");
                        break;

                    case 2:
                        AD.ShowContactOutput();
                        Console.WriteLine("Please Enter Your Information");
                        break;

                    case 3:
                        AD.EditContact();
                        //Console.WriteLine("Contact Edited Succesfully");
                        break;
                    case 4:
                        Console.WriteLine("Thank You We are Exiting");
                        return;

                    default:
                        Console.WriteLine("Sorry You are Type Wrong Choice");
                        break;

                }
            }
        }
    }
}
