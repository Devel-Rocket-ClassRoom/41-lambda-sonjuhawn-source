using System;
using System.Runtime.CompilerServices;

// README.md를 읽고 아래에 코드를 작성하세요.
//Console.WriteLine("'''");
//{
//    PrintMessage hi = () => Console.WriteLine("안녕하세요.");

//    hi();

//    delegate void PrintMessage();
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Transformer square = x => x * x;
//    Console.WriteLine(square(3));
//    Console.WriteLine(square(4));

//    delegate int Transformer(int x);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
    
//    IsLonger isLong = (string msg, int len) => msg.Length > len;
//    isLong("안녕하세요", 5);
//    isLong("반갑습니다", 10);


//    delegate bool IsLonger(string s);
//}
//Console.WriteLine("'''\n");

//Console.WriteLine("'''");
//{
//    Greeting say = () =>
//    {
//        Console.WriteLine("안녕하세요.");
//        Console.WriteLine("반갑습니다.");
//    };
//    say();
    
//    delegate void Greeting();
//}
//Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Calculator add = (a, b) =>
    {
        int result = a + b;
        Console.WriteLine($"{a} + {b} = {result}");
        Console.WriteLine($"합계: {result}";
    };
    add(3, 5);

    delegate int Calculator(int a, int b);
}
Console.WriteLine("'''\n");