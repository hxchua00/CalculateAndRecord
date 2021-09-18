using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAndRecord
{
    class Calculate
    {
        //Global Variables
        int x, y;
        //int addCount, multCount, minusCount, divideCount; //Counters
        static int count;
        int input1, input2;
        
        static Calculate()
        {
            count = 0;
        }

        public Calculate() { }

        public Calculate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void InputMsg()
        {
            Calculate c = new Calculate(input1, input2);          

            Console.WriteLine("Enter first number: ");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            input2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void Add()
        {
            InputMsg();
            Console.WriteLine("Adding...");
            Console.WriteLine("Result is " + (input1 + input2));
            Console.WriteLine();
            count++;
        }
        public void Multuply()
        {
            InputMsg();
            Console.WriteLine("Multiplying...");
            Console.WriteLine("Result is " + (input1 + input2));
            Console.WriteLine();
            count++;
        }
        public void Minus()
        {
            InputMsg();
            Console.WriteLine("Subtracting...");
            if (input1 > input2)
            {
                Console.WriteLine("Result is " + (input1 - input2));
            }
            else
            {
                Console.WriteLine("Result is " + (input2 - input1));
            }

            Console.WriteLine();
            count++;
        }
        public void Divide()
        {
            InputMsg();
            Console.WriteLine("Adding...");
            if (input1 != 0 && input2 != 0)
            {
                if (input1 > input2)
                {
                    Console.WriteLine("Result of " + input1 + " divided by " + input2 + " is " + (input1 / input2));
                }
                else
                {
                    Console.WriteLine("Result of " + input2 + " divided by " + input1 + " is " + (input2 / input1));
                }
            }

            Console.WriteLine();
            count++;
        }

        public void showUsedOperators()
        {
            //Console.WriteLine("Number of additions: " + addCount);
            //Console.WriteLine("Number of subtractions: " + minusCount);
            //Console.WriteLine("Number of multiplications: " + multCount);
            //Console.WriteLine("Number of divisions: " + divideCount);
            //Console.WriteLine();
            //Console.WriteLine("Total number of operators used is " + (addCount + minusCount + multCount + divideCount));
            //Console.WriteLine();
            Console.WriteLine("Total number of operations: " + count);
            Console.WriteLine();
        }
    }
}
