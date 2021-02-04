using System;

namespace Calculator
{

    public class Calculator
    {
        
        static void Main(string[] args)
        {
            Calculator number = new Calculator();

            Console.WriteLine("*** ADDING ***");
            double sum1 = number.Add(2, 10);
            Console.WriteLine("is {0}", sum1);

            double sum2 = number.Add(10, 4);
            Console.WriteLine("is {0}\r\n", sum2);

            Console.WriteLine("*** SUBTRACTING ***");
            double sum3 = number.Subtract(2, 10);
            Console.WriteLine("is {0}", sum3);

            double sum4 = number.Subtract(10, 4);
            Console.WriteLine("is {0}\r\n", sum4);

            Console.WriteLine("*** MULTIPLYING ***");
            double sum5 = number.Multiply(2, 10);
            Console.WriteLine("is {0}", sum5);

            double sum6 = number.Multiply(10, 4);
            Console.WriteLine("is {0}\r\n", sum6);

            Console.WriteLine("*** TO THE POWER(ING) XD ***");
            double sum7 = number.Power(4, 2);
            Console.WriteLine("is {0}\r\n", sum7);

        }

        public double Add(double a, double b)
        {
            Console.Write("Adding {0} and {1} ", a, b);
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Console.Write("Subtracting {0} from {1} ", a, b);
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Console.Write("Multiplying {0} with {1} ", a, b);
            return a*b;
        }

        public double Power(double x, double exp)
        {
            Console.Write("{0} to the power of {1} ", exp, x);
            return Math.Pow(x,exp);

        }

    }
}
