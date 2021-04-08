using System;

namespace ConsoleApp1
{
    public class Individual
    {
        private int a;
        private int b;

        public Individual(int[] x1, int[] x2, int a, int b)
        {
            X1Binary = x1;
            X2Binary = x2;
            this.a = a;
            this.b = b;

            NumberOfBits = x1.Length;
        }

        public int[] X1Binary { get;}
        public int[] X2Binary { get;}

        public int NumberOfBits { get; }

        public double FunctionResult => BoothFunction.CalculateFor(this);

        public double GetX1Dec(int a, int b, int m) => CalculateDecimal(a, b, m, X1Binary);

        public double GetX2Dec(int a, int b, int m) => CalculateDecimal(a, b, m, X2Binary);

        private double CalculateDecimal(int a, int b, int m, int[] xBinary)
        {
            var resultOfDecimal = Convert.ToInt32(string.Join("", xBinary), 2);
            return a + resultOfDecimal * (b - a) / ((2 ^ m) - 1);
        }
    }
}
