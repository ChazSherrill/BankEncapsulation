using System;
using System.Text.RegularExpressions;

namespace BankEncapsulation
{
    public class PersonalInformation
    {
        public PersonalInformation()
        {
            Console.WriteLine("Can you tell me your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Can you tell me your last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Can you tell me what is the first line of your address?");
            StreetAddress = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("If your address needs another line you can write it here.");
            Address2 = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("In what city do you live?");
            City = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("In what state do you live?");
            State = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("What is your zip code?");
            Zip = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            Console.WriteLine("What's your phone number?");
            NumberFormatted = Console.ReadLine();
            Console.WriteLine("---------------------------------");
        }



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        private string phoneNumber;

        public string NumberFormatted
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }


        }

        public void PrintPersonalInfo()
        {
             Console.WriteLine(FirstName);
             Console.WriteLine(LastName);
             Console.WriteLine(StreetAddress);
             Console.WriteLine(Address2);
             Console.WriteLine(City);
             Console.WriteLine(State);
             Console.WriteLine(Zip);
            Console.WriteLine(phoneNumber);
        }



    }
}
