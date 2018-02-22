using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            double a; // Area
            double r; // Radius
            double v; // Volume
            
            // Ask for area
            Console.WriteLine("Cylinder area: ");
            a = double.Parse(Console.ReadLine());

            // Ask for volume
            Console.WriteLine("\nCylinder radius: ");
            r = double.Parse(Console.ReadLine());


            // Calculate and print
            v = Math.PI * r * a;
            Console.WriteLine("\nThe cylinder´s volume is: " + v);

            // Restart Program (loop)
            Console.ReadKey();
            Console.Clear();
            Test();
        }
    }
}
