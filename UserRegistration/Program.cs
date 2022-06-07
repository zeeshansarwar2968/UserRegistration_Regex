using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t User Registration using Regular Expression (Regex)");
            RegexValidation regexValidation = new RegexValidation();
            Console.Write("Enter Your First Name : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));

            Console.Write("Enter Your Last Name : ");
            string LastName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateLastName(LastName));

            Console.Write("Enter Your Email : ");
            string email = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateEmail(email));
            
            Console.Write("Enter Your Phone Number : ");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidatePhone(PhoneNumber));

            Console.Write("Enter Your Password : ");
            string password = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidatePassword(password));


            Console.WriteLine("--------------Sample Email validation----------------");
            List<string> sampleCheck = new List<string>()
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmail.com.com",
                "abc+100@gmail.com"
            };

            foreach (var item in sampleCheck)
            {
                if (regexValidation.ValidateEmail(item))
                {
                    Console.WriteLine("{0} : Valid Email",item);
                }
                else
                {
                    Console.WriteLine("{0} : Not Valid Email", item);
                }
            }

        }
    }
}
