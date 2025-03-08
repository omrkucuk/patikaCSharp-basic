using System;

class Program
{
    static void Main()
    { 
        Console.Write("Kelime girin: ");
        string word = Console.ReadLine();
        Console.WriteLine("Ters Çevrilmiş: " + SwapCharacters.SwapAdjacentCharacters(word));
    }
}