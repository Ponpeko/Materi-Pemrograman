using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMachine;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Nilai A: ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("Nilai B: ");
            var b = int.Parse(Console.ReadLine());

            var cal = new Calculator();

            Console.WriteLine();
            Console.WriteLine("Hasil: ");
            Console.WriteLine("Penjumlahan: {0} + {1} = {2}", a, b, cal.penjumlahan(a,b));
            Console.WriteLine("Pengurangan: {0} - {1} = {2}", a, b, cal.pengurangan(a,b));
            Console.WriteLine("Perkalian  : {0} * {1} = {2}", a, b, cal.perkalian(a,b));
            Console.WriteLine("Pembagian  : {0} / {1} = {2}", a, b, Calculator.pembagian(a,b));
            Console.WriteLine("Pangkat    : {0} ^ {1} = {2}", a, b, cal.Pangkat(a,b));
            Console.WriteLine("Modulo     : {0} % {1} = {2}", a, b, Calculator.Modulo(a,b));

            Console.ReadKey();
        }
    }
}
