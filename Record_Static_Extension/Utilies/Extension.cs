namespace Record_Static_Extension.Utilies;

public static class Extension
{
    public static void MatchCount(this string str, string findStr)
    {
        int count = 0;
        for (int i = 0; i <= str.Length - findStr.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < findStr.Length; j++)
            {
                if (str[i + j] != findStr[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
