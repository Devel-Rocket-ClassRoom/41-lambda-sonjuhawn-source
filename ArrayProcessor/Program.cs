using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

int[] numbers = { 10, 25, 7, 42, 18, 33 };
Console.Write($"배열:");
foreach (int number in numbers)
{
    Console.Write($"{number}, ");
}
Console.WriteLine();

Console.WriteLine($"합계: {ProcessArray(numbers, (int[] i) => { int sum = 0; foreach (int number in i) { sum += number; } return sum; })}");

Console.WriteLine($"최댓값: {ProcessArray(numbers, (int[] i) => { int max = int.MinValue; foreach (int number in i) { if (number > max) { max = number; } } return max; }  )}");

Console.WriteLine($"최솟값: {ProcessArray(numbers, (int[] i) => { int min = int.MaxValue; foreach (int number in i) { if (number < min) { min = number; } } return min; })}");

Console.WriteLine($"짝수 개수: {ProcessArray(numbers, (int[] i) => { int two = 0; foreach (int number in i) { if (number % 2 ==0) { two++; } } return two; })}");

int ProcessArray(int[] data, Func<int[], int> processor)
{
    return processor(data);
}