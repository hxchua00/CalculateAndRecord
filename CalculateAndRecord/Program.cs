using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAndRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start calculating!");
            Console.WriteLine("");

            Calculate c = new Calculate();
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Show all used operators");
                Console.WriteLine("6) Exit");
                Console.WriteLine();

                Console.Write("Enter your option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:                        
                        c.Add();
                        break;
                    case 2:
                        c.Minus();
                        break;
                    case 3:
                        c.Multuply();
                        break;
                    case 4:
                        c.Divide();
                        break;
                    case 5:
                        c.showUsedOperators();
                        break;
                    case 6:
                        Console.WriteLine("Good bye!");
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Choose from the option!");
                        break;
                }
            }

            Console.ReadLine();
           
        }
    }
}
