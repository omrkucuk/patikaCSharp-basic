namespace FibonacciOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisinin derinliğini girin: ");
            int depth = Convert.ToInt32(Console.ReadLine());

            
            FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
            List<int> fibonacciSeries = fibonacciCalculator.GetFibonacciSeries(depth);

            
            AverageCalculator averageCalculator = new AverageCalculator();
            double average = averageCalculator.CalculateAverage(fibonacciSeries);

            
            Console.WriteLine("\nFibonacci Serisi: ");
            foreach (var number in fibonacciSeries)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nFibonacci serisinin ortalaması: " + average);
        }
    }
}
