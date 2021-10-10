public static class OutputFormater
{
    public static string GetFormattedNumber<T>(T number)
    {
        string stringifized = number.ToString();
        string result = string.Empty;
        for (int i = 0; i < stringifized.Length; ++i)
        {
            int dif = stringifized.Length - i;
            if (dif % 3 == 0 && dif != 0)
                result += " ";
            result += stringifized[i];
        }
        return result;
    }
}