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
            Console.WriteLine(" Welcome To Address Book Program on Master ");
            CreateContact contactdetails = new CreateContact("Pranali", "Rane", "Bhusawal", "Jalgaon", "Maharashtra", 425305, 260101, "ranepranali1997h@gmail.com");
            Console.WriteLine("Contact Detail is Created for : " + contactdetails.Firstname + " " + contactdetails.Lastname);
            Console.WriteLine("Address Is :" + contactdetails.Address);
            Console.WriteLine("City Is : " + contactdetails.City);
            Console.WriteLine("State Is : " + contactdetails.State);
            Console.WriteLine("Zip Is : " + contactdetails.Zip);
            Console.WriteLine("Phone Number Is : " + contactdetails.PhoneNumber);
            Console.WriteLine("Email Is : " + contactdetails.Email);
            Console.ReadLine();
        }
    }
}
