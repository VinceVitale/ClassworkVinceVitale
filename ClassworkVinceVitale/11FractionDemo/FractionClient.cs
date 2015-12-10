using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11FractionDemo
{
    class FractionClient
    {
        static void Main(string[] args)
        {
            Fraction[] fractions = new Fraction[4];
            Fraction[] add = new Fraction[16];
            Fraction[] mult = new Fraction[16];

            WriteLine("Enter the values for 4 fractions");
            for (int i = 0; i < fractions.Length; i++)
            {
                int wholeNumb = -1, numer = -1, denom = -1;
                WriteLine("\nEnter the values for fraction {0}", (i + 1));
                Write("Enter whole number: ");
                wholeNumb = Convert.ToInt32(ReadLine());
                while (wholeNumb < 0)
                {
                    WriteLine("Input must be an int of 0 or greater");
                    Write("Enter whole number: ");
                    wholeNumb = Convert.ToInt32(ReadLine());
                }
                Write("Enter the numerator: ");
                numer = Convert.ToInt32(ReadLine());
                while (numer < 0)
                {
                    WriteLine("Input must be an int of 0 or greater");
                    Write("Enter the numerator: ");
                    numer = Convert.ToInt32(ReadLine());
                }
                Write("Enter the denominator: ");
                denom = Convert.ToInt32(ReadLine());
                while (denom <= 0)
                {
                    WriteLine("Input must be an int of 1 or greater");
                    Write("Enter the denominator: ");
                    denom = Convert.ToInt32(ReadLine());
                }
                if (wholeNumb == 0)
                {
                    fractions[i] = new Fraction(numer, denom);
                }
                else
                {
                    fractions[i] = new Fraction(wholeNumb, numer, denom);
                }
            }
            int z = 0;
            for (int i = 0; i < fractions.Length; i++)
            {
                for (int x = 0; x < fractions.Length; x++)
                {
                    add[z] = (fractions[i] + fractions[x]);
                    mult[z] = (fractions[i] * fractions[x]);
                    z++;
                }
            }
            WriteLine("\n\n");
            for (int i = 0; i < fractions.Length; i++)
            {
                WriteLine("Fraction {0}: {1}", (i + 1), fractions[i].PrintFunction());
            }
            WriteLine("\n\n");
            for (int i = 0; i < add.Length; i++)
            {
                WriteLine("Added fraction {0}: {1}", (i + 1), add[i].PrintFunction());
            }
            WriteLine("\n\n");
            for (int i = 0; i < mult.Length; i++)
            {
                WriteLine("Multiplied fraction {0}: {1}", (i + 1), mult[i].PrintFunction());
            }
        }
    }
}
