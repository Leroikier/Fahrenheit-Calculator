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
            //Input
            Console.WriteLine("Indtast Fahrenheit");
            double fahrenheit = double.Parse(Console.ReadLine());

            //Udregning
            double celcius = (fahrenheit - 32) * 5 / 9;

            //Output
            Console.WriteLine("Fahrenheit til Celcius = {0}",celcius);

            //Slut
            Console.ReadKey();
        }
    }
}
