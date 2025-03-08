public class CircleDrawer
{
    public static void Draw(int radius)
    {
        double thickness = 0.4;
        for (int i = -radius; i <= radius; i++)
        {
            for (int j = -radius; j <= radius; j++)
            {
                double distance = Math.Sqrt(i * i + j * j);
                if (distance >= radius - thickness && distance <= radius + thickness)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}