using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var individualGenerator = new IndividualGenerator();
            var generatedList = individualGenerator.GenerateList(10, 6, -10, 10);
            var x = generatedList.First().X1Binary;
            var xx = generatedList.First().GetX1Dec();
            var inwersja = new Inwersja();
            var res = inwersja.Inwersuj(generatedList[0], -10, 10);

            Console.WriteLine("Hello World!");
        }
    }
}
