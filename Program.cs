using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5; int b = 8;
            Console.WriteLine($"Values before swapping: a={a}, b={b}");
            a = a + b;     
            b = a - b;   
            a = a - b;
            Console.WriteLine($"Values after swapping: a={a}, b={b}");
        }
    }
}
