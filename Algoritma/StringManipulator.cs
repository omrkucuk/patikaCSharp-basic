public class StringManipulator
{
    public static string RemoveCharacterAtIndex(string input)
    {
        var parts = input.Split(',');
        if (parts.Length != 2 || !int.TryParse(parts[1], out int index))
            return "Geçersiz giriş!";

        string text = parts[0];
        if (index < 0 || index >= text.Length)
            return text;

        return text.Remove(index, 1);
    }
}