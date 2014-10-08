using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComplex
{
    class Complex
    {
        private int real;
        private int imaginary;

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public Complex(Complex complex)
        {
            this.real = complex.getReal();
            this.imaginary = complex.getImaginary();
        }

        public Complex Add(Complex complex)
        {
            int returnReal = real + complex.getReal();
            int returnImaginary = imaginary + complex.getImaginary();

            return new Complex(returnReal, returnImaginary);
        }

        public static Complex Add(Complex c1, Complex c2)
        {
            return c1.Add(c2);
        }

        public static Complex operator + (Complex c1, Complex c2)
        {
            return c1.Add(c2);
        }

        public int getReal()
        {
            return real;
        }

        public int getImaginary()
        {
            return imaginary;
        }

        public override string ToString()
        {
            return (imaginary < 0) ? string.Format("{0}{1}i", real, imaginary) : string.Format("{0}+{1}i", real, imaginary);
        }
    }
}
