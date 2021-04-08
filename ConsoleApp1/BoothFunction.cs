namespace ConsoleApp1
{
    public static class BoothFunction
    {
        // BOOTH FUNCTION
        public static double CalculateFor(Individual individual)
        {
            return (individual.GetX1Dec() + 2 * individual.GetX2Dec() - 7) * (individual.GetX1Dec() + 2 * individual.GetX2Dec() - 7) + (2 * individual.GetX1Dec() + individual.GetX2Dec() - 5) * (2 * individual.GetX1Dec() + individual.GetX2Dec() - 5);
        }
    }
}
