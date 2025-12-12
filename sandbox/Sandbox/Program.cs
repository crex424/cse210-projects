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
        Console.WriteLine();
        Console.WriteLine($"{GetSum(5, 5)} 10");
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

     public static int GetSum(int a, int b) {
        string binaryA = Convert.ToString(a, 2);
        string binaryB = Convert.ToString(b, 2);
        StringBuilder result = new StringBuilder();
        int maxLength = Math.Max(binaryA.Length, binaryB.Length);
        string remainder = "0";
        int sum = 0;
        for(int i = 0; i < maxLength; i++) 
        {
            if(binaryA[i].Equals("1") && binaryB[i].Equals("1") && remainder.Equals("0"))
            {
                result.Append("0");
                remainder = "1";
            }
            if(binaryA[i].Equals("1") && binaryB[i].Equals("1") && remainder.Equals("1"))
            {
                result.Append("1");
                remainder = "1";
            }

            if(binaryA.Equals("0") && binaryB[i].Equals("0") && remainder.Equals("0")) 
            {
                result.Append("0");
            }

            if(binaryA.Equals("0") && binaryB[i].Equals("0") && remainder.Equals("1")) 
            {
                result.Append("1");
                remainder = "0";
            }

            if(binaryA.Equals("0") && binaryB[i].Equals("1") && remainder.Equals("0")) 
            {
                result.Append("1");
            }

            if(binaryA.Equals("0") && binaryB[i].Equals("1") && remainder.Equals("1")) 
            {
                result.Append("0");
                remainder = "1";
            }

            if(binaryA.Equals("1") && binaryB[i].Equals("0") && remainder.Equals("0")) 
            {
                result.Append("1");
            }

            if(binaryA.Equals("1") && binaryB[i].Equals("0") && remainder.Equals("1")) 
            {
                result.Append("0");
                remainder = "1";
            }

        }
        if (remainder.Equals("1")) 
        {
            result.Append("1");
        }
        string reversed = new string(result.ToString().Reverse().ToArray());
        sum = Convert.ToInt32(reversed, 2);

        return sum;
    }

}