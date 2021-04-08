using System;

namespace ConsoleApp1
{
    public class Individual
    {
        public Individual(double x1, double x2, int numberOfBits)
        {
            X1 = x1;
            X2 = x2;
            NumberOfBits = numberOfBits;
        }

        public Individual(int[] x1, int[] x2)
        {
            // TODO: przypisac x1 i x2 po przeliczeniu na dziesietne
            NumberOfBits = x1.Length;
        }

        public double X1 { get; }
        public double X2 { get; }
        public int NumberOfBits { get; }

        public double FunctionResult => BoothFunction.CalculateFor(this);

        public int[] GetX1Binary()
        {
            // TODO
            throw new NotImplementedException();
        }

        public int[] GetX2Binary()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
