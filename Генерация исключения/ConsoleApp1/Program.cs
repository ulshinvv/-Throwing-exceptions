using FunctionCalculator;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N = 1;
            double K = 1;
            int iterations = 10; 
            FunctionCalculator1 functionCalculator = new FunctionCalculator1();

            functionCalculator.Calculate(N, iterations,K);
        }
    }
}