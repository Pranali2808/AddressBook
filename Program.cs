using System;
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
            int adno = 0;
            Console.WriteLine("Welcome To The Address Book System");

            AddNweContact AD = new AddNweContact();                     // Creating a Object of Main Class
            AddNweContact AD2 = new AddNweContact();
            do
            {
                Console.WriteLine("1. Personal Address Book \n 2. Shop Address Book \n.Exit");
                Console.WriteLine("Select the Address Book:");
                adno = Convert.ToInt32(Console.ReadLine());
                switch (adno)
                {
                    case 1:
                        ManageADBOOK(AD);
                        break;
                    case 2:
                        ManageADBOOK(AD2);
                        break;
                    case 3:
                        Console.WriteLine("Thank You For Exiting");
                        break;
                }
            } while (adno < 3);
        }
        private static void ManageADBOOK(AddNweContact ABP)
        {
            //while (true)                                // Checking a Choice with Switch Statement
            // {
            Console.WriteLine("1. Adding Contact \n2. Show All Contact \n3. Edit \n4. Delete \n5. Exit");
            Console.WriteLine("Enter a Your Choice :");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    CreateContact ContactDetails = ABP.GetContactInput();
                    ABP.addContact(ContactDetails);

                    Console.WriteLine("Contact Added Successfully");
                    break;

                case 2:
                    ABP.ShowContactOutput();
                    Console.WriteLine("Please Enter Your Information");
                    break;

                case 3:
                    ABP.EditContact();
                    Console.WriteLine("Contact Edited Succesfully");
                    break;
                case 4:
                    ABP.DeleteContact();
                    break;
                case 5:
                    Console.WriteLine("Thank You We are Exiting");
                    return;

                default:
                    Console.WriteLine("Sorry You are Type Wrong Choice");
                    break;
            }
        }
    }
}

