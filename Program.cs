using System;
namespace Homework1 {
    class Program {
        static void Main(string[] args) {
            string agency, password;
            Console.Write("Password : ");
            password = Console.ReadLine();

            if(password.Length <= 6) {
                Console.Write("Agency : ");
                agency = Console.ReadLine();
                switch(agency) {
                    case"CIA":
                    if((int)password[2] >= 54 && (int)password[2] != 56) {
                        if(password[4] != 49 && password[4] != 51 && password[4] != 53) {
                           int pass = int.Parse(password);
                           if(pass % 3 == 0) {
                            Console.WriteLine("True");
                           } else {
                            Console.WriteLine("False");
                           }
                        }
                        else {
                            Console.WriteLine("False");
                        }
                    }
                    else {
                            Console.WriteLine("False");
                    }
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
            else {
                Console.WriteLine("Error");
            }

        }
    }
}
