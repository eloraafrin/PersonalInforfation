using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address, dateOfBirth;
            int contactNo, age;

            Console.WriteLine("Please enter your personal Information here, ");

            Console.Write("Your Name: ");
            name = Console.ReadLine();

            Console.Write("Your present address: ");
            address = Console.ReadLine();

            Console.Write("Your Contact Number: ");
            contactNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your Date of Birth: ");
            dateOfBirth = Console.ReadLine();

            Console.Write("Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 Your Personal Information");

            Console.WriteLine();
            Console.WriteLine("     Name: "+name);
            Console.WriteLine();
            Console.WriteLine("     Address: "+address);
            Console.WriteLine();
            Console.WriteLine("     Contact No.: "+contactNo);
            Console.WriteLine();
            Console.WriteLine("     Date of Birth: "+dateOfBirth);
            Console.WriteLine();
            Console.WriteLine("     Age: "+age);

            Console.ReadKey();


        }
    }
}
