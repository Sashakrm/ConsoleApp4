using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("сторона: ");
            double side = double.Parse(Console.ReadLine());
            double perimeter = 4 * side; 
            double area = side * side; 
            Console.WriteLine($"Периметр: {perimeter}, Площадь: {area}");
        }
    }
}
