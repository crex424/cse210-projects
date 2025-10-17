using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(1);
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        string fraction1_string = fraction1.GetFractionString();
        double fraction1_double = fraction1.GetDecimalValue();

        string fraction2_string = fraction2.GetFractionString();
        double fraction2_double = fraction2.GetDecimalValue();

        string fraction3_string = fraction3.GetFractionString();
        double fraction3_double = fraction3.GetDecimalValue();

        string fraction4_string = fraction4.GetFractionString();
        double fraction4_double = fraction4.GetDecimalValue();

        Console.WriteLine(fraction1_string);
        Console.WriteLine(fraction1_double);

        Console.WriteLine(fraction2_string);
        Console.WriteLine(fraction2_double);

        Console.WriteLine(fraction3_string);
        Console.WriteLine(fraction3_double);

        Console.WriteLine(fraction4_string);
        Console.WriteLine(fraction4_double);
    }
}