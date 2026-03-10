using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    Func<int> num = () => 1234;
    Func<int, int> square = (a) => a * a;
    Func<int ,int ,int> add = (a, b) => a + b;
    Console.WriteLine(num());
    Console.WriteLine(square(3));
    Console.WriteLine(add(3, 5));
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Action hi = () => Console.WriteLine("안녕하세요");
    Action<string> hi1 = (str) => Console.WriteLine(str);
    Action<string, int> hi2 = (str, num) =>
    {
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(str);
        }
    };
    hi();
    hi1("Hello, Lambda!");
    hi2("반복", 3);
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Func<int, int> anonymous = delegate (int x) { return x * x; };
    Func<int, int> lambda = (x) => x * x;
    anonymous(2);
    lambda(2);
}
Console.WriteLine("'''\n");