using System;

class Program
{
    static void Main()
    {
        Console.Write("Metin ve indexi girin (örnek: Algoritma,3): ");
        string input = Console.ReadLine();
        Console.WriteLine("Sonuç: " + StringManipulator.RemoveCharacterAtIndex(input));
    }
}