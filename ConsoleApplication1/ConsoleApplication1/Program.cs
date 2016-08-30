using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            Console.WriteLine("type a valid date to calculate the age");
            input = Console.ReadLine();

            AgeCalc calc = new AgeCalc(input);

            calc.check();
            
            

        }
    }
}
