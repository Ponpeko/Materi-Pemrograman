using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMachine
{
    public class Calculator
    {
        public int penjumlahan(int a, int b)
        {
            return a + b;
        }

        public int pengurangan(int a, int b)
        {
            return a - b;
        }

        public int perkalian(int a, int b)
        {
            return a * b;
        }

        public static int pembagian(int a, int b)
        {
            return a / b;
        }

        public int Pangkat (int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public static int Modulo (int a, int b)
        {
            return a % b;
        }
    }
}
