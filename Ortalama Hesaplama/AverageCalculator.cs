public class AverageCalculator
{
    public double CalculateAverage(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            return 0;
        }

        double sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Count;
    }
}