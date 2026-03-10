using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    Predicate<int> num3 = (x) => x % 3 == 0;
    var multi3 = FindNumbers(num3);
    foreach(var x in multi3)
    {
        Console.Write($"{x} "); 
    }
    Console.WriteLine();
    
    var squares = FindNumbers(square =>
        {
        int sqrt = (int)Math.Sqrt(square);
        return sqrt * sqrt == square;
        });
    foreach (var x in squares)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}
Console.WriteLine("'''");

Console.WriteLine("'''");
{
    Predicate<int> isEven = (x) => x % 2 == 0;
    Func<int, bool> isOdd = (x) => (x % 2 == 1);

    Console.WriteLine(isEven(4));
    Console.WriteLine(isOdd(4));
}
Console.WriteLine("'''");

Console.WriteLine("'''");
{
    int factor = 2;

    Func<int, int> multiplier = n => n * factor;
    Console.WriteLine(multiplier(3));
    Console.WriteLine(multiplier(10));
}
Console.WriteLine("'''");

Console.WriteLine("'''");
{
    int count = 0;

    Action increment = () => count++;

    increment();
    increment();
    increment();
    Console.WriteLine(count);
}
Console.WriteLine("'''");

Console.WriteLine("'''");
{
    var counter = CreateCounter();
    Console.WriteLine(counter());
    Console.WriteLine(counter());
    Console.WriteLine(counter());

}
Console.WriteLine("'''");



static List<int> FindNumbers(Predicate<int> predicate)
{
    List<int> ints = new List<int>();
    for (int i = 1; i < 100; i++)
    {
        if (predicate(i))
        {
            ints.Add(i);
        }
    }
    return ints;
}

static Func<int> CreateCounter()
{
    int count = 0;
    return () => count++;
}