class Program
{
    static void Main()
    {
        Console.Write("Üçgenin boyutunu girin: ");
        int triangleSize = int.Parse(Console.ReadLine());
        TriangleDrawer.Draw(triangleSize);
    }
 }