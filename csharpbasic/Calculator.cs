using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasic
{
    public class Calculator
    {
        private readonly double PI = 3.14;  
        public Calculator()
        {
            Console.WriteLine("Choose the operation");
            Console.WriteLine("1: add\n2: substract\n3: multiply\n4: divide");
            int i = Convert.ToInt32(Console.ReadLine());
            while (i != -1)
            {
                Console.WriteLine("enter x");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter y");
                int y = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("add op x + y = " + this.add(x, y));
                        break;
                    case 2:
                        Console.WriteLine("substract op x - y = " + this.substract(x, y));
                        break;
                    case 3:
                        Console.WriteLine("multiply op x * y = " + this.multiply(x, y));
                        break;
                    case 4:
                        Console.WriteLine("divide op x : y = " + this.divide(x, y));
                        break;
                    default:
                        Console.WriteLine("invalid op");
                        break;
                }
                Console.WriteLine("Choose the operation");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void welcome()
        {

        }

        public int add(int x, int y)
        {
            return x + y;
        }

        public int substract(int x, int y)
        {
            return x - y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int divide(int x, int y)
        {
            return x / y;
        }
    }
}
