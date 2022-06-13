/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/
string InputNumbers(int n, int m)
{
    if (n > m)
    {
        return InputNumbers(n, m+1) + ", " + m;
    }
    else if(n < m)
    {
        return InputNumbers(n+1, m) + ", " + n;
    }
    {
        return Convert.ToString(m);
    }
}
Console.Write("Введите значение M: ");
int numberOne=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int numberTwo=Convert.ToInt32(Console.ReadLine());
string result = InputNumbers(numberOne, numberTwo);
Console.WriteLine($"M = {numberOne}; N = {numberTwo}. - > {result}");
