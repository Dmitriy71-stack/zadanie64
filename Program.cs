// Задайте значение М и N. Напишите программу , которая выведет все натуральные числа в промежутке от М до N.
// M = 1; N = 5. -> "5,4,3,2,1"
// M = 4; N = 8. -> "8, 7, 6, 5, 4"
using System;
using static System.Console;


Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(m, n));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}