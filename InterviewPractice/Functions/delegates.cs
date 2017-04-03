using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Tests.Functions
{
    public class Delegates
    {
        public delegate double ProcessDelegate(double param1, double param2);

        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;


        public void DelegateTest()
        {
            ProcessDelegate process = null;
            Console.WriteLine("Enter 2 numbers separated by a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = double.Parse(input.Substring(0, commaPos));
            double param2 = double.Parse(input.Substring((commaPos + 1)));
            Console.WriteLine("Enter M to multiply, D to divide  (param1:{param1}, param2:{param2}) or Q to Quit:");
            input = Console.ReadKey().KeyChar.ToString().ToUpper();

            while (true)
            {
                if (input == "M")
                {
                    process = new ProcessDelegate(Delegates.Multiply);

                }
                else if (input == "D")
                {
                    process = new ProcessDelegate(Delegates.Divide);
                }
                else if(input == "Q")
                {
                    Console.WriteLine("  Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("You need to enter M or D to do calculations.");
                }

                if (process != null)
                {
                    Console.WriteLine($"  Result: {process(param1, param2)}");
                }

                input = (Console.ReadKey()).KeyChar.ToString().ToUpper();
            }

            Console.ReadLine();
        }

    }
}
