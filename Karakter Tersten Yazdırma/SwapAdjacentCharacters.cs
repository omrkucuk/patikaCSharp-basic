class SwapCharacters
{
    public static string SwapAdjacentCharacters(string input)
    {
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length - 1; i += 2)
        {
            (chars[i], chars[i + 1]) = (chars[i + 1], chars[i]);
        }
        return new string(chars);
    }

}

