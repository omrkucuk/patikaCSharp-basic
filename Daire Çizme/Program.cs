using System;

class Program
{
    static void Main()
    {
        Console.Write("Dairenin yarıçapını girin: ");
        int radius = int.Parse(Console.ReadLine());
        CircleDrawer.Draw(radius);
    }
}