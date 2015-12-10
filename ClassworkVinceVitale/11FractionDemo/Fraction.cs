using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11FractionDemo
{
    class Fraction
    {
        public int WholeNumber { get; set; }
        public int Numerator { get; set; }
        private int denominator;

        public int Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    value = 1;
                }
                this.denominator = value;
            }
        }

        public Fraction()
        {
            this.WholeNumber = 0;
            this.Numerator = 0;
            this.Denominator = 1;
        }
        
        public Fraction(int wholeNumb, int numer, int denom)
        {
            Reduce(ref wholeNumb,ref numer, ref denom);

            this.WholeNumber = wholeNumb;
            this.Numerator = numer;
            this.Denominator = denom;
        }
        
        public Fraction(int numer, int denom)
        {
            int wholeNumb = 0;
            Reduce(ref wholeNumb, ref numer, ref denom);

            this.WholeNumber = wholeNumb;
            this.Numerator = numer;
            this.Denominator = denom;
        }

        //Reduce if improper
        public static void Reduce(ref int wholeNumb, ref int numer, ref int denom)
        {
            if ((numer % denom) == 0)
            {
                wholeNumb += (numer / denom);
                numer = 0;
                denom = 1;
            }
            else
            {
                if (numer > denom)
                {
                    wholeNumb += (numer / denom);
                    numer = (numer % denom);
                }
                int j;
                if (numer <= denom)
                {
                    j = numer;
                }
                else if (numer > denom)
                {
                    j = denom;
                }
                else
                {
                    j = 0;
                }
                for (int i = j; i >= 2; i--)
                {
                    if (((numer % i) == 0) && ((denom % i) == 0))
                    {
                        numer = (numer / i);
                        denom = (denom / i);
                    }
                }
            }
        }
        
        public string PrintFunction()
        {
            string fractionString;
            if (WholeNumber != 0 && Numerator != 0)
            {
                fractionString =  WholeNumber+" "+ Numerator+"/"+Denominator+"\n";
            }
            else if(WholeNumber != 0 && Numerator == 0)
            {
                fractionString = WholeNumber + "\n";
            }
            else if (WholeNumber == 0 && Numerator != 0)
            {
                fractionString = Numerator + "/" + Denominator + "\n";
                WriteLine("{0}/{1}\n", Numerator, Denominator);
            }
            else
            {
                fractionString = "0\n";
            }
            return fractionString;
        }

        //overloaded + operator 
        public static Fraction operator +(Fraction first, Fraction second)
        {
            int fNumerator, sNumerator, commonDenominator, totalNumerator;
            fNumerator = (first.Numerator + (first.WholeNumber * first.Denominator));
            sNumerator = (second.Numerator + (second.WholeNumber * second.Denominator));
            commonDenominator = (first.Denominator * second.Denominator);
            fNumerator *= second.Denominator;
            sNumerator *= first.Denominator;
            totalNumerator = (fNumerator + sNumerator);
            return new Fraction(totalNumerator, commonDenominator);
        }

        //overloaded * operator 
        public static Fraction operator *(Fraction first, Fraction second)
        {
            int fNumerator, sNumerator, commonDenominator, totalNumerator;
            fNumerator = (first.Numerator + (first.WholeNumber * first.Denominator));
            sNumerator = (second.Numerator + (second.WholeNumber * second.Denominator));
            commonDenominator = (first.Denominator * second.Denominator);
            totalNumerator = (fNumerator * sNumerator);
            return new Fraction(totalNumerator, commonDenominator);
        }
    }
}
