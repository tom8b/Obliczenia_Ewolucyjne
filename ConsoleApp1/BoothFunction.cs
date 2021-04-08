namespace ConsoleApp1
{
    public static class BoothFunction
    {
        // BOOTH FUNCTION
        public static double CalculateFor(Individual individual)
        {
            return (individual.X1 + 2 * individual.X2 - 7) * (individual.X1 + 2 * individual.X2 - 7) + (2 * individual.X1 + individual.X2 - 5) * (2 * individual.X1 + individual.X2 - 5);
        }
    }
}
