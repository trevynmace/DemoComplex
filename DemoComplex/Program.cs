using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(2, 3);
            Complex complex2 = new Complex(1, -6);

            Console.WriteLine("complex1: {0}", complex1);
            Console.WriteLine("complex2: {0}", complex2);
            Console.WriteLine("complex1.add(complex2): {0}", complex1.Add(complex2));

            Complex complexAdd = Complex.Add(complex1, complex2);
            Console.WriteLine("add(complex1, complex2): {0}", complexAdd);

            Console.WriteLine("complex1 + complex2: {0}", complex1 + complex2);
        }
    }
}
