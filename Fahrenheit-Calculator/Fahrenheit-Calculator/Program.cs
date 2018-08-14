using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celcius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Fahrenheit til Celcius = {0}",celcius);

            Console.ReadKey();
        }
    }
}
