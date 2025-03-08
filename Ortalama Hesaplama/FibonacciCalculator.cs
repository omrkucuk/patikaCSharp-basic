public class FibonacciCalculator
{
    public List<int> GetFibonacciSeries(int depth)
    {
        List<int> fibonacciSeries = new List<int>();

        if (depth <= 0) return fibonacciSeries;

        fibonacciSeries.Add(0);
        if (depth == 1) return fibonacciSeries;

        fibonacciSeries.Add(1);

        for (int i = 2; i < depth; i++)
        {
            int nextNumber = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
            fibonacciSeries.Add(nextNumber);
        }
        return fibonacciSeries;
    }
}