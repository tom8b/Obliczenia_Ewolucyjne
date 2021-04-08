using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class SelekcjaNajlepszych
    {
        public List<Individual> Select(List<Individual> individuals, double percent) //procenty = od 0 do 1
        {
            var ordered = individuals.OrderByDescending(x => x.FunctionResult);
            var numberOfChoosen = (int)(percent * individuals.Count());

            return ordered.Take(numberOfChoosen).ToList();
        }
    }
}
