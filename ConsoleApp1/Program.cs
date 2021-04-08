using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var individualGenerator = new IndividualGenerator();
            //var generatedList = individualGenerator.GenerateList(3, 6, -10, 10);

            var strategy = new Strategy(new IndividualGenerator(), new SelekcjaNajlepszych(), new SelekcjaTurniejowa(), new SelekcjaRuletka(), new KrzyzowanieJednopunktowe() , new KrzyzowanieDwupunktowe(), new KrzyzowanieJednorodne(), new MutacjaJednopunktowa(), new MutacjaDwupunktowa(), new MutacjaBrzegowa(), new Inwersja());

            strategy.Execute(-10, 10, 10, 10, 3, 0.2, 0.2, 0.4, 0.2, 0.2, SelectionMethod.BEST, CrossMethod.ONE_POINT, MutationMethod.ONE_POINT, true);
        }
    }
}
