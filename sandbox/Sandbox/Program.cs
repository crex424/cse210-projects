using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        string example = WeaveStrings("abc", "efg");
        string example2 = WeaveStrings("ab", "efg");
        string example3 = WeaveStrings("abc", "ef");
        string example4 = WeaveStrings("abc", "");
        string example5 = WeaveStrings("", "efg");
        string example6 = WeaveStrings("", "");
        Console.WriteLine(example);
        Console.WriteLine(example2);
        Console.WriteLine(example3);
        Console.WriteLine(example4);
        Console.WriteLine(example5);
        Console.WriteLine(example6);
    }

    public static string WeaveStrings(string str1, string str2)
{
    StringBuilder result = new StringBuilder();
    int maxLength = Math.Max(str1.Length, str2.Length);

    for (int i = 0; i < maxLength; i++)
    {
        if (i < str1.Length)
            result.Append(str1[i]);
        if (i < str2.Length)
            result.Append(str2[i]);
    }

    return result.ToString();
}

}