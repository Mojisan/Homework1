using System;
namespace Homework1 {
    class Program {
        static void Main(string[] args) {
            int password;
            string agency;
            Console.Write("Password : ");
            password = int.Parse(Console.ReadLine());
            Console.Write("Agency : ");
            agency = Console.ReadLine();

            switch(agency) {
                case"CIA":
                Console.WriteLine("Hello CIA");
                break;
                case"FBI":
                Console.WriteLine("Hello FBI");
                break;
                case"NSA":
                Console.WriteLine("Hello NSA");
                break;
                default:
                Console.WriteLine("Error");
                break;
            }
        }
    }
}
