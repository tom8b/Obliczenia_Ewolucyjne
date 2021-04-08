using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class IndividualGenerator
    {
        public List<Individual> GenerateList(double minValue, double maxValue, int count, int numberOfBits)
        {
            var result = new List<Individual>();
            for (int i = 0; i < count; i++)
            {
                var firstRandomNumberInRange = GetRandomDouble(minValue, maxValue);
                var secondRandomNumberInRange = GetRandomDouble(minValue, maxValue);

                result.Add(new Individual (firstRandomNumberInRange, secondRandomNumberInRange, numberOfBits));
            }

            return result;
        }
        
        private double GetRandomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
    }
}
