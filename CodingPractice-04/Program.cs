using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("'''");
{
    Action[] actions = new Action[3];
    for(int i = 0; i < 3; i++)
    {
        actions[i] = () => Console.Write(i);
    }
    foreach(Action action in actions)
    {
        action();
    }
    Console.WriteLine();
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Action[] actions = new Action[3];
    for (int i = 0; i < 3; i++)
    {
        int loopVar = i;
        actions[i] = () => Console.Write(loopVar);
    }
    foreach (Action action in actions)
    {
        action();
    }
    Console.WriteLine();
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    string[] names = { "김철수", "이영희", "박민수", "최지연" };

    Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));
    foreach(string name in names)
    {
        Console.WriteLine(name); 
    }
    Array.Sort(names, (b, a) => b.CompareTo(a));
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int num1 = numbers.Find(n => n % 2 == 0);
    Console.WriteLine($"첫 번째 짝수: {num1}");

    List<int> num2 = numbers.FindAll(n => n % 2 == 0);
    Console.WriteLine("모든 짝수:");
    foreach(int i in num2)
    {
        Console.Write(num2);
    }

    bool num3 = numbers.Exists(n => n > 8);
    Console.WriteLine($"8보다 큰 수 존재: {num3}");

    bool num4 = numbers.TrueForAll(n => n > 0);
    Console.WriteLine($"모두 양수: {num4}");

    int num5 = numbers.RemoveAll(n => n % 2 == 0);
    Console.WriteLine($"제거된 짝수 개수: {num5}");
    Console.WriteLine($"남은 숫자: {string.Join(", ", numbers)}");

}
Console.WriteLine("'''\n");