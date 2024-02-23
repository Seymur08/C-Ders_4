using C__Ders_4;
using System;


Point point = new Point(1, 2);

point.Get_Print();

Console.WriteLine();
Console.WriteLine();

Counter counter = new Counter(0,100);
counter.increment();
counter.increment();
counter.increment();
counter.increment();
counter.increment();
counter.increment();
counter.increment();
Console.WriteLine($"increment - {counter.Currentvalue()}");
counter.decrement();
counter.decrement();
counter.decrement();

Console.WriteLine($"decrement - {counter.Currentvalue()}");

Console.WriteLine();
Console.WriteLine();

fraction frac_1 = new fraction(3,7);
fraction frac_2 = new fraction(4, 8);

fraction f3 = frac_1.Divide(frac_2);
frac_1.Simplify(f3);
Console.WriteLine();
Console.WriteLine();


// duzgun olmayan kesr (ixtisarla)
fraction frac_3 = new fraction(4, 7);
fraction frac_4 = new fraction(4, 8);
fraction frac_5 = frac_3.Divide(frac_4);
frac_1.Simplify(frac_5);




class Point
{
    public int _x { get; set; }
    public int _y { get; set; }


    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public Point(Point other)
    {
        _x = other._x;
        _y = other._y;
    }

    public void Get_Print()
    {

        Console.WriteLine($"X : Y = {_x} : {_y}");
    }
}




