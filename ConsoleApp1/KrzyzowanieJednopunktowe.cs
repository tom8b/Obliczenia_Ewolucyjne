using System;

namespace ConsoleApp1
{
    public class KrzyzowanieJednopunktowe
    {
        public Individual Krzyzuj(Individual firstIndividual, Individual secondIndividual, int a, int b)
        {
            int[] resultX1 = Array.Empty<int>();
            int[] resultX2 = Array.Empty<int>();
            var punktKrzyzowania = WybierzPunktKrzyzowania(firstIndividual.NumberOfBits);

            for (int i = 0; i < firstIndividual.NumberOfBits; i++)
            {
                resultX1[i] = i < punktKrzyzowania ? firstIndividual.X1Binary[i] : secondIndividual.X2Binary[i];
                resultX2[i] = i < punktKrzyzowania ? firstIndividual.X1Binary[i] : secondIndividual.X2Binary[i];
            }

            return new Individual(resultX1, resultX2, a, b);
        }

        private int WybierzPunktKrzyzowania(int numberOfBits)
        {
            Random random = new Random();
            return random.Next(1, numberOfBits-1);
        }
    }
}
