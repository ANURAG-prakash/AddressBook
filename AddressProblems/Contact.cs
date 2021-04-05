using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book
{
     class Contact
    {
        public static void contact_Details()
        {
            Console.WriteLine("Enter the First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter the City Name");
           string City = Console.ReadLine();
            Console.WriteLine("Enter the State Name");
            string State = Console.ReadLine();
            Console.WriteLine("Enter the zip code");
            string Zip = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the email address");
            string Email = Console.ReadLine();
        }

    }
}