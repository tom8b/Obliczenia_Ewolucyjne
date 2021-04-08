using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Strategy
    {
        private readonly IndividualGenerator _individualGenerator;
        private readonly SelekcjaNajlepszych _selekcjaNajlepszych;

        public Strategy(IndividualGenerator individualGenerator, SelekcjaNajlepszych selekcjaNajlepszych)
        {
            _individualGenerator = individualGenerator;
            _selekcjaNajlepszych = selekcjaNajlepszych;
        }

        public void Execute(int a, int b, int populationAmount, int numberOfBits, int epochsAmount, int bestAndTournamentChomosomeAmount, int eliteStrategyAmount, double crossProbability, double mutationProbability, double inversionProbability, SelectionMethod selectionMethod, CrossMethod crossMethod, MutationMethod mutationMethod, bool maximization)
        {
            //Poczatkowa populacja
            var population = _individualGenerator.GenerateList(populationAmount, numberOfBits, a, b);

            //Selekcja
            var afterSelection = Wyselekcjuj(selectionMethod, population, bestAndTournamentChomosomeAmount);





        }

        private List<Individual> Wyselekcjuj(SelectionMethod selectionMethod, List<Individual> population, int bestChromosomeAmount)
        {
            switch (selectionMethod)
            {
                case SelectionMethod.BEST:
                    return _selekcjaNajlepszych.Select(population, bestChromosomeAmount);
                default:
                    throw new NotImplementedException();
            }
        }
    }

  

    public enum SelectionMethod
    {
        BEST
    }

    public enum CrossMethod
    {
        ONE_POINT
    }

    public enum MutationMethod
    {
        ONE_POINT
    }
}
