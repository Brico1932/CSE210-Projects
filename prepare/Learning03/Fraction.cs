using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int number)
    {
        _numerator = number;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string fraction_string = $"{_numerator}/{_denominator}";
        return fraction_string;
    }
    public double GetDecimalValue()
    {
        
        return (double)_numerator/(double)_denominator;
    }
}