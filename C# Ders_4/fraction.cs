namespace C__Ders_4;

internal class fraction
{
    private int _numerator;
    private int _denuminator;

    public fraction(int num, int don)
    {
        Numerator = num;
        Denumerator = don;
    }

    public int Numerator
    {
        get { return _numerator; }

        set
        {
            if (value > 0 && value < 100)
                _numerator = value;
        }
    }

    public int Denumerator
    {
        get { return _denuminator; }

        set
        {
            if (value > 0 && value < 100)
                _denuminator = value;
        }
    }
    public fraction Multiply(fraction other)
    {
        int numerator = _numerator * other._numerator;
        int denumerator = _denuminator * other._denuminator;

        return new fraction(numerator, denumerator);
    }

    public fraction Add(fraction other)
    {
        int numerator_1 = _denuminator * other._numerator;
        int numerator_2 = _numerator * other._denuminator;

        int denumerator = _denuminator * other._denuminator;

        return new fraction(numerator_1 + numerator_2, denumerator);
    }
    public fraction Minus(fraction other)
    {
        int denumerator = _denuminator * other._denuminator;

        int numerator_1 = denumerator / _denuminator * _numerator;

        int numerator_2 = denumerator / other._denuminator * other._numerator;

        return new fraction(numerator_1 - numerator_2, denumerator);
    }

    public fraction Divide(fraction other)
    {
        int numerator = _numerator * other._denuminator;
        int denumerator = _denuminator * other._numerator;

        return new fraction(numerator, denumerator);
    }

    public void Simplify(fraction other)
    {
        int num = Rounding(other._numerator, other._denuminator);

        int numerator = other._numerator / num;

        int denumerator = other._denuminator / num;

        if (numerator < denumerator)
        {
            Console.WriteLine($" {numerator}");
            Console.WriteLine("---");
            Console.WriteLine($" {denumerator}");

        }

        else if (numerator > denumerator)
        {
            int number = numerator / denumerator;

            Console.WriteLine($"  {numerator - denumerator}");
            Console.WriteLine($"{number}---");
            Console.WriteLine($"  {denumerator}");
        }
    }
    private int Rounding(int num_1, int num_2)
    {
        while (num_2 != 0)
        {
            int temp = num_2;
            num_2 = num_1 % num_2;
            num_1 = temp;
        }
        return num_1;

    }

}
