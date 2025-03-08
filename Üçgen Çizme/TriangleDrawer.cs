public class TriangleDrawer
{
     public static void Draw(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(' ', size - i) + new string('*', 2 * i - 1));
            }
        }
}