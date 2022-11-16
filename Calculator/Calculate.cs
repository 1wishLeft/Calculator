using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public double add(double a, double b)
        {
            return (a + b);
        }

        public double subtract(double a, double b)
        {
            return (a - b);
        }

        public double multiply(double a, double b)
        {
            return (a * b);
        }

        public double divide(double a, double b)
        {
            return (a / b);
        }

        public double sin(double a)
        {
            return Math.Sin(a);
        }

        public double cos(double a)
        {
            return Math.Cos(a);
        }

        public double tan(double a)
        {
            return Math.Tan(a);
        }

        public double log10(double a)
        {
            return Math.Log10(a);
        }

        public double ln(double a)
        {
            return Math.Log(a);
        }

    }
}
